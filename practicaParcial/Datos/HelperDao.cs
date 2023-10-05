using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using practicaParcial.Entidades;

namespace practicaParcial.Datos
{
    public class HelperDao
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        public static HelperDao instancia;

        public HelperDao()
        {
            conexion = new SqlConnection(Properties.Resources.ConexionCasa);
            comando = new SqlCommand();
        }

        private void Conectar()
        {
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
        }

        private void Desconectar()
        {
            conexion.Close();
        }

        public static HelperDao NI()
        {
            if (instancia == null)
            {
                instancia = new HelperDao();
            }
            return instancia;
        }

        public int ConsultarEscalar(string nombreSP, string paramOut)
        {
            Conectar();
            comando.CommandText = nombreSP;
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = paramOut;
            parametro.SqlDbType = SqlDbType.Int;
            parametro.Direction = ParameterDirection.Output;
            comando.Parameters.Add(parametro);
            comando.ExecuteNonQuery();
            Desconectar();

            return (int)parametro.Value;
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
        public DataTable Consultar(string nombreSP)
        {
            Conectar();
            comando.CommandText = nombreSP;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            return tabla;
        }
        public SqlParameter pSalida()
        {
            SqlParameter p = new SqlParameter();
            p.Direction = ParameterDirection.Output;
            return p;
        }

        public bool ConfirmarOrden(Orden o)
        {
            bool confirm = true;
            SqlTransaction t = null;

            try
            {
                conexion.Open();
                SqlCommand c = new SqlCommand();
                t = conexion.BeginTransaction();
                c.Connection = conexion;
                c.Transaction = t;
                c.CommandType = CommandType.StoredProcedure;
                c.CommandText = "SP_INSERTAR_ORDEN";
                c.Parameters.AddWithValue("@responsable", o.Responsable);

                SqlParameter parametro = pSalida();
                parametro.ParameterName = "@nro";
                parametro.SqlDbType = SqlDbType.Int;
                c.Parameters.Add(parametro);

                c.ExecuteNonQuery();

                int nroOrden = (int)parametro.Value;
                int nroDetalle = 1;

                SqlCommand cDetalle;
                
                foreach (DetalleOrden d in o.Detalles)
                {
                    cDetalle = new SqlCommand("SP_INSERTAR_DETALLES", conexion, t);
                    cDetalle.CommandType = CommandType.StoredProcedure;
                    cDetalle.Parameters.AddWithValue("@nro_orden", nroOrden);
                    cDetalle.Parameters.AddWithValue("@detalle", nroDetalle);
                    cDetalle.Parameters.AddWithValue("@codigo", d.PProducto.Id);
                    cDetalle.Parameters.AddWithValue("@cantidad",d.Cantidad);
                    cDetalle.ExecuteNonQuery();
                    nroDetalle++;
                }
                t.Commit();
            } catch
            {
                t.Rollback();
                confirm = false;
            } finally
            {
                if((conexion!=null) || (conexion.State==ConnectionState.Open))
                {
                    Desconectar();
                }
            }
            return confirm;
        }

    }
}
