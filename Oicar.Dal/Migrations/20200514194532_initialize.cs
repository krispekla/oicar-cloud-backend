using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Oicar.Dal.Migrations
{
    public partial class initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CloudFunction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: false),
                    ExecutinPerRequestInMiliseconds = table.Column<int>(nullable: false),
                    MemorySizeInMB = table.Column<int>(nullable: false),
                    ExecutionsPerMonth = table.Column<double>(nullable: false),
                    Location = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CloudFunction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CloudSQL",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: false),
                    Instance = table.Column<int>(nullable: false),
                    Ram = table.Column<int>(nullable: false),
                    CpuCores = table.Column<int>(nullable: false),
                    BaskupSize = table.Column<int>(nullable: false),
                    AverageHoursPerDay = table.Column<int>(nullable: false),
                    AverageDaysPerWeek = table.Column<int>(nullable: false),
                    SQLServerType = table.Column<int>(nullable: false),
                    Location = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CloudSQL", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CloudStorage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: false),
                    Location = table.Column<int>(nullable: false),
                    TotalAmount = table.Column<double>(nullable: false),
                    ReadOperationsPerMonth = table.Column<double>(nullable: false),
                    WriteOperationsPerMonth = table.Column<double>(nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CloudStorage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CloudVM",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: false),
                    InstanceNb = table.Column<int>(nullable: false),
                    OperatingSystem = table.Column<int>(nullable: false),
                    Core = table.Column<int>(nullable: false),
                    Ram = table.Column<int>(nullable: false),
                    Storage = table.Column<double>(nullable: false),
                    StorageType = table.Column<int>(nullable: false),
                    Location = table.Column<int>(nullable: false),
                    AverageHoursPerDay = table.Column<int>(nullable: false),
                    AverageDaysPerWeek = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CloudVM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "Modified", "Password" },
                values: new object[] { 1, new DateTime(2020, 5, 14, 21, 45, 31, 980, DateTimeKind.Local).AddTicks(2097), null, "Trolo", "Trolic", new DateTime(2020, 5, 14, 21, 45, 31, 981, DateTimeKind.Local).AddTicks(9129), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CloudFunction");

            migrationBuilder.DropTable(
                name: "CloudSQL");

            migrationBuilder.DropTable(
                name: "CloudStorage");

            migrationBuilder.DropTable(
                name: "CloudVM");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
