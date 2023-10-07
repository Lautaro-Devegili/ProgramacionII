using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_Parcial2.Dominio;
namespace Practica_Parcial2.Datos.Int
{
    public interface IConsultaDao
    {
        List<Cliente> GetClientes(DateTime fecDesde, DateTime fecHasta);
        List<Pedido> GetPedidos(int id_cliente, DateTime fecDesde, DateTime fecHasta);
        int Entregar(int nPedido);
        int DarDeBaja(int nPedido);
    }
}
