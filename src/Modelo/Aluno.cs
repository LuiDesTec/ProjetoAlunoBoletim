namespace ProjetoEducar.Modelo
{
    public class Aluno : Pessoa
    {
       
        public Aluno(int id, string nome, string sexo, DateTime datanascimento)
            : base(id, nome, sexo, datanascimento)
        {
            
        }
        /*public BoletimNota boletim { get; set; }*/

        public Aluno() { }
       /* public void SetMatricula(String Matricula)
        {
            this.Matricula = Matricula;

        }
       */
    }
}
