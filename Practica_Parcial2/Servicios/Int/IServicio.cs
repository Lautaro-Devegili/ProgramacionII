using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_Parcial2.Dominio;
using Practica_Parcial2.Datos.DTOs;

namespace Practica_Parcial2.Servicios.Int
{
    public interface IServicio
    {
        List<Cliente> TraerClientes(DateTime fecDesde, DateTime fecHasta);
        int Entregar(int nPedido);
        int DarDeBaja(int nPedido);
    }
}
