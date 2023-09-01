using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMCCarpinteria_Krlitos.Entidades
{
    public class DetallePresupuesto
    {
        public Producto PProducto { get; set; }
        public int Cantidad { get; set; }

        public DetallePresupuesto(Producto pProducto, int cantidad)
        {
            PProducto = pProducto;
            Cantidad = cantidad;
        }

        public double CalcularSubTotal()
        {
            return Cantidad * PProducto.Precio;
        }

    }
}
