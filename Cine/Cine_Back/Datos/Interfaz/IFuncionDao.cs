using Cine_Back.Entidades.Clientes;
using Cine_Back.Entidades.Funciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Back.Datos.Interfaz
{
    public interface IFuncionDao
    {
        List<Formato> TraerFormatos();
        List<Funcion> TraerFunciones();
        public int TraerNextFuncionId();
        List<Pelicula> TraerPeliculas();
        List<Sala> TraerSalas();
        DataTable TraerFuncionesXFiltro(List<Parametro> lst);
        public bool BorrarFuncion(Parametro pa);
        bool CrearFuncion(Funcion f);
        bool ModificarFuncion(Funcion f);
    }
}
