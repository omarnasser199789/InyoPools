using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InyoPools.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class adorderformheder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "OrdersFormHeader",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderGroupID = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderFormDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderStatusID = table.Column<int>(type: "int", nullable: false),
                    VendorID = table.Column<int>(type: "int", nullable: false),
                    VendorDateApproved = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VendorDateAccepted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VendorDateShipped = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VendorAccepted = table.Column<bool>(type: "bit", nullable: false),
                    Vendor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactCompany = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactAddress1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactAddress2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactZip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactFax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillToFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillToLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillToCompany = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillToAddress1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillToAddress2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillToCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillToState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillToCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillToZip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillToPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillToFax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillToEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillOptionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipToFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipToLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipToCompany = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipToAddress1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipToAddress2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipToCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipToState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipToCountr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipToZip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipToPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipToFax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipToEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvoiceStatusID = table.Column<int>(type: "int", nullable: false),
                    InvoiceStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillingTypeID = table.Column<int>(type: "int", nullable: false),
                    CCNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CCID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CCExpDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CCNameOnCard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BAAccountName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BABankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BARoutingNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BAAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BACheckNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillTotal = table.Column<double>(type: "float", nullable: false),
                    Subtotal = table.Column<double>(type: "float", nullable: false),
                    TaxRate = table.Column<double>(type: "float", nullable: false),
                    Shipping = table.Column<double>(type: "float", nullable: false),
                    Handling = table.Column<double>(type: "float", nullable: false),
                    ShipMethodID = table.Column<int>(type: "int", nullable: false),
                    ShipMethodDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipTotal = table.Column<double>(type: "float", nullable: false),
                    HandlingTotal = table.Column<double>(type: "float", nullable: false),
                    Tax = table.Column<double>(type: "float", nullable: false),
                    PPUserID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxCertificateNum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxCertificateOnFile = table.Column<bool>(type: "bit", nullable: false),
                    TaxCertificateExpDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UseTaxCertificate = table.Column<bool>(type: "bit", nullable: false),
                    OrderItems = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PONumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthAmount = table.Column<double>(type: "float", nullable: false),
                    AuthTransID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthCaptured = table.Column<bool>(type: "bit", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    TransMethodID = table.Column<int>(type: "int", nullable: false),
                    BillOptionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommissionPct = table.Column<double>(type: "float", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderStatusPublic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceLevelID = table.Column<int>(type: "int", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    OrderError = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UploadOrderNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersFormHeader", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "22a85fef-36b0-443a-86da-21a35ece44c9", "1", "Admin", "Admin" },
                    { "99c6218b-ef48-4cdc-bebc-48ef87fd5362", "3", "HR", "HR" },
                    { "d1aa3649-95d8-4470-8999-84fb89bcf526", "2", "User", "User" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdersFormHeader");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22a85fef-36b0-443a-86da-21a35ece44c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99c6218b-ef48-4cdc-bebc-48ef87fd5362");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1aa3649-95d8-4470-8999-84fb89bcf526");

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
    }
}
