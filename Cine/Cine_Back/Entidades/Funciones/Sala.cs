namespace Cine_Back.Entidades.Funciones
{
    public class Sala
    {
        public int NroSala { get; set; }
        public int IdTipoSala { get; set; }
        public string TipoSala { get; set; }
        public int Capacidad { get; set; }

        public Sala(int nroSala, int idTipoSala, string tipoSala, int capacidad)
        {
            NroSala = nroSala;
            IdTipoSala = idTipoSala;
            TipoSala = tipoSala;
            Capacidad = capacidad;
        }
    }
}
