using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Back.Datos
{
    public class HelperDao
    {
        private static HelperDao instancia;
        private SqlConnection conexion;
        private SqlCommand comando;
        public HelperDao()
        {
            conexion = new SqlConnection(Properties.Resources.CadenaAfuera);
            //conexion = new SqlConnection(Properties.Resources.CadenaCasa);
            comando = new SqlCommand();
        }

        public int EjecutarSP(string nombreSP, List<Parametro> parametros)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            comando.Parameters.Clear();

            if (parametros != null)
            {
                foreach (Parametro parametro in parametros)
                {
                    comando.Parameters.AddWithValue(parametro.Nombre, parametro.Valor);
                }
            }

            int filasAfectadas = comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.Close();
            return filasAfectadas;
        }
        public static HelperDao OI()
        {
            if (instancia == null)
            {
                instancia = new HelperDao();
            }
            return instancia;

        }

        public static HelperDao ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new HelperDao();
            return instancia;

        }

        public void Conectar()
        {
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
        }

        public void Desconectar()
        {
            conexion.Close();
        }

        public SqlConnection ObtenerConexion()
        {
            return this.conexion;
        }

        public int ConsultarEscalar(string nombreSP, string paramOut)
        {
            Conectar();
            comando.Parameters.Clear();
            comando.CommandText = nombreSP;
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = paramOut;
            parametro.SqlDbType = SqlDbType.Int;
            parametro.Direction = ParameterDirection.Output;
            comando.Parameters.Add(parametro);
            comando.ExecuteNonQuery();
            Desconectar();
            comando.Parameters.Clear();
            return (int)parametro.Value;
        }

        public int ConsultarEscalar(string nombreSP, string paramOut, int IdFuncion)
        {
            Conectar();
            comando.Parameters.Clear();
            comando.CommandText = nombreSP;
            SqlParameter parametro = new SqlParameter();

            parametro.ParameterName = paramOut;
            parametro.SqlDbType = SqlDbType.Int;
            parametro.Direction = ParameterDirection.Output;
            comando.Parameters.AddWithValue("@funcion", IdFuncion);
            comando.Parameters.Add(parametro);
            comando.ExecuteNonQuery();
            Desconectar();
            comando.Parameters.Clear();
            return (int)parametro.Value;
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
            comando.Parameters.Clear();
            comando.CommandText = nombreSP;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            comando.Parameters.Clear();
            return tabla;
        }

        public DataTable Consultar(string nombreSP, List<Parametro> parametros)
        {
            Conectar();
            comando.Parameters.Clear();
            comando.CommandText = nombreSP;
            foreach (Parametro p in parametros)
            {
                comando.Parameters.AddWithValue(p.Nombre, p.Valor);
            }
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            comando.Parameters.Clear();
            return tabla;
        }

        public int CheckearID(int idaCheckear)
        {
            Conectar();
            comando.Parameters.Clear();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "VerificarComprasCliente";

            // Parámetro de entrada
            SqlParameter parametroEntrada = new SqlParameter();
            parametroEntrada.ParameterName = "@CodCliente";
            parametroEntrada.SqlDbType = SqlDbType.Int;
            parametroEntrada.Value = idaCheckear;
            comando.Parameters.Add(parametroEntrada);

            // Parámetro de salida
            SqlParameter parametroSalida = new SqlParameter();
            parametroSalida.ParameterName = "@Resultado";
            parametroSalida.SqlDbType = SqlDbType.Int;
            parametroSalida.Direction = ParameterDirection.Output;
            comando.Parameters.Add(parametroSalida);

            comando.ExecuteNonQuery();

            int resultado = (int)parametroSalida.Value;

            Desconectar();
            comando.Parameters.Clear();

            return resultado;
        }

        public SqlParameter pSalida()
        {
            SqlParameter p = new SqlParameter();
            p.Direction = ParameterDirection.Output;
            return p;
        }
        public int EjecutarSQL(string strSql, List<Parametro> values)
        {
            int afectadas = 0;
            SqlTransaction t = null;

            try
            {
                SqlCommand cmd = new SqlCommand();
                conexion.Open();
                t = conexion.BeginTransaction();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = strSql;
                cmd.Transaction = t;

                if (values != null)
                {
                    foreach (Parametro param in values)
                    {
                        cmd.Parameters.AddWithValue(param.Nombre, param.Valor);
                    }
                }

                afectadas = cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (SqlException)
            {
                if (t != null) { t.Rollback(); }
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();

            }

            return afectadas;
        }
        public bool BorrarFuncion(int nro)
        {
            string sp = "DELETEFunciones";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@codFuncion", nro));
            int afectadas = HelperDao.ObtenerInstancia().EjecutarSQL(sp, lst);
            return afectadas > 0;
        }
    }
}
