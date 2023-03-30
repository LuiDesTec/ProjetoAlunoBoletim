using ProjetoEducar.Interface;

namespace ProjetoEducar.Modelo
{
    public class Docente : Pessoa, IPessoa, IFuncao
    {
        
        public Curso Curso { get; set; }

        public Docente() { }

        public Docente(int id, string nome, string sexo,
            DateTime datanascimento, Curso curso) : base(id, nome,sexo, datanascimento)
        {
            Curso= curso;
        }
        public string GetFuncao()
        {
            return "Professor(a) ";
        }
    }
}

