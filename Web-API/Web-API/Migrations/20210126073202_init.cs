using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web_API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Building",
                columns: table => new
                {
                    BuildingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingCode = table.Column<string>(maxLength: 50, nullable: true),
                    BuildingName = table.Column<string>(maxLength: 50, nullable: true),
                    Visible = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Building", x => x.BuildingID);
                });

            migrationBuilder.CreateTable(
                name: "PDC",
                columns: table => new
                {
                    PDCID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PDCName = table.Column<string>(maxLength: 50, nullable: true),
                    PDCCode = table.Column<string>(maxLength: 50, nullable: true),
                    Visible = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PDC", x => x.PDCID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 20, nullable: true),
                    HashPass = table.Column<string>(maxLength: 100, nullable: true),
                    HashImage = table.Column<string>(maxLength: 200, nullable: true),
                    EmailAddress = table.Column<string>(maxLength: 100, nullable: true),
                    Visible = table.Column<bool>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true),
                    EmpName = table.Column<string>(maxLength: 50, nullable: true),
                    Roles = table.Column<string>(maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Building");

            migrationBuilder.DropTable(
                name: "PDC");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
