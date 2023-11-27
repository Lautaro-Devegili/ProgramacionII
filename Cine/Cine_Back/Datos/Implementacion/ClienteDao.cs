using Cine_Back.Datos.Interfaz;
using Cine_Back.Entidades.Clientes;
using Cine_Back.Entidades.Funciones;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Back.Datos.Implementacion
{
    public class ClienteDao : IClienteDao
    {
        public bool EliminarCliente(int codCliente)
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro("@codCliente", codCliente)
            };

            int filasAfectadas = HelperDao.ObtenerInstancia().EjecutarSP("DELETEClientes", parametros);

            return filasAfectadas > 0;

        }
        public List<Cliente> TraerClientes()
        {
            DataTable t = HelperDao.OI().Consultar("GETClientes");
            List<Cliente> lst = new List<Cliente>();

            foreach (DataRow fila in t.Rows)
            {
                int IdCliente = Convert.ToInt32(fila[0].ToString());
                string Apellido = fila[1].ToString();
                string Nombre = fila[2].ToString();
                int TipoDoc = Convert.ToInt32(fila[3].ToString());
                int Documento = Convert.ToInt32(fila[4].ToString());
                int IdSexo = Convert.ToInt32(fila[5].ToString());
                DateTime FechaNac = Convert.ToDateTime(fila[6].ToString());
                long Telefono = Convert.ToInt64(fila[7].ToString());
                Cliente c = new Cliente(IdCliente, Apellido, Nombre, TipoDoc, Documento, IdSexo, FechaNac, Telefono);
                lst.Add(c);
            }
            return lst;
        }
        public List<TipoDoc> TraerTiposDoc()
        {
            DataTable t = HelperDao.OI().Consultar("SP_GET_TIPOSDOC");
            List<TipoDoc> lst = new List<TipoDoc>();

            foreach (DataRow fila in t.Rows)
            {
                int IdTipo = Convert.ToInt32(fila[0].ToString());
                string Tipo = fila[1].ToString();
                TipoDoc ti = new TipoDoc(IdTipo, Tipo);
                lst.Add(ti);
            }
            return lst;
        }
        public List<Sexo> TraerSexos()
        {
            DataTable t = HelperDao.OI().Consultar("SP_GET_SEXOS");
            List<Sexo> lst = new List<Sexo>();

            foreach (DataRow fila in t.Rows)
            {
                int IdSexo = Convert.ToInt32(fila[0].ToString());
                string Sex = fila[1].ToString();
                Sexo s = new Sexo(IdSexo, Sex);
                lst.Add(s);
            }
            return lst;
        }
        public int TraerNextClienteId()
        {
            int id = HelperDao.OI().ConsultarEscalar("SP_PROXIMO_CLIENTE", "@next");
            return id;
        }
        public bool CrearCliente(Cliente c)
        {
            bool confirm = true;
            SqlTransaction t = null;
            SqlConnection conexion = HelperDao.OI().ObtenerConexion();

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                //Se inicia la conexion bajo transaccion
                t = conexion.BeginTransaction();
                comando.Connection = conexion;
                comando.Transaction = t;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "INSERTClientes";

                //comando.Parameters.AddWithValue("@apellido", c.Apellido);
                comando.Parameters.AddWithValue("@apellido", c.Apellido);
                comando.Parameters.AddWithValue("@nombre", c.Nombre);
                comando.Parameters.AddWithValue("@codTipoDoc", c.TipoDoc);
                comando.Parameters.AddWithValue("@documento", c.Documento);
                comando.Parameters.AddWithValue("@fechaNacimiento", c.FechaNac);
                comando.Parameters.Add("@nroTelefono", SqlDbType.BigInt).Value = c.Telefono;
                comando.Parameters.AddWithValue("@idSexo", c.IdSexo);

                comando.ExecuteNonQuery();
                t.Commit();
            }
            catch
            {
                t.Rollback();
                confirm = false;
            }
            finally
            {
                if ((conexion != null) || (conexion.State == ConnectionState.Open))
                {
                    HelperDao.OI().Desconectar();
                    conexion.Close();
                }
            }
            return confirm;
        }

        public List<TipoDoc> ObtenerCombo()
        {
            List<TipoDoc> ltipodoc = new List<TipoDoc>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_CONSULTAR_TIPODOC");
            foreach (DataRow fila in tabla.Rows)
            {
                int codTipoDoc = int.Parse(fila["codTipoDoc"].ToString());
                string tipo = fila["tipoDoc"].ToString();
                TipoDoc td = new TipoDoc(codTipoDoc, tipo);
                ltipodoc.Add(td);

            }
            return ltipodoc;

        }

        public bool ModificarCliente(Cliente c)
        {
            bool ok = true;
            SqlConnection cnn = HelperDao.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            SqlCommand cmd = new SqlCommand();

            try
            {
                
                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.Transaction = t;
                cmd.CommandText = "UPDATEClientes";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codCliente", c.IdCliente);
                cmd.Parameters.AddWithValue("@apellido", c.Apellido);
                cmd.Parameters.AddWithValue("@nombre", c.Nombre);
                cmd.Parameters.AddWithValue("@codTipoDoc", c.TipoDoc);
                cmd.Parameters.AddWithValue("@documento", c.Documento);
                cmd.Parameters.AddWithValue("@sexo", c.IdSexo);
                cmd.Parameters.AddWithValue("@fechaNacimiento", c.FechaNac);
                cmd.Parameters.AddWithValue("@nroTelefono", c.Telefono);
                cmd.ExecuteNonQuery();
                t.Commit();
            }

            catch (Exception ex)
            {
                if (t != null)
                    t.Rollback();
                ok = false;
                Console.WriteLine("Error al actualizar: " + ex.Message);
            }

            finally
            {
                if (cnn != null || cnn.State == ConnectionState.Open)
                {
                    HelperDao.ObtenerInstancia().Desconectar();
                    cnn.Close();
                }
            }
            return ok;
        }
        public List<Sexo> ObtenerComboSex()
        {
            List<Sexo> ltiposexo = new List<Sexo>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_CONSULTAR_SEXO");
            foreach (DataRow fila in tabla.Rows)
            {
                int idSexo = int.Parse(fila["idSexo"].ToString());
                string sexo = fila["sexo"].ToString();
                Sexo ts = new Sexo(idSexo, sexo);
                ltiposexo.Add(ts);

            }
            return ltiposexo;
        }

        public DataTable TraerClientesConOSinFiltro(List<Parametro> lst)
        {
            DataTable dt = HelperDao.OI().Consultar("SP_BUSCAR_CLIENTES", lst);
            return dt;
        }

        public int TraerIdCheckeada(int codCliente)
        {
            int idCheckeada = HelperDao.OI().CheckearID(codCliente);
            return idCheckeada;
        }
    }
}
