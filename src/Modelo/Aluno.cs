namespace ProjetoEducar.Modelo
{
    public class Aluno : Pessoa
    {
        private BoletimNota? boletimNota;

        public BoletimNota boletim { get; set; }
        public Matricula Matriculas { get; set; }
        public Aluno(int id, string nome, string sexo, DateTime datanascimento)
            : base(id, nome, sexo, datanascimento)
        {
            boletim = boletimNota;
        }
        

        public Aluno() { }
        public void SetMatricula (Matricula Matricula)
        {
            this.Matriculas = Matricula;

        }
       
    }
}
