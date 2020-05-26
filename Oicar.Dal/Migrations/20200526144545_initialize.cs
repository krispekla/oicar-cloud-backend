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
                    CloudProvider = table.Column<int>(nullable: false),
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
                    CloudProvider = table.Column<int>(nullable: false),
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
                    TotalAmount = table.Column<double>(nullable: false),
                    ReadOperationsPerMonth = table.Column<double>(nullable: false),
                    WriteOperationsPerMonth = table.Column<double>(nullable: false),
                    CloudProvider = table.Column<int>(nullable: false),
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
                    AverageHoursPerDay = table.Column<int>(nullable: false),
                    AverageDaysPerWeek = table.Column<int>(nullable: false),
                    CloudProvider = table.Column<int>(nullable: false),
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
                table: "CloudFunction",
                columns: new[] { "Id", "CloudProvider", "Created", "ExecutinPerRequestInMiliseconds", "ExecutionsPerMonth", "MemorySizeInMB", "Modified", "Price" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2020, 5, 26, 16, 45, 44, 810, DateTimeKind.Local).AddTicks(8200), 10000, 10000.0, 10000, new DateTime(2020, 5, 26, 16, 45, 44, 810, DateTimeKind.Local).AddTicks(8220), 12.0 },
                    { 9, 2, new DateTime(2020, 5, 26, 16, 45, 44, 810, DateTimeKind.Local).AddTicks(8300), 20000, 1000000.0, 250000, new DateTime(2020, 5, 26, 16, 45, 44, 810, DateTimeKind.Local).AddTicks(8300), 39.0 },
                    { 8, 1, new DateTime(2020, 5, 26, 16, 45, 44, 810, DateTimeKind.Local).AddTicks(8290), 20000, 1000000.0, 250000, new DateTime(2020, 5, 26, 16, 45, 44, 810, DateTimeKind.Local).AddTicks(8300), 41.0 },
                    { 7, 0, new DateTime(2020, 5, 26, 16, 45, 44, 810, DateTimeKind.Local).AddTicks(8290), 20000, 1000000.0, 250000, new DateTime(2020, 5, 26, 16, 45, 44, 810, DateTimeKind.Local).AddTicks(8290), 44.0 },
                    { 6, 2, new DateTime(2020, 5, 26, 16, 45, 44, 810, DateTimeKind.Local).AddTicks(8280), 50000, 50000.0, 50000, new DateTime(2020, 5, 26, 16, 45, 44, 810, DateTimeKind.Local).AddTicks(8290), 22.0 },
                    { 5, 1, new DateTime(2020, 5, 26, 16, 45, 44, 810, DateTimeKind.Local).AddTicks(8280), 50000, 50000.0, 50000, new DateTime(2020, 5, 26, 16, 45, 44, 810, DateTimeKind.Local).AddTicks(8280), 20.0 },
                    { 4, 0, new DateTime(2020, 5, 26, 16, 45, 44, 810, DateTimeKind.Local).AddTicks(8270), 50000, 50000.0, 50000, new DateTime(2020, 5, 26, 16, 45, 44, 810, DateTimeKind.Local).AddTicks(8270), 18.0 },
                    { 3, 2, new DateTime(2020, 5, 26, 16, 45, 44, 810, DateTimeKind.Local).AddTicks(8260), 10000, 100000.0, 10000, new DateTime(2020, 5, 26, 16, 45, 44, 810, DateTimeKind.Local).AddTicks(8270), 9.0 },
                    { 1, 0, new DateTime(2020, 5, 26, 16, 45, 44, 810, DateTimeKind.Local).AddTicks(6020), 10000, 10000.0, 10000, new DateTime(2020, 5, 26, 16, 45, 44, 810, DateTimeKind.Local).AddTicks(6040), 10.0 }
                });

            migrationBuilder.InsertData(
                table: "CloudSQL",
                columns: new[] { "Id", "AverageDaysPerWeek", "AverageHoursPerDay", "BaskupSize", "CloudProvider", "CpuCores", "Created", "Instance", "Modified", "Price", "Ram", "SQLServerType" },
                values: new object[,]
                {
                    { 21, 7, 24, 1, 1, 4, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(870), 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(880), 52.0, 16, 0 },
                    { 22, 7, 24, 64, 0, 8, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(880), 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(880), 59.0, 32, 0 },
                    { 23, 7, 24, 64, 2, 8, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(910), 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(910), 56.0, 32, 0 },
                    { 1, 7, 24, 1, 0, 1, new DateTime(2020, 5, 26, 16, 45, 44, 812, DateTimeKind.Local).AddTicks(6830), 1, new DateTime(2020, 5, 26, 16, 45, 44, 812, DateTimeKind.Local).AddTicks(6840), 45.0, 1, 1 },
                    { 26, 7, 24, 64, 2, 16, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(920), 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(930), 56.0, 32, 0 },
                    { 27, 7, 24, 64, 1, 16, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(930), 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(930), 84.0, 32, 0 },
                    { 20, 7, 24, 1, 2, 4, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(870), 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(870), 47.0, 16, 0 },
                    { 24, 7, 24, 64, 1, 8, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(910), 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(910), 57.0, 32, 0 },
                    { 19, 7, 24, 1, 0, 4, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(860), 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(860), 48.0, 16, 0 },
                    { 25, 7, 24, 64, 0, 16, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(920), 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(920), 59.0, 32, 0 },
                    { 17, 7, 24, 1, 2, 2, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(850), 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(850), 39.0, 8, 0 },
                    { 2, 7, 24, 1, 2, 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(640), 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(660), 48.0, 1, 1 },
                    { 18, 7, 24, 1, 1, 2, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(850), 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(860), 40.0, 8, 0 },
                    { 4, 7, 24, 1, 0, 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(760), 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(770), 24.0, 1, 2 },
                    { 5, 7, 24, 1, 2, 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(770), 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(770), 37.0, 1, 2 },
                    { 6, 7, 24, 1, 1, 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(780), 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(780), 36.0, 1, 2 },
                    { 7, 7, 24, 1, 0, 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(780), 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(790), 27.0, 1, 0 },
                    { 8, 7, 24, 1, 2, 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(790), 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(790), 30.0, 1, 0 },
                    { 9, 7, 24, 1, 1, 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(800), 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(800), 31.0, 1, 0 },
                    { 3, 7, 24, 1, 1, 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(760), 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(760), 41.0, 1, 1 },
                    { 11, 7, 24, 1, 2, 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(810), 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(810), 20.0, 1, 3 },
                    { 12, 7, 24, 1, 1, 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(820), 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(820), 18.0, 1, 3 },
                    { 13, 7, 24, 1, 0, 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(820), 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(830), 30.0, 4, 0 },
                    { 14, 7, 24, 1, 2, 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(830), 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(830), 27.0, 4, 0 },
                    { 15, 7, 24, 1, 1, 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(840), 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(840), 28.0, 4, 0 },
                    { 16, 7, 24, 1, 0, 2, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(840), 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(840), 38.0, 8, 0 },
                    { 10, 7, 24, 1, 0, 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(800), 1, new DateTime(2020, 5, 26, 16, 45, 44, 813, DateTimeKind.Local).AddTicks(810), 21.0, 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "CloudStorage",
                columns: new[] { "Id", "CloudProvider", "Created", "Modified", "Price", "ReadOperationsPerMonth", "TotalAmount", "WriteOperationsPerMonth" },
                values: new object[,]
                {
                    { 19, 0, new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7730), new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7730), 180.0, 4000000.0, 2028.0, 4000000.0 },
                    { 20, 2, new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7730), new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7740), 167.0, 10000.0, 2028.0, 10000.0 },
                    { 21, 1, new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7740), new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7740), 169.0, 10000.0, 2028.0, 10000.0 },
                    { 22, 0, new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7750), new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7750), 160.0, 10000.0, 2028.0, 10000.0 },
                    { 23, 2, new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7750), new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7760), 183.0, 10000.0, 2028.0, 10000.0 },
                    { 24, 1, new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7760), new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7760), 68.0, 50000.0, 128.0, 50000.0 },
                    { 27, 1, new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7780), new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7780), 78.0, 500000.0, 128.0, 500000.0 },
                    { 26, 2, new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7770), new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7770), 65.0, 50000.0, 128.0, 50000.0 },
                    { 28, 0, new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7780), new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7790), 66.0, 500000.0, 128.0, 500000.0 },
                    { 29, 2, new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7790), new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7790), 46.0, 125000.0, 64.0, 125000.0 },
                    { 30, 1, new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7800), new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7800), 55.0, 125000.0, 64.0, 125000.0 },
                    { 18, 1, new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7720), new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7730), 183.0, 4000000.0, 2028.0, 4000000.0 },
                    { 25, 0, new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7770), new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7770), 78.0, 50000.0, 128.0, 50000.0 },
                    { 17, 2, new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7720), new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7720), 113.0, 4000000.0, 512.0, 4000000.0 },
                    { 16, 0, new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7710), new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7710), 99.0, 4000000.0, 512.0, 4000000.0 },
                    { 5, 2, new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7640), new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7650), 88.0, 500000.0, 128.0, 500000.0 },
                    { 1, 0, new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(5330), new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(5350), 100.0, 1000000.0, 512.0, 1000000.0 },
                    { 2, 2, new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7560), new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7580), 54.0, 1000000.0, 16.0, 1000000.0 },
                    { 3, 1, new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7630), new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7630), 60.0, 1000000.0, 32.0, 1000000.0 },
                    { 4, 0, new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7640), new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7640), 68.0, 500000.0, 64.0, 500000.0 },
                    { 6, 1, new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7650), new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7650), 98.0, 500000.0, 254.0, 500000.0 },
                    { 15, 1, new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7710), new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7710), 86.0, 4000000.0, 254.0, 4000000.0 },
                    { 7, 0, new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7660), new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7660), 112.0, 2000000.0, 512.0, 2000000.0 },
                    { 9, 1, new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7670), new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7670), 135.0, 2000000.0, 1024.0, 2000000.0 },
                    { 10, 0, new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7670), new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7680), 156.0, 2000000.0, 1024.0, 2000000.0 },
                    { 11, 2, new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7680), new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7680), 159.0, 250000.0, 1024.0, 250000.0 },
                    { 12, 1, new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7690), new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7690), 76.0, 250000.0, 254.0, 250000.0 },
                    { 13, 0, new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7690), new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7700), 73.0, 250000.0, 254.0, 250000.0 },
                    { 14, 2, new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7700), new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7700), 79.0, 250000.0, 254.0, 250000.0 },
                    { 8, 2, new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7660), new DateTime(2020, 5, 26, 16, 45, 44, 806, DateTimeKind.Local).AddTicks(7670), 122.0, 2000000.0, 1024.0, 2000000.0 }
                });

            migrationBuilder.InsertData(
                table: "CloudVM",
                columns: new[] { "Id", "AverageDaysPerWeek", "AverageHoursPerDay", "CloudProvider", "Core", "Created", "InstanceNb", "Modified", "OperatingSystem", "Price", "Ram", "Storage", "StorageType" },
                values: new object[,]
                {
                    { 24, 6, 16, 1, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9240), 1, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9250), 0, 809.0, 8, 256.0, 0 },
                    { 23, 6, 16, 1, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9240), 1, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9240), 0, 869.0, 8, 256.0, 1 },
                    { 12, 6, 16, 0, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9150), 1, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9150), 0, 800.0, 8, 256.0, 0 },
                    { 21, 6, 16, 1, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9230), 1, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9230), 1, 950.0, 8, 256.0, 1 },
                    { 25, 6, 16, 2, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9250), 1, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9250), 1, 1499.0, 16, 256.0, 1 },
                    { 22, 6, 16, 1, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9230), 1, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9230), 1, 909.0, 8, 256.0, 0 },
                    { 26, 6, 16, 2, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9260), 1, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9260), 1, 1359.0, 16, 256.0, 0 },
                    { 34, 6, 16, 2, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9310), 1, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9320), 1, 911.0, 8, 256.0, 0 },
                    { 28, 6, 16, 2, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9270), 1, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9270), 0, 1379.0, 16, 256.0, 0 },
                    { 29, 6, 16, 2, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9280), 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9280), 1, 3790.0, 16, 256.0, 1 },
                    { 30, 6, 16, 2, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9280), 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9290), 1, 3911.0, 16, 256.0, 0 },
                    { 31, 6, 16, 2, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9290), 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9290), 0, 3619.0, 16, 256.0, 1 },
                    { 32, 6, 16, 2, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9300), 1, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9300), 0, 3659.0, 16, 256.0, 0 },
                    { 33, 6, 16, 2, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9310), 1, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9310), 1, 944.0, 8, 256.0, 1 },
                    { 20, 6, 16, 1, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9220), 1, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9220), 0, 3759.0, 16, 256.0, 0 },
                    { 27, 6, 16, 2, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9270), 1, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9270), 0, 1656.0, 16, 256.0, 1 },
                    { 19, 6, 16, 1, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9210), 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9210), 0, 3609.0, 16, 256.0, 1 },
                    { 11, 6, 16, 0, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9140), 1, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9140), 0, 887.0, 8, 256.0, 1 },
                    { 17, 6, 16, 1, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9200), 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9200), 1, 3800.0, 16, 256.0, 1 },
                    { 1, 6, 16, 0, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(4790), 1, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(4810), 1, 1500.0, 16, 256.0, 1 },
                    { 2, 6, 16, 0, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(8970), 1, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(8990), 1, 1250.0, 16, 256.0, 0 },
                    { 3, 6, 16, 0, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9090), 1, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9090), 0, 1650.0, 16, 256.0, 1 },
                    { 4, 6, 16, 0, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9100), 1, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9100), 0, 1400.0, 16, 256.0, 0 },
                    { 5, 6, 16, 0, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9100), 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9110), 1, 4000.0, 16, 256.0, 1 },
                    { 6, 6, 16, 0, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9110), 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9110), 1, 3800.0, 16, 256.0, 0 },
                    { 7, 6, 16, 0, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9120), 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9120), 0, 3600.0, 16, 256.0, 1 },
                    { 8, 6, 16, 0, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9120), 1, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9130), 0, 3750.0, 16, 256.0, 0 },
                    { 9, 6, 16, 0, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9130), 1, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9130), 1, 850.0, 8, 256.0, 1 },
                    { 10, 6, 16, 0, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9140), 1, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9140), 1, 900.0, 8, 256.0, 0 },
                    { 35, 6, 16, 2, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9320), 1, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9320), 0, 919.0, 8, 256.0, 1 },
                    { 13, 6, 16, 1, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9160), 1, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9160), 1, 1509.0, 16, 256.0, 1 },
                    { 14, 6, 16, 1, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9160), 1, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9170), 1, 1350.0, 16, 256.0, 0 },
                    { 15, 6, 16, 1, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9170), 1, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9170), 0, 1652.0, 16, 256.0, 1 },
                    { 16, 6, 16, 1, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9180), 1, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9180), 0, 1389.0, 16, 256.0, 0 },
                    { 18, 6, 16, 1, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9210), 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9210), 1, 3901.0, 16, 256.0, 0 },
                    { 36, 6, 16, 2, 4, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9330), 1, new DateTime(2020, 5, 26, 16, 45, 44, 809, DateTimeKind.Local).AddTicks(9330), 0, 821.0, 8, 256.0, 0 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "Modified", "Password" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 26, 16, 45, 44, 796, DateTimeKind.Local).AddTicks(6870), "admin@test.com", "Admin", "Ad", new DateTime(2020, 5, 26, 16, 45, 44, 803, DateTimeKind.Local).AddTicks(5360), "Admin!123" },
                    { 2, new DateTime(2020, 5, 26, 16, 45, 44, 803, DateTimeKind.Local).AddTicks(8160), "test@test.com", "Test", "Testic", new DateTime(2020, 5, 26, 16, 45, 44, 803, DateTimeKind.Local).AddTicks(8190), "Test!123" }
                });
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
