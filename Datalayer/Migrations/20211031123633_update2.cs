using Microsoft.EntityFrameworkCore.Migrations;

namespace Datalayer.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductOrder",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1,
                columns: new[] { "ImageName", "ImagePath" },
                values: new object[] { "Pi30", "Pi2.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 2,
                columns: new[] { "ImageName", "ImagePath" },
                values: new object[] { "Pi29", "Pi7.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 3,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi75", "Pi5.jpg", 3 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 4,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi73", "Pi3.jpg", 4 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 5,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi75", "Pi7.jpg", 5 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 6,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi37", "Pi3.jpg", 6 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 7,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi73", "Pi1.jpg", 7 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 8,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi91", "Pi5.jpg", 8 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 9,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi32", "Pi6.jpg", 8 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 10,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi84", "Pi6.jpg", 9 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 11,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi33", "Pi4.jpg", 9 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 12,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi2", "Pi2.jpg", 10 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 13,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi24", "Pi2.jpg", 10 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 14,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi77", "Pi4.jpg", 11 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 15,
                columns: new[] { "ImageName", "ImagePath" },
                values: new object[] { "Pi46", "Pi7.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 16,
                columns: new[] { "ImageName", "ImagePath" },
                values: new object[] { "Pi21", "Pi2.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 17,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi63", "Pi2.jpg", 12 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 18,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi53", "Pi6.jpg", 13 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 19,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi61", "Pi1.jpg", 13 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 20,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi32", "Pi6.jpg", 14 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 21,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi79", "Pi3.jpg", 15 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 22,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi57", "Pi7.jpg", 15 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 23,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi17", "Pi3.jpg", 16 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 24,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi6", "Pi6.jpg", 16 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 25,
                columns: new[] { "ImageName", "ProductId" },
                values: new object[] { "Pi17", 17 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 26,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi15", "Pi6.jpg", 18 });

            migrationBuilder.InsertData(
                table: "ProductImage",
                columns: new[] { "ProductImageId", "ImageName", "ImagePath", "ProductId" },
                values: new object[,]
                {
                    { 27, "Pi59", "Pi7.jpg", 19 },
                    { 28, "Pi28", "Pi1.jpg", 20 }
                });

            migrationBuilder.InsertData(
                table: "ProductOrder",
                columns: new[] { "OrderId", "ProductId", "Amount" },
                values: new object[] { 1, 14, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 61% better then the original", "Raspberry pi 98", 310.19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 72% better then the original", "Raspberry pi 12", 961.80999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 56% better then the original", "Raspberry pi 50", 140.25999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 12% better then the original", "Raspberry pi 29", 474.80000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 23% better then the original", "Raspberry pi 84", 437.16000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 2% better then the original", "Raspberry pi 56", 108.14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 58% better then the original", "Raspberry pi 43", 914.90999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 97% better then the original", "Raspberry pi 22", 897.67999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 92% better then the original", "Raspberry pi 21", 909.90999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 56% better then the original", "Raspberry pi 81", 968.67999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 12% better then the original", "Raspberry pi 40", 520.80999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 24% better then the original", "Raspberry pi 80", 119.87 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 92% better then the original", "Raspberry pi 64", 600.07000000000005 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 57% better then the original", "Raspberry pi 14", 974.39999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 45% better then the original", "Raspberry pi 58", 584.72000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 4% better then the original", "Raspberry pi 48", 573.77999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 71% better then the original", "Raspberry pi 73", 426.94 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 95% better then the original", "Raspberry pi 41", 361.60000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 28% better then the original", "Raspberry pi 71", 496.36000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 56% better then the original", "Raspberry pi 40", 273.5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductOrder",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1,
                columns: new[] { "ImageName", "ImagePath" },
                values: new object[] { "Pi89", "Pi7.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 2,
                columns: new[] { "ImageName", "ImagePath" },
                values: new object[] { "Pi15", "Pi2.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 3,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi97", "Pi2.jpg", 2 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 4,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi98", "Pi1.jpg", 3 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 5,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi99", "Pi1.jpg", 4 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 6,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi64", "Pi5.jpg", 5 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 7,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi5", "Pi7.jpg", 6 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 8,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi12", "Pi4.jpg", 6 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 9,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi99", "Pi5.jpg", 7 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 10,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi81", "Pi1.jpg", 8 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 11,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi97", "Pi1.jpg", 8 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 12,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi68", "Pi1.jpg", 9 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 13,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi71", "Pi7.jpg", 9 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 14,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi43", "Pi1.jpg", 10 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 15,
                columns: new[] { "ImageName", "ImagePath" },
                values: new object[] { "Pi2", "Pi2.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 16,
                columns: new[] { "ImageName", "ImagePath" },
                values: new object[] { "Pi42", "Pi5.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 17,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi32", "Pi7.jpg", 13 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 18,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi42", "Pi5.jpg", 14 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 19,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi59", "Pi4.jpg", 15 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 20,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi93", "Pi4.jpg", 15 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 21,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi41", "Pi7.jpg", 16 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 22,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi69", "Pi3.jpg", 16 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 23,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi72", "Pi4.jpg", 17 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 24,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi92", "Pi3.jpg", 18 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 25,
                columns: new[] { "ImageName", "ProductId" },
                values: new object[] { "Pi46", 19 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 26,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi22", "Pi5.jpg", 20 });

            migrationBuilder.InsertData(
                table: "ProductOrder",
                columns: new[] { "OrderId", "ProductId", "Amount" },
                values: new object[] { 1, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 91% better then the original", "Raspberry pi 7", 748.34000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 62% better then the original", "Raspberry pi 76", 739.63 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 49% better then the original", "Raspberry pi 42", 576.29999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 75% better then the original", "Raspberry pi 62", 275.43000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 85% better then the original", "Raspberry pi 65", 616.91999999999996 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 81% better then the original", "Raspberry pi 61", 726.42999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 96% better then the original", "Raspberry pi 38", 562.09000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 23% better then the original", "Raspberry pi 48", 850.90999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 4% better then the original", "Raspberry pi 88", 408.00999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 42% better then the original", "Raspberry pi 33", 934.34000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 62% better then the original", "Raspberry pi 88", 961.25999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 76% better then the original", "Raspberry pi 90", 527.02999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 33% better then the original", "Raspberry pi 31", 784.77999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 66% better then the original", "Raspberry pi 86", 322.45999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 33% better then the original", "Raspberry pi 4", 824.94000000000005 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 22% better then the original", "Raspberry pi 29", 279.25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 5% better then the original", "Raspberry pi 97", 627.30999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 63% better then the original", "Raspberry pi 48", 304.00999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 34% better then the original", "Raspberry pi 73", 991.19000000000005 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 92% better then the original", "Raspberry pi 57", 662.99000000000001 });
        }
    }
}
