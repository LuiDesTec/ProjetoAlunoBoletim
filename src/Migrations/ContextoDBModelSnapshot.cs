﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoEducar.Infra.Dados;

#nullable disable

namespace ProjetoEducar.Migrations
{
    [DbContext(typeof(ContextoDB))]
    partial class ContextoDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProjetoEducar.Modelo.BoletimNota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Boletins");
                });

            modelBuilder.Entity("ProjetoEducar.Modelo.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("ProjetoEducar.Modelo.Disciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("BoletimNotaId")
                        .HasColumnType("int");

                    b.Property<int?>("CursoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("BoletimNotaId");

                    b.HasIndex("CursoId");

                    b.ToTable("Disciplinas");
                });

            modelBuilder.Entity("ProjetoEducar.Modelo.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("ProjetoEducar.Modelo.Escola", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Escolas");
                });

            modelBuilder.Entity("ProjetoEducar.Modelo.EtapaAvaliacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Falta")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nota")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("EpataAvaliações");
                });

            modelBuilder.Entity("ProjetoEducar.Modelo.Matricula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.Property<int?>("EscolaId")
                        .HasColumnType("int");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.HasIndex("CursoId");

                    b.HasIndex("EscolaId");

                    b.ToTable("Matriculas");
                });

            modelBuilder.Entity("ProjetoEducar.Modelo.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataDeNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("EscolaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("EscolaId");

                    b.ToTable("Pessoa");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Pessoa");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("ProjetoEducar.Modelo.Docente", b =>
                {
                    b.HasBaseType("ProjetoEducar.Modelo.Pessoa");

                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.HasIndex("CursoId");

                    b.HasDiscriminator().HasValue("Docente");
                });

            modelBuilder.Entity("ProjetoEducar.Modelo.Funcionario", b =>
                {
                    b.HasBaseType("ProjetoEducar.Modelo.Pessoa");

                    b.HasDiscriminator().HasValue("Funcionario");
                });

            modelBuilder.Entity("ProjetoEducar.Modelo.Disciplina", b =>
                {
                    b.HasOne("ProjetoEducar.Modelo.BoletimNota", null)
                        .WithMany("Disciplinas")
                        .HasForeignKey("BoletimNotaId");

                    b.HasOne("ProjetoEducar.Modelo.Curso", null)
                        .WithMany("Disciplinas")
                        .HasForeignKey("CursoId");
                });

            modelBuilder.Entity("ProjetoEducar.Modelo.Matricula", b =>
                {
                    b.HasOne("ProjetoEducar.Modelo.Pessoa", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoEducar.Modelo.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoEducar.Modelo.Escola", null)
                        .WithMany("Matriculas")
                        .HasForeignKey("EscolaId");

                    b.Navigation("Aluno");

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("ProjetoEducar.Modelo.Pessoa", b =>
                {
                    b.HasOne("ProjetoEducar.Modelo.Escola", null)
                        .WithMany("Alunos")
                        .HasForeignKey("EscolaId");
                });

            modelBuilder.Entity("ProjetoEducar.Modelo.Docente", b =>
                {
                    b.HasOne("ProjetoEducar.Modelo.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("ProjetoEducar.Modelo.BoletimNota", b =>
                {
                    b.Navigation("Disciplinas");
                });

            modelBuilder.Entity("ProjetoEducar.Modelo.Curso", b =>
                {
                    b.Navigation("Disciplinas");
                });

            modelBuilder.Entity("ProjetoEducar.Modelo.Escola", b =>
                {
                    b.Navigation("Alunos");

                    b.Navigation("Matriculas");
                });
#pragma warning restore 612, 618
        }
    }
}
