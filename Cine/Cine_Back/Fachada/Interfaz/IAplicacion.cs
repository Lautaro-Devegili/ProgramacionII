using Cine_Back.Datos;
using Cine_Back.Entidades.Clientes;
using Cine_Back.Entidades.Compras;
using Cine_Back.Entidades.Funciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Back.Fachada.Interfaz
{
    public interface IAplicacion
    {
        public List<Formato> GetFormatos();
        public List<Funcion> GetFunciones();
        public int GetNextFuncionId();
        public List<Pelicula> GetPeliculas();
        public List<Sala> GetSalas();
        public List<Sexo> GetSexos();
        public List<TipoDoc> GetTiposDoc();
        public List<Cliente> GetClientes();
        public bool SaveCliente(Cliente c);
        public bool SaveFuncion(Funcion f);
        public List<Compra> GetCompras();
        public List<Descuento> GetDescuentos();
        public List<FormaPago> GetFormasPago();
        public bool SaveCompra(Compra c);
        public bool BorrarFuncion(Parametro pa);
        public bool UpdateCliente(Cliente c);
        public bool EliminarCliente(int codCliente);
        public bool UpdateFuncion(Funcion fun);
        public bool UpdateEstadoCompra(int codCompra);
    }
}
