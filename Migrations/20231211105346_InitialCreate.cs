using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeoProfs.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Verlof",
                columns: table => new
                {
                    VerlofId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WerknemerId = table.Column<int>(type: "int", nullable: false),
                    RedenVerlof = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Beschrijving = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EindDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Verlof", x => x.VerlofId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Verlof");
        }
    }
}
