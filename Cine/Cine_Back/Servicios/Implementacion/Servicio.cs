using Cine_Back.Datos;
using Cine_Back.Datos.Implementacion;
using Cine_Back.Datos.Interfaz;
using Cine_Back.Entidades.Clientes;
using Cine_Back.Entidades.Funciones;
using Cine_Back.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Back.Servicios.Implementacion
{
    public class Servicio : IServicio
    {
        IFuncionDao FuncionDao = new FuncionDao();
        IClienteDao ClienteDao = new ClienteDao();
        ICompraDao CompraDao = new CompraDao();
        public int GetNextClienteId()
        {
            int id = ClienteDao.TraerNextClienteId();
            return id;
        }

        public int GetNextCompraNro()
        {
            int id = CompraDao.TraerNextCompraNro();
            return id;
        }

        public int GetNextEntradaNro()
        {
            int id = CompraDao.TraerNextEntradaNro();
            return id;
        }

        public int GetNextFuncionId()
        {
            int id = FuncionDao.TraerNextFuncionId();
            return id;
        }
        public int GetNextButacaXFuncion(int Idfuncion)
        {
            int id = CompraDao.TraerNextButacaXFuncion(Idfuncion);
            return id;
        }

        public bool EliminarCliente(int codCliente)
        {
            return ClienteDao.EliminarCliente(codCliente);
        }

        public DataTable GetFuncionesXFiltro(List<Parametro> lst)
        {
            DataTable funcionesFiltradas = FuncionDao.TraerFuncionesXFiltro(lst);
            return funcionesFiltradas;
        }
        public List<Sexo> TraerComboSex()
        {
            return ClienteDao.ObtenerComboSex();
        }
        public List<TipoDoc> TraerComboDoc()
        {
            return ClienteDao.ObtenerCombo();
        }

        DataTable IServicio.GetClientesConOSinFiltro(List<Parametro> lst)
        {
            return ClienteDao.TraerClientesConOSinFiltro(lst);
        }

        public int GetIdCheckeada(int codCliente)
        {
            return ClienteDao.TraerIdCheckeada(codCliente);
        }

        public bool UpdateEstadoCompra(int codCompra)
        {
            return CompraDao.ActualizarEstadoCompra(codCompra);
        }

        public DataTable BuscarCompra(List<Parametro> lista)
        {
            DataTable compras = CompraDao.TraerCompras2(lista);
            return compras;
        }

        public DataTable BuscarCompraDetalle(List<Parametro> lista)
        {
            DataTable c = CompraDao.TraerCompraDetalle(lista);
            return c;
        }
    }
}
