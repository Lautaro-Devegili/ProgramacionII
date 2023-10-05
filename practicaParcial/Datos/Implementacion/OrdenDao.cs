using practicaParcial.Datos.Interfaz;
using practicaParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaParcial.Datos.Implementacion
{
    public class OrdenDao : IOrdenDao
    {
        public List<Producto> GetProductos()
        {
            List<Producto> lprod = new List<Producto>();

            DataTable tabla = HelperDao.NI().Consultar("SP_CONSULTAR_MATERIALES");
            foreach (DataRow f in tabla.Rows)
            {
                Producto p = new Producto();
                p.Id = Convert.ToInt32(f["Codigo"]);
                p.Nombre = f["nombre"].ToString();
                p.Stock = Convert.ToInt32(f["stock"]);
                lprod.Add(p);
            }
            return lprod;
        }

        public bool GrabarOrden(Orden orden)
        {
            return HelperDao.NI().ConfirmarOrden(orden);
        }
    }
}
