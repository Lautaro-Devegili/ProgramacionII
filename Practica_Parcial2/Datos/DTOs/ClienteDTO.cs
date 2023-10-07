using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Parcial2.Datos.DTOs
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }

        public override string ToString()
        {
            return $"{NombreCompleto}";
        }
    }
}
