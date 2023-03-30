using ProjetoEducar.Interface;

namespace ProjetoEducar.Modelo
{
    public class Pessoa : IPessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public DateTime DataDeNascimento { get; set; }
        
        public Pessoa() { }
        public Pessoa(int id, string nome, string sexo, DateTime datanascimento)
        {
            this.Nome = nome;
            this.Sexo = sexo;
            this.DataDeNascimento = datanascimento;
        }

        public Pessoa(string nome, string sexo)
        {
            Nome = nome;
            Sexo = sexo;
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
