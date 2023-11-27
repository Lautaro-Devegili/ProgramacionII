namespace Cine_Back.Entidades.Funciones
{
    public class Pelicula
    {
        public int IdPeli { get; set; }
        public string Nombre { get; set; }
        public int Duracion { get; set; }
        public DateTime FechaEstreno { get; set; }
        public int IdCategoria { get; set; }
        public int PriGenero { get; set; }
        public int SegGenero { get; set; }
        public int IdDirector { get; set; }

        public Pelicula(int idPeli, string nombre, int duracion, DateTime fechaEstreno, int idCategoria, int priGenero, int segGenero, int idDirector)
        {
            IdPeli = idPeli;
            Nombre = nombre;
            Duracion = duracion;
            FechaEstreno = fechaEstreno;
            IdCategoria = idCategoria;
            PriGenero = priGenero;
            SegGenero = segGenero;
            IdDirector = idDirector;
        }
    }
}
