using Microsoft.AspNetCore.Mvc;
using ProjetoEducar.Infra.Dados;
using ProjetoEducar.Modelo;
using System.ComponentModel;

namespace ProjetoEducar.EndPoints
{
    public class AlunoPut
    {
        public static string Template => "/alunosUrl/{id}";
        public static string[] Methods => new string[] { HttpMethods.Put.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action([FromRoute] int id, AlunoRequest alunoRequest, ContextoDB contexto)
        {
            var aluno = contexto.Alunos.Where(a => a.Id == id).FirstOrDefault();
            if (aluno == null)
                return Results.NotFound();

            aluno.EdiInfo(alunoRequest.Nome);
            if (!aluno.IsValid)
                return Results.ValidationProblem(aluno.Notifications.ConvertToProblemDetails());

            contexto.SaveChanges();
            return Results.Ok();
        }


    }
}
