namespace ProjetoEducar.Modelo
{
    public class Aluno : Pessoa
    {
       
        public Aluno(int id, string nome, string sexo, DateTime datanascimento, string matricula)
            : base(id, nome, sexo, datanascimento)
        {
            Matricula = matricula;
        }
        
        public string? Matricula { get; set; }


        public BoletimNota boletim { get; set; }

        public Aluno() { }
        public void SetMatricula(String Matricula)
        {
            this.Matricula = Matricula;

        }

    }
}
