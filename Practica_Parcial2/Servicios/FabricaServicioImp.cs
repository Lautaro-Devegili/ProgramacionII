using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_Parcial2.Servicios.Imp;
using Practica_Parcial2.Servicios.Int;
namespace Practica_Parcial2.Servicios
{
    public class FabricaServicioImp : FabricaServicio
    {
        public override IServicio GetServicio()
        {
            return new Servicio();
        }
    }
}
