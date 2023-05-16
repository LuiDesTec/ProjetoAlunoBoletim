namespace ProjetoEducar.Modelo
{
    public class BoletimNota
    {
        public int Id { get; set; }
        public List<Disciplina> Disciplinas { get; set; }
        public BoletimNota()
        {
            Disciplinas = new List<Disciplina>();
        }
      

        public string getListaDisciplinas()
        {
            string relatorio = "";
            foreach (var disciplina in this.Disciplinas)
            {
                relatorio = relatorio + disciplina.Nome + ";";
            }
            return relatorio;

        }
    }
}
