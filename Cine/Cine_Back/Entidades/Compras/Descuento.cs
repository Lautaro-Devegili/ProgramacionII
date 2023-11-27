using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Back.Entidades.Compras
{
    public class Descuento
    {
        public int IdDescuento { get; set; }
        public string Descripcion { get; set; }
        public decimal Porcentaje { get; set; }

        public Descuento(int idDescuento, string descripcion, decimal porcentaje)
        {
            IdDescuento = idDescuento;
            Descripcion = descripcion;
            Porcentaje = porcentaje;
        }
        public Descuento()
        {
            IdDescuento = 0;
            Porcentaje = 0;
            Descripcion = "";
        }
    }
}
