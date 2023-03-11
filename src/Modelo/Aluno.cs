namespace ProjetoEducar.Modelo
{
    public class Aluno : Pessoa
    {
       
    
        public Aluno(string nome, string sexo, DateTime datanascimento)
            : base(nome, sexo, datanascimento)
        {
        }

        public string Matricula { get; set; }


        public BoletimNota boletim { get; set; }

        public void SetMatricula(String Matricula)
        {
            this.Matricula = Matricula;

        }

    }
}
