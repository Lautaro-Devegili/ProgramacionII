using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaParcial.Entidades
{
    public class DetalleOrden
    {
        public Producto PProducto { get; set; }
        public int Cantidad { get; set; }

        public DetalleOrden(Producto pProducto, int cantidad)
        {
            PProducto = pProducto;
            Cantidad = cantidad;
        }
    }
}
