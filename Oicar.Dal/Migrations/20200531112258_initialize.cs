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
                        .Annotation("Npgsql:IdentitySequenceOptions", "'13', '1', '', '', 'False', '1'")
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
                        .Annotation("Npgsql:IdentitySequenceOptions", "'28', '1', '', '', 'False', '1'")
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
                        .Annotation("Npgsql:IdentitySequenceOptions", "'31', '1', '', '', 'False', '1'")
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
                        .Annotation("Npgsql:IdentitySequenceOptions", "'37', '1', '', '', 'False', '1'")
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
                name: "NewsPost",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'4', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Subtitle = table.Column<string>(nullable: true),
                    Image = table.Column<byte[]>(nullable: true),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsPost", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'3', '1', '', '', 'False', '1'")
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
                    { 4, 0, new DateTime(2020, 5, 31, 13, 22, 57, 669, DateTimeKind.Local).AddTicks(7250), 50000, 50000.0, 10, new DateTime(2020, 5, 31, 13, 22, 57, 669, DateTimeKind.Local).AddTicks(7250), 18.0 },
                    { 12, 2, new DateTime(2020, 5, 31, 13, 22, 57, 669, DateTimeKind.Local).AddTicks(7380), 20000, 1000000.0, 1000, new DateTime(2020, 5, 31, 13, 22, 57, 669, DateTimeKind.Local).AddTicks(7380), 39.0 },
                    { 11, 1, new DateTime(2020, 5, 31, 13, 22, 57, 669, DateTimeKind.Local).AddTicks(7370), 20000, 1000000.0, 1000, new DateTime(2020, 5, 31, 13, 22, 57, 669, DateTimeKind.Local).AddTicks(7370), 41.0 },
                    { 10, 0, new DateTime(2020, 5, 31, 13, 22, 57, 669, DateTimeKind.Local).AddTicks(7350), 20000, 1000000.0, 1000, new DateTime(2020, 5, 31, 13, 22, 57, 669, DateTimeKind.Local).AddTicks(7360), 44.0 },
                    { 9, 2, new DateTime(2020, 5, 31, 13, 22, 57, 669, DateTimeKind.Local).AddTicks(7340), 20000, 1000000.0, 100, new DateTime(2020, 5, 31, 13, 22, 57, 669, DateTimeKind.Local).AddTicks(7350), 39.0 },
                    { 8, 1, new DateTime(2020, 5, 31, 13, 22, 57, 669, DateTimeKind.Local).AddTicks(7300), 20000, 1000000.0, 100, new DateTime(2020, 5, 31, 13, 22, 57, 669, DateTimeKind.Local).AddTicks(7300), 41.0 },
                    { 7, 0, new DateTime(2020, 5, 31, 13, 22, 57, 669, DateTimeKind.Local).AddTicks(7280), 20000, 1000000.0, 100, new DateTime(2020, 5, 31, 13, 22, 57, 669, DateTimeKind.Local).AddTicks(7290), 44.0 },
                    { 6, 2, new DateTime(2020, 5, 31, 13, 22, 57, 669, DateTimeKind.Local).AddTicks(7270), 50000, 50000.0, 10, new DateTime(2020, 5, 31, 13, 22, 57, 669, DateTimeKind.Local).AddTicks(7280), 22.0 },
                    { 5, 1, new DateTime(2020, 5, 31, 13, 22, 57, 669, DateTimeKind.Local).AddTicks(7260), 50000, 50000.0, 10, new DateTime(2020, 5, 31, 13, 22, 57, 669, DateTimeKind.Local).AddTicks(7270), 20.0 },
                    { 3, 2, new DateTime(2020, 5, 31, 13, 22, 57, 669, DateTimeKind.Local).AddTicks(7230), 10000, 100000.0, 1, new DateTime(2020, 5, 31, 13, 22, 57, 669, DateTimeKind.Local).AddTicks(7240), 9.0 },
                    { 2, 1, new DateTime(2020, 5, 31, 13, 22, 57, 669, DateTimeKind.Local).AddTicks(7110), 10000, 10000.0, 1, new DateTime(2020, 5, 31, 13, 22, 57, 669, DateTimeKind.Local).AddTicks(7130), 12.0 },
                    { 1, 0, new DateTime(2020, 5, 31, 13, 22, 57, 669, DateTimeKind.Local).AddTicks(2700), 10000, 10000.0, 1, new DateTime(2020, 5, 31, 13, 22, 57, 669, DateTimeKind.Local).AddTicks(2740), 10.0 }
                });

            migrationBuilder.InsertData(
                table: "CloudSQL",
                columns: new[] { "Id", "AverageDaysPerWeek", "AverageHoursPerDay", "BaskupSize", "CloudProvider", "CpuCores", "Created", "Instance", "Modified", "Price", "Ram", "SQLServerType" },
                values: new object[,]
                {
                    { 23, 7, 24, 64, 2, 8, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(540), 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(550), 56.0, 32, 0 },
                    { 24, 7, 24, 64, 1, 8, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(560), 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(560), 57.0, 32, 0 },
                    { 1, 7, 24, 1, 0, 1, new DateTime(2020, 5, 31, 13, 22, 57, 674, DateTimeKind.Local).AddTicks(2420), 1, new DateTime(2020, 5, 31, 13, 22, 57, 674, DateTimeKind.Local).AddTicks(2450), 45.0, 1, 1 },
                    { 26, 7, 24, 64, 2, 16, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(580), 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(590), 56.0, 32, 0 },
                    { 22, 7, 24, 64, 0, 8, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(530), 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(540), 59.0, 32, 0 },
                    { 25, 7, 24, 64, 0, 16, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(570), 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(580), 59.0, 32, 0 },
                    { 21, 7, 24, 1, 1, 4, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(520), 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(520), 52.0, 16, 0 },
                    { 27, 7, 24, 64, 1, 16, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(600), 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(600), 84.0, 32, 0 },
                    { 19, 7, 24, 1, 0, 4, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(490), 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(500), 48.0, 16, 0 },
                    { 2, 7, 24, 1, 2, 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(70), 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(100), 48.0, 1, 1 },
                    { 3, 7, 24, 1, 1, 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(280), 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(290), 41.0, 1, 1 },
                    { 20, 7, 24, 1, 2, 4, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(510), 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(510), 47.0, 16, 0 },
                    { 5, 7, 24, 1, 2, 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(310), 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(320), 37.0, 1, 2 },
                    { 6, 7, 24, 1, 1, 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(330), 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(330), 36.0, 1, 2 },
                    { 7, 7, 24, 1, 0, 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(340), 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(350), 27.0, 1, 0 },
                    { 8, 7, 24, 1, 2, 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(350), 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(360), 30.0, 1, 0 },
                    { 9, 7, 24, 1, 1, 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(370), 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(370), 31.0, 1, 0 },
                    { 10, 7, 24, 1, 0, 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(380), 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(380), 21.0, 1, 3 },
                    { 4, 7, 24, 1, 0, 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(300), 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(300), 24.0, 1, 2 },
                    { 12, 7, 24, 1, 1, 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(410), 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(410), 18.0, 1, 3 },
                    { 13, 7, 24, 1, 0, 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(420), 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(420), 30.0, 4, 0 },
                    { 14, 7, 24, 1, 2, 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(430), 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(440), 27.0, 4, 0 },
                    { 15, 7, 24, 1, 1, 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(440), 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(450), 28.0, 4, 0 },
                    { 16, 7, 24, 1, 0, 2, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(460), 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(460), 38.0, 8, 0 },
                    { 17, 7, 24, 1, 2, 2, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(470), 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(470), 39.0, 8, 0 },
                    { 18, 7, 24, 1, 1, 2, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(480), 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(490), 40.0, 8, 0 },
                    { 11, 7, 24, 1, 2, 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(390), 1, new DateTime(2020, 5, 31, 13, 22, 57, 675, DateTimeKind.Local).AddTicks(400), 20.0, 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "CloudStorage",
                columns: new[] { "Id", "CloudProvider", "Created", "Modified", "Price", "ReadOperationsPerMonth", "TotalAmount", "WriteOperationsPerMonth" },
                values: new object[,]
                {
                    { 19, 0, new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7540), new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7540), 180.0, 4000000.0, 2028.0, 4000000.0 },
                    { 20, 2, new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7550), new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7560), 167.0, 10000.0, 2028.0, 10000.0 },
                    { 21, 1, new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7560), new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7570), 169.0, 10000.0, 2028.0, 10000.0 },
                    { 22, 0, new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7570), new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7580), 160.0, 10000.0, 2028.0, 10000.0 },
                    { 23, 2, new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7590), new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7590), 183.0, 10000.0, 2028.0, 10000.0 },
                    { 24, 1, new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7600), new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7600), 68.0, 50000.0, 128.0, 50000.0 },
                    { 28, 0, new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7650), new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7650), 66.0, 500000.0, 128.0, 500000.0 },
                    { 26, 2, new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7620), new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7630), 65.0, 50000.0, 128.0, 50000.0 },
                    { 27, 1, new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7630), new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7640), 78.0, 500000.0, 128.0, 500000.0 },
                    { 29, 2, new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7660), new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7660), 46.0, 125000.0, 64.0, 125000.0 },
                    { 30, 1, new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7670), new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7680), 55.0, 125000.0, 64.0, 125000.0 },
                    { 18, 1, new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7530), new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7530), 183.0, 4000000.0, 2028.0, 4000000.0 },
                    { 25, 0, new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7610), new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7620), 78.0, 50000.0, 128.0, 50000.0 },
                    { 17, 2, new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7510), new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7520), 113.0, 4000000.0, 512.0, 4000000.0 },
                    { 16, 0, new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7500), new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7510), 99.0, 4000000.0, 512.0, 4000000.0 },
                    { 4, 0, new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7360), new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7360), 68.0, 500000.0, 64.0, 500000.0 },
                    { 1, 0, new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(2720), new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(2780), 100.0, 1000000.0, 512.0, 1000000.0 },
                    { 2, 2, new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7200), new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7230), 54.0, 1000000.0, 16.0, 1000000.0 },
                    { 3, 1, new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7340), new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7350), 60.0, 1000000.0, 32.0, 1000000.0 },
                    { 5, 2, new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7370), new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7370), 88.0, 500000.0, 128.0, 500000.0 },
                    { 6, 1, new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7380), new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7390), 98.0, 500000.0, 254.0, 500000.0 },
                    { 8, 2, new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7410), new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7410), 122.0, 2000000.0, 1024.0, 2000000.0 },
                    { 7, 0, new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7390), new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7400), 112.0, 2000000.0, 512.0, 2000000.0 },
                    { 10, 0, new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7430), new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7430), 156.0, 2000000.0, 1024.0, 2000000.0 },
                    { 11, 2, new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7440), new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7450), 159.0, 250000.0, 1024.0, 250000.0 },
                    { 12, 1, new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7450), new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7460), 76.0, 250000.0, 254.0, 250000.0 },
                    { 13, 0, new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7470), new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7470), 73.0, 250000.0, 254.0, 250000.0 },
                    { 14, 2, new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7480), new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7480), 79.0, 250000.0, 254.0, 250000.0 },
                    { 9, 1, new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7420), new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7420), 135.0, 2000000.0, 1024.0, 2000000.0 },
                    { 15, 1, new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7490), new DateTime(2020, 5, 31, 13, 22, 57, 659, DateTimeKind.Local).AddTicks(7500), 86.0, 4000000.0, 254.0, 4000000.0 }
                });

            migrationBuilder.InsertData(
                table: "CloudVM",
                columns: new[] { "Id", "AverageDaysPerWeek", "AverageHoursPerDay", "CloudProvider", "Core", "Created", "InstanceNb", "Modified", "OperatingSystem", "Price", "Ram", "Storage", "StorageType" },
                values: new object[,]
                {
                    { 25, 6, 16, 2, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5580), 1, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5590), 1, 1499.0, 16, 256.0, 1 },
                    { 26, 6, 16, 2, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5590), 1, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5600), 1, 1359.0, 16, 256.0, 0 },
                    { 13, 6, 16, 1, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5430), 1, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5430), 1, 1509.0, 16, 256.0, 1 },
                    { 23, 6, 16, 1, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5560), 1, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5560), 0, 869.0, 8, 256.0, 1 },
                    { 22, 6, 16, 1, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5540), 1, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5550), 1, 909.0, 8, 256.0, 0 },
                    { 27, 6, 16, 2, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5610), 1, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5610), 0, 1656.0, 16, 256.0, 1 },
                    { 24, 6, 16, 1, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5570), 1, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5570), 0, 809.0, 8, 256.0, 0 },
                    { 28, 6, 16, 2, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5620), 1, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5630), 0, 1379.0, 16, 256.0, 0 },
                    { 35, 6, 16, 2, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5710), 1, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5710), 0, 919.0, 8, 256.0, 1 },
                    { 30, 6, 16, 2, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5650), 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5650), 1, 3911.0, 16, 256.0, 0 },
                    { 31, 6, 16, 2, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5660), 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5660), 0, 3619.0, 16, 256.0, 1 },
                    { 32, 6, 16, 2, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5670), 1, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5680), 0, 3659.0, 16, 256.0, 0 },
                    { 33, 6, 16, 2, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5680), 1, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5690), 1, 944.0, 8, 256.0, 1 },
                    { 34, 6, 16, 2, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5700), 1, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5700), 1, 911.0, 8, 256.0, 0 },
                    { 21, 6, 16, 1, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5530), 1, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5540), 1, 950.0, 8, 256.0, 1 },
                    { 36, 6, 16, 2, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5720), 1, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5730), 0, 821.0, 8, 256.0, 0 },
                    { 29, 6, 16, 2, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5630), 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5640), 1, 3790.0, 16, 256.0, 1 },
                    { 20, 6, 16, 1, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5520), 1, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5520), 0, 3759.0, 16, 256.0, 0 },
                    { 12, 6, 16, 0, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5420), 1, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5420), 0, 800.0, 8, 256.0, 0 },
                    { 18, 6, 16, 1, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5490), 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5500), 1, 3901.0, 16, 256.0, 0 },
                    { 1, 6, 16, 0, 4, new DateTime(2020, 5, 31, 13, 22, 57, 665, DateTimeKind.Local).AddTicks(6530), 1, new DateTime(2020, 5, 31, 13, 22, 57, 665, DateTimeKind.Local).AddTicks(6570), 1, 1500.0, 16, 256.0, 1 },
                    { 2, 6, 16, 0, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5090), 1, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5120), 1, 1250.0, 16, 256.0, 0 },
                    { 3, 6, 16, 0, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5300), 1, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5300), 0, 1650.0, 16, 256.0, 1 },
                    { 4, 6, 16, 0, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5310), 1, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5320), 0, 1400.0, 16, 256.0, 0 },
                    { 5, 6, 16, 0, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5330), 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5330), 1, 4000.0, 16, 256.0, 1 },
                    { 6, 6, 16, 0, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5340), 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5350), 1, 3800.0, 16, 256.0, 0 },
                    { 7, 6, 16, 0, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5350), 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5360), 0, 3600.0, 16, 256.0, 1 },
                    { 19, 6, 16, 1, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5510), 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5510), 0, 3609.0, 16, 256.0, 1 },
                    { 8, 6, 16, 0, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5360), 1, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5370), 0, 3750.0, 16, 256.0, 0 },
                    { 10, 6, 16, 0, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5390), 1, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5400), 1, 900.0, 8, 256.0, 0 },
                    { 11, 6, 16, 0, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5400), 1, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5410), 0, 887.0, 8, 256.0, 1 },
                    { 14, 6, 16, 1, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5440), 1, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5450), 1, 1350.0, 16, 256.0, 0 },
                    { 15, 6, 16, 1, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5450), 1, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5460), 0, 1652.0, 16, 256.0, 1 },
                    { 16, 6, 16, 1, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5470), 1, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5470), 0, 1389.0, 16, 256.0, 0 },
                    { 17, 6, 16, 1, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5480), 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5490), 1, 3800.0, 16, 256.0, 1 },
                    { 9, 6, 16, 0, 4, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5380), 1, new DateTime(2020, 5, 31, 13, 22, 57, 666, DateTimeKind.Local).AddTicks(5380), 1, 850.0, 8, 256.0, 1 }
                });

            migrationBuilder.InsertData(
                table: "NewsPost",
                columns: new[] { "Id", "Content", "Created", "Image", "Modified", "Subtitle", "Title" },
                values: new object[,]
                {
                    { 2, "The coronavirus pandemic has magnified the importance of cloud-based technologies in major, life-altering ways and ushered in a new paradigm. Before COVID-19, experts projected the worldwide public cloud services market would jump by 17% this year, reaching $266.4 million. Software as a service is the largest segment within that market, but the second-largest — infrastructure as a service — claims the fastest growth rate.A number of factors are driving businesses to choose the cloud as the standard for applications, data, and storage. They migrate to gain flexible computing power, to lower the cost of backup/recovery, or to turn capital expenses into operational costs. Beyond any single benefit, however, companies migrate to facilitate organisational change in ways that only the cloud can offer.Take artificial intelligence as just one example. Companies that have already implemented AI saw an uptick in revenue, and 44% experienced a reduction in costs. Executives across industries want (and need) to use this technology effectively, and that’s possible from a technical and logistical standpoint only if the technology runs out of the cloud. To put it simply, the cloud is where the future happens, meaning companies either migrate or get left behind.", new DateTime(2020, 5, 31, 13, 22, 57, 681, DateTimeKind.Local).AddTicks(8360), null, new DateTime(2020, 5, 31, 13, 22, 57, 681, DateTimeKind.Local).AddTicks(8380), null, "Covid-19 has hastened cloud migration – but don’t move without a plan" },
                    { 1, "Google Cloud has brokered another partnership in its exploration of blockchain technologies, with the company joining the enterprise program of blockchain-based video delivery network Theta Labs. Google has joined the grandly-named Enterprise Validator Program, alongside Binance, Blockchain Ventures, and Gumi, which ‘allows enterprises to validate transactions in accordance with Theta’s underlying consensus protocol’, in its own words. Theta’s business case is to broadly put together a decentralised content delivery network (CDN), which will aim to solve the problems of combining high quality data throughput with no buffering, as well as giving more revenues to content creators rather than arbiters. Blockchain comes in through what the company calls ‘Theta fuel’ – tokens on which a value exchange is based between viewer and video platform. Theta and its partners in the media and entertainment, telecom, technology and gaming industries thus provide a high performance decentralised micropayment network that scales to millions of concurrent video viewers,” Theta wrote in a Medium post.  Google Cloud’s role will be to provide ‘stability, reliability and security’ to the Theta network, in the company’s words. Distributed ledger technology enables new business models that potentially transform the global digital economy, including the media and entertainment industry, said Allen Day, Google Cloud developer advocate. We look forward to participating as an enterprise validator, and to providing Google Cloud infrastructure in support of Theta’s long-term mission and future growth.", new DateTime(2020, 5, 31, 13, 22, 57, 681, DateTimeKind.Local).AddTicks(6340), null, new DateTime(2020, 5, 31, 13, 22, 57, 681, DateTimeKind.Local).AddTicks(6380), null, "Google Cloud teams up with Theta Labs for blockchain-based video delivery" },
                    { 3, "Cloud providers need to proactively support their customers through the tail end of the Covid-19 pandemic. They can do this by demonstrating the strength and adaptability of their service offerings. Covid-19 has left many organisations unsure if their business continuity strategy is sufficiently robust, particularly when it comes to cloud services. The reliance on videoconferencing and collaboration tools has stressed the limits of back-end supporting services, while also increasing network traffic volume. However, cloud providers with robust and excess infrastructure, combined with disaster recovery plans to respond to such a crisis, are successfully managing in this new normal. As IT leaders begin to consider longer-term cloud solutions to support the new portion of their workforce remaining remote, they are facing challenging questions about the resiliency and dependability of cloud services. At the same time as Covid-19 has pushed cloud to the spotlight, it has put providers in a unique position to reassure customers of their strength and adaptability.The providers who will fail at this time are the ones still tackling the debate of on-premises data centres vs cloud. Customers are now asking about the adaptability of their current cloud service that they have been forced to adopt if they decided to continue using it post pandemic.", new DateTime(2020, 5, 31, 13, 22, 57, 681, DateTimeKind.Local).AddTicks(8420), null, new DateTime(2020, 5, 31, 13, 22, 57, 681, DateTimeKind.Local).AddTicks(8430), null, "Gartner: How and why cloud providers need to support their customers through Covid-19" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "Modified", "Password" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 31, 13, 22, 57, 622, DateTimeKind.Local).AddTicks(5840), "admin@test.com", "Admin", "Ad", new DateTime(2020, 5, 31, 13, 22, 57, 641, DateTimeKind.Local).AddTicks(1610), "10000.7mSNp+Oapzv2iVbiybMmSA==.TjfFGVah1ko7+nrYvgKIBwpJGGgVzRz2BcG24jUBMiE=" },
                    { 2, new DateTime(2020, 5, 31, 13, 22, 57, 641, DateTimeKind.Local).AddTicks(7310), "test@test.com", "Test", "Testic", new DateTime(2020, 5, 31, 13, 22, 57, 641, DateTimeKind.Local).AddTicks(7360), "10000.7mSNp+Oapzv2iVbiybMmSA==.TjfFGVah1ko7+nrYvgKIBwpJGGgVzRz2BcG24jUBMiE=" }
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
                name: "NewsPost");

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
