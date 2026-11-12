using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoPortfolio.Migrations
{
    /// <inheritdoc />
    public partial class AtualizarTudo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Experiencia",
                table: "Alunos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FerramentasConhecidas",
                table: "Alunos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HabilidadesCertificados",
                table: "Alunos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SobreAluno",
                table: "Alunos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TecnologiasConhecida",
                table: "Alunos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Projetos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TecnologiaUtilizadas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkAcesso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgVideo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlunoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projetos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projetos_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projetos_AlunoId",
                table: "Projetos",
                column: "AlunoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projetos");

            migrationBuilder.DropColumn(
                name: "Experiencia",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "FerramentasConhecidas",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "HabilidadesCertificados",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "SobreAluno",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "TecnologiasConhecida",
                table: "Alunos");
        }
    }
}
