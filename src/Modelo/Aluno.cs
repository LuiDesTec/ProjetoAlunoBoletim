namespace ProjetoEducar.Modelo
{
    public class Aluno : Pessoa
    {

        public BoletimNota Boletim { get; set; }
       
        public Aluno() { }
       

       
        public Aluno(int id, string nome, string sexo, DateTime datanascimento, BoletimNota boletim)
            : base(id, nome, sexo, datanascimento)
        {
            Boletim = boletim;
           
        }
     
    }
}
