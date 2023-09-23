using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InyoPools.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_testCategories_testCategories_ParentID",
                table: "testCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_testCategories",
                table: "testCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_productTypes",
                table: "productTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_manufacturers",
                table: "manufacturers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21edf113-358b-49e9-8f97-10d776f9f5db");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68f9481d-958f-48c6-9e76-12f9e3c759e7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4b59f17-89bf-4d6f-a6c7-ff7af99da61f");

            migrationBuilder.RenameTable(
                name: "testCategories",
                newName: "TestCategories");

            migrationBuilder.RenameTable(
                name: "productTypes",
                newName: "ProductTypes");

            migrationBuilder.RenameTable(
                name: "manufacturers",
                newName: "Manufacturers");

            migrationBuilder.RenameIndex(
                name: "IX_testCategories_ParentID",
                table: "TestCategories",
                newName: "IX_TestCategories_ParentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TestCategories",
                table: "TestCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTypes",
                table: "ProductTypes",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Manufacturers",
                table: "Manufacturers",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "emailLogs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailSubject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateSent = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmailTransactionTypeID = table.Column<int>(type: "int", nullable: true),
                    EmailBody = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailBcc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    QuoteId = table.Column<int>(type: "int", nullable: true),
                    OriginalEmailLogId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emailLogs", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0488802e-593d-4a80-94ef-1f32933a0391", "1", "Admin", "Admin" },
                    { "1f13ad54-a6f3-4d3a-8657-677f5a8916ec", "2", "User", "User" },
                    { "2e8715ad-bd78-4f09-9b50-0763c3e09492", "3", "HR", "HR" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_TestCategories_TestCategories_ParentID",
                table: "TestCategories",
                column: "ParentID",
                principalTable: "TestCategories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestCategories_TestCategories_ParentID",
                table: "TestCategories");

            migrationBuilder.DropTable(
                name: "emailLogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TestCategories",
                table: "TestCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTypes",
                table: "ProductTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Manufacturers",
                table: "Manufacturers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0488802e-593d-4a80-94ef-1f32933a0391");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f13ad54-a6f3-4d3a-8657-677f5a8916ec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e8715ad-bd78-4f09-9b50-0763c3e09492");

            migrationBuilder.RenameTable(
                name: "TestCategories",
                newName: "testCategories");

            migrationBuilder.RenameTable(
                name: "ProductTypes",
                newName: "productTypes");

            migrationBuilder.RenameTable(
                name: "Manufacturers",
                newName: "manufacturers");

            migrationBuilder.RenameIndex(
                name: "IX_TestCategories_ParentID",
                table: "testCategories",
                newName: "IX_testCategories_ParentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_testCategories",
                table: "testCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_productTypes",
                table: "productTypes",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_manufacturers",
                table: "manufacturers",
                column: "ID");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "21edf113-358b-49e9-8f97-10d776f9f5db", "1", "Admin", "Admin" },
                    { "68f9481d-958f-48c6-9e76-12f9e3c759e7", "3", "HR", "HR" },
                    { "e4b59f17-89bf-4d6f-a6c7-ff7af99da61f", "2", "User", "User" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_testCategories_testCategories_ParentID",
                table: "testCategories",
                column: "ParentID",
                principalTable: "testCategories",
                principalColumn: "Id");
        }
    }
}
