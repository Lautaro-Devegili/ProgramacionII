using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Back.Entidades.Compras
{
    public class Compra
    {
        public int NroCompra { get; set; }
        public int IdFormaPago { get; set; }
        public int IdCliente { get; set; }
        public string ApeCliente { get; set; }
        public DateTime FechaCompra { get; set; }
        public int IdEstado { get; set; }
        public List<Entrada> Entradas { get; set; }

        public Compra(int nroCompra, int idFormaPago, int idCliente, string apeCliente, DateTime fechaCompra, int idEstado)
        {
            NroCompra = nroCompra;
            IdFormaPago = idFormaPago;
            IdCliente = idCliente;
            ApeCliente = apeCliente;
            FechaCompra = fechaCompra;
            IdEstado = idEstado;
            Entradas = new List<Entrada>();
        }
        public Compra()
        {
            NroCompra = IdFormaPago = IdCliente = IdEstado = 0;
            ApeCliente = "";
            FechaCompra = DateTime.Now;
            Entradas = new List<Entrada>();
        }

        public void AgregarEntrada(Entrada e)
        {
            Entradas.Add(e);
        }
        public void QuitarEntrada(Entrada e)
        {
            Entradas.Remove(e);
        }
    }
}
