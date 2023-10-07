﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Parcial2.Datos.DTOs
{
    public class PedidoDTO
    {
        public int Codigo { get; set; }
        public string Cliente { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string Entregado { get; set; }

        public int idCliente { get; set; }
    }
}
