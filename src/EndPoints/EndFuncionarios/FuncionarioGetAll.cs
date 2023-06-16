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

    public static IResult Action( int page, int rows, IConfiguration configuration)
    {
        var db = new MySqlConnection(configuration.GetConnectionString("EducandarioData"));
        var funcionarios = db.Query<FuncionarioResponse>
        (
          @"select Email, ClaimValue as Nome
            from AspNetUsers u 
            inner join AspnetUserClaims c             
            on u.id = c.UserId and claimtype = 'Nome'
            order by nome"
            
        );

        return Results.Ok( funcionarios );
    }
}
