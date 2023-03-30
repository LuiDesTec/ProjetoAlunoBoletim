using Microsoft.EntityFrameworkCore;
using ProjetoEducar.EndPoints.EndAlunos;
using ProjetoEducar.Infra.Dados;
using System;

var builder = WebApplication.CreateBuilder(args);

string mySqlConnection =
              builder.Configuration.GetConnectionString("EducandarioData");

builder.Services.AddDbContextPool<ContextoDB>(options =>
                options.UseMySql(mySqlConnection,
                      ServerVersion.AutoDetect(mySqlConnection)));

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

app.Run();

