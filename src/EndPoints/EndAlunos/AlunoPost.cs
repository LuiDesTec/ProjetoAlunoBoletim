using ProjetoEducar.Infra.Dados;
using ProjetoEducar.Modelo;
using System.ComponentModel;

namespace ProjetoEducar.EndPoints.EndAlunos
{
    public class AlunoPost
    {
        public static string Template => "/alunosUrl";
        public static string[] Methods => new string[] { HttpMethods.Post.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action(AlunoRequest alunoRequest, ContextoDB contexto)
        {
            var aluno = new Aluno
            {
              Nome = alunoRequest.Nome,
              Sexo = "Testando",
             
            };
            contexto.Alunos.Add(aluno);
            contexto.SaveChanges();
            return Results.Created($"/Aluno/ {aluno.Id}", aluno.Id);
        }


    }
}
