using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_Parcial2.Datos.DTOs;
using Practica_Parcial2.Dominio;
using Practica_Parcial2.Servicios.Int;
using Practica_Parcial2.Datos.Int;
using Practica_Parcial2.Datos.Imp;
using System.Windows.Forms;

namespace Practica_Parcial2.Servicios.Imp
{
    public class Servicio : IServicio
    {
        private IConsultaDao d;

        public Servicio()
        {
            d = new ConsultaDao();
        }

        public int DarDeBaja(int nPedido)
        {
            return d.DarDeBaja(nPedido);
        }

        public int Entregar(int nPedido)
        {
            return d.Entregar(nPedido);
            
        }

        public List<Cliente> TraerClientes(DateTime fecDesde, DateTime fecHasta)
        {
            return d.GetClientes(fecDesde, fecHasta);
        }
    }
}
