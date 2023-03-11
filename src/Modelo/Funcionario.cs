using ProjetoEducar.Interface;

namespace ProjetoEducar.Modelo
{
    public class Funcionario : Pessoa, IPessoa, IFuncao
    {
        public Funcionario(string nome, string sexo, DateTime datanascimento)
     : base(nome, sexo, datanascimento)
        {
            this.Nome = "Funcionario(a) " + nome;
        }

        public string GetFuncao()
        {
            return "Funcionario";
        }
    }
}
