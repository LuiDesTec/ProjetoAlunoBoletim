using Microsoft.AspNetCore.Identity;

namespace ProjetoEducar.EndPoints;

public class FuncionarioGetAll
{
    public static string Template => "/funcionarioUrl";
    public static string[] Methods => new string[] { HttpMethods.Get.ToString()};
    public static Delegate Handle => Action;

    public static IResult Action(UserManager<IdentityUser> userManager)
    {
        var users = userManager.Users.ToList();
        var funcionarios = new List<FuncionarioResponse>();
        foreach ( var user in users ) 
        {
            var claims = userManager.GetClaimsAsync(user).Result;
            var claimNome = claims.FirstOrDefault(c => c.Type == "Name");
            var userNome = claimNome != null ? claimNome.Value : string.Empty;
            funcionarios.Add(new FuncionarioResponse(user.Email, userNome));
        }
        return Results.Ok(funcionarios);
    }


}
