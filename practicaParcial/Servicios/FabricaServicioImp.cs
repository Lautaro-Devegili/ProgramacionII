using practicaParcial.Servicios.Implementacion;
using practicaParcial.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaParcial.Servicios
{
    public class FabricaServicioImp : FabricaServicio
    {
        public override IServicio GetServicio()
        {
            return new Servicio();
        }
    }
}
