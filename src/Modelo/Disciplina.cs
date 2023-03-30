using System.Security.Cryptography.X509Certificates;

namespace ProjetoEducar.Modelo
{
    public class Disciplina
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Disciplina(string nome)
        {
            this.Nome = nome;
        }
    }
}
