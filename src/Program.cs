using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProjetoEducar.EndPoints;

using ProjetoEducar.Infra.Dados;


var builder = WebApplication.CreateBuilder(args);

string mySqlConnection =
              builder.Configuration.GetConnectionString("EducandarioData");
builder.Services.AddDbContextPool<ContextoDB>(options =>
                options.UseMySql(mySqlConnection,
                      ServerVersion.AutoDetect(mySqlConnection)));

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<ContextoDB>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapMethods(AlunoPost.Template, AlunoPost.Methods, AlunoPost.Handle);
app.MapMethods(AlunoGetAll.Template, AlunoGetAll.Methods, AlunoGetAll.Handle);
app.MapMethods(AlunoPut.Template, AlunoPut.Methods, AlunoPut.Handle);
app.MapMethods(FuncionarioPost.Template, FuncionarioPost.Methods, FuncionarioPost.Handle);
app.MapMethods(FuncionarioGetAll.Template, FuncionarioGetAll.Methods, FuncionarioGetAll.Handle);

app.Run();

