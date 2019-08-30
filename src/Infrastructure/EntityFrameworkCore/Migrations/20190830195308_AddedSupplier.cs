using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Optivem.Northwind.Infrastructure.EntityFrameworkCore.Migrations
{
    public partial class AddedSupplier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetailRecord_Product_ProductId",
                table: "OrderDetailRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderRecord_Customer_CustomerId",
                table: "OrderRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Company = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    EmailAddress = table.Column<string>(maxLength: 50, nullable: false),
                    JobTitle = table.Column<string>(maxLength: 50, nullable: false),
                    BusinessPhone = table.Column<string>(maxLength: 25, nullable: false),
                    HomePhone = table.Column<string>(maxLength: 25, nullable: true),
                    MobilePhone = table.Column<string>(maxLength: 25, nullable: false),
                    FaxNumber = table.Column<string>(maxLength: 25, nullable: true),
                    Address = table.Column<string>(nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    StateProvince = table.Column<string>(maxLength: 50, nullable: false),
                    ZipPostalCode = table.Column<string>(maxLength: 15, nullable: false),
                    CountryRegion = table.Column<string>(maxLength: 50, nullable: false),
                    WebPage = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetailRecord_Products_ProductId",
                table: "OrderDetailRecord",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderRecord_Customers_CustomerId",
                table: "OrderRecord",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetailRecord_Products_ProductId",
                table: "OrderDetailRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderRecord_Customers_CustomerId",
                table: "OrderRecord");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetailRecord_Product_ProductId",
                table: "OrderDetailRecord",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderRecord_Customer_CustomerId",
                table: "OrderRecord",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
