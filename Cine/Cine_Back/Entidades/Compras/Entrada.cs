using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Back.Entidades.Compras
{
    public class Entrada
    {
        public int CodEntrada { get; set; }
        public int NroCompra { get; set; }
        public int Nrobutaca { get; set; }
        public int CodFuncion { get; set; }
        public decimal Precio { get; set; }
        public int CodDescuento { get; set; }
        public decimal Descuento { get; set; }
        public Entrada(int codEntrada, int nroCompra, int nroButaca, int codFuncion, decimal precio, int codDescuento, decimal descuento)
        {
            CodEntrada = codEntrada;
            NroCompra = nroCompra;
            Nrobutaca = nroButaca;
            CodFuncion = codFuncion;
            Precio = precio;
            CodDescuento = codDescuento;
            Descuento = descuento;
        }

        public Entrada()
        {
            CodEntrada = NroCompra = Nrobutaca = CodFuncion = CodDescuento = 0;
            Precio = Descuento = 0;
        }
    }
}
