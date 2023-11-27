using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Back.Entidades.Clientes
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int TipoDoc { get; set; }
        public int Documento { get; set; }
        public int IdSexo { get; set; }
        public DateTime FechaNac { get; set; }
        public long Telefono { get; set; }
        public string ApeNombre { get; set; }

        public Cliente(int idCliente, string apellido, string nombre, int tipoDoc, int documento, int idSexo, DateTime fechaNac, long telefono)
        {
            IdCliente = idCliente;
            Nombre = nombre;
            Apellido = apellido;
            TipoDoc = tipoDoc;
            Documento = documento;
            IdSexo = idSexo;
            FechaNac = fechaNac;
            Telefono = telefono;
            ApeNombre = Apellido + ", " + Nombre;
        }
        public Cliente()
        {
             IdCliente = TipoDoc = Documento = IdSexo  = 0;
            Nombre = Apellido = "";
            FechaNac = DateTime.Now;
            Telefono = 0;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
