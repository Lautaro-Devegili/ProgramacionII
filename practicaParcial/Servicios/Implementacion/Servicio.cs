using practicaParcial.Datos.Implementacion;
using practicaParcial.Datos.Interfaz;
using practicaParcial.Entidades;
using practicaParcial.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaParcial.Servicios.Implementacion
{
    public class Servicio : IServicio
    {
        private IOrdenDao Dao;
        public Servicio()
        {
            Dao = new OrdenDao();
        }
        public List<Producto> GetProductos()
        {
            return Dao.GetProductos();
        }
        public bool EnviarOrden(Orden orden)
        {
            return Dao.GrabarOrden(orden);
        }
    }
}
