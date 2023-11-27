using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Back.Entidades.Compras
{
    public class FormaPago
    {
        public int IdFormaPago { get; set; }
        public string FormPago { get; set; }

        public FormaPago(int idFormaPago, string formaPago)
        {
            IdFormaPago = idFormaPago;
            FormPago = formaPago;
        }
        public FormaPago()
        {
            IdFormaPago = 0;
            FormPago = "";
        }
    }
}
