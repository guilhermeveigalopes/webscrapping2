using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webscrapp.Migrations
{
    public partial class webscrap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    IdLog = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodRob = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuRob = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateLog = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Processo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InfLog = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdProd = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.IdLog);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logs");
        }
    }
}
