using Cine_Back.Entidades.Clientes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Back.Datos.Interfaz
{
    public interface IClienteDao
    {
        public bool CrearCliente(Cliente c);
        public bool ModificarCliente(Cliente c);
        public List<Cliente> TraerClientes();
        public List<TipoDoc> TraerTiposDoc();
        public List<Sexo> TraerSexos();
        public int TraerNextClienteId();
        public bool EliminarCliente(int codCliente);
        List<TipoDoc> ObtenerCombo();
        List<Sexo> ObtenerComboSex();
        DataTable TraerClientesConOSinFiltro(List<Parametro> lst);
        public int TraerIdCheckeada(int codCliente);
    }
}
