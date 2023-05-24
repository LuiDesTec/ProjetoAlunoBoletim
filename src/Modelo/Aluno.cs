using Flunt.Validations;
using System.Diagnostics.Contracts;

namespace ProjetoEducar.Modelo
{
    public class Aluno : Pessoa
    {

        public BoletimNota Boletim { get; private set; }
       
        public Aluno() { }

        public Aluno(string nome)
        {
           
            Nome = nome;
            Validar();
        }

        public Aluno(int id, string nome, string sexo, DateTime datanascimento, BoletimNota boletim)
            : base(id, nome, sexo, datanascimento)
        {
           
            Boletim = boletim;
           
        }
        private void Validar()
        {
            var contrato = new Contract<Aluno>()
               .IsNotNullOrEmpty(Nome, "Nome")
               .IsGreaterOrEqualsThan(Nome, 4, "Nome");

            AddNotifications(contrato);
        }
        public void EdiInfo(string nome)
        {
            Nome = nome;
            Validar();
        }

       
    }
}
