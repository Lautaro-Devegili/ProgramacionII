using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Practica_Parcial2.Datos.Helper
{
    public class HelperDB
    {
        private static HelperDB instancia;
        private SqlConnection cnn;
        private SqlCommand comando;
        public HelperDB()
        {
            cnn = new SqlConnection(Properties.Resources.ConexionCasa);
            comando = new SqlCommand();
        }

        public static HelperDB NI()
        {
            if (instancia == null)
                instancia = new HelperDB();
            return instancia;
        }
        public DataTable Consultar(string nombreSP, List<Parametro> parametros)
        {
            Conectar();
            comando.CommandText = nombreSP;
            comando.Parameters.Clear();
            foreach (Parametro p in parametros)
            {
                comando.Parameters.AddWithValue(p.Clave, p.Valor);
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
            comando.Parameters.Clear();
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

        public int EjecutarSQL(string strSql, List<Parametro> values)
        {
            int afectadas = 0;
            SqlTransaction t = null;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = strSql;
                cmd.Transaction = t;

                if (values != null)
                {
                    foreach (Parametro param in values)
                    {
                        cmd.Parameters.AddWithValue(param.Clave, param.Valor);
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
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();

            }

            return afectadas;
        }

        public SqlConnection ObtenerConexion()
        {
            return this.cnn;
        }

        private void Conectar()
        {
            cnn.Open();
            comando.Connection = cnn;
            comando.CommandType = CommandType.StoredProcedure;
        }

        private void Desconectar()
        {
            cnn.Close();
        }
    }
}
