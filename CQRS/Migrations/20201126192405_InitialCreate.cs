using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CQRS.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookRequest",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(nullable: true),
                    Edicao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookRequest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookResponse",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Titulo = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookResponse", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookRequest");

            migrationBuilder.DropTable(
                name: "BookResponse");
        }
    }
}
