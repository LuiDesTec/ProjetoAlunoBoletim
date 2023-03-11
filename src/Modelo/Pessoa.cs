using ProjetoEducar.Interface;

namespace ProjetoEducar.Modelo
{
    public class Pessoa : IPessoa
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

        public string GetIdade()
        {
            return DateTime.Now.Year - DataDeNascimento.Year + " years old";
        }

        public string GetNome()
        {
            return this.Nome;
        }

        public string GetSexo()
        {
            return this.Sexo;
        }

        public void SetPessoa(string nome, string sexo, DateTime datanascimento)
        {
            this.Nome = nome;
            this.Sexo = sexo;
            this.DataDeNascimento = datanascimento;
        }
    }
}
