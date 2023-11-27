using Cine_Back.Datos.Interfaz;
using Cine_Back.Fachada.Interfaz;
using Cine_Back.Servicios.Implementacion;
using Cine_Back.Servicios.Interfaz;
using Cine_Back.Datos.Implementacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cine_Back.Datos;
using Cine_Back.Entidades.Funciones;
using Cine_Back.Entidades.Clientes;
using Cine_Back.Entidades.Compras;

namespace Cine_Back.Fachada.Implementacion
{
    public class Aplicacion : IAplicacion
    {
        IServicio s = new Servicio();
        private IFuncionDao daoF;
        private IClienteDao daoC;
        private ICompraDao daoCo;

        public Aplicacion()
        {
            daoF = new FuncionDao();
            daoC = new ClienteDao();
            daoCo = new CompraDao();
        }

        public List<Formato> GetFormatos()
        {
            List<Formato> lst = daoF.TraerFormatos();
            return lst;
        }

        public List<Sala> GetSalas()
        {
            List<Sala> lst = daoF.TraerSalas();
            return lst;
        }

        public List<Funcion> GetFunciones()
        {
            List<Funcion> lst = daoF.TraerFunciones();
            return lst;
        }

        public int GetNextFuncionId()
        {
            int id = daoF.TraerNextFuncionId();
            return id;
        }
        public List<Pelicula> GetPeliculas()
        {
            List<Pelicula> lst = daoF.TraerPeliculas();
            return lst;
        }

        public List<Sexo> GetSexos()
        {
           List<Sexo> lst = daoC.TraerSexos();
            return lst;
        }

        public List<TipoDoc> GetTiposDoc()
        {
            List<TipoDoc> lst = daoC.TraerTiposDoc();
            return lst;
        }
        
        public List<Cliente> GetClientes()
        {
            List<Cliente> lst = daoC.TraerClientes();
            return lst;
        }

        public List<Compra> GetCompras()
        {
            List<Compra> lst = daoCo.TraerCompras();
            return lst;
        }

        public List<Descuento> GetDescuentos()
        {
            List<Descuento> lst = daoCo.TraerDescuentos();
            return lst;
        }
        public List<FormaPago> GetFormasPago()
        {
            List <FormaPago> lst = daoCo.TraerFormasPago();
            return lst;
        }

        public bool SaveCompra(Compra c)
        {
            return daoCo.CrearCompra(c);
        }

        public bool SaveCliente(Cliente c)
        {
            return daoC.CrearCliente(c);
        }

        public bool BorrarFuncion(Parametro pa)
        {
            return daoF.BorrarFuncion(pa);
        }

        public bool SaveFuncion(Funcion f)
        {
            return daoF.CrearFuncion(f);
        }

        public bool UpdateCliente(Cliente c)
        {
            return daoC.ModificarCliente(c);
        }

        public bool UpdateEstadoCompra(int codCompra)
        {
            return daoCo.ActualizarEstadoCompra(codCompra);
        }

        public bool EliminarCliente(int codCliente)
        {
            return daoC.EliminarCliente(codCliente);
        }

        public bool UpdateFuncion(Funcion fun)
        {
            return daoF.ModificarFuncion(fun);
        }
    }
}
