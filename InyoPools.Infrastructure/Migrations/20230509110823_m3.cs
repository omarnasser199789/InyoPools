using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InyoPools.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class m3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subscribed = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsINYOPool = table.Column<bool>(type: "bit", nullable: false),
                    IsINYOWinter = table.Column<bool>(type: "bit", nullable: false),
                    BypassCVVCheck = table.Column<bool>(type: "bit", nullable: false),
                    QandAQuestionOptOut = table.Column<bool>(type: "bit", nullable: false),
                    LastOnlineChatDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastSubscribedChangeDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastSubscribedNewsletterGroupTypeId = table.Column<int>(type: "int", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastBounceDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastComplaintDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastEmailChangeDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastSubscribedNewsletterGroupChangeDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    FraudReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FraudReportedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FraudStatusId = table.Column<int>(type: "int", nullable: true),
                    FraudReportedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0488802e-593d-4a80-94ef-1f32933a0391", "1", "Admin", "Admin" },
                    { "1f13ad54-a6f3-4d3a-8657-677f5a8916ec", "2", "User", "User" },
                    { "2e8715ad-bd78-4f09-9b50-0763c3e09492", "3", "HR", "HR" }
                });
        }
    }
}
