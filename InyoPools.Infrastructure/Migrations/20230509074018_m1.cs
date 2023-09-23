using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InyoPools.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ec51600-e382-4b45-bd7f-710dc2d876ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e2a8eaa-b409-4ef2-b9ef-00fdfc106963");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffa535a1-1cb1-455c-b65e-ab9565c60b6f");

            migrationBuilder.CreateTable(
                name: "manufacturers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoPublicDisplayOfMfg = table.Column<bool>(type: "bit", nullable: false),
                    NoDisplayPopularItems = table.Column<bool>(type: "bit", nullable: false),
                    NoDisplayToVendors = table.Column<bool>(type: "bit", nullable: false),
                    AbbrDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_manufacturers", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "21edf113-358b-49e9-8f97-10d776f9f5db", "1", "Admin", "Admin" },
                    { "68f9481d-958f-48c6-9e76-12f9e3c759e7", "3", "HR", "HR" },
                    { "e4b59f17-89bf-4d6f-a6c7-ff7af99da61f", "2", "User", "User" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "manufacturers");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ec51600-e382-4b45-bd7f-710dc2d876ad", "2", "User", "User" },
                    { "1e2a8eaa-b409-4ef2-b9ef-00fdfc106963", "1", "Admin", "Admin" },
                    { "ffa535a1-1cb1-455c-b65e-ab9565c60b6f", "3", "HR", "HR" }
                });
        }
    }
}
