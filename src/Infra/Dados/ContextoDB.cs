using Microsoft.EntityFrameworkCore;
using ProjetoEducar.Modelo;
using System;

namespace ProjetoEducar.Infra.Dados
{
    public class ContextoDB : DbContext
    {
        public ContextoDB(DbContextOptions<ContextoDB> options) : base(options)
        { }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<BoletimNota> Boletim { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Docente> Docentes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Matricula> Matriculas{ get; set; }
        public DbSet<Escola> Escolas { get; set; }
        public DbSet<EtapaAvaliacao> EtapaAvaliacoes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }


       protected override void OnModelCreating(ModelBuilder modelbuilder)
        {

            modelbuilder.Entity<Aluno>().Property(a => a.Sexo).IsRequired();
            modelbuilder.Entity<Aluno>().Property(a => a.Nome).IsRequired();

            modelbuilder.Entity<Pessoa>().Property(p => p.Nome).IsRequired();
            modelbuilder.Entity<Pessoa>().Property(p => p.DataDeNascimento).IsRequired();

            modelbuilder.Entity<Funcionario>().Property(f => f.Nome).IsRequired();
            modelbuilder.Entity<Funcionario>().Property(f => f.DataDeNascimento);
           
            modelbuilder.Entity<Escola>().Property(e => e.Nome).HasMaxLength(100).IsRequired();
           
           
            modelbuilder.Entity<Matricula>().Property(m => m.Numero);
       }

    }

    
}
