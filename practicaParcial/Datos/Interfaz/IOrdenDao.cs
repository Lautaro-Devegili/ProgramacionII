using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practicaParcial.Entidades;
namespace practicaParcial.Datos.Interfaz
{
    public interface IOrdenDao
    {
        List<Producto> GetProductos();
        bool GrabarOrden(Orden orden);
    }
}
