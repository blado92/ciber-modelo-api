using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBManager.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblAccessMatrix",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    QueryTypeId = table.Column<int>(type: "int", nullable: false),
                    AccessLevelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAccessMatrix", x => new { x.RoleId, x.QueryTypeId, x.AccessLevelId });
                });

            migrationBuilder.CreateTable(
                name: "tblDeceased",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EPS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeceasedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDeceased", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblDeceasedDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    DeceasedId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDeceasedDocuments", x => new { x.Id, x.DeceasedId });
                });

            migrationBuilder.CreateTable(
                name: "tblFieldAccessLevel",
                columns: table => new
                {
                    QueryTypeId = table.Column<int>(type: "int", nullable: false),
                    AccessLevelId = table.Column<int>(type: "int", nullable: false),
                    FieldId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblFieldAccessLevel", x => new { x.QueryTypeId, x.AccessLevelId, x.FieldId });
                });

            migrationBuilder.CreateTable(
                name: "tblUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblUserDeceasedRole",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DeceasedId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUserDeceasedRole", x => new { x.UserId, x.DeceasedId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "tblValidationState",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DeceasedId = table.Column<int>(type: "int", nullable: false),
                    FileUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: true),
                    ValidationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblValidationState", x => new { x.DeceasedId, x.UserId });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblAccessMatrix");

            migrationBuilder.DropTable(
                name: "tblDeceased");

            migrationBuilder.DropTable(
                name: "tblDeceasedDocuments");

            migrationBuilder.DropTable(
                name: "tblFieldAccessLevel");

            migrationBuilder.DropTable(
                name: "tblUser");

            migrationBuilder.DropTable(
                name: "tblUserDeceasedRole");

            migrationBuilder.DropTable(
                name: "tblValidationState");
        }
    }
}
