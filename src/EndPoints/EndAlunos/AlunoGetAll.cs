

using ProjetoEducar.Infra.Dados;
using ProjetoEducar.Modelo;
using System.ComponentModel;

namespace ProjetoEducar.EndPoints
{
    public class AlunoGetAll
    {
        public static string Template => "/alunosUrl";
        public static string[] Methods => new string[] { HttpMethod.Get.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action(ContextoDB contexto)
        {
            var alunos = contexto.Alunos.ToList();
            var response = alunos.Select(a => new AlunoResponse {Nome = a.Nome, Id = a.Id});
            return Results.Ok(response);
        }


    }
}
