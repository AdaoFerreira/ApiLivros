using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiLivros.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Livros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Paginas = table.Column<int>(type: "int", nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Editora = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    AnoPublicacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Idioma = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livros", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Livros");
        }
    }
}
