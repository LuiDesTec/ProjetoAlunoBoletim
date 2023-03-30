using Microsoft.EntityFrameworkCore;
using ProjetoEducar.Modelo;
using System;

namespace ProjetoEducar.Infra.Dados
{
    public class ContextoDB : DbContext
    {
        public ContextoDB(DbContextOptions<ContextoDB> options) : base(options)
        { }
        public DbSet<Pessoa> Alunos { get; set; }
        public DbSet<BoletimNota> Boletins { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Docente> Docentes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Matricula> Matriculas{ get; set; }
        public DbSet<Escola> Escolas { get; set; }
        public DbSet<EtapaAvaliacao> EpataAvaliações { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }


       protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Pessoa>().Property(n => n.Nome).IsRequired();
            modelbuilder.Entity<Pessoa>().Property(n => n.DataDeNascimento).IsRequired();
            
            modelbuilder.Entity<Funcionario>().Property(n => n.Nome).IsRequired();
            modelbuilder.Entity<Funcionario>().Property(n => n.DataDeNascimento);
           
            modelbuilder.Entity<Escola>().Property(n => n.Nome).HasMaxLength(100).IsRequired();
            //modelbuilder.Entity<Escola>().Property(n => n.Enderecos).HasMaxLength(100);
           
            modelbuilder.Entity<Matricula>().Property(n => n.Numero).IsRequired();
       }

    }

    
}
