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
                name: "Location",
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
                    table.PrimaryKey("PK_Location", x => x.LocationId);
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
                        name: "FK_CustomerLocation_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
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
                        name: "FK_ManufacturerLocation_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
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
                    OrderId = table.Column<int>(type: "int", nullable: false)
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
                table: "Location",
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
                    { 2, "Aabenraa makinfabrik" }
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
                    { 2, 2 },
                    { 1, 1 }
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
                    { 2, "This product is an Awesome piece of craftsmanship", false, 1, "Product8184", 0.82861133004939713 },
                    { 19, "This product is an Awesome piece of craftsmanship", false, 1, "Product9961", 0.46216725207034837 },
                    { 18, "This product is an Awesome piece of craftsmanship", false, 1, "Product1441", 0.42984472281757963 },
                    { 17, "This product is an Awesome piece of craftsmanship", false, 1, "Product8353", 0.21315525714920613 },
                    { 16, "This product is an Awesome piece of craftsmanship", false, 1, "Product2588", 0.58267959746656917 },
                    { 15, "This product is an Awesome piece of craftsmanship", false, 1, "Product1510", 0.93296121849350688 },
                    { 14, "This product is an Awesome piece of craftsmanship", false, 1, "Product4233", 0.89173890458966554 },
                    { 13, "This product is an Awesome piece of craftsmanship", false, 1, "Product9646", 0.012724678969348166 },
                    { 12, "This product is an Awesome piece of craftsmanship", false, 1, "Product1041", 0.56402758209222348 },
                    { 11, "This product is an Awesome piece of craftsmanship", false, 1, "Product2891", 0.12926765630453249 },
                    { 10, "This product is an Awesome piece of craftsmanship", false, 1, "Product7613", 0.5388925944170414 },
                    { 20, "This product is an Awesome piece of craftsmanship", false, 1, "Product2766", 0.5853943878716763 },
                    { 8, "This product is an Awesome piece of craftsmanship", false, 1, "Product1536", 0.94153446654860606 },
                    { 7, "This product is an Awesome piece of craftsmanship", false, 1, "Product2666", 0.41928267870996272 },
                    { 6, "This product is an Awesome piece of craftsmanship", false, 1, "Product6680", 0.59594522537474759 },
                    { 5, "This product is an Awesome piece of craftsmanship", false, 1, "Product9599", 0.05805989450684744 },
                    { 4, "This product is an Awesome piece of craftsmanship", false, 1, "Product6729", 0.99687428446341042 },
                    { 3, "This product is an Awesome piece of craftsmanship", false, 1, "Product4594", 0.026904471696775626 },
                    { 1, "This product is an Awesome piece of craftsmanship", false, 1, "Product4510", 0.13782152772779649 },
                    { 9, "This product is an Awesome piece of craftsmanship", false, 1, "Product3451", 0.079871053378968992 }
                });

            migrationBuilder.InsertData(
                table: "ProductOrder",
                columns: new[] { "OrderId", "ProductId" },
                values: new object[] { 1, 15 });

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
                name: "Location");

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
