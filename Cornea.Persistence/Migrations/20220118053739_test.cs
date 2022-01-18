using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cornea.Persistence.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    LabName = table.Column<string>(nullable: true),
                    Number = table.Column<long>(nullable: true),
                    ProductName = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    SaleDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Factors",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FactorNumber = table.Column<string>(nullable: false),
                    ProductName = table.Column<string>(nullable: false),
                    Number = table.Column<long>(nullable: false),
                    Price = table.Column<string>(nullable: false),
                    Issuancedate = table.Column<DateTime>(type: "date", nullable: false),
                    Imagedir = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<string>(nullable: false),
                    Number = table.Column<string>(nullable: false),
                    Imagedir = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    Priority = table.Column<string>(nullable: false),
                    StartTime = table.Column<DateTime>(type: "date", nullable: false),
                    FinishTime = table.Column<DateTime>(type: "date", nullable: false),
                    Message = table.Column<string>(nullable: true),
                    PassedTime = table.Column<long>(nullable: true),
                    Timeline = table.Column<long>(nullable: true),
                    Percent = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "LoginInfo",
                columns: table => new
                {
                    UserId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<long>(nullable: false),
                    UserName = table.Column<string>(maxLength: 20, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    Password = table.Column<string>(maxLength: 100, nullable: true),
                    Fullname = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(type: "date", nullable: true),
                    HireDay = table.Column<DateTime>(type: "date", nullable: true),
                    Imagedir = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    University = table.Column<string>(nullable: true),
                    DegreeLevel = table.Column<string>(nullable: true),
                    Company = table.Column<string>(nullable: true),
                    Specialization = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    LastjobDescription = table.Column<string>(nullable: true),
                    StartEducationTime = table.Column<string>(nullable: true),
                    FinishEducationTime = table.Column<string>(nullable: true),
                    StartLastjobTime = table.Column<string>(nullable: true),
                    FinishLastjobTime = table.Column<string>(nullable: true),
                    AdditionalInfo = table.Column<string>(nullable: true),
                    Resumedir = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginInfo", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_LoginInfo_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AllTasks",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(nullable: false),
                    ProjectName = table.Column<string>(nullable: false),
                    TaskName = table.Column<string>(nullable: false),
                    Owner = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    Priority = table.Column<string>(nullable: false),
                    StartTime = table.Column<DateTime>(type: "date", nullable: false),
                    FinishTime = table.Column<DateTime>(type: "date", nullable: false),
                    Message = table.Column<string>(nullable: true),
                    PassedTime = table.Column<long>(nullable: true),
                    Timeline = table.Column<long>(nullable: true),
                    Percent = table.Column<long>(nullable: true),
                    Filedir = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AllTasks_LoginInfo_UserId",
                        column: x => x.UserId,
                        principalTable: "LoginInfo",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName" },
                values: new object[] { 1L, "Manager" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName" },
                values: new object[] { 2L, "Employee" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName" },
                values: new object[] { 3L, "Finance" });

            migrationBuilder.CreateIndex(
                name: "IX_AllTasks_UserId",
                table: "AllTasks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LoginInfo_RoleId",
                table: "LoginInfo",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_LoginInfo_UserName",
                table: "LoginInfo",
                column: "UserName",
                unique: true,
                filter: "[UserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllTasks");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Factors");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "LoginInfo");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
