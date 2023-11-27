using Cine_Back.Entidades.Compras;
using Cine_Back.Entidades.Funciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Back.Datos.Interfaz
{
    public interface ICompraDao
    {
        public List<Compra> TraerCompras();
        public List<Descuento> TraerDescuentos();
        public int TraerNextCompraNro();
        public int TraerNextEntradaNro();
        public int TraerNextButacaXFuncion(int Idfuncion);
        public List<FormaPago> TraerFormasPago();
        public bool CrearCompra(Compra c);

        public bool ActualizarEstadoCompra(int nroCompra);

        DataTable TraerCompras2(List<Parametro> lista);

        DataTable TraerCompraDetalle(List<Parametro> lista);


    }
}
