namespace ProjetoEducar.Modelo
{
    public class Escola
    {
        public string Nome { get; private set; }

        public List<Aluno> Alunos { get; private set; }

        public Endereco Endereco { get; private set; }

        public Escola(string nomedaescola)
        {
            this.Nome = nomedaescola;
            this.Alunos = new List<Aluno>();//Garantir que tenha a lista de alunos.
            this.Endereco = new Endereco();
        }
}
