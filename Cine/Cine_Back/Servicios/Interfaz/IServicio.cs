using Cine_Back.Datos;
using Cine_Back.Entidades.Clientes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Back.Servicios.Interfaz
{
    public interface IServicio
    {
        public int GetNextClienteId();
        public int GetNextCompraNro();
        public int GetNextEntradaNro();
        public int GetNextFuncionId();
        public int GetNextButacaXFuncion(int Idfuncion);
        DataTable GetFuncionesXFiltro(List<Parametro> lst);
        bool EliminarCliente(int codCliente);
        List<TipoDoc> TraerComboDoc();
        List<Sexo> TraerComboSex();
        public DataTable GetClientesConOSinFiltro(List<Parametro> lst);
        public int GetIdCheckeada(int codCliente);
        public bool UpdateEstadoCompra(int codCompra);

        DataTable BuscarCompra(List<Parametro> lista);
        DataTable BuscarCompraDetalle(List<Parametro> lista);
    }
}
