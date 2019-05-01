using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Optivem.Northwind.Infrastructure.Domain.Repositories.EntityFrameworkCore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
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
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
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
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InventoryTransactionType",
                columns: table => new
                {
                    Id = table.Column<byte>(nullable: false),
                    Code = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryTransactionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetailStatus",
                columns: table => new
                {
                    Id = table.Column<byte>(nullable: false),
                    Code = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetailStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatus",
                columns: table => new
                {
                    Id = table.Column<byte>(nullable: false),
                    Code = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderTaxStatus",
                columns: table => new
                {
                    Id = table.Column<byte>(nullable: false),
                    Code = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderTaxStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Privilege",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PrivilegeName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Privilege", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SupplierId = table.Column<string>(nullable: false),
                    ProductCode = table.Column<string>(maxLength: 25, nullable: false),
                    ProductName = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(nullable: false),
                    StandardCost = table.Column<decimal>(type: "money", nullable: false),
                    ListPrice = table.Column<decimal>(type: "money", nullable: false),
                    ReorderLevel = table.Column<short>(nullable: false),
                    TargetLevel = table.Column<int>(nullable: false),
                    QuantityPerUnit = table.Column<string>(maxLength: 50, nullable: false),
                    Discontinued = table.Column<bool>(nullable: false),
                    MinimumReorderQuantity = table.Column<short>(nullable: false),
                    Category = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrderStatus",
                columns: table => new
                {
                    Id = table.Column<byte>(nullable: false),
                    Code = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrderStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shipper",
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
                    table.PrimaryKey("PK_Shipper", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
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
                    table.PrimaryKey("PK_Supplier", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeePrivilege",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeId = table.Column<int>(nullable: false),
                    PrivilegeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePrivilege", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeePrivilege_Employee",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeePrivilege_Privilege",
                        column: x => x.PrivilegeId,
                        principalTable: "Privilege",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ShippedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ShipperId = table.Column<int>(nullable: false),
                    ShipName = table.Column<string>(maxLength: 50, nullable: false),
                    ShipAddress = table.Column<string>(nullable: false),
                    ShipCity = table.Column<string>(maxLength: 50, nullable: false),
                    ShipStateProvince = table.Column<string>(maxLength: 50, nullable: false),
                    ShipZipPostalCode = table.Column<string>(maxLength: 50, nullable: false),
                    ShipCountryRegion = table.Column<string>(maxLength: 50, nullable: false),
                    ShippingFee = table.Column<decimal>(type: "money", nullable: false),
                    Taxes = table.Column<decimal>(type: "money", nullable: false),
                    PaymentType = table.Column<string>(maxLength: 50, nullable: false),
                    PaidDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    TaxRate = table.Column<double>(nullable: false),
                    TaxStatusId = table.Column<byte>(nullable: false),
                    StatusId = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Customer",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Employee",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Shipper",
                        column: x => x.ShipperId,
                        principalTable: "Shipper",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_OrderStatus",
                        column: x => x.StatusId,
                        principalTable: "OrderStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_OrderTaxStatus",
                        column: x => x.TaxStatusId,
                        principalTable: "OrderTaxStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrder",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SupplierId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    SubmittedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    StatusId = table.Column<byte>(nullable: false),
                    ExpectedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ShippingFee = table.Column<decimal>(type: "money", nullable: false),
                    Taxes = table.Column<decimal>(type: "money", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    PaymentAmount = table.Column<decimal>(type: "money", nullable: false),
                    PaymentMethod = table.Column<string>(maxLength: 50, nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    ApprovedBy = table.Column<int>(nullable: false),
                    ApprovedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    SubmittedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_Employee",
                        column: x => x.CreatedBy,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_PurchaseOrderStatus",
                        column: x => x.StatusId,
                        principalTable: "PurchaseOrderStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_Supplier",
                        column: x => x.SupplierId,
                        principalTable: "Supplier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(nullable: false),
                    InvoiceDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Tax = table.Column<decimal>(type: "money", nullable: false),
                    Shipping = table.Column<decimal>(type: "money", nullable: false),
                    AmountDue = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoice_Order",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18, 4)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "money", nullable: false),
                    Discount = table.Column<double>(nullable: false),
                    StatusId = table.Column<byte>(nullable: false),
                    DateAllocated = table.Column<DateTime>(type: "datetime", nullable: false),
                    PurchaseOrderId = table.Column<int>(nullable: false),
                    InventoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Product",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetail_OrderDetailStatus",
                        column: x => x.StatusId,
                        principalTable: "OrderDetailStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InventoryTransaction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TransactionTypeId = table.Column<byte>(nullable: false),
                    TransactionCreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    TransactionModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    PurchaseOrderId = table.Column<int>(nullable: false),
                    CustomerOrderId = table.Column<int>(nullable: false),
                    Comments = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryTransaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InventoryTransaction_Order",
                        column: x => x.CustomerOrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventoryTransaction_Product",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventoryTransaction_PurchaseOrder",
                        column: x => x.PurchaseOrderId,
                        principalTable: "PurchaseOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventoryTransaction_InventoryTransactionType",
                        column: x => x.TransactionTypeId,
                        principalTable: "InventoryTransactionType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrderDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PurchaseOrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18, 4)", nullable: false),
                    UnitCost = table.Column<decimal>(type: "money", nullable: false),
                    DateReceived = table.Column<DateTime>(type: "datetime", nullable: false),
                    PostedToInventory = table.Column<bool>(nullable: false),
                    InventoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrderDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderDetail_InventoryTransaction",
                        column: x => x.InventoryId,
                        principalTable: "InventoryTransaction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderDetail_Product",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderDetail_PurchaseOrder",
                        column: x => x.PurchaseOrderId,
                        principalTable: "PurchaseOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePrivilege_EmployeeId",
                table: "EmployeePrivilege",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePrivilege_PrivilegeId",
                table: "EmployeePrivilege",
                column: "PrivilegeId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryTransaction_CustomerOrderId",
                table: "InventoryTransaction",
                column: "CustomerOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryTransaction_ProductId",
                table: "InventoryTransaction",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryTransaction_PurchaseOrderId",
                table: "InventoryTransaction",
                column: "PurchaseOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryTransaction_TransactionTypeId",
                table: "InventoryTransaction",
                column: "TransactionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_OrderId",
                table: "Invoice",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_EmployeeId",
                table: "Order",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ShipperId",
                table: "Order",
                column: "ShipperId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_StatusId",
                table: "Order",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_TaxStatusId",
                table: "Order",
                column: "TaxStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductId",
                table: "OrderDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_StatusId",
                table: "OrderDetail",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_CreatedBy",
                table: "PurchaseOrder",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_StatusId",
                table: "PurchaseOrder",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_SupplierId",
                table: "PurchaseOrder",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderDetail_InventoryId",
                table: "PurchaseOrderDetail",
                column: "InventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderDetail_ProductId",
                table: "PurchaseOrderDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderDetail_PurchaseOrderId",
                table: "PurchaseOrderDetail",
                column: "PurchaseOrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeePrivilege");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "PurchaseOrderDetail");

            migrationBuilder.DropTable(
                name: "Privilege");

            migrationBuilder.DropTable(
                name: "OrderDetailStatus");

            migrationBuilder.DropTable(
                name: "InventoryTransaction");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "PurchaseOrder");

            migrationBuilder.DropTable(
                name: "InventoryTransactionType");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Shipper");

            migrationBuilder.DropTable(
                name: "OrderStatus");

            migrationBuilder.DropTable(
                name: "OrderTaxStatus");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "PurchaseOrderStatus");

            migrationBuilder.DropTable(
                name: "Supplier");
        }
    }
}