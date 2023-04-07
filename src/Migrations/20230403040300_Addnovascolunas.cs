using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoEducar.Migrations
{
    /// <inheritdoc />
    public partial class Addnovascolunas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matriculas_Pessoa_AlunoId",
                table: "Matriculas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_Cursos_CursoId",
                table: "Pessoa");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_Escolas_EscolaId",
                table: "Pessoa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pessoa",
                table: "Pessoa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EpataAvaliações",
                table: "EpataAvaliações");

            migrationBuilder.RenameTable(
                name: "Pessoa",
                newName: "Pessoas");

            migrationBuilder.RenameTable(
                name: "EpataAvaliações",
                newName: "EtapaAvaliacoes");

            migrationBuilder.RenameIndex(
                name: "IX_Pessoa_EscolaId",
                table: "Pessoas",
                newName: "IX_Pessoas_EscolaId");

            migrationBuilder.RenameIndex(
                name: "IX_Pessoa_CursoId",
                table: "Pessoas",
                newName: "IX_Pessoas_CursoId");

            migrationBuilder.AddColumn<int>(
                name: "EnderecosId",
                table: "Escolas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MatriculasId",
                table: "Pessoas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "boletimId",
                table: "Pessoas",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pessoas",
                table: "Pessoas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EtapaAvaliacoes",
                table: "EtapaAvaliacoes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Escolas_EnderecosId",
                table: "Escolas",
                column: "EnderecosId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_boletimId",
                table: "Pessoas",
                column: "boletimId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_MatriculasId",
                table: "Pessoas",
                column: "MatriculasId");

            migrationBuilder.AddForeignKey(
                name: "FK_Escolas_Enderecos_EnderecosId",
                table: "Escolas",
                column: "EnderecosId",
                principalTable: "Enderecos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Matriculas_Pessoas_AlunoId",
                table: "Matriculas",
                column: "AlunoId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Boletins_boletimId",
                table: "Pessoas",
                column: "boletimId",
                principalTable: "Boletins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Cursos_CursoId",
                table: "Pessoas",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Escolas_EscolaId",
                table: "Pessoas",
                column: "EscolaId",
                principalTable: "Escolas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Matriculas_MatriculasId",
                table: "Pessoas",
                column: "MatriculasId",
                principalTable: "Matriculas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Escolas_Enderecos_EnderecosId",
                table: "Escolas");

            migrationBuilder.DropForeignKey(
                name: "FK_Matriculas_Pessoas_AlunoId",
                table: "Matriculas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Boletins_boletimId",
                table: "Pessoas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Cursos_CursoId",
                table: "Pessoas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Escolas_EscolaId",
                table: "Pessoas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Matriculas_MatriculasId",
                table: "Pessoas");

            migrationBuilder.DropIndex(
                name: "IX_Escolas_EnderecosId",
                table: "Escolas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pessoas",
                table: "Pessoas");

            migrationBuilder.DropIndex(
                name: "IX_Pessoas_boletimId",
                table: "Pessoas");

            migrationBuilder.DropIndex(
                name: "IX_Pessoas_MatriculasId",
                table: "Pessoas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EtapaAvaliacoes",
                table: "EtapaAvaliacoes");

            migrationBuilder.DropColumn(
                name: "EnderecosId",
                table: "Escolas");

            migrationBuilder.DropColumn(
                name: "MatriculasId",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "boletimId",
                table: "Pessoas");

            migrationBuilder.RenameTable(
                name: "Pessoas",
                newName: "Pessoa");

            migrationBuilder.RenameTable(
                name: "EtapaAvaliacoes",
                newName: "EpataAvaliações");

            migrationBuilder.RenameIndex(
                name: "IX_Pessoas_EscolaId",
                table: "Pessoa",
                newName: "IX_Pessoa_EscolaId");

            migrationBuilder.RenameIndex(
                name: "IX_Pessoas_CursoId",
                table: "Pessoa",
                newName: "IX_Pessoa_CursoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pessoa",
                table: "Pessoa",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EpataAvaliações",
                table: "EpataAvaliações",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Matriculas_Pessoa_AlunoId",
                table: "Matriculas",
                column: "AlunoId",
                principalTable: "Pessoa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoa_Cursos_CursoId",
                table: "Pessoa",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoa_Escolas_EscolaId",
                table: "Pessoa",
                column: "EscolaId",
                principalTable: "Escolas",
                principalColumn: "Id");
        }
    }
}
