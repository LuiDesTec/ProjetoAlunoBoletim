using Dapper;
using Microsoft.AspNetCore.Identity;
using MySqlConnector;
using System.Security.Claims;

namespace ProjetoEducar.EndPoints;

public class FuncionarioGetAll
{
    public static string Template => "/funcionarioUrl";
    public static string[] Methods => new string[] { HttpMethods.Get.ToString() };
    public static Delegate Handle => Action;

    public static IResult Action(int page, int rows, IConfiguration configuration)
    {
        var db = new MySqlConnection(configuration["EducandarioData"]);
        var funcionarios = db.Query<FuncionarioResponse>
        (
          @"select Email, ClaimValue as Nome
            from aspnetusers u 
            inner join aspnetuserclaims c 
            on u.id = c.UserId and ClaimType = 'Nome'
            order by nome"

        );

        return Results.Ok( funcionarios );
    }
   


}
