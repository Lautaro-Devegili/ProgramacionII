namespace Cine_Back.Entidades.Clientes
{
    public class Sexo
    {
        public int IdSexo { get; set; }
        public string Sex { get; set; }

        public Sexo(int idSexo, string sex)
        {
            IdSexo = idSexo;
            Sex = sex;
        }
    }
}
