using Cine_Back.Entidades.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Back.Entidades.Funciones
{
    public class Funcion
    {
        public int IdFuncion { get; set; }
        public int IdPeli { get; set; }
        public string Peli { get; set; }
        public DateTime FechaHora { get; set; }
        public int NroSala { get; set; }
        public string TipoSala { get; set; }
        public decimal Precio { get; set; }
        public int IdFormato { get; set; }
        public string Format { get; set; }
        public string Show { get; set; }

        public Funcion(int idFuncion, int idPeli, string peli, DateTime fechaHora, int nroSala, string tipoSala, decimal precio, int idFormato, string format)
        {
            IdFuncion = idFuncion;
            IdPeli = idPeli;
            Peli = peli;
            FechaHora = fechaHora;
            NroSala = nroSala;
            TipoSala = tipoSala;
            Precio = precio;
            IdFormato = idFormato;
            Format = format;
            Show = $"Función: {IdFuncion} - Peli: {Peli} - Sala: {NroSala}";
        }
        public Funcion()
        {
            IdFuncion = IdPeli = NroSala = IdFormato = 0;
            Peli = "";
            FechaHora = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Función: {IdFuncion} - Peli: {Peli} - Sala: {NroSala}";
        }
    }
}
