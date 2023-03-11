namespace ProjetoEducar.Modelo
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }

        public DateTime DataDeNascimento { get; set; }

        public Pessoa(string nome, string sexo, DateTime datanascimento)
        {
            this.Nome = nome;
            this.Sexo = sexo;

            this.DataDeNascimento = datanascimento;
        }
    }
}
