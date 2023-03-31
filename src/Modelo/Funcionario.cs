using ProjetoEducar.Interface;

namespace ProjetoEducar.Modelo
{
    public class Funcionario : Pessoa, IPessoa, IFuncao
    {
        public Funcionario() { }
        public Funcionario(int id, string nome, string sexo, DateTime datanascimento)
        : base(id, nome, sexo, datanascimento)
        {
            this.Nome = "Funcionario(a) " + nome;
        }

        public string GetFuncao()
        {
            return "Funcionario";
        }
    }
}
