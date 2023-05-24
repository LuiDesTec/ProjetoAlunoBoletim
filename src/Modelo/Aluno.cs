using Flunt.Validations;
using System.Diagnostics.Contracts;

namespace ProjetoEducar.Modelo
{
    public class Aluno : Pessoa
    {

        public BoletimNota Boletim { get; set; }
       
        public Aluno() { }

        public Aluno(string nome)
        {
            var contrato = new Contract<Aluno>()
               .IsNotNullOrEmpty(nome, "Nome")
               .IsGreaterOrEqualsThan(nome,4,"Nome");
              
            AddNotifications(contrato);
            Nome = nome;
           
        }

        public Aluno(int id, string nome, string sexo, DateTime datanascimento, BoletimNota boletim)
            : base(id, nome, sexo, datanascimento)
        {
           
            Boletim = boletim;
           
        }

       
    }
}
