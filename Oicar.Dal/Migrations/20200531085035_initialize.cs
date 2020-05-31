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
                name: "NewsPost",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
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
                    { 4, 0, new DateTime(2020, 5, 31, 10, 50, 35, 495, DateTimeKind.Local).AddTicks(8670), 50000, 50000.0, 10, new DateTime(2020, 5, 31, 10, 50, 35, 495, DateTimeKind.Local).AddTicks(8670), 18.0 },
                    { 12, 2, new DateTime(2020, 5, 31, 10, 50, 35, 495, DateTimeKind.Local).AddTicks(8720), 20000, 1000000.0, 1000, new DateTime(2020, 5, 31, 10, 50, 35, 495, DateTimeKind.Local).AddTicks(8720), 39.0 },
                    { 11, 1, new DateTime(2020, 5, 31, 10, 50, 35, 495, DateTimeKind.Local).AddTicks(8710), 20000, 1000000.0, 1000, new DateTime(2020, 5, 31, 10, 50, 35, 495, DateTimeKind.Local).AddTicks(8720), 41.0 },
                    { 10, 0, new DateTime(2020, 5, 31, 10, 50, 35, 495, DateTimeKind.Local).AddTicks(8710), 20000, 1000000.0, 1000, new DateTime(2020, 5, 31, 10, 50, 35, 495, DateTimeKind.Local).AddTicks(8710), 44.0 },
                    { 9, 2, new DateTime(2020, 5, 31, 10, 50, 35, 495, DateTimeKind.Local).AddTicks(8700), 20000, 1000000.0, 100, new DateTime(2020, 5, 31, 10, 50, 35, 495, DateTimeKind.Local).AddTicks(8700), 39.0 },
                    { 8, 1, new DateTime(2020, 5, 31, 10, 50, 35, 495, DateTimeKind.Local).AddTicks(8690), 20000, 1000000.0, 100, new DateTime(2020, 5, 31, 10, 50, 35, 495, DateTimeKind.Local).AddTicks(8700), 41.0 },
                    { 7, 0, new DateTime(2020, 5, 31, 10, 50, 35, 495, DateTimeKind.Local).AddTicks(8690), 20000, 1000000.0, 100, new DateTime(2020, 5, 31, 10, 50, 35, 495, DateTimeKind.Local).AddTicks(8690), 44.0 },
                    { 6, 2, new DateTime(2020, 5, 31, 10, 50, 35, 495, DateTimeKind.Local).AddTicks(8680), 50000, 50000.0, 10, new DateTime(2020, 5, 31, 10, 50, 35, 495, DateTimeKind.Local).AddTicks(8690), 22.0 },
                    { 5, 1, new DateTime(2020, 5, 31, 10, 50, 35, 495, DateTimeKind.Local).AddTicks(8680), 50000, 50000.0, 10, new DateTime(2020, 5, 31, 10, 50, 35, 495, DateTimeKind.Local).AddTicks(8680), 20.0 },
                    { 3, 2, new DateTime(2020, 5, 31, 10, 50, 35, 495, DateTimeKind.Local).AddTicks(8660), 10000, 100000.0, 1, new DateTime(2020, 5, 31, 10, 50, 35, 495, DateTimeKind.Local).AddTicks(8670), 9.0 },
                    { 2, 1, new DateTime(2020, 5, 31, 10, 50, 35, 495, DateTimeKind.Local).AddTicks(8600), 10000, 10000.0, 1, new DateTime(2020, 5, 31, 10, 50, 35, 495, DateTimeKind.Local).AddTicks(8620), 12.0 },
                    { 1, 0, new DateTime(2020, 5, 31, 10, 50, 35, 495, DateTimeKind.Local).AddTicks(6480), 10000, 10000.0, 1, new DateTime(2020, 5, 31, 10, 50, 35, 495, DateTimeKind.Local).AddTicks(6490), 10.0 }
                });

            migrationBuilder.InsertData(
                table: "CloudSQL",
                columns: new[] { "Id", "AverageDaysPerWeek", "AverageHoursPerDay", "BaskupSize", "CloudProvider", "CpuCores", "Created", "Instance", "Modified", "Price", "Ram", "SQLServerType" },
                values: new object[,]
                {
                    { 23, 7, 24, 64, 2, 8, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1120), 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1120), 56.0, 32, 0 },
                    { 24, 7, 24, 64, 1, 8, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1130), 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1130), 57.0, 32, 0 },
                    { 1, 7, 24, 1, 0, 1, new DateTime(2020, 5, 31, 10, 50, 35, 497, DateTimeKind.Local).AddTicks(7140), 1, new DateTime(2020, 5, 31, 10, 50, 35, 497, DateTimeKind.Local).AddTicks(7160), 45.0, 1, 1 },
                    { 26, 7, 24, 64, 2, 16, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1140), 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1140), 56.0, 32, 0 },
                    { 22, 7, 24, 64, 0, 8, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1110), 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1110), 59.0, 32, 0 },
                    { 25, 7, 24, 64, 0, 16, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1130), 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1140), 59.0, 32, 0 },
                    { 21, 7, 24, 1, 1, 4, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1100), 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1110), 52.0, 16, 0 },
                    { 27, 7, 24, 64, 1, 16, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1150), 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1150), 84.0, 32, 0 },
                    { 19, 7, 24, 1, 0, 4, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1090), 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1090), 48.0, 16, 0 },
                    { 2, 7, 24, 1, 2, 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(870), 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(880), 48.0, 1, 1 },
                    { 3, 7, 24, 1, 1, 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(960), 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(970), 41.0, 1, 1 },
                    { 20, 7, 24, 1, 2, 4, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1090), 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1100), 47.0, 16, 0 },
                    { 5, 7, 24, 1, 2, 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(980), 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(980), 37.0, 1, 2 },
                    { 6, 7, 24, 1, 1, 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(990), 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(990), 36.0, 1, 2 },
                    { 7, 7, 24, 1, 0, 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1000), 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1000), 27.0, 1, 0 },
                    { 8, 7, 24, 1, 2, 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1000), 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1010), 30.0, 1, 0 },
                    { 9, 7, 24, 1, 1, 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1010), 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1010), 31.0, 1, 0 },
                    { 10, 7, 24, 1, 0, 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1020), 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1020), 21.0, 1, 3 },
                    { 4, 7, 24, 1, 0, 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(970), 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(980), 24.0, 1, 2 },
                    { 12, 7, 24, 1, 1, 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1030), 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1040), 18.0, 1, 3 },
                    { 13, 7, 24, 1, 0, 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1040), 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1040), 30.0, 4, 0 },
                    { 14, 7, 24, 1, 2, 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1050), 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1050), 27.0, 4, 0 },
                    { 15, 7, 24, 1, 1, 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1060), 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1060), 28.0, 4, 0 },
                    { 16, 7, 24, 1, 0, 2, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1060), 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1070), 38.0, 8, 0 },
                    { 17, 7, 24, 1, 2, 2, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1070), 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1080), 39.0, 8, 0 },
                    { 18, 7, 24, 1, 1, 2, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1080), 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1080), 40.0, 8, 0 },
                    { 11, 7, 24, 1, 2, 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1030), 1, new DateTime(2020, 5, 31, 10, 50, 35, 498, DateTimeKind.Local).AddTicks(1030), 20.0, 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "CloudStorage",
                columns: new[] { "Id", "CloudProvider", "Created", "Modified", "Price", "ReadOperationsPerMonth", "TotalAmount", "WriteOperationsPerMonth" },
                values: new object[,]
                {
                    { 19, 0, new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7110), new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7110), 180.0, 4000000.0, 2028.0, 4000000.0 },
                    { 20, 2, new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7110), new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7110), 167.0, 10000.0, 2028.0, 10000.0 },
                    { 21, 1, new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7120), new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7120), 169.0, 10000.0, 2028.0, 10000.0 },
                    { 22, 0, new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7120), new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7130), 160.0, 10000.0, 2028.0, 10000.0 },
                    { 23, 2, new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7130), new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7130), 183.0, 10000.0, 2028.0, 10000.0 },
                    { 24, 1, new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7140), new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7140), 68.0, 50000.0, 128.0, 50000.0 },
                    { 28, 0, new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7160), new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7160), 66.0, 500000.0, 128.0, 500000.0 },
                    { 26, 2, new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7150), new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7150), 65.0, 50000.0, 128.0, 50000.0 },
                    { 27, 1, new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7150), new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7160), 78.0, 500000.0, 128.0, 500000.0 },
                    { 29, 2, new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7170), new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7170), 46.0, 125000.0, 64.0, 125000.0 },
                    { 30, 1, new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7170), new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7170), 55.0, 125000.0, 64.0, 125000.0 },
                    { 18, 1, new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7100), new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7100), 183.0, 4000000.0, 2028.0, 4000000.0 },
                    { 25, 0, new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7140), new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7140), 78.0, 50000.0, 128.0, 50000.0 },
                    { 17, 2, new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7090), new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7100), 113.0, 4000000.0, 512.0, 4000000.0 },
                    { 16, 0, new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7090), new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7090), 99.0, 4000000.0, 512.0, 4000000.0 },
                    { 4, 0, new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7010), new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7020), 68.0, 500000.0, 64.0, 500000.0 },
                    { 1, 0, new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(4760), new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(4780), 100.0, 1000000.0, 512.0, 1000000.0 },
                    { 2, 2, new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(6940), new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(6960), 54.0, 1000000.0, 16.0, 1000000.0 },
                    { 3, 1, new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7010), new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7010), 60.0, 1000000.0, 32.0, 1000000.0 },
                    { 5, 2, new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7020), new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7020), 88.0, 500000.0, 128.0, 500000.0 },
                    { 6, 1, new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7030), new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7030), 98.0, 500000.0, 254.0, 500000.0 },
                    { 8, 2, new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7040), new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7040), 122.0, 2000000.0, 1024.0, 2000000.0 },
                    { 7, 0, new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7030), new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7030), 112.0, 2000000.0, 512.0, 2000000.0 },
                    { 10, 0, new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7050), new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7050), 156.0, 2000000.0, 1024.0, 2000000.0 },
                    { 11, 2, new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7060), new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7060), 159.0, 250000.0, 1024.0, 250000.0 },
                    { 12, 1, new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7060), new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7070), 76.0, 250000.0, 254.0, 250000.0 },
                    { 13, 0, new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7070), new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7070), 73.0, 250000.0, 254.0, 250000.0 },
                    { 14, 2, new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7080), new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7080), 79.0, 250000.0, 254.0, 250000.0 },
                    { 9, 1, new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7040), new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7050), 135.0, 2000000.0, 1024.0, 2000000.0 },
                    { 15, 1, new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7080), new DateTime(2020, 5, 31, 10, 50, 35, 491, DateTimeKind.Local).AddTicks(7080), 86.0, 4000000.0, 254.0, 4000000.0 }
                });

            migrationBuilder.InsertData(
                table: "CloudVM",
                columns: new[] { "Id", "AverageDaysPerWeek", "AverageHoursPerDay", "CloudProvider", "Core", "Created", "InstanceNb", "Modified", "OperatingSystem", "Price", "Ram", "Storage", "StorageType" },
                values: new object[,]
                {
                    { 25, 6, 16, 2, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8410), 1, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8420), 1, 1499.0, 16, 256.0, 1 },
                    { 26, 6, 16, 2, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8420), 1, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8420), 1, 1359.0, 16, 256.0, 0 },
                    { 13, 6, 16, 1, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8340), 1, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8340), 1, 1509.0, 16, 256.0, 1 },
                    { 23, 6, 16, 1, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8400), 1, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8400), 0, 869.0, 8, 256.0, 1 },
                    { 22, 6, 16, 1, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8400), 1, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8400), 1, 909.0, 8, 256.0, 0 },
                    { 27, 6, 16, 2, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8430), 1, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8430), 0, 1656.0, 16, 256.0, 1 },
                    { 24, 6, 16, 1, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8410), 1, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8410), 0, 809.0, 8, 256.0, 0 },
                    { 28, 6, 16, 2, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8430), 1, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8440), 0, 1379.0, 16, 256.0, 0 },
                    { 35, 6, 16, 2, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8480), 1, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8480), 0, 919.0, 8, 256.0, 1 },
                    { 30, 6, 16, 2, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8450), 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8450), 1, 3911.0, 16, 256.0, 0 },
                    { 31, 6, 16, 2, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8450), 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8450), 0, 3619.0, 16, 256.0, 1 },
                    { 32, 6, 16, 2, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8460), 1, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8460), 0, 3659.0, 16, 256.0, 0 },
                    { 33, 6, 16, 2, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8460), 1, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8470), 1, 944.0, 8, 256.0, 1 },
                    { 34, 6, 16, 2, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8470), 1, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8470), 1, 911.0, 8, 256.0, 0 },
                    { 21, 6, 16, 1, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8390), 1, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8390), 1, 950.0, 8, 256.0, 1 },
                    { 36, 6, 16, 2, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8480), 1, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8490), 0, 821.0, 8, 256.0, 0 },
                    { 29, 6, 16, 2, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8440), 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8440), 1, 3790.0, 16, 256.0, 1 },
                    { 20, 6, 16, 1, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8380), 1, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8390), 0, 3759.0, 16, 256.0, 0 },
                    { 12, 6, 16, 0, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8330), 1, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8340), 0, 800.0, 8, 256.0, 0 },
                    { 18, 6, 16, 1, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8370), 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8370), 1, 3901.0, 16, 256.0, 0 },
                    { 1, 6, 16, 0, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(3720), 1, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(3740), 1, 1500.0, 16, 256.0, 1 },
                    { 2, 6, 16, 0, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8160), 1, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8170), 1, 1250.0, 16, 256.0, 0 },
                    { 3, 6, 16, 0, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8270), 1, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8280), 0, 1650.0, 16, 256.0, 1 },
                    { 4, 6, 16, 0, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8280), 1, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8280), 0, 1400.0, 16, 256.0, 0 },
                    { 5, 6, 16, 0, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8290), 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8290), 1, 4000.0, 16, 256.0, 1 },
                    { 6, 6, 16, 0, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8290), 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8300), 1, 3800.0, 16, 256.0, 0 },
                    { 7, 6, 16, 0, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8300), 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8300), 0, 3600.0, 16, 256.0, 1 },
                    { 19, 6, 16, 1, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8380), 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8380), 0, 3609.0, 16, 256.0, 1 },
                    { 8, 6, 16, 0, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8310), 1, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8310), 0, 3750.0, 16, 256.0, 0 },
                    { 10, 6, 16, 0, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8320), 1, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8320), 1, 900.0, 8, 256.0, 0 },
                    { 11, 6, 16, 0, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8330), 1, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8330), 0, 887.0, 8, 256.0, 1 },
                    { 14, 6, 16, 1, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8340), 1, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8350), 1, 1350.0, 16, 256.0, 0 },
                    { 15, 6, 16, 1, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8350), 1, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8350), 0, 1652.0, 16, 256.0, 1 },
                    { 16, 6, 16, 1, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8360), 1, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8360), 0, 1389.0, 16, 256.0, 0 },
                    { 17, 6, 16, 1, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8360), 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8370), 1, 3800.0, 16, 256.0, 1 },
                    { 9, 6, 16, 0, 4, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8310), 1, new DateTime(2020, 5, 31, 10, 50, 35, 494, DateTimeKind.Local).AddTicks(8320), 1, 850.0, 8, 256.0, 1 }
                });

            migrationBuilder.InsertData(
                table: "NewsPost",
                columns: new[] { "Id", "Content", "Created", "Image", "Modified", "Subtitle", "Title" },
                values: new object[,]
                {
                    { 2, "The coronavirus pandemic has magnified the importance of cloud-based technologies in major, life-altering ways and ushered in a new paradigm. Before COVID-19, experts projected the worldwide public cloud services market would jump by 17% this year, reaching $266.4 million. Software as a service is the largest segment within that market, but the second-largest — infrastructure as a service — claims the fastest growth rate.A number of factors are driving businesses to choose the cloud as the standard for applications, data, and storage. They migrate to gain flexible computing power, to lower the cost of backup/recovery, or to turn capital expenses into operational costs. Beyond any single benefit, however, companies migrate to facilitate organisational change in ways that only the cloud can offer.Take artificial intelligence as just one example. Companies that have already implemented AI saw an uptick in revenue, and 44% experienced a reduction in costs. Executives across industries want (and need) to use this technology effectively, and that’s possible from a technical and logistical standpoint only if the technology runs out of the cloud. To put it simply, the cloud is where the future happens, meaning companies either migrate or get left behind.", new DateTime(2020, 5, 31, 10, 50, 35, 508, DateTimeKind.Local).AddTicks(5210), null, new DateTime(2020, 5, 31, 10, 50, 35, 508, DateTimeKind.Local).AddTicks(5230), null, "Covid-19 has hastened cloud migration – but don’t move without a plan" },
                    { 1, "Google Cloud has brokered another partnership in its exploration of blockchain technologies, with the company joining the enterprise program of blockchain-based video delivery network Theta Labs. Google has joined the grandly-named Enterprise Validator Program, alongside Binance, Blockchain Ventures, and Gumi, which ‘allows enterprises to validate transactions in accordance with Theta’s underlying consensus protocol’, in its own words. Theta’s business case is to broadly put together a decentralised content delivery network (CDN), which will aim to solve the problems of combining high quality data throughput with no buffering, as well as giving more revenues to content creators rather than arbiters. Blockchain comes in through what the company calls ‘Theta fuel’ – tokens on which a value exchange is based between viewer and video platform. Theta and its partners in the media and entertainment, telecom, technology and gaming industries thus provide a high performance decentralised micropayment network that scales to millions of concurrent video viewers,” Theta wrote in a Medium post.  Google Cloud’s role will be to provide ‘stability, reliability and security’ to the Theta network, in the company’s words. Distributed ledger technology enables new business models that potentially transform the global digital economy, including the media and entertainment industry, said Allen Day, Google Cloud developer advocate. We look forward to participating as an enterprise validator, and to providing Google Cloud infrastructure in support of Theta’s long-term mission and future growth.", new DateTime(2020, 5, 31, 10, 50, 35, 508, DateTimeKind.Local).AddTicks(3850), null, new DateTime(2020, 5, 31, 10, 50, 35, 508, DateTimeKind.Local).AddTicks(3890), null, "Google Cloud teams up with Theta Labs for blockchain-based video delivery" },
                    { 3, "Cloud providers need to proactively support their customers through the tail end of the Covid-19 pandemic. They can do this by demonstrating the strength and adaptability of their service offerings. Covid-19 has left many organisations unsure if their business continuity strategy is sufficiently robust, particularly when it comes to cloud services. The reliance on videoconferencing and collaboration tools has stressed the limits of back-end supporting services, while also increasing network traffic volume. However, cloud providers with robust and excess infrastructure, combined with disaster recovery plans to respond to such a crisis, are successfully managing in this new normal. As IT leaders begin to consider longer-term cloud solutions to support the new portion of their workforce remaining remote, they are facing challenging questions about the resiliency and dependability of cloud services. At the same time as Covid-19 has pushed cloud to the spotlight, it has put providers in a unique position to reassure customers of their strength and adaptability.The providers who will fail at this time are the ones still tackling the debate of on-premises data centres vs cloud. Customers are now asking about the adaptability of their current cloud service that they have been forced to adopt if they decided to continue using it post pandemic.", new DateTime(2020, 5, 31, 10, 50, 35, 508, DateTimeKind.Local).AddTicks(5270), null, new DateTime(2020, 5, 31, 10, 50, 35, 508, DateTimeKind.Local).AddTicks(5270), null, "Gartner: How and why cloud providers need to support their customers through Covid-19" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "Modified", "Password" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 31, 10, 50, 35, 479, DateTimeKind.Local).AddTicks(4150), "admin@test.com", "Admin", "Ad", new DateTime(2020, 5, 31, 10, 50, 35, 488, DateTimeKind.Local).AddTicks(4970), "10000.7mSNp+Oapzv2iVbiybMmSA==.TjfFGVah1ko7+nrYvgKIBwpJGGgVzRz2BcG24jUBMiE=" },
                    { 2, new DateTime(2020, 5, 31, 10, 50, 35, 488, DateTimeKind.Local).AddTicks(7680), "test@test.com", "Test", "Testic", new DateTime(2020, 5, 31, 10, 50, 35, 488, DateTimeKind.Local).AddTicks(7700), "10000.7mSNp+Oapzv2iVbiybMmSA==.TjfFGVah1ko7+nrYvgKIBwpJGGgVzRz2BcG24jUBMiE=" }
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
