namespace ProjetoEducar.Modelo
{
    public class BoletimNota
    {
        public BoletimNota()
        {
            Disciplinas = new List<Disciplina>();
        }
        public List<Disciplina> Disciplinas { get; set; }

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
