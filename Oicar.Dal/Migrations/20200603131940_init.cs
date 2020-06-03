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
                    { 4, 0, new DateTime(2020, 6, 3, 15, 19, 39, 812, DateTimeKind.Local).AddTicks(3407), 50000, 50000.0, 10, new DateTime(2020, 6, 3, 15, 19, 39, 812, DateTimeKind.Local).AddTicks(3411), 18.0 },
                    { 12, 2, new DateTime(2020, 6, 3, 15, 19, 39, 812, DateTimeKind.Local).AddTicks(3486), 20000, 1000000.0, 1000, new DateTime(2020, 6, 3, 15, 19, 39, 812, DateTimeKind.Local).AddTicks(3490), 39.0 },
                    { 11, 1, new DateTime(2020, 6, 3, 15, 19, 39, 812, DateTimeKind.Local).AddTicks(3476), 20000, 1000000.0, 1000, new DateTime(2020, 6, 3, 15, 19, 39, 812, DateTimeKind.Local).AddTicks(3481), 41.0 },
                    { 10, 0, new DateTime(2020, 6, 3, 15, 19, 39, 812, DateTimeKind.Local).AddTicks(3467), 20000, 1000000.0, 1000, new DateTime(2020, 6, 3, 15, 19, 39, 812, DateTimeKind.Local).AddTicks(3471), 44.0 },
                    { 9, 2, new DateTime(2020, 6, 3, 15, 19, 39, 812, DateTimeKind.Local).AddTicks(3457), 20000, 1000000.0, 100, new DateTime(2020, 6, 3, 15, 19, 39, 812, DateTimeKind.Local).AddTicks(3461), 39.0 },
                    { 8, 1, new DateTime(2020, 6, 3, 15, 19, 39, 812, DateTimeKind.Local).AddTicks(3445), 20000, 1000000.0, 100, new DateTime(2020, 6, 3, 15, 19, 39, 812, DateTimeKind.Local).AddTicks(3451), 41.0 },
                    { 7, 0, new DateTime(2020, 6, 3, 15, 19, 39, 812, DateTimeKind.Local).AddTicks(3435), 20000, 1000000.0, 100, new DateTime(2020, 6, 3, 15, 19, 39, 812, DateTimeKind.Local).AddTicks(3440), 44.0 },
                    { 6, 2, new DateTime(2020, 6, 3, 15, 19, 39, 812, DateTimeKind.Local).AddTicks(3425), 50000, 50000.0, 10, new DateTime(2020, 6, 3, 15, 19, 39, 812, DateTimeKind.Local).AddTicks(3430), 22.0 },
                    { 5, 1, new DateTime(2020, 6, 3, 15, 19, 39, 812, DateTimeKind.Local).AddTicks(3416), 50000, 50000.0, 10, new DateTime(2020, 6, 3, 15, 19, 39, 812, DateTimeKind.Local).AddTicks(3420), 20.0 },
                    { 3, 2, new DateTime(2020, 6, 3, 15, 19, 39, 812, DateTimeKind.Local).AddTicks(3395), 10000, 100000.0, 1, new DateTime(2020, 6, 3, 15, 19, 39, 812, DateTimeKind.Local).AddTicks(3401), 9.0 },
                    { 2, 1, new DateTime(2020, 6, 3, 15, 19, 39, 812, DateTimeKind.Local).AddTicks(3270), 10000, 10000.0, 1, new DateTime(2020, 6, 3, 15, 19, 39, 812, DateTimeKind.Local).AddTicks(3318), 12.0 },
                    { 1, 0, new DateTime(2020, 6, 3, 15, 19, 39, 811, DateTimeKind.Local).AddTicks(9044), 10000, 10000.0, 1, new DateTime(2020, 6, 3, 15, 19, 39, 811, DateTimeKind.Local).AddTicks(9131), 10.0 }
                });

            migrationBuilder.InsertData(
                table: "CloudSQL",
                columns: new[] { "Id", "AverageDaysPerWeek", "AverageHoursPerDay", "BaskupSize", "CloudProvider", "CpuCores", "Created", "Instance", "Modified", "Price", "Ram", "SQLServerType" },
                values: new object[,]
                {
                    { 23, 7, 24, 64, 2, 8, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4574), 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4577), 56.0, 32, 0 },
                    { 24, 7, 24, 64, 1, 8, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4581), 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4584), 57.0, 32, 0 },
                    { 1, 7, 24, 1, 0, 1, new DateTime(2020, 6, 3, 15, 19, 39, 815, DateTimeKind.Local).AddTicks(8863), 1, new DateTime(2020, 6, 3, 15, 19, 39, 815, DateTimeKind.Local).AddTicks(8942), 45.0, 1, 1 },
                    { 26, 7, 24, 64, 2, 16, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4596), 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4599), 56.0, 32, 0 },
                    { 22, 7, 24, 64, 0, 8, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4567), 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4570), 59.0, 32, 0 },
                    { 25, 7, 24, 64, 0, 16, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4588), 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4592), 59.0, 32, 0 },
                    { 21, 7, 24, 1, 1, 4, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4560), 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4563), 52.0, 16, 0 },
                    { 27, 7, 24, 64, 1, 16, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4603), 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4606), 84.0, 32, 0 },
                    { 19, 7, 24, 1, 0, 4, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4546), 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4549), 48.0, 16, 0 },
                    { 2, 7, 24, 1, 2, 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4254), 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4297), 48.0, 1, 1 },
                    { 3, 7, 24, 1, 1, 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4424), 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4429), 41.0, 1, 1 },
                    { 20, 7, 24, 1, 2, 4, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4553), 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4556), 47.0, 16, 0 },
                    { 5, 7, 24, 1, 2, 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4442), 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4445), 37.0, 1, 2 },
                    { 6, 7, 24, 1, 1, 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4450), 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4454), 36.0, 1, 2 },
                    { 7, 7, 24, 1, 0, 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4457), 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4461), 27.0, 1, 0 },
                    { 8, 7, 24, 1, 2, 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4465), 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4468), 30.0, 1, 0 },
                    { 9, 7, 24, 1, 1, 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4473), 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4476), 31.0, 1, 0 },
                    { 10, 7, 24, 1, 0, 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4480), 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4483), 21.0, 1, 3 },
                    { 4, 7, 24, 1, 0, 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4434), 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4437), 24.0, 1, 2 },
                    { 12, 7, 24, 1, 1, 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4495), 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4498), 18.0, 1, 3 },
                    { 13, 7, 24, 1, 0, 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4502), 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4506), 30.0, 4, 0 },
                    { 14, 7, 24, 1, 2, 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4509), 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4513), 27.0, 4, 0 },
                    { 15, 7, 24, 1, 1, 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4517), 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4520), 28.0, 4, 0 },
                    { 16, 7, 24, 1, 0, 2, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4524), 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4527), 38.0, 8, 0 },
                    { 17, 7, 24, 1, 2, 2, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4531), 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4534), 39.0, 8, 0 },
                    { 18, 7, 24, 1, 1, 2, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4538), 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4542), 40.0, 8, 0 },
                    { 11, 7, 24, 1, 2, 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4488), 1, new DateTime(2020, 6, 3, 15, 19, 39, 816, DateTimeKind.Local).AddTicks(4491), 20.0, 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "CloudStorage",
                columns: new[] { "Id", "CloudProvider", "Created", "Modified", "Price", "ReadOperationsPerMonth", "TotalAmount", "WriteOperationsPerMonth" },
                values: new object[,]
                {
                    { 18, 1, new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3518), new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3526), 183.0, 4000000.0, 2028.0, 4000000.0 },
                    { 19, 0, new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3533), new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3539), 180.0, 4000000.0, 2028.0, 4000000.0 },
                    { 20, 2, new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3547), new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3553), 167.0, 10000.0, 2028.0, 10000.0 },
                    { 22, 0, new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3574), new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3580), 160.0, 10000.0, 2028.0, 10000.0 },
                    { 23, 2, new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3587), new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3593), 183.0, 10000.0, 2028.0, 10000.0 },
                    { 24, 1, new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3601), new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3607), 68.0, 50000.0, 128.0, 50000.0 },
                    { 28, 0, new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3655), new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3660), 66.0, 500000.0, 128.0, 500000.0 },
                    { 26, 2, new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3628), new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3634), 65.0, 50000.0, 128.0, 50000.0 },
                    { 27, 1, new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3642), new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3648), 78.0, 500000.0, 128.0, 500000.0 },
                    { 29, 2, new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3667), new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3674), 46.0, 125000.0, 64.0, 125000.0 },
                    { 30, 1, new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3681), new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3688), 55.0, 125000.0, 64.0, 125000.0 },
                    { 17, 2, new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3394), new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3400), 113.0, 4000000.0, 512.0, 4000000.0 },
                    { 25, 0, new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3615), new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3621), 78.0, 50000.0, 128.0, 50000.0 },
                    { 16, 0, new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3384), new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3388), 99.0, 4000000.0, 512.0, 4000000.0 },
                    { 21, 1, new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3560), new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3567), 169.0, 10000.0, 2028.0, 10000.0 },
                    { 14, 2, new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3364), new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3369), 79.0, 250000.0, 254.0, 250000.0 },
                    { 15, 1, new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3375), new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3379), 86.0, 4000000.0, 254.0, 4000000.0 },
                    { 1, 0, new DateTime(2020, 6, 3, 15, 19, 39, 803, DateTimeKind.Local).AddTicks(8599), new DateTime(2020, 6, 3, 15, 19, 39, 803, DateTimeKind.Local).AddTicks(8687), 100.0, 1000000.0, 512.0, 1000000.0 },
                    { 2, 2, new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3045), new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3111), 54.0, 1000000.0, 16.0, 1000000.0 },
                    { 3, 1, new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3218), new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3226), 60.0, 1000000.0, 32.0, 1000000.0 },
                    { 5, 2, new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3247), new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3253), 88.0, 500000.0, 128.0, 500000.0 },
                    { 6, 1, new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3261), new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3267), 98.0, 500000.0, 254.0, 500000.0 },
                    { 7, 0, new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3274), new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3280), 112.0, 2000000.0, 512.0, 2000000.0 },
                    { 4, 0, new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3233), new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3240), 68.0, 500000.0, 64.0, 500000.0 },
                    { 9, 1, new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3300), new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3306), 135.0, 2000000.0, 1024.0, 2000000.0 },
                    { 10, 0, new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3312), new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3318), 156.0, 2000000.0, 1024.0, 2000000.0 },
                    { 11, 2, new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3325), new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3331), 159.0, 250000.0, 1024.0, 250000.0 },
                    { 12, 1, new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3338), new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3344), 76.0, 250000.0, 254.0, 250000.0 },
                    { 13, 0, new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3350), new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3357), 73.0, 250000.0, 254.0, 250000.0 },
                    { 8, 2, new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3287), new DateTime(2020, 6, 3, 15, 19, 39, 804, DateTimeKind.Local).AddTicks(3293), 122.0, 2000000.0, 1024.0, 2000000.0 }
                });

            migrationBuilder.InsertData(
                table: "CloudVM",
                columns: new[] { "Id", "AverageDaysPerWeek", "AverageHoursPerDay", "CloudProvider", "Core", "Created", "InstanceNb", "Modified", "OperatingSystem", "Price", "Ram", "Storage", "StorageType" },
                values: new object[,]
                {
                    { 26, 6, 16, 2, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(568), 1, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(573), 1, 1359.0, 16, 256.0, 0 },
                    { 33, 6, 16, 2, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(652), 1, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(657), 1, 944.0, 8, 256.0, 1 },
                    { 27, 6, 16, 2, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(582), 1, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(588), 0, 1656.0, 16, 256.0, 1 },
                    { 28, 6, 16, 2, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(595), 1, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(601), 0, 1379.0, 16, 256.0, 0 },
                    { 29, 6, 16, 2, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(607), 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(612), 1, 3790.0, 16, 256.0, 1 },
                    { 30, 6, 16, 2, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(618), 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(623), 1, 3911.0, 16, 256.0, 0 },
                    { 31, 6, 16, 2, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(630), 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(635), 0, 3619.0, 16, 256.0, 1 },
                    { 32, 6, 16, 2, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(641), 1, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(646), 0, 3659.0, 16, 256.0, 0 },
                    { 34, 6, 16, 2, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(664), 1, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(669), 1, 911.0, 8, 256.0, 0 },
                    { 41, 7, 24, 0, 32, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(744), 64, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(749), 0, 5300.0, 128, 1024.0, 1 },
                    { 36, 6, 16, 2, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(687), 1, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(691), 0, 821.0, 8, 256.0, 0 },
                    { 37, 7, 24, 2, 32, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(698), 64, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(703), 1, 4200.0, 128, 1024.0, 0 },
                    { 38, 7, 24, 2, 32, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(709), 64, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(714), 0, 4300.0, 128, 1024.0, 1 },
                    { 39, 7, 24, 2, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(721), 64, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(726), 0, 4500.0, 8, 1024.0, 0 },
                    { 40, 7, 24, 0, 32, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(732), 64, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(737), 1, 4900.0, 128, 1024.0, 0 },
                    { 25, 6, 16, 2, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(554), 1, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(562), 1, 1499.0, 16, 256.0, 1 },
                    { 42, 7, 24, 0, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(756), 64, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(761), 0, 5500.0, 8, 1024.0, 0 },
                    { 43, 7, 24, 1, 32, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(767), 64, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(772), 1, 5210.0, 128, 1024.0, 0 },
                    { 44, 7, 24, 1, 32, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(777), 64, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(783), 0, 5600.0, 128, 1024.0, 1 },
                    { 45, 7, 24, 1, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(788), 64, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(793), 0, 4100.0, 8, 1024.0, 0 },
                    { 35, 6, 16, 2, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(675), 1, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(680), 0, 919.0, 8, 256.0, 1 },
                    { 24, 6, 16, 1, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(544), 1, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(548), 0, 809.0, 8, 256.0, 0 },
                    { 18, 6, 16, 1, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(478), 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(483), 1, 3901.0, 16, 256.0, 0 },
                    { 22, 6, 16, 1, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(522), 1, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(526), 1, 909.0, 8, 256.0, 0 },
                    { 1, 6, 16, 0, 4, new DateTime(2020, 6, 3, 15, 19, 39, 809, DateTimeKind.Local).AddTicks(3178), 1, new DateTime(2020, 6, 3, 15, 19, 39, 809, DateTimeKind.Local).AddTicks(3266), 1, 1500.0, 16, 256.0, 1 },
                    { 2, 6, 16, 0, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(75), 1, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(134), 1, 1250.0, 16, 256.0, 0 },
                    { 3, 6, 16, 0, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(295), 1, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(304), 0, 1650.0, 16, 256.0, 1 },
                    { 4, 6, 16, 0, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(311), 1, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(317), 0, 1400.0, 16, 256.0, 0 },
                    { 5, 6, 16, 0, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(324), 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(330), 1, 4000.0, 16, 256.0, 1 },
                    { 6, 6, 16, 0, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(336), 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(342), 1, 3800.0, 16, 256.0, 0 },
                    { 7, 6, 16, 0, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(349), 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(355), 0, 3600.0, 16, 256.0, 1 },
                    { 23, 6, 16, 1, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(532), 1, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(538), 0, 869.0, 8, 256.0, 1 },
                    { 9, 6, 16, 0, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(374), 1, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(378), 1, 850.0, 8, 256.0, 1 },
                    { 10, 6, 16, 0, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(384), 1, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(389), 1, 900.0, 8, 256.0, 0 },
                    { 8, 6, 16, 0, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(362), 1, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(367), 0, 3750.0, 16, 256.0, 0 },
                    { 12, 6, 16, 0, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(406), 1, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(411), 0, 800.0, 8, 256.0, 0 },
                    { 13, 6, 16, 1, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(417), 1, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(423), 1, 1509.0, 16, 256.0, 1 },
                    { 14, 6, 16, 1, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(429), 1, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(436), 1, 1350.0, 16, 256.0, 0 },
                    { 15, 6, 16, 1, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(443), 1, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(448), 0, 1652.0, 16, 256.0, 1 },
                    { 16, 6, 16, 1, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(454), 1, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(460), 0, 1389.0, 16, 256.0, 0 },
                    { 17, 6, 16, 1, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(467), 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(472), 1, 3800.0, 16, 256.0, 1 },
                    { 19, 6, 16, 1, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(490), 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(495), 0, 3609.0, 16, 256.0, 1 },
                    { 20, 6, 16, 1, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(501), 1, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(506), 0, 3759.0, 16, 256.0, 0 },
                    { 21, 6, 16, 1, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(512), 1, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(517), 1, 950.0, 8, 256.0, 1 },
                    { 11, 6, 16, 0, 4, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(395), 1, new DateTime(2020, 6, 3, 15, 19, 39, 810, DateTimeKind.Local).AddTicks(400), 0, 887.0, 8, 256.0, 1 }
                });

            migrationBuilder.InsertData(
                table: "NewsPost",
                columns: new[] { "Id", "Content", "Created", "Image", "Modified", "Subtitle", "Title" },
                values: new object[,]
                {
                    { 1, "Google Cloud has brokered another partnership in its exploration of blockchain technologies, with the company joining the enterprise program of blockchain-based video delivery network Theta Labs. Google has joined the grandly-named Enterprise Validator Program, alongside Binance, Blockchain Ventures, and Gumi, which ‘allows enterprises to validate transactions in accordance with Theta’s underlying consensus protocol’, in its own words. Theta’s business case is to broadly put together a decentralised content delivery network (CDN), which will aim to solve the problems of combining high quality data throughput with no buffering, as well as giving more revenues to content creators rather than arbiters. Blockchain comes in through what the company calls ‘Theta fuel’ – tokens on which a value exchange is based between viewer and video platform. Theta and its partners in the media and entertainment, telecom, technology and gaming industries thus provide a high performance decentralised micropayment network that scales to millions of concurrent video viewers,” Theta wrote in a Medium post.  Google Cloud’s role will be to provide ‘stability, reliability and security’ to the Theta network, in the company’s words. Distributed ledger technology enables new business models that potentially transform the global digital economy, including the media and entertainment industry, said Allen Day, Google Cloud developer advocate. We look forward to participating as an enterprise validator, and to providing Google Cloud infrastructure in support of Theta’s long-term mission and future growth.", new DateTime(2020, 6, 3, 15, 19, 39, 822, DateTimeKind.Local).AddTicks(6817), null, new DateTime(2020, 6, 3, 15, 19, 39, 822, DateTimeKind.Local).AddTicks(6893), null, "Google Cloud teams up with Theta Labs for blockchain-based video delivery" },
                    { 2, "The coronavirus pandemic has magnified the importance of cloud-based technologies in major, life-altering ways and ushered in a new paradigm. Before COVID-19, experts projected the worldwide public cloud services market would jump by 17% this year, reaching $266.4 million. Software as a service is the largest segment within that market, but the second-largest — infrastructure as a service — claims the fastest growth rate.A number of factors are driving businesses to choose the cloud as the standard for applications, data, and storage. They migrate to gain flexible computing power, to lower the cost of backup/recovery, or to turn capital expenses into operational costs. Beyond any single benefit, however, companies migrate to facilitate organisational change in ways that only the cloud can offer.Take artificial intelligence as just one example. Companies that have already implemented AI saw an uptick in revenue, and 44% experienced a reduction in costs. Executives across industries want (and need) to use this technology effectively, and that’s possible from a technical and logistical standpoint only if the technology runs out of the cloud. To put it simply, the cloud is where the future happens, meaning companies either migrate or get left behind.", new DateTime(2020, 6, 3, 15, 19, 39, 822, DateTimeKind.Local).AddTicks(8173), null, new DateTime(2020, 6, 3, 15, 19, 39, 822, DateTimeKind.Local).AddTicks(8190), null, "Covid-19 has hastened cloud migration – but don’t move without a plan" },
                    { 3, "Cloud providers need to proactively support their customers through the tail end of the Covid-19 pandemic. They can do this by demonstrating the strength and adaptability of their service offerings. Covid-19 has left many organisations unsure if their business continuity strategy is sufficiently robust, particularly when it comes to cloud services. The reliance on videoconferencing and collaboration tools has stressed the limits of back-end supporting services, while also increasing network traffic volume. However, cloud providers with robust and excess infrastructure, combined with disaster recovery plans to respond to such a crisis, are successfully managing in this new normal. As IT leaders begin to consider longer-term cloud solutions to support the new portion of their workforce remaining remote, they are facing challenging questions about the resiliency and dependability of cloud services. At the same time as Covid-19 has pushed cloud to the spotlight, it has put providers in a unique position to reassure customers of their strength and adaptability.The providers who will fail at this time are the ones still tackling the debate of on-premises data centres vs cloud. Customers are now asking about the adaptability of their current cloud service that they have been forced to adopt if they decided to continue using it post pandemic.", new DateTime(2020, 6, 3, 15, 19, 39, 822, DateTimeKind.Local).AddTicks(8218), null, new DateTime(2020, 6, 3, 15, 19, 39, 822, DateTimeKind.Local).AddTicks(8222), null, "Gartner: How and why cloud providers need to support their customers through Covid-19" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "Modified", "Password" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 3, 15, 19, 39, 788, DateTimeKind.Local).AddTicks(711), "admin@test.com", "Admin", "Ad", new DateTime(2020, 6, 3, 15, 19, 39, 791, DateTimeKind.Local).AddTicks(1160), "10000.7mSNp+Oapzv2iVbiybMmSA==.TjfFGVah1ko7+nrYvgKIBwpJGGgVzRz2BcG24jUBMiE=" },
                    { 2, new DateTime(2020, 6, 3, 15, 19, 39, 791, DateTimeKind.Local).AddTicks(4593), "test@test.com", "Test", "Testic", new DateTime(2020, 6, 3, 15, 19, 39, 791, DateTimeKind.Local).AddTicks(4627), "10000.7mSNp+Oapzv2iVbiybMmSA==.TjfFGVah1ko7+nrYvgKIBwpJGGgVzRz2BcG24jUBMiE=" }
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
