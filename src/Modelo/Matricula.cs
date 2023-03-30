namespace ProjetoEducar.Modelo
{
    public class Matricula
    {
        public int Id { get; set; }
        public int Numero { get; private set; }
        public Pessoa Aluno { get; set; }
        public Curso Curso { get; set; }

        public void Alunocursos(Pessoa aluno, Curso curso)
        {
            this.Aluno = aluno;
            this.Curso = curso;
        }

    }
}
