using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InyoPools.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class m5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3efe3c27-872e-410c-909e-0b92a123b5fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81ccc865-fdd4-4eff-b6aa-cdcfa25d74ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6dd774f-1437-429c-8867-cde34ddaa692");

            migrationBuilder.CreateTable(
                name: "EmailTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailBcc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailSubject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailBody = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailTransactionTypeID = table.Column<int>(type: "int", nullable: false),
                    DelaySendMinutes = table.Column<int>(type: "int", nullable: true),
                    UseNewTemplate = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailTypes", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6c3f125e-2cc2-4739-bd6c-d70db12a334d", "3", "HR", "HR" },
                    { "6da1e379-1605-4364-8321-afbe05e19810", "1", "Admin", "Admin" },
                    { "effa0287-bf85-409b-bc0f-d445b9477fe6", "2", "User", "User" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailTypes");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c3f125e-2cc2-4739-bd6c-d70db12a334d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6da1e379-1605-4364-8321-afbe05e19810");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "effa0287-bf85-409b-bc0f-d445b9477fe6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3efe3c27-872e-410c-909e-0b92a123b5fb", "1", "Admin", "Admin" },
                    { "81ccc865-fdd4-4eff-b6aa-cdcfa25d74ed", "3", "HR", "HR" },
                    { "a6dd774f-1437-429c-8867-cde34ddaa692", "2", "User", "User" }
                });
        }
    }
}
