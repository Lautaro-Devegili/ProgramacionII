using practicaParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaParcial.Servicios.Interfaz
{
    public interface IServicio
    {
        bool EnviarOrden(Orden orden);
        List<Producto> GetProductos();
    }
}
