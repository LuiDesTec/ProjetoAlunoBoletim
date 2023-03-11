namespace ProjetoEducar.Modelo
{
    public class Matricula
    {
        public Aluno Aluno { get; set; }
        public Curso Curso { get; set; }

        public void Alunocursos(Aluno aluno, Curso curso)
        {
            this.Aluno = aluno;
            this.Curso = curso;
        }

    }
}
