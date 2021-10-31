using Microsoft.EntityFrameworkCore.Migrations;

namespace Datalayer.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProductOrder",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1,
                column: "ImageName",
                value: "Pi89");

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 2,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi15", "Pi2.jpg", 2 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 3,
                column: "ImageName",
                value: "Pi97");

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
                column: "ImageName",
                value: "Pi12");

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 9,
                columns: new[] { "ImageName", "ImagePath" },
                values: new object[] { "Pi99", "Pi5.jpg" });

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
                columns: new[] { "ImageName", "ImagePath" },
                values: new object[] { "Pi97", "Pi1.jpg" });

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
                columns: new[] { "ImageName", "ImagePath" },
                values: new object[] { "Pi71", "Pi7.jpg" });

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
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi2", "Pi2.jpg", 11 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 16,
                columns: new[] { "ImageName", "ProductId" },
                values: new object[] { "Pi42", 12 });

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
                columns: new[] { "ImageName", "ProductId" },
                values: new object[] { "Pi72", 17 });

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
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi46", "Pi3.jpg", 19 });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductOrder",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1,
                column: "ImageName",
                value: "Pi70");

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 2,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi58", "Pi1.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 3,
                column: "ImageName",
                value: "Pi43");

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 4,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi72", "Pi5.jpg", 2 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 5,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi16", "Pi5.jpg", 3 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 6,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi23", "Pi1.jpg", 4 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 7,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi46", "Pi2.jpg", 5 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 8,
                column: "ImageName",
                value: "Pi9");

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 9,
                columns: new[] { "ImageName", "ImagePath" },
                values: new object[] { "Pi36", "Pi6.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 10,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi91", "Pi7.jpg", 7 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 11,
                columns: new[] { "ImageName", "ImagePath" },
                values: new object[] { "Pi38", "Pi7.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 12,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi92", "Pi7.jpg", 8 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 13,
                columns: new[] { "ImageName", "ImagePath" },
                values: new object[] { "Pi61", "Pi3.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 14,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi71", "Pi7.jpg", 9 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 15,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi12", "Pi7.jpg", 10 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 16,
                columns: new[] { "ImageName", "ProductId" },
                values: new object[] { "Pi62", 11 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 17,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi1", "Pi6.jpg", 11 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 18,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi33", "Pi7.jpg", 12 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 19,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi55", "Pi1.jpg", 13 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 20,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi97", "Pi5.jpg", 14 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 21,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi45", "Pi3.jpg", 14 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 22,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi57", "Pi1.jpg", 15 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 23,
                columns: new[] { "ImageName", "ProductId" },
                values: new object[] { "Pi18", 15 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 24,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi85", "Pi7.jpg", 16 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 25,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi70", "Pi2.jpg", 16 });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 26,
                columns: new[] { "ImageName", "ImagePath", "ProductId" },
                values: new object[] { "Pi98", "Pi1.jpg", 17 });

            migrationBuilder.InsertData(
                table: "ProductImage",
                columns: new[] { "ProductImageId", "ImageName", "ImagePath", "ProductId" },
                values: new object[,]
                {
                    { 27, "Pi30", "Pi4.jpg", 17 },
                    { 29, "Pi47", "Pi6.jpg", 19 },
                    { 31, "Pi66", "Pi7.jpg", 20 },
                    { 28, "Pi34", "Pi2.jpg", 18 },
                    { 30, "Pi36", "Pi7.jpg", 19 }
                });

            migrationBuilder.InsertData(
                table: "ProductOrder",
                columns: new[] { "OrderId", "ProductId", "Amount" },
                values: new object[] { 1, 16, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 27% better then the original", "Raspberry pi 51", 0.064442106086966627 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 55% better then the original", "Raspberry pi 49", 0.19485148703439695 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 74% better then the original", "Raspberry pi 44", 0.6008433716375583 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 33% better then the original", "Raspberry pi 88", 0.1613166752091221 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 19% better then the original", "Raspberry pi 9", 0.48301145456871553 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 42% better then the original", "Raspberry pi 12", 0.95120598746054152 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 23% better then the original", "Raspberry pi 77", 0.43558739797938029 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 39% better then the original", "Raspberry pi 50", 0.16150921590696518 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 64% better then the original", "Raspberry pi 15", 0.20476716067863962 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 70% better then the original", "Raspberry pi 24", 0.65246497125013958 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 16% better then the original", "Raspberry pi 99", 0.12596092285865962 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 89% better then the original", "Raspberry pi 92", 0.9797203410322407 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 91% better then the original", "Raspberry pi 67", 0.63951263466827224 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 35% better then the original", "Raspberry pi 93", 0.090230986983622891 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 64% better then the original", "Raspberry pi 5", 0.26485338120947283 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 64% better then the original", "Raspberry pi 64", 0.052567358618866356 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 84% better then the original", "Raspberry pi 68", 0.24547895428048397 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 92% better then the original", "Raspberry pi 62", 0.38221089978805317 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 56% better then the original", "Raspberry pi 70", 0.95362494371534556 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "This product is 10% better then the original", "Raspberry pi 17", 0.88460101414686121 });
        }
    }
}
