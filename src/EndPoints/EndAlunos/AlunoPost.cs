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
            var aluno = new Aluno(alunoRequest.Nome);

            if (!aluno.IsValid)
            {
                var erros = aluno.Notifications
                    .GroupBy(k => k.Key)
                    .ToDictionary(k => k.Key, k => k.Select(x => x.Message).ToArray());
                return Results.ValidationProblem(erros);
            }
            contexto.Alunos.Add(aluno);
            contexto.SaveChanges();
            return Results.Created($"/Aluno/ {aluno.Id}", aluno.Id);
        }


    }
}
