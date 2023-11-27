namespace Cine_Back.Entidades.Clientes
{
    public class TipoDoc
    {
        public int IdTipoDoc { get; set; }
        public string Tipo { get; set; }

        public TipoDoc(int idTipoDoc, string tipoDoc)
        {
            IdTipoDoc = idTipoDoc;
            Tipo = tipoDoc;
        }
    }
}
