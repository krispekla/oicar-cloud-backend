using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Oicar.Dal.Migrations
{
    public partial class init : Migration
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

            migrationBuilder.CreateTable(
                name: "UserClouds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: false),
                    UserInput = table.Column<string>(type: "json", nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    CloudDbSQLId = table.Column<int>(nullable: true),
                    CloudFunctionId = table.Column<int>(nullable: true),
                    CloudStorageId = table.Column<int>(nullable: true),
                    CloudVMId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClouds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClouds_CloudSQL_CloudDbSQLId",
                        column: x => x.CloudDbSQLId,
                        principalTable: "CloudSQL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserClouds_CloudFunction_CloudFunctionId",
                        column: x => x.CloudFunctionId,
                        principalTable: "CloudFunction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserClouds_CloudStorage_CloudStorageId",
                        column: x => x.CloudStorageId,
                        principalTable: "CloudStorage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserClouds_CloudVM_CloudVMId",
                        column: x => x.CloudVMId,
                        principalTable: "CloudVM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserClouds_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "CloudFunction",
                columns: new[] { "Id", "CloudProvider", "Created", "ExecutinPerRequestInMiliseconds", "ExecutionsPerMonth", "MemorySizeInMB", "Modified", "Price" },
                values: new object[,]
                {
                    { 4, 0, new DateTime(2020, 5, 28, 23, 16, 55, 287, DateTimeKind.Local).AddTicks(7910), 50000, 50000.0, 10, new DateTime(2020, 5, 28, 23, 16, 55, 287, DateTimeKind.Local).AddTicks(7910), 18.0 },
                    { 12, 2, new DateTime(2020, 5, 28, 23, 16, 55, 287, DateTimeKind.Local).AddTicks(7960), 20000, 1000000.0, 1000, new DateTime(2020, 5, 28, 23, 16, 55, 287, DateTimeKind.Local).AddTicks(7960), 39.0 },
                    { 11, 1, new DateTime(2020, 5, 28, 23, 16, 55, 287, DateTimeKind.Local).AddTicks(7950), 20000, 1000000.0, 1000, new DateTime(2020, 5, 28, 23, 16, 55, 287, DateTimeKind.Local).AddTicks(7950), 41.0 },
                    { 10, 0, new DateTime(2020, 5, 28, 23, 16, 55, 287, DateTimeKind.Local).AddTicks(7950), 20000, 1000000.0, 1000, new DateTime(2020, 5, 28, 23, 16, 55, 287, DateTimeKind.Local).AddTicks(7950), 44.0 },
                    { 9, 2, new DateTime(2020, 5, 28, 23, 16, 55, 287, DateTimeKind.Local).AddTicks(7940), 20000, 1000000.0, 100, new DateTime(2020, 5, 28, 23, 16, 55, 287, DateTimeKind.Local).AddTicks(7940), 39.0 },
                    { 8, 1, new DateTime(2020, 5, 28, 23, 16, 55, 287, DateTimeKind.Local).AddTicks(7930), 20000, 1000000.0, 100, new DateTime(2020, 5, 28, 23, 16, 55, 287, DateTimeKind.Local).AddTicks(7940), 41.0 },
                    { 7, 0, new DateTime(2020, 5, 28, 23, 16, 55, 287, DateTimeKind.Local).AddTicks(7930), 20000, 1000000.0, 100, new DateTime(2020, 5, 28, 23, 16, 55, 287, DateTimeKind.Local).AddTicks(7930), 44.0 },
                    { 6, 2, new DateTime(2020, 5, 28, 23, 16, 55, 287, DateTimeKind.Local).AddTicks(7920), 50000, 50000.0, 10, new DateTime(2020, 5, 28, 23, 16, 55, 287, DateTimeKind.Local).AddTicks(7920), 22.0 },
                    { 5, 1, new DateTime(2020, 5, 28, 23, 16, 55, 287, DateTimeKind.Local).AddTicks(7910), 50000, 50000.0, 10, new DateTime(2020, 5, 28, 23, 16, 55, 287, DateTimeKind.Local).AddTicks(7920), 20.0 },
                    { 3, 2, new DateTime(2020, 5, 28, 23, 16, 55, 287, DateTimeKind.Local).AddTicks(7900), 10000, 100000.0, 1, new DateTime(2020, 5, 28, 23, 16, 55, 287, DateTimeKind.Local).AddTicks(7900), 9.0 },
                    { 2, 1, new DateTime(2020, 5, 28, 23, 16, 55, 287, DateTimeKind.Local).AddTicks(7840), 10000, 10000.0, 1, new DateTime(2020, 5, 28, 23, 16, 55, 287, DateTimeKind.Local).AddTicks(7850), 12.0 },
                    { 1, 0, new DateTime(2020, 5, 28, 23, 16, 55, 287, DateTimeKind.Local).AddTicks(5650), 10000, 10000.0, 1, new DateTime(2020, 5, 28, 23, 16, 55, 287, DateTimeKind.Local).AddTicks(5660), 10.0 }
                });

            migrationBuilder.InsertData(
                table: "CloudSQL",
                columns: new[] { "Id", "AverageDaysPerWeek", "AverageHoursPerDay", "BaskupSize", "CloudProvider", "CpuCores", "Created", "Instance", "Modified", "Price", "Ram", "SQLServerType" },
                values: new object[,]
                {
                    { 23, 7, 24, 64, 2, 8, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(630), 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(640), 56.0, 32, 0 },
                    { 24, 7, 24, 64, 1, 8, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(640), 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(640), 57.0, 32, 0 },
                    { 1, 7, 24, 1, 0, 1, new DateTime(2020, 5, 28, 23, 16, 55, 289, DateTimeKind.Local).AddTicks(6570), 1, new DateTime(2020, 5, 28, 23, 16, 55, 289, DateTimeKind.Local).AddTicks(6580), 45.0, 1, 1 },
                    { 26, 7, 24, 64, 2, 16, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(650), 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(660), 56.0, 32, 0 },
                    { 22, 7, 24, 64, 0, 8, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(630), 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(630), 59.0, 32, 0 },
                    { 25, 7, 24, 64, 0, 16, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(650), 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(650), 59.0, 32, 0 },
                    { 21, 7, 24, 1, 1, 4, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(620), 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(620), 52.0, 16, 0 },
                    { 27, 7, 24, 64, 1, 16, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(660), 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(660), 84.0, 32, 0 },
                    { 19, 7, 24, 1, 0, 4, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(610), 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(610), 48.0, 16, 0 },
                    { 2, 7, 24, 1, 2, 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(400), 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(410), 48.0, 1, 1 },
                    { 3, 7, 24, 1, 1, 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(500), 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(510), 41.0, 1, 1 },
                    { 20, 7, 24, 1, 2, 4, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(610), 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(620), 47.0, 16, 0 },
                    { 5, 7, 24, 1, 2, 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(520), 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(520), 37.0, 1, 2 },
                    { 6, 7, 24, 1, 1, 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(520), 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(530), 36.0, 1, 2 },
                    { 7, 7, 24, 1, 0, 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(530), 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(530), 27.0, 1, 0 },
                    { 8, 7, 24, 1, 2, 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(540), 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(540), 30.0, 1, 0 },
                    { 9, 7, 24, 1, 1, 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(540), 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(550), 31.0, 1, 0 },
                    { 10, 7, 24, 1, 0, 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(550), 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(550), 21.0, 1, 3 },
                    { 4, 7, 24, 1, 0, 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(510), 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(510), 24.0, 1, 2 },
                    { 12, 7, 24, 1, 1, 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(560), 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(560), 18.0, 1, 3 },
                    { 13, 7, 24, 1, 0, 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(570), 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(570), 30.0, 4, 0 },
                    { 14, 7, 24, 1, 2, 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(580), 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(580), 27.0, 4, 0 },
                    { 15, 7, 24, 1, 1, 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(580), 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(580), 28.0, 4, 0 },
                    { 16, 7, 24, 1, 0, 2, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(590), 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(590), 38.0, 8, 0 },
                    { 17, 7, 24, 1, 2, 2, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(590), 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(600), 39.0, 8, 0 },
                    { 18, 7, 24, 1, 1, 2, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(600), 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(600), 40.0, 8, 0 },
                    { 11, 7, 24, 1, 2, 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(560), 1, new DateTime(2020, 5, 28, 23, 16, 55, 290, DateTimeKind.Local).AddTicks(560), 20.0, 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "CloudStorage",
                columns: new[] { "Id", "CloudProvider", "Created", "Modified", "Price", "ReadOperationsPerMonth", "TotalAmount", "WriteOperationsPerMonth" },
                values: new object[,]
                {
                    { 18, 1, new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7120), new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7120), 183.0, 4000000.0, 2028.0, 4000000.0 },
                    { 19, 0, new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7120), new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7130), 180.0, 4000000.0, 2028.0, 4000000.0 },
                    { 20, 2, new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7130), new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7130), 167.0, 10000.0, 2028.0, 10000.0 },
                    { 21, 1, new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7140), new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7140), 169.0, 10000.0, 2028.0, 10000.0 },
                    { 22, 0, new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7140), new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7140), 160.0, 10000.0, 2028.0, 10000.0 },
                    { 23, 2, new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7150), new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7150), 183.0, 10000.0, 2028.0, 10000.0 },
                    { 27, 1, new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7170), new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7180), 78.0, 500000.0, 128.0, 500000.0 },
                    { 25, 0, new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7160), new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7160), 78.0, 50000.0, 128.0, 50000.0 },
                    { 26, 2, new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7170), new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7170), 65.0, 50000.0, 128.0, 50000.0 },
                    { 28, 0, new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7180), new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7180), 66.0, 500000.0, 128.0, 500000.0 },
                    { 29, 2, new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7180), new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7190), 46.0, 125000.0, 64.0, 125000.0 },
                    { 30, 1, new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7190), new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7190), 55.0, 125000.0, 64.0, 125000.0 },
                    { 17, 2, new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7110), new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7110), 113.0, 4000000.0, 512.0, 4000000.0 },
                    { 24, 1, new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7150), new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7160), 68.0, 50000.0, 128.0, 50000.0 },
                    { 16, 0, new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7100), new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7110), 99.0, 4000000.0, 512.0, 4000000.0 },
                    { 15, 1, new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7100), new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7100), 86.0, 4000000.0, 254.0, 4000000.0 },
                    { 14, 2, new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7090), new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7090), 79.0, 250000.0, 254.0, 250000.0 },
                    { 1, 0, new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(4750), new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(4760), 100.0, 1000000.0, 512.0, 1000000.0 },
                    { 2, 2, new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(6950), new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(6960), 54.0, 1000000.0, 16.0, 1000000.0 },
                    { 3, 1, new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7020), new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7020), 60.0, 1000000.0, 32.0, 1000000.0 },
                    { 5, 2, new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7040), new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7040), 88.0, 500000.0, 128.0, 500000.0 },
                    { 6, 1, new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7040), new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7040), 98.0, 500000.0, 254.0, 500000.0 },
                    { 7, 0, new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7050), new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7050), 112.0, 2000000.0, 512.0, 2000000.0 },
                    { 4, 0, new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7030), new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7030), 68.0, 500000.0, 64.0, 500000.0 },
                    { 9, 1, new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7060), new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7060), 135.0, 2000000.0, 1024.0, 2000000.0 },
                    { 10, 0, new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7070), new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7070), 156.0, 2000000.0, 1024.0, 2000000.0 },
                    { 11, 2, new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7070), new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7080), 159.0, 250000.0, 1024.0, 250000.0 },
                    { 12, 1, new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7080), new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7080), 76.0, 250000.0, 254.0, 250000.0 },
                    { 13, 0, new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7080), new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7090), 73.0, 250000.0, 254.0, 250000.0 },
                    { 8, 2, new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7050), new DateTime(2020, 5, 28, 23, 16, 55, 283, DateTimeKind.Local).AddTicks(7060), 122.0, 2000000.0, 1024.0, 2000000.0 }
                });

            migrationBuilder.InsertData(
                table: "CloudVM",
                columns: new[] { "Id", "AverageDaysPerWeek", "AverageHoursPerDay", "CloudProvider", "Core", "Created", "InstanceNb", "Modified", "OperatingSystem", "Price", "Ram", "Storage", "StorageType" },
                values: new object[,]
                {
                    { 27, 6, 16, 2, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7470), 1, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7470), 0, 1656.0, 16, 256.0, 1 },
                    { 21, 6, 16, 1, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7430), 1, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7430), 1, 950.0, 8, 256.0, 1 },
                    { 22, 6, 16, 1, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7440), 1, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7440), 1, 909.0, 8, 256.0, 0 },
                    { 23, 6, 16, 1, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7450), 1, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7450), 0, 869.0, 8, 256.0, 1 },
                    { 24, 6, 16, 1, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7450), 1, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7450), 0, 809.0, 8, 256.0, 0 },
                    { 25, 6, 16, 2, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7460), 1, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7460), 1, 1499.0, 16, 256.0, 1 },
                    { 26, 6, 16, 2, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7460), 1, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7470), 1, 1359.0, 16, 256.0, 0 },
                    { 28, 6, 16, 2, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7480), 1, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7480), 0, 1379.0, 16, 256.0, 0 },
                    { 35, 6, 16, 2, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7520), 1, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7530), 0, 919.0, 8, 256.0, 1 },
                    { 30, 6, 16, 2, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7490), 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7490), 1, 3911.0, 16, 256.0, 0 },
                    { 31, 6, 16, 2, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7500), 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7500), 0, 3619.0, 16, 256.0, 1 },
                    { 32, 6, 16, 2, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7500), 1, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7510), 0, 3659.0, 16, 256.0, 0 },
                    { 33, 6, 16, 2, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7510), 1, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7510), 1, 944.0, 8, 256.0, 1 },
                    { 34, 6, 16, 2, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7520), 1, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7520), 1, 911.0, 8, 256.0, 0 },
                    { 20, 6, 16, 1, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7430), 1, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7430), 0, 3759.0, 16, 256.0, 0 },
                    { 36, 6, 16, 2, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7530), 1, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7530), 0, 821.0, 8, 256.0, 0 },
                    { 29, 6, 16, 2, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7480), 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7490), 1, 3790.0, 16, 256.0, 1 },
                    { 19, 6, 16, 1, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7420), 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7420), 0, 3609.0, 16, 256.0, 1 },
                    { 12, 6, 16, 0, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7370), 1, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7380), 0, 800.0, 8, 256.0, 0 },
                    { 17, 6, 16, 1, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7410), 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7410), 1, 3800.0, 16, 256.0, 1 },
                    { 1, 6, 16, 0, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(3110), 1, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(3120), 1, 1500.0, 16, 256.0, 1 },
                    { 2, 6, 16, 0, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7200), 1, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7220), 1, 1250.0, 16, 256.0, 0 },
                    { 3, 6, 16, 0, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7310), 1, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7320), 0, 1650.0, 16, 256.0, 1 },
                    { 4, 6, 16, 0, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7320), 1, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7320), 0, 1400.0, 16, 256.0, 0 },
                    { 5, 6, 16, 0, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7330), 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7330), 1, 4000.0, 16, 256.0, 1 },
                    { 6, 6, 16, 0, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7330), 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7340), 1, 3800.0, 16, 256.0, 0 },
                    { 7, 6, 16, 0, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7340), 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7340), 0, 3600.0, 16, 256.0, 1 },
                    { 18, 6, 16, 1, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7410), 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7420), 1, 3901.0, 16, 256.0, 0 },
                    { 8, 6, 16, 0, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7350), 1, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7350), 0, 3750.0, 16, 256.0, 0 },
                    { 10, 6, 16, 0, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7360), 1, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7360), 1, 900.0, 8, 256.0, 0 },
                    { 11, 6, 16, 0, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7370), 1, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7370), 0, 887.0, 8, 256.0, 1 },
                    { 13, 6, 16, 1, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7380), 1, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7380), 1, 1509.0, 16, 256.0, 1 },
                    { 14, 6, 16, 1, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7390), 1, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7390), 1, 1350.0, 16, 256.0, 0 },
                    { 15, 6, 16, 1, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7390), 1, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7400), 0, 1652.0, 16, 256.0, 1 },
                    { 16, 6, 16, 1, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7400), 1, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7400), 0, 1389.0, 16, 256.0, 0 },
                    { 9, 6, 16, 0, 4, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7350), 1, new DateTime(2020, 5, 28, 23, 16, 55, 286, DateTimeKind.Local).AddTicks(7360), 1, 850.0, 8, 256.0, 1 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "Modified", "Password" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 28, 23, 16, 55, 271, DateTimeKind.Local).AddTicks(290), "admin@test.com", "Admin", "Ad", new DateTime(2020, 5, 28, 23, 16, 55, 280, DateTimeKind.Local).AddTicks(4340), "10000.7mSNp+Oapzv2iVbiybMmSA==.TjfFGVah1ko7+nrYvgKIBwpJGGgVzRz2BcG24jUBMiE=" },
                    { 2, new DateTime(2020, 5, 28, 23, 16, 55, 280, DateTimeKind.Local).AddTicks(7270), "test@test.com", "Test", "Testic", new DateTime(2020, 5, 28, 23, 16, 55, 280, DateTimeKind.Local).AddTicks(7290), "10000.7mSNp+Oapzv2iVbiybMmSA==.TjfFGVah1ko7+nrYvgKIBwpJGGgVzRz2BcG24jUBMiE=" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserClouds_CloudDbSQLId",
                table: "UserClouds",
                column: "CloudDbSQLId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClouds_CloudFunctionId",
                table: "UserClouds",
                column: "CloudFunctionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClouds_CloudStorageId",
                table: "UserClouds",
                column: "CloudStorageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClouds_CloudVMId",
                table: "UserClouds",
                column: "CloudVMId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClouds_UserId",
                table: "UserClouds",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserClouds");

            migrationBuilder.DropTable(
                name: "CloudSQL");

            migrationBuilder.DropTable(
                name: "CloudFunction");

            migrationBuilder.DropTable(
                name: "CloudStorage");

            migrationBuilder.DropTable(
                name: "CloudVM");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
