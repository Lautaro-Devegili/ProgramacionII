using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_Parcial2.Datos.Int;
using Practica_Parcial2.Dominio;
using System.Data;
using Practica_Parcial2.Datos.Helper;
namespace Practica_Parcial2.Datos.Imp
{
    public class ConsultaDao : IConsultaDao
    {
        public List<Cliente> GetClientes(DateTime fecDesde, DateTime fecHasta)
        {
            List<Cliente> Clientes = new List<Cliente>();
            DataTable t = HelperDB.NI().Consultar("SP_CONSULTAR_CLIENTES");
            foreach (DataRow dr in t.Rows)
            {
                Cliente cliente = new Cliente();
                cliente.Id = Convert.ToInt32(dr["id_cliente"]);
                cliente.Nombre = dr["nombre"].ToString();
                cliente.Apellido = dr["apellido"].ToString();
                cliente.Dni = Convert.ToInt32(dr["dni"]);
                cliente.CodigoPostal = Convert.ToInt32(dr["cod_postal"]);
                cliente.Pedidos = GetPedidos(cliente.Id, fecDesde, fecHasta);
                cliente.NombreYApellido = $"{cliente.Nombre} {cliente.Apellido}";
                Clientes.Add(cliente);
            }
            return Clientes;
        }

        public int DarDeBaja(int nPedido)
        {
            return HelperDB.NI().EjecutarSQL("SP_REGISTRAR_BAJA", new List<Parametro>() { new Parametro("@codigo", nPedido) });
        }

        public int Entregar(int nPedido)
        {
            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@codigo", nPedido));
            return HelperDB.NI().EjecutarSQL("SP_REGISTRAR_ENTREGA",parametros);
            
        }

        public List<Pedido> GetPedidos(int id_cliente, DateTime fecDesde, DateTime fecHasta)
        {
            List<Pedido> pedidos = new List<Pedido>();
            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@cliente", id_cliente));
            parametros.Add(new Parametro("@fecha_desde", fecDesde));
            parametros.Add(new Parametro("@fecha_hasta", fecHasta));
            DataTable t = HelperDB.NI().Consultar("SP_CONSULTAR_PEDIDOS", parametros);
            foreach (DataRow dr in t.Rows)
            {
                Pedido p = new Pedido();
                p.Codigo = Convert.ToInt32(dr["codigo"]);
                p.FechaEntrega = Convert.ToDateTime(dr["fec_entrega"]);
                p.direccionEntrega = dr["dir_entrega"].ToString();
                if (dr["fecha_baja"] != DBNull.Value)
                {
                    p.FechaBaja = Convert.ToDateTime(dr["fecha_baja"]);
                } else
                {
                    p.FechaBaja = DateTime.MinValue;
                }
                
                p.Entregado = dr["entregado"].ToString();
                pedidos.Add(p);
            }
            return pedidos;
        }
    }
}
