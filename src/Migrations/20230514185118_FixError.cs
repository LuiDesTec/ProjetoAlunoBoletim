using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoEducar.Migrations
{
    /// <inheritdoc />
    public partial class FixError : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disciplinas_Boletins_BoletimNotaId",
                table: "Disciplinas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Boletins_boletimId",
                table: "Pessoas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Matriculas_MatriculasId",
                table: "Pessoas");

            migrationBuilder.DropIndex(
                name: "IX_Pessoas_MatriculasId",
                table: "Pessoas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Boletins",
                table: "Boletins");

            migrationBuilder.DropColumn(
                name: "MatriculasId",
                table: "Pessoas");

            migrationBuilder.RenameTable(
                name: "Boletins",
                newName: "Boletim");

            migrationBuilder.RenameColumn(
                name: "boletimId",
                table: "Pessoas",
                newName: "BoletimId");

            migrationBuilder.RenameIndex(
                name: "IX_Pessoas_boletimId",
                table: "Pessoas",
                newName: "IX_Pessoas_BoletimId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Boletim",
                table: "Boletim",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplinas_Boletim_BoletimNotaId",
                table: "Disciplinas",
                column: "BoletimNotaId",
                principalTable: "Boletim",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Boletim_BoletimId",
                table: "Pessoas",
                column: "BoletimId",
                principalTable: "Boletim",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disciplinas_Boletim_BoletimNotaId",
                table: "Disciplinas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Boletim_BoletimId",
                table: "Pessoas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Boletim",
                table: "Boletim");

            migrationBuilder.RenameTable(
                name: "Boletim",
                newName: "Boletins");

            migrationBuilder.RenameColumn(
                name: "BoletimId",
                table: "Pessoas",
                newName: "boletimId");

            migrationBuilder.RenameIndex(
                name: "IX_Pessoas_BoletimId",
                table: "Pessoas",
                newName: "IX_Pessoas_boletimId");

            migrationBuilder.AddColumn<int>(
                name: "MatriculasId",
                table: "Pessoas",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Boletins",
                table: "Boletins",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_MatriculasId",
                table: "Pessoas",
                column: "MatriculasId");

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplinas_Boletins_BoletimNotaId",
                table: "Disciplinas",
                column: "BoletimNotaId",
                principalTable: "Boletins",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Boletins_boletimId",
                table: "Pessoas",
                column: "boletimId",
                principalTable: "Boletins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Matriculas_MatriculasId",
                table: "Pessoas",
                column: "MatriculasId",
                principalTable: "Matriculas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
