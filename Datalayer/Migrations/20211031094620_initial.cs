using Microsoft.EntityFrameworkCore.Migrations;

namespace Datalayer.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zipcode = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    ManufacturerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.ManufacturerId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerLocation",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerLocation", x => new { x.CustomerId, x.LocationId });
                    table.ForeignKey(
                        name: "FK_CustomerLocation_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerLocation_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ManufacturerLocation",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    ManufacturerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManufacturerLocation", x => new { x.ManufacturerId, x.LocationId });
                    table.ForeignKey(
                        name: "FK_ManufacturerLocation_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ManufacturerLocation_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "ManufacturerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Hidden = table.Column<bool>(type: "bit", nullable: false),
                    ManufacturerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "ManufacturerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImage",
                columns: table => new
                {
                    ProductImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImage", x => x.ProductImageId);
                    table.ForeignKey(
                        name: "FK_ProductImage_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductOrder",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOrder", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductOrder_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductOrder_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Email", "FirstName", "LastName" },
                values: new object[] { 1, "Ole@eksample.dk", "Ole", "Sigurd" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "Address", "City", "Country", "Zipcode" },
                values: new object[,]
                {
                    { 1, "Hilmarfinsensgade 12", "Sønderborg", "Denmark", 6400 },
                    { 2, "Bredgade 33", "Aabenraa", "Denmark", 6200 },
                    { 3, "Landevejen 144", "Aalborg", "Denmark", 9029 }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "ManufacturerId", "Name" },
                values: new object[,]
                {
                    { 1, "Euc syd" },
                    { 2, "Aabenraa maskinfabrik" },
                    { 3, "Raspberrypi.dk" }
                });

            migrationBuilder.InsertData(
                table: "CustomerLocation",
                columns: new[] { "CustomerId", "LocationId" },
                values: new object[] { 1, 3 });

            migrationBuilder.InsertData(
                table: "ManufacturerLocation",
                columns: new[] { "LocationId", "ManufacturerId" },
                values: new object[,]
                {
                    { 2, 3 },
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CustomerId", "TotalPrice" },
                values: new object[] { 1, 1, 100.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "Hidden", "ManufacturerId", "Name", "Price" },
                values: new object[,]
                {
                    { 3, "This product is 74% better then the original", false, 1, "Raspberry pi 44", 0.6008433716375583 },
                    { 20, "This product is 10% better then the original", false, 1, "Raspberry pi 17", 0.88460101414686121 },
                    { 19, "This product is 56% better then the original", false, 1, "Raspberry pi 70", 0.95362494371534556 },
                    { 18, "This product is 92% better then the original", false, 1, "Raspberry pi 62", 0.38221089978805317 },
                    { 17, "This product is 84% better then the original", false, 1, "Raspberry pi 68", 0.24547895428048397 },
                    { 16, "This product is 64% better then the original", false, 1, "Raspberry pi 64", 0.052567358618866356 },
                    { 15, "This product is 64% better then the original", false, 1, "Raspberry pi 5", 0.26485338120947283 },
                    { 14, "This product is 35% better then the original", false, 1, "Raspberry pi 93", 0.090230986983622891 },
                    { 13, "This product is 91% better then the original", false, 1, "Raspberry pi 67", 0.63951263466827224 },
                    { 12, "This product is 89% better then the original", false, 1, "Raspberry pi 92", 0.9797203410322407 },
                    { 11, "This product is 16% better then the original", false, 1, "Raspberry pi 99", 0.12596092285865962 },
                    { 1, "This product is 27% better then the original", false, 1, "Raspberry pi 51", 0.064442106086966627 },
                    { 9, "This product is 64% better then the original", false, 1, "Raspberry pi 15", 0.20476716067863962 },
                    { 8, "This product is 39% better then the original", false, 1, "Raspberry pi 50", 0.16150921590696518 },
                    { 7, "This product is 23% better then the original", false, 1, "Raspberry pi 77", 0.43558739797938029 },
                    { 6, "This product is 42% better then the original", false, 1, "Raspberry pi 12", 0.95120598746054152 },
                    { 5, "This product is 19% better then the original", false, 1, "Raspberry pi 9", 0.48301145456871553 },
                    { 4, "This product is 33% better then the original", false, 1, "Raspberry pi 88", 0.1613166752091221 },
                    { 2, "This product is 55% better then the original", false, 1, "Raspberry pi 49", 0.19485148703439695 },
                    { 10, "This product is 70% better then the original", false, 1, "Raspberry pi 24", 0.65246497125013958 }
                });

            migrationBuilder.InsertData(
                table: "ProductImage",
                columns: new[] { "ProductImageId", "ImageName", "ImagePath", "ProductId" },
                values: new object[,]
                {
                    { 1, "Pi70", "Pi7.jpg", 1 },
                    { 29, "Pi47", "Pi6.jpg", 19 },
                    { 28, "Pi34", "Pi2.jpg", 18 },
                    { 27, "Pi30", "Pi4.jpg", 17 },
                    { 26, "Pi98", "Pi1.jpg", 17 },
                    { 25, "Pi70", "Pi2.jpg", 16 },
                    { 24, "Pi85", "Pi7.jpg", 16 },
                    { 23, "Pi18", "Pi4.jpg", 15 },
                    { 22, "Pi57", "Pi1.jpg", 15 },
                    { 21, "Pi45", "Pi3.jpg", 14 },
                    { 20, "Pi97", "Pi5.jpg", 14 },
                    { 19, "Pi55", "Pi1.jpg", 13 },
                    { 18, "Pi33", "Pi7.jpg", 12 },
                    { 17, "Pi1", "Pi6.jpg", 11 },
                    { 30, "Pi36", "Pi7.jpg", 19 },
                    { 16, "Pi62", "Pi5.jpg", 11 },
                    { 14, "Pi71", "Pi7.jpg", 9 },
                    { 13, "Pi61", "Pi3.jpg", 9 },
                    { 12, "Pi92", "Pi7.jpg", 8 },
                    { 11, "Pi38", "Pi7.jpg", 8 },
                    { 10, "Pi91", "Pi7.jpg", 7 },
                    { 9, "Pi36", "Pi6.jpg", 7 },
                    { 8, "Pi9", "Pi4.jpg", 6 },
                    { 7, "Pi46", "Pi2.jpg", 5 },
                    { 6, "Pi23", "Pi1.jpg", 4 },
                    { 5, "Pi16", "Pi5.jpg", 3 },
                    { 4, "Pi72", "Pi5.jpg", 2 },
                    { 3, "Pi43", "Pi2.jpg", 2 },
                    { 2, "Pi58", "Pi1.jpg", 1 },
                    { 15, "Pi12", "Pi7.jpg", 10 },
                    { 31, "Pi66", "Pi7.jpg", 20 }
                });

            migrationBuilder.InsertData(
                table: "ProductOrder",
                columns: new[] { "OrderId", "ProductId", "Amount" },
                values: new object[] { 1, 16, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerLocation_LocationId",
                table: "CustomerLocation",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_ManufacturerLocation_LocationId",
                table: "ManufacturerLocation",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_ProductId",
                table: "ProductImage",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrder_ProductId",
                table: "ProductOrder",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ManufacturerId",
                table: "Products",
                column: "ManufacturerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerLocation");

            migrationBuilder.DropTable(
                name: "ManufacturerLocation");

            migrationBuilder.DropTable(
                name: "ProductImage");

            migrationBuilder.DropTable(
                name: "ProductOrder");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Manufacturers");
        }
    }
}
