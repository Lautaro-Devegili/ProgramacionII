using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using ABMCCarpinteria_Krlitos.Entidades;
namespace ABMCCarpinteria_Krlitos.Datos
{
    public class DBHelper
    {
        private string strConexion = @"Data Source=;Initial Catalog=Carpinteria_2023;User ID=;Password=";
        private string strConexionCasa = @"Data Source=pckrlos;Initial Catalog=Carpinteria_2023;Integrated Security=True";
        private SqlConnection conexion; 
        private SqlCommand comando; 
        public DBHelper()
        {
            conexion = new SqlConnection(strConexionCasa);
            comando = new SqlCommand();
        }

        public int ProximoPresupuesto()
        {
            Conectar();
            comando.CommandText = "SP_PROXIMO_ID";
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@next";
            parametro.SqlDbType = SqlDbType.Int;
            parametro.Direction = ParameterDirection.Output;
            comando.Parameters.Add(parametro);
            comando.ExecuteNonQuery();
            Desconectar();

            return (int)parametro.Value;
        }
        private void Desconectar()
        {
            conexion.Close();
        }
        public DataTable CargarProductos()
        {
            Conectar();
            comando.CommandText = "SP_CONSULTAR_PRODUCTOS";
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            return tabla;
        }
        
        public DataTable Consultar(string nombreSP)
        {
            Conectar();
            comando.CommandText = nombreSP;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            return tabla;
        }

        public DataTable Consultar(string nombreSP, List<Parametro> parametros)
        {
            Conectar();
            comando.CommandText = nombreSP;
            foreach (Parametro p in parametros)
            {
                comando.Parameters.AddWithValue(p.Nombre, p.Valor);
            }
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            return tabla;
        }
        
        private SqlParameter pSalida()
        {
            SqlParameter p = new SqlParameter();
            p.Direction = ParameterDirection.Output;
            return p;
        }
        private void Conectar()
        {
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
        }

        public bool ConfirmarPresupuesto(Presupuesto p)
        {
            bool confirm = true;
            SqlTransaction t = null;

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                //Se inicia la conexion bajo transaccion
                t = conexion.BeginTransaction();
                comando.Connection = conexion;
                comando.Transaction = t;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_INSERTAR_MAESTRO";

                comando.Parameters.AddWithValue("@cliente", p.Cliente);
                comando.Parameters.AddWithValue("@dto", p.Descuento);
                comando.Parameters.AddWithValue("@total", p.CalcularTotal());

                SqlParameter parametro = pSalida();
                parametro.ParameterName = "@presupuesto_nro";
                parametro.SqlDbType = SqlDbType.Int;
                comando.Parameters.Add(parametro);

                comando.ExecuteNonQuery();
                int presupuestoNro = (int)parametro.Value;
                int detalleNro = 1;

                SqlCommand cmdDetalle;//p es presupuesto
                foreach (DetallePresupuesto dp in p.Detalles)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE", conexion, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@presupuesto_nro", presupuestoNro);
                    cmdDetalle.Parameters.AddWithValue("@detalle", detalleNro);
                    cmdDetalle.Parameters.AddWithValue("@id_producto", dp.PProducto.ProductoNro);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", dp.Cantidad);
                    cmdDetalle.ExecuteNonQuery();
                    detalleNro++;
                }
                t.Commit();
            } catch
            {
                t.Rollback();
                confirm = false;
            } finally
            {
                if((conexion!=null) && (conexion.State==ConnectionState.Closed))
                Desconectar();
            }
            return confirm;
        }
    }
}
