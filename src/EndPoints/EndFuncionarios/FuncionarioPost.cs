using Microsoft.AspNetCore.Identity;

using ProjetoEducar.Infra.Dados;
using ProjetoEducar.Modelo;
using System.ComponentModel;
using System.Security.Claims;

namespace ProjetoEducar.EndPoints;

public class FuncionarioPost
{
    public static string Template => "/funcionarioUrl";
    public static string[] Methods => new string[] { HttpMethods.Post.ToString()};
    public static Delegate Handle => Action;

    public static IResult Action(FuncionarioRequest funcRequest, UserManager<IdentityUser> userManager)
    {
        var user = new IdentityUser { UserName = funcRequest.Email, Email = funcRequest.Email };
        var result = userManager.CreateAsync(user, funcRequest.Password).Result;

        if(!result.Succeeded)
        
            return Results.ValidationProblem(result.Errors.ConvertToProblemDetails());

        var userClaims = new List<Claim>
        {
            new Claim("CodigoFuncionario", funcRequest.codigoFuncionario),
            new Claim("Nome", funcRequest.Nome)

        };

        var claimResult =
            userManager.AddClaimsAsync(user,userClaims).Result;
        if(!claimResult.Succeeded)
            return Results.BadRequest(claimResult.Errors.First());
        
        return Results.Created($"/Funcionario/ {user.Id}", user.Id);
    }
}
