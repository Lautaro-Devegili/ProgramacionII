using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Parcial2.Dominio
{
    public class Pedido
    {
        public int Codigo { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string direccionEntrega { get; set; }
        public DateTime FechaBaja { get; set; }
        public string Entregado { get; set; }
    }
}
