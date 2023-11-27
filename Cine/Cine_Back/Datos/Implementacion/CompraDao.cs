using Cine_Back.Datos.Interfaz;
using Cine_Back.Entidades.Compras;
using Cine_Back.Entidades.Funciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Back.Datos.Implementacion
{
    public class CompraDao : ICompraDao
    {
        public List<Compra> TraerCompras()
        {
            DataTable t = HelperDao.OI().Consultar("SP_GET_COMPRAS");
            List<Compra> lst = new List<Compra>();

            foreach (DataRow fila in t.Rows)
            {
                int IdCompra = Convert.ToInt32(fila[0].ToString());
                int IdFormaPago = Convert.ToInt32(fila[1].ToString());
                int IdCliente = Convert.ToInt32(fila[2].ToString());
                string ApeCliente = fila[3].ToString();
                DateTime FechaCompra = Convert.ToDateTime(fila[4].ToString());
                int IdEstado = Convert.ToInt32(fila[5].ToString());
                Compra c = new Compra(IdCompra, IdFormaPago, IdCliente, ApeCliente, FechaCompra, IdEstado);
                lst.Add(c);
            }
            return lst;
        }

        public List<Descuento> TraerDescuentos()
        {
            DataTable t = HelperDao.OI().Consultar("SP_GET_DESCUENTOS");
            List<Descuento> lst = new List<Descuento>();

            foreach (DataRow fila in t.Rows)
            {
                int IdDescuento = Convert.ToInt32(fila[0].ToString());
                string Descripcion = fila[1].ToString();
                decimal Porcentaje = Convert.ToDecimal(fila[2].ToString());
                Descuento d = new Descuento(IdDescuento, Descripcion, Porcentaje);
                lst.Add(d);
            }
            return lst;
        }

        public List<FormaPago> TraerFormasPago()
        {
            DataTable t = HelperDao.OI().Consultar("SP_GET_FORMASPAGO");
            List<FormaPago> lst = new List<FormaPago>();

            foreach (DataRow fila in t.Rows)
            {
                int IdFormaPago = Convert.ToInt32(fila[0].ToString());
                string FormPago = fila[1].ToString();
                FormaPago f = new FormaPago(IdFormaPago, FormPago);
                lst.Add(f);
            }
            return lst;
        }

        public int TraerNextCompraNro()
        {
            int id = HelperDao.OI().ConsultarEscalar("SP_PROXIMA_COMPRA", "@next");
            return id;
        }

        public int TraerNextButacaXFuncion(int Idfuncion)
        {
            int id = HelperDao.OI().ConsultarEscalar("SP_PROXIMO_NROBUTACA_PARA_XFUNCION", "@next", Idfuncion);
            return id;
        }

        public int TraerNextEntradaNro()
        {
            int id = HelperDao.OI().ConsultarEscalar("SP_PROXIMA_ENTRADA", "@next");
            return id;
        }

        public bool CrearCompra(Compra c)
        {
            bool confirm = true;
            SqlTransaction t = null;
            SqlConnection conexion = HelperDao.OI().ObtenerConexion();

            try
            {
                int nroButaca = TraerNextButacaXFuncion(c.Entradas[0].CodFuncion);
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                //Se inicia la conexion bajo transaccion
                t = conexion.BeginTransaction();
                comando.Connection = conexion;
                comando.Transaction = t;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "INSERTCompra";

                comando.Parameters.AddWithValue("@IdFormaPago", c.IdFormaPago);
                comando.Parameters.AddWithValue("@codCliente", c.IdCliente);
                comando.Parameters.AddWithValue("@fecha", c.FechaCompra);
                comando.Parameters.AddWithValue("@codEstado", c.IdEstado);

                SqlParameter parametro = HelperDao.OI().pSalida();
                parametro.ParameterName = "@compraNro";
                parametro.SqlDbType = SqlDbType.Int;
                comando.Parameters.Add(parametro);

                comando.ExecuteNonQuery();
                int compraNro = (int)parametro.Value;
                int codEntrada = 1;
                SqlCommand cmdDetalle;//p es presupuesto
                foreach (Entrada ent in c.Entradas)
                {
                    SqlCommand cmdButaca = new SqlCommand("INSERTButacas", conexion, t);
                    cmdButaca.CommandType = CommandType.StoredProcedure;
                    cmdButaca.Parameters.AddWithValue("@nroButaca", nroButaca);
                    cmdButaca.Parameters.AddWithValue("@codFuncion", ent.CodFuncion);
                    cmdButaca.Parameters.AddWithValue("@codEstado", c.IdEstado);
                    cmdButaca.ExecuteNonQuery();
                    cmdDetalle = new SqlCommand("INSERTEntrada", conexion, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@nroCompra", compraNro);
                    cmdDetalle.Parameters.AddWithValue("@codEntrada", codEntrada);
                    cmdDetalle.Parameters.AddWithValue("@nroButaca", nroButaca);
                    cmdDetalle.Parameters.AddWithValue("@codFuncion", ent.CodFuncion);
                    cmdDetalle.Parameters.AddWithValue("@precio", ent.Precio);
                    cmdDetalle.Parameters.AddWithValue("@codDescuento", ent.CodDescuento);
                    cmdDetalle.Parameters.AddWithValue("@descuento", ent.Descuento);
                    cmdDetalle.ExecuteNonQuery();
                    codEntrada++;
                    nroButaca++;
                }

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
                    HelperDao.OI().Desconectar();
            }
            return confirm;
        }

        public DataTable TraerFuncionesXFiltro(List<Parametro> lst)
        {
            DataTable funcionesFiltradas = HelperDao.OI().Consultar("SP_GET_FUNCIONESXFILTRO", lst);
            return funcionesFiltradas;
        }

        public bool ActualizarEstadoCompra(int nroCompra)
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
                cmd.CommandText = "SP_CAMBIAR_ESTADO";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nroCompra", nroCompra);
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

        public DataTable TraerCompras2(List<Parametro> lista)
        {
            DataTable compras = HelperDao.OI().Consultar("SP_BUSCAR_COMPRAS", lista);
            return compras;
        }

        public DataTable TraerCompraDetalle(List<Parametro> lista)
        {
            DataTable c = HelperDao.OI().Consultar("SP_BUSCAR_COMPRAS_DETALLES", lista);
            return c;
        }
    }
}
