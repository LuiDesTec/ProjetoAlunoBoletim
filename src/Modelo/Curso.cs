namespace ProjetoEducar.Modelo
{
    public class Curso
    {
        public int Id { get; set; }
        public List<Disciplina> Disciplinas { get; set; } = new List<Disciplina>();

        public void setDisciplinas(string nomedisciplina)
        {
            Disciplina disciplina = new Disciplina(nomedisciplina);

            this.Disciplinas.Add(disciplina);
        }


    }
}
