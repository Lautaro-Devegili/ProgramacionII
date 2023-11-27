namespace Cine_Back.Entidades.Funciones
{
    public class Formato
    {
        public int IdFormato { get; set; }
        public string Format { get; set; }

        public Formato(int idFormato, string formato)
        {
            IdFormato = idFormato;
            Format = formato;
        }
    }
}
