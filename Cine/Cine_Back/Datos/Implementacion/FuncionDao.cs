using Cine_Back.Datos.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Cine_Back.Entidades.Funciones;

namespace Cine_Back.Datos.Implementacion
{
    public class FuncionDao : IFuncionDao
    {
        public List<Formato> TraerFormatos()
        {
            DataTable t = HelperDao.OI().Consultar("SP_GET_FORMATOS");
            List<Formato> lst = new List<Formato>();

            foreach (DataRow fila in t.Rows)
            {
                int IdFormato = Convert.ToInt32(fila[0].ToString());
                string Format = fila[1].ToString();
                Formato f = new Formato(IdFormato, Format);
                lst.Add(f);
            }
            return lst;
        }

        public List<Sala> TraerSalas()
        {
            DataTable t = HelperDao.OI().Consultar("SP_GET_SALAS");
            List<Sala> lst = new List<Sala>();

            foreach (DataRow fila in t.Rows)
            {
                int NroSala = Convert.ToInt32(fila[0].ToString());
                int IdTipoSala = Convert.ToInt32(fila[1].ToString());
                string TipoSala = fila[2].ToString();
                int Capacidad = Convert.ToInt32(fila[3].ToString());
                Sala s = new Sala(NroSala, IdTipoSala, TipoSala, Capacidad);
                lst.Add(s);
            }
            return lst;
        }

        public List<Funcion> TraerFunciones()
        {
            DataTable t = HelperDao.OI().Consultar("SP_GET_FUNCIONES");
            List<Funcion> lst = new List<Funcion>();

            foreach (DataRow fila in t.Rows)
            {
                if (!(Convert.ToDateTime(fila[3].ToString()) < DateTime.Today))
                {
                    int IdFuncion = Convert.ToInt32(fila[0].ToString());
                    int IdPeli = Convert.ToInt32(fila[1].ToString());
                    string Peli = fila[2].ToString();
                    DateTime FechaHora = Convert.ToDateTime(fila[3].ToString());
                    int NroSala = Convert.ToInt32(fila[4].ToString());
                    string TipoSala = fila[5].ToString();
                    decimal Precio = Convert.ToDecimal(fila[6].ToString());
                    int IdFormato = Convert.ToInt32(fila[7].ToString());
                    string Format = fila[8].ToString();
                    Funcion f = new Funcion(IdFuncion, IdPeli, Peli, FechaHora, NroSala, TipoSala, Precio, IdFormato, Format);
                    lst.Add(f);
                }
            }
            return lst;
        }

        public int TraerNextFuncionId()
        {
            int id = HelperDao.OI().ConsultarEscalar("SP_PROXIMA_FUNCION", "@next");
            return id;
        }

        public List<Pelicula> TraerPeliculas()
        {
            DataTable t = HelperDao.OI().Consultar("SP_GET_PELICULAS");
            List<Pelicula> lst = new List<Pelicula>();

            foreach (DataRow fila in t.Rows)
            {
                int IdPeli = Convert.ToInt32(fila[0].ToString());
                string Peli = fila[1].ToString();
                int Duracion = Convert.ToInt32(fila[2].ToString());
                DateTime FechaEstreno = ((DateTime)fila["FechaEstreno"]);
                int IdCategoria = Convert.ToInt32(fila[4].ToString());
                int PriGenero = Convert.ToInt32(fila[5].ToString());
                int SegGenero = Convert.ToInt32(fila[6].ToString());
                int IdDirector = Convert.ToInt32(fila[7].ToString());
                Pelicula p = new Pelicula(IdPeli, Peli, Duracion, FechaEstreno, IdCategoria, PriGenero, SegGenero, IdDirector);
                lst.Add(p);
            }
            return lst;
        }
        public DataTable TraerFuncionesXFiltro(List<Parametro> lst)
        {
            DataTable funcionesFiltradas = HelperDao.OI().Consultar("SP_GET_FUNCIONESXFILTRO", lst);
            return funcionesFiltradas;
        }

        public bool BorrarFuncion(Parametro pa)
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
                comando.CommandText = "DELETEFunciones";

                comando.Parameters.AddWithValue(pa.Nombre, pa.Valor);

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
                if ((conexion != null) || (conexion.State == ConnectionState.Closed))
                    HelperDao.OI().Desconectar();
            }
            return confirm;
        }

        public bool CrearFuncion(Funcion f)
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
                comando.CommandText = "INSERTFunciones";

                comando.Parameters.AddWithValue("@codPelicula", f.IdPeli);
                comando.Parameters.AddWithValue("@FechaHora", f.FechaHora);
                comando.Parameters.AddWithValue("@nroSala", f.NroSala);
                comando.Parameters.AddWithValue("@codFormato", f.IdFormato);

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
                if ((conexion != null) || (conexion.State == ConnectionState.Closed))
                    HelperDao.OI().Desconectar();
            }
            return confirm;
        }

        public bool ModificarFuncion(Funcion f)
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
                cmd.CommandText = "SP_UPDATE_FUNCIONES";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codFuncion", f.IdFuncion);
                cmd.Parameters.AddWithValue("@codFormato", f.IdFormato);
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

    }
}


/**/