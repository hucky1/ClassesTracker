using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrackerModel.Migrations
{
    public partial class TasksTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClassesTest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstAnswer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondAnswer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThirdAnswer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RightAnswer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassesTest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InheritanceTest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstAnswer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondAnswer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThirdAnswer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RightAnswer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InheritanceTest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MethodsTest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstAnswer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondAnswer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThirdAnswer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RightAnswer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MethodsTest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PassedTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Group = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mark = table.Column<int>(type: "int", nullable: false),
                    Test = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassedTests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassesTest");

            migrationBuilder.DropTable(
                name: "InheritanceTest");

            migrationBuilder.DropTable(
                name: "MethodsTest");

            migrationBuilder.DropTable(
                name: "PassedTests");

            migrationBuilder.DropTable(
                name: "Tasks");
        }
    }
}
