namespace ProjetoEducar.Modelo
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; private set; }
        public BoletimNotas boletim { get; set; }
    }
}
