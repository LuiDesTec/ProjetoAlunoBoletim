using ProjetoEducar.Interface;

namespace ProjetoEducar.Modelo
{
    public class Escola
    {
        public int Id { get; set; }
        public string Nome { get; private set; }

        public Endereco Enderecos { get; private set; } = new Endereco();

        public List<Pessoa> Alunos { get; private set; }
        public List<Matricula> Matriculas { get; private set; } = new List<Matricula>();
        public Escola() { }


     
        public string AddPessoa(IPessoa pessoa)
        {
            if (pessoa.GetType().Name.Equals("Aluno"))
            {
                pessoa.SetPessoa(pessoa.GetNome(), pessoa.GetSexo(), new DateTime(2000, 01, 01));
            }

            return pessoa.GetType().Name;
        }
        public Escola(string nome)
        {
            this.Nome = nome;
            this.Alunos = new List<Pessoa>();
           
        }


        public Pessoa AddAluno(int id, string nome, string sexo, DateTime datanascimento)
        {

            // gerar o numero da matricula randomicamente de 0 a 2000
            string matricula = new Random().Next(0, 2000).ToString();

            var aluno = new Pessoa(id, nome, sexo, datanascimento);

            this.Alunos.Add(aluno);

            return this.Alunos.LastOrDefault();
        }


       
        public Matricula SetMatricular(Pessoa aluno, Curso curso)
        {
            Matricula matricula = new Matricula();
            matricula.Alunocursos(aluno, curso);
            this.Matriculas.Add(matricula);

            return matricula;
        }


    }
}
