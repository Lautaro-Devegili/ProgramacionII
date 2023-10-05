using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaParcial.Entidades
{
    public class Producto
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public int Stock { get; set; }

        public Producto(int id, string nombre, int stock)
        {
            Id = id;
            Nombre = nombre;
            Stock = stock;
        }
        public Producto()
        {
            Id = Stock = 0;
            Nombre = "";
        }
    }
}
