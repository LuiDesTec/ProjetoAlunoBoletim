using Dapper;
using Microsoft.AspNetCore.Identity;
using MySqlConnector;
using ProjetoEducar.Infra.Dados;
using System.Security.Claims;

namespace ProjetoEducar.EndPoints;

public class FuncionarioGetAll
{
    public static string Template => "/funcionarioUrl";
    public static string[] Methods => new string[] { HttpMethods.Get.ToString() };
    public static Delegate Handle => Action;

    public static IResult Action( int? page, int? rows, QueryUsuarios query)
    {
        return Results.Ok(query.Executar(page.Value, rows.Value));
    }
}
