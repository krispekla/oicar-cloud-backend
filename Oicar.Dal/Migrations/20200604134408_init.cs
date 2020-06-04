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
                        .Annotation("Npgsql:IdentitySequenceOptions", "'16', '1', '', '', 'False', '1'")
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
                        .Annotation("Npgsql:IdentitySequenceOptions", "'46', '1', '', '', 'False', '1'")
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
                        .Annotation("Npgsql:IdentitySequenceOptions", "'2', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: false),
                    UserInput = table.Column<string>(type: "json", nullable: true),
                    Name = table.Column<string>(nullable: true),
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
                    { 1, 0, new DateTime(2020, 6, 4, 15, 44, 7, 403, DateTimeKind.Local).AddTicks(617), 10000, 10000.0, 1, new DateTime(2020, 6, 4, 15, 44, 7, 403, DateTimeKind.Local).AddTicks(687), 10.0 },
                    { 2, 1, new DateTime(2020, 6, 4, 15, 44, 7, 403, DateTimeKind.Local).AddTicks(3388), 10000, 10000.0, 1, new DateTime(2020, 6, 4, 15, 44, 7, 403, DateTimeKind.Local).AddTicks(3405), 12.0 },
                    { 3, 2, new DateTime(2020, 6, 4, 15, 44, 7, 403, DateTimeKind.Local).AddTicks(3450), 10000, 100000.0, 1, new DateTime(2020, 6, 4, 15, 44, 7, 403, DateTimeKind.Local).AddTicks(3453), 9.0 },
                    { 4, 0, new DateTime(2020, 6, 4, 15, 44, 7, 403, DateTimeKind.Local).AddTicks(3458), 50000, 50000.0, 10, new DateTime(2020, 6, 4, 15, 44, 7, 403, DateTimeKind.Local).AddTicks(3461), 18.0 },
                    { 5, 1, new DateTime(2020, 6, 4, 15, 44, 7, 403, DateTimeKind.Local).AddTicks(3465), 50000, 50000.0, 10, new DateTime(2020, 6, 4, 15, 44, 7, 403, DateTimeKind.Local).AddTicks(3468), 20.0 },
                    { 7, 0, new DateTime(2020, 6, 4, 15, 44, 7, 403, DateTimeKind.Local).AddTicks(3479), 20000, 1000000.0, 100, new DateTime(2020, 6, 4, 15, 44, 7, 403, DateTimeKind.Local).AddTicks(3482), 44.0 },
                    { 8, 1, new DateTime(2020, 6, 4, 15, 44, 7, 403, DateTimeKind.Local).AddTicks(3486), 20000, 1000000.0, 100, new DateTime(2020, 6, 4, 15, 44, 7, 403, DateTimeKind.Local).AddTicks(3490), 41.0 },
                    { 6, 2, new DateTime(2020, 6, 4, 15, 44, 7, 403, DateTimeKind.Local).AddTicks(3472), 50000, 50000.0, 10, new DateTime(2020, 6, 4, 15, 44, 7, 403, DateTimeKind.Local).AddTicks(3475), 22.0 },
                    { 10, 0, new DateTime(2020, 6, 4, 15, 44, 7, 403, DateTimeKind.Local).AddTicks(3501), 20000, 1000000.0, 1000, new DateTime(2020, 6, 4, 15, 44, 7, 403, DateTimeKind.Local).AddTicks(3504), 44.0 },
                    { 11, 1, new DateTime(2020, 6, 4, 15, 44, 7, 403, DateTimeKind.Local).AddTicks(3508), 20000, 1000000.0, 1000, new DateTime(2020, 6, 4, 15, 44, 7, 403, DateTimeKind.Local).AddTicks(3511), 41.0 },
                    { 12, 2, new DateTime(2020, 6, 4, 15, 44, 7, 403, DateTimeKind.Local).AddTicks(3515), 20000, 1000000.0, 1000, new DateTime(2020, 6, 4, 15, 44, 7, 403, DateTimeKind.Local).AddTicks(3518), 39.0 },
                    { 13, 0, new DateTime(2020, 6, 4, 15, 44, 7, 403, DateTimeKind.Local).AddTicks(3522), 200000, 10000000.0, 100000, new DateTime(2020, 6, 4, 15, 44, 7, 403, DateTimeKind.Local).AddTicks(3525), 4400.0 },
                    { 14, 1, new DateTime(2020, 6, 4, 15, 44, 7, 403, DateTimeKind.Local).AddTicks(3529), 200000, 10000000.0, 100000, new DateTime(2020, 6, 4, 15, 44, 7, 403, DateTimeKind.Local).AddTicks(3533), 4100.0 },
                    { 15, 2, new DateTime(2020, 6, 4, 15, 44, 7, 403, DateTimeKind.Local).AddTicks(3536), 200000, 10000000.0, 100000, new DateTime(2020, 6, 4, 15, 44, 7, 403, DateTimeKind.Local).AddTicks(3540), 3900.0 },
                    { 9, 2, new DateTime(2020, 6, 4, 15, 44, 7, 403, DateTimeKind.Local).AddTicks(3494), 20000, 1000000.0, 100, new DateTime(2020, 6, 4, 15, 44, 7, 403, DateTimeKind.Local).AddTicks(3497), 39.0 }
                });

            migrationBuilder.InsertData(
                table: "CloudSQL",
                columns: new[] { "Id", "AverageDaysPerWeek", "AverageHoursPerDay", "BaskupSize", "CloudProvider", "CpuCores", "Created", "Instance", "Modified", "Price", "Ram", "SQLServerType" },
                values: new object[,]
                {
                    { 23, 7, 24, 64, 2, 8, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9692), 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9695), 56.0, 32, 0 },
                    { 27, 7, 24, 1024, 1, 64, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9721), 120, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9724), 8400.0, 128, 0 },
                    { 26, 7, 24, 1024, 2, 64, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9714), 120, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9717), 5600.0, 128, 0 },
                    { 25, 7, 24, 1024, 0, 64, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9706), 120, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9709), 5900.0, 128, 0 },
                    { 24, 7, 24, 1024, 1, 8, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9699), 120, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9702), 57.0, 128, 0 },
                    { 22, 7, 24, 64, 0, 8, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9685), 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9688), 59.0, 32, 0 },
                    { 1, 7, 24, 1, 0, 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(4890), 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(4955), 45.0, 1, 1 },
                    { 20, 7, 24, 1, 2, 4, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9670), 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9674), 47.0, 16, 0 },
                    { 2, 7, 24, 1, 2, 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9422), 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9441), 48.0, 1, 1 },
                    { 3, 7, 24, 1, 1, 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9543), 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9546), 41.0, 1, 1 },
                    { 4, 7, 24, 1, 0, 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9551), 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9554), 24.0, 1, 2 },
                    { 21, 7, 24, 1, 1, 4, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9678), 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9681), 52.0, 16, 0 },
                    { 6, 7, 24, 1, 1, 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9566), 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9570), 36.0, 1, 2 },
                    { 7, 7, 24, 1, 0, 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9574), 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9577), 27.0, 1, 0 },
                    { 8, 7, 24, 1, 2, 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9581), 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9584), 30.0, 1, 0 },
                    { 9, 7, 24, 1, 1, 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9588), 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9592), 31.0, 1, 0 },
                    { 10, 7, 24, 1, 0, 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9596), 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9599), 21.0, 1, 3 },
                    { 5, 7, 24, 1, 2, 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9559), 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9562), 37.0, 1, 2 },
                    { 12, 7, 24, 1, 1, 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9610), 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9613), 18.0, 1, 3 },
                    { 13, 7, 24, 1, 0, 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9617), 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9621), 30.0, 4, 0 },
                    { 14, 7, 24, 1, 2, 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9625), 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9628), 27.0, 4, 0 },
                    { 15, 7, 24, 1, 1, 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9633), 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9637), 28.0, 4, 0 },
                    { 16, 7, 24, 1, 0, 2, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9641), 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9644), 38.0, 8, 0 },
                    { 17, 7, 24, 1, 2, 2, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9648), 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9652), 39.0, 8, 0 },
                    { 18, 7, 24, 1, 1, 2, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9656), 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9659), 40.0, 8, 0 },
                    { 19, 7, 24, 1, 0, 4, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9663), 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9666), 48.0, 16, 0 },
                    { 11, 7, 24, 1, 2, 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9603), 1, new DateTime(2020, 6, 4, 15, 44, 7, 405, DateTimeKind.Local).AddTicks(9606), 20.0, 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "CloudStorage",
                columns: new[] { "Id", "CloudProvider", "Created", "Modified", "Price", "ReadOperationsPerMonth", "TotalAmount", "WriteOperationsPerMonth" },
                values: new object[,]
                {
                    { 18, 1, new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6112), new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6115), 183.0, 4000000.0, 2028.0, 4000000.0 },
                    { 20, 2, new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6126), new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6129), 167.0, 10000.0, 2028.0, 10000.0 },
                    { 21, 1, new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6133), new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6136), 169.0, 10000.0, 2028.0, 10000.0 },
                    { 22, 0, new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6140), new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6143), 160.0, 10000.0, 2028.0, 10000.0 },
                    { 23, 2, new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6147), new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6150), 183.0, 10000.0, 2028.0, 10000.0 },
                    { 24, 1, new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6154), new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6158), 68.0, 50000.0, 128.0, 50000.0 },
                    { 28, 0, new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6182), new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6185), 660.0, 800000.0, 90000.0, 800000.0 },
                    { 26, 2, new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6168), new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6171), 65.0, 50000.0, 128.0, 50000.0 },
                    { 27, 1, new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6175), new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6178), 78.0, 500000.0, 128.0, 500000.0 },
                    { 29, 2, new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6189), new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6192), 460.0, 800000.0, 90000.0, 800000.0 },
                    { 30, 1, new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6196), new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6199), 550.0, 800000.0, 90000.0, 800000.0 },
                    { 17, 2, new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6105), new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6108), 113.0, 4000000.0, 512.0, 4000000.0 },
                    { 25, 0, new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6161), new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6165), 78.0, 50000.0, 128.0, 50000.0 },
                    { 16, 0, new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6098), new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6101), 99.0, 4000000.0, 512.0, 4000000.0 },
                    { 19, 0, new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6119), new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6122), 180.0, 4000000.0, 2028.0, 4000000.0 },
                    { 14, 2, new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6084), new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6087), 79.0, 250000.0, 254.0, 250000.0 },
                    { 15, 1, new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6091), new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6094), 86.0, 4000000.0, 254.0, 4000000.0 },
                    { 1, 0, new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(3142), new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(3213), 100.0, 1000000.0, 512.0, 1000000.0 },
                    { 2, 2, new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(5927), new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(5944), 54.0, 1000000.0, 16.0, 1000000.0 },
                    { 3, 1, new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6005), new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6008), 60.0, 1000000.0, 32.0, 1000000.0 },
                    { 5, 2, new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6020), new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6024), 88.0, 500000.0, 128.0, 500000.0 },
                    { 6, 1, new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6028), new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6031), 98.0, 500000.0, 254.0, 500000.0 },
                    { 7, 0, new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6035), new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6038), 112.0, 2000000.0, 512.0, 2000000.0 },
                    { 4, 0, new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6013), new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6016), 68.0, 500000.0, 64.0, 500000.0 },
                    { 9, 1, new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6049), new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6052), 135.0, 2000000.0, 1024.0, 2000000.0 },
                    { 10, 0, new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6056), new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6059), 156.0, 2000000.0, 1024.0, 2000000.0 },
                    { 11, 2, new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6063), new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6066), 159.0, 250000.0, 1024.0, 250000.0 },
                    { 12, 1, new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6070), new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6073), 76.0, 250000.0, 254.0, 250000.0 },
                    { 13, 0, new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6077), new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6080), 73.0, 250000.0, 254.0, 250000.0 },
                    { 8, 2, new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6042), new DateTime(2020, 6, 4, 15, 44, 7, 396, DateTimeKind.Local).AddTicks(6045), 122.0, 2000000.0, 1024.0, 2000000.0 }
                });

            migrationBuilder.InsertData(
                table: "CloudVM",
                columns: new[] { "Id", "AverageDaysPerWeek", "AverageHoursPerDay", "CloudProvider", "Core", "Created", "InstanceNb", "Modified", "OperatingSystem", "Price", "Ram", "Storage", "StorageType" },
                values: new object[,]
                {
                    { 33, 6, 16, 2, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2088), 1, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2093), 1, 944.0, 8, 256.0, 1 },
                    { 26, 6, 16, 2, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2005), 1, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2010), 1, 1359.0, 16, 256.0, 0 },
                    { 27, 6, 16, 2, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2017), 1, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2023), 0, 1656.0, 16, 256.0, 1 },
                    { 28, 6, 16, 2, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2030), 1, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2035), 0, 1379.0, 16, 256.0, 0 },
                    { 29, 6, 16, 2, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2041), 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2047), 1, 3790.0, 16, 256.0, 1 },
                    { 30, 6, 16, 2, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2053), 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2058), 1, 3911.0, 16, 256.0, 0 },
                    { 31, 6, 16, 2, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2065), 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2070), 0, 3619.0, 16, 256.0, 1 },
                    { 32, 6, 16, 2, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2076), 1, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2081), 0, 3659.0, 16, 256.0, 0 },
                    { 34, 6, 16, 2, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2099), 1, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2105), 1, 911.0, 8, 256.0, 0 },
                    { 41, 7, 24, 0, 128, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2184), 64, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2190), 0, 5300.0, 128, 1024.0, 1 },
                    { 36, 6, 16, 2, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2123), 1, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2129), 0, 821.0, 8, 256.0, 0 },
                    { 37, 7, 24, 2, 128, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2136), 64, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2141), 1, 4200.0, 128, 1024.0, 0 },
                    { 38, 7, 24, 2, 128, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2147), 64, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2153), 0, 4300.0, 128, 1024.0, 1 },
                    { 39, 7, 24, 2, 128, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2159), 64, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2165), 0, 4500.0, 128, 1024.0, 0 },
                    { 40, 7, 24, 0, 128, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2171), 64, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2177), 1, 4900.0, 128, 1024.0, 0 },
                    { 25, 6, 16, 2, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1990), 1, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1995), 1, 1499.0, 16, 256.0, 1 },
                    { 42, 7, 24, 0, 128, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2197), 64, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2202), 0, 5500.0, 128, 1024.0, 0 },
                    { 43, 7, 24, 1, 128, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2209), 64, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2214), 1, 5210.0, 128, 1024.0, 0 },
                    { 44, 7, 24, 1, 128, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2221), 64, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2227), 0, 5600.0, 128, 1024.0, 1 },
                    { 45, 7, 24, 1, 128, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2233), 64, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2238), 0, 4100.0, 128, 1024.0, 0 },
                    { 35, 6, 16, 2, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2111), 1, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(2116), 0, 919.0, 8, 256.0, 1 },
                    { 24, 6, 16, 1, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1978), 1, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1983), 0, 809.0, 8, 256.0, 0 },
                    { 18, 6, 16, 1, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1905), 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1911), 1, 3901.0, 16, 256.0, 0 },
                    { 22, 6, 16, 1, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1953), 1, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1959), 1, 909.0, 8, 256.0, 0 },
                    { 1, 6, 16, 0, 4, new DateTime(2020, 6, 4, 15, 44, 7, 400, DateTimeKind.Local).AddTicks(2354), 1, new DateTime(2020, 6, 4, 15, 44, 7, 400, DateTimeKind.Local).AddTicks(2454), 1, 1500.0, 16, 256.0, 1 },
                    { 2, 6, 16, 0, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1355), 1, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1431), 1, 1250.0, 16, 256.0, 0 },
                    { 3, 6, 16, 0, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1596), 1, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1606), 0, 1650.0, 16, 256.0, 1 },
                    { 4, 6, 16, 0, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1615), 1, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1621), 0, 1400.0, 16, 256.0, 0 },
                    { 5, 6, 16, 0, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1628), 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1634), 1, 4000.0, 16, 256.0, 1 },
                    { 6, 6, 16, 0, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1640), 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1646), 1, 3800.0, 16, 256.0, 0 },
                    { 7, 6, 16, 0, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1653), 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1658), 0, 3600.0, 16, 256.0, 1 },
                    { 23, 6, 16, 1, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1966), 1, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1971), 0, 869.0, 8, 256.0, 1 },
                    { 9, 6, 16, 0, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1676), 1, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1682), 1, 850.0, 8, 256.0, 1 },
                    { 10, 6, 16, 0, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1688), 1, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1693), 1, 900.0, 8, 256.0, 0 },
                    { 8, 6, 16, 0, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1665), 1, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1670), 0, 3750.0, 16, 256.0, 0 },
                    { 12, 6, 16, 0, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1709), 1, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1714), 0, 800.0, 8, 256.0, 0 },
                    { 13, 6, 16, 1, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1720), 1, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1725), 1, 1509.0, 16, 256.0, 1 },
                    { 14, 6, 16, 1, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1852), 1, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1861), 1, 1350.0, 16, 256.0, 0 },
                    { 15, 6, 16, 1, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1868), 1, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1874), 0, 1652.0, 16, 256.0, 1 },
                    { 16, 6, 16, 1, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1880), 1, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1887), 0, 1389.0, 16, 256.0, 0 },
                    { 17, 6, 16, 1, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1894), 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1899), 1, 3800.0, 16, 256.0, 1 },
                    { 19, 6, 16, 1, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1917), 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1923), 0, 3609.0, 16, 256.0, 1 },
                    { 20, 6, 16, 1, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1930), 1, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1934), 0, 3759.0, 16, 256.0, 0 },
                    { 21, 6, 16, 1, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1941), 1, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1946), 1, 950.0, 8, 256.0, 1 },
                    { 11, 6, 16, 0, 4, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1699), 1, new DateTime(2020, 6, 4, 15, 44, 7, 401, DateTimeKind.Local).AddTicks(1704), 0, 887.0, 8, 256.0, 1 }
                });

            migrationBuilder.InsertData(
                table: "NewsPost",
                columns: new[] { "Id", "Content", "Created", "Image", "Modified", "Subtitle", "Title" },
                values: new object[,]
                {
                    { 1, "Google Cloud has brokered another partnership in its exploration of blockchain technologies, with the company joining the enterprise program of blockchain-based video delivery network Theta Labs. Google has joined the grandly-named Enterprise Validator Program, alongside Binance, Blockchain Ventures, and Gumi, which ‘allows enterprises to validate transactions in accordance with Theta’s underlying consensus protocol’, in its own words. Theta’s business case is to broadly put together a decentralised content delivery network (CDN), which will aim to solve the problems of combining high quality data throughput with no buffering, as well as giving more revenues to content creators rather than arbiters. Blockchain comes in through what the company calls ‘Theta fuel’ – tokens on which a value exchange is based between viewer and video platform. Theta and its partners in the media and entertainment, telecom, technology and gaming industries thus provide a high performance decentralised micropayment network that scales to millions of concurrent video viewers,” Theta wrote in a Medium post.  Google Cloud’s role will be to provide ‘stability, reliability and security’ to the Theta network, in the company’s words. Distributed ledger technology enables new business models that potentially transform the global digital economy, including the media and entertainment industry, said Allen Day, Google Cloud developer advocate. We look forward to participating as an enterprise validator, and to providing Google Cloud infrastructure in support of Theta’s long-term mission and future growth.", new DateTime(2020, 6, 4, 15, 44, 7, 410, DateTimeKind.Local).AddTicks(726), null, new DateTime(2020, 6, 4, 15, 44, 7, 410, DateTimeKind.Local).AddTicks(794), null, "Google Cloud teams up with Theta Labs for blockchain-based video delivery" },
                    { 2, "The coronavirus pandemic has magnified the importance of cloud-based technologies in major, life-altering ways and ushered in a new paradigm. Before COVID-19, experts projected the worldwide public cloud services market would jump by 17% this year, reaching $266.4 million. Software as a service is the largest segment within that market, but the second-largest — infrastructure as a service — claims the fastest growth rate.A number of factors are driving businesses to choose the cloud as the standard for applications, data, and storage. They migrate to gain flexible computing power, to lower the cost of backup/recovery, or to turn capital expenses into operational costs. Beyond any single benefit, however, companies migrate to facilitate organisational change in ways that only the cloud can offer.Take artificial intelligence as just one example. Companies that have already implemented AI saw an uptick in revenue, and 44% experienced a reduction in costs. Executives across industries want (and need) to use this technology effectively, and that’s possible from a technical and logistical standpoint only if the technology runs out of the cloud. To put it simply, the cloud is where the future happens, meaning companies either migrate or get left behind.", new DateTime(2020, 6, 4, 15, 44, 7, 410, DateTimeKind.Local).AddTicks(2077), null, new DateTime(2020, 6, 4, 15, 44, 7, 410, DateTimeKind.Local).AddTicks(2092), null, "Covid-19 has hastened cloud migration – but don’t move without a plan" },
                    { 3, "Cloud providers need to proactively support their customers through the tail end of the Covid-19 pandemic. They can do this by demonstrating the strength and adaptability of their service offerings. Covid-19 has left many organisations unsure if their business continuity strategy is sufficiently robust, particularly when it comes to cloud services. The reliance on videoconferencing and collaboration tools has stressed the limits of back-end supporting services, while also increasing network traffic volume. However, cloud providers with robust and excess infrastructure, combined with disaster recovery plans to respond to such a crisis, are successfully managing in this new normal. As IT leaders begin to consider longer-term cloud solutions to support the new portion of their workforce remaining remote, they are facing challenging questions about the resiliency and dependability of cloud services. At the same time as Covid-19 has pushed cloud to the spotlight, it has put providers in a unique position to reassure customers of their strength and adaptability.The providers who will fail at this time are the ones still tackling the debate of on-premises data centres vs cloud. Customers are now asking about the adaptability of their current cloud service that they have been forced to adopt if they decided to continue using it post pandemic.", new DateTime(2020, 6, 4, 15, 44, 7, 410, DateTimeKind.Local).AddTicks(2115), null, new DateTime(2020, 6, 4, 15, 44, 7, 410, DateTimeKind.Local).AddTicks(2119), null, "Gartner: How and why cloud providers need to support their customers through Covid-19" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "Modified", "Password" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 4, 15, 44, 7, 383, DateTimeKind.Local).AddTicks(1318), "admin@test.com", "Admin", "Ad", new DateTime(2020, 6, 4, 15, 44, 7, 386, DateTimeKind.Local).AddTicks(8245), "10000.7mSNp+Oapzv2iVbiybMmSA==.TjfFGVah1ko7+nrYvgKIBwpJGGgVzRz2BcG24jUBMiE=" },
                    { 2, new DateTime(2020, 6, 4, 15, 44, 7, 387, DateTimeKind.Local).AddTicks(1514), "test@test.com", "Test", "Testic", new DateTime(2020, 6, 4, 15, 44, 7, 387, DateTimeKind.Local).AddTicks(1543), "10000.7mSNp+Oapzv2iVbiybMmSA==.TjfFGVah1ko7+nrYvgKIBwpJGGgVzRz2BcG24jUBMiE=" }
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
