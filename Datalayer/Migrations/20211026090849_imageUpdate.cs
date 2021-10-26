using Microsoft.EntityFrameworkCore.Migrations;

namespace Datalayer.Migrations
{
    public partial class imageUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductOrder",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.InsertData(
                table: "ProductImage",
                columns: new[] { "ProductImageId", "ImageName", "ImagePath", "ProductId" },
                values: new object[,]
                {
                    { 1, "Image", "Image.png", 1 },
                    { 18, "Image", "Image.png", 18 },
                    { 17, "Image", "Image.png", 17 },
                    { 16, "Image", "Image.png", 16 },
                    { 15, "Image", "Image.png", 15 },
                    { 14, "Image", "Image.png", 14 },
                    { 13, "Image", "Image.png", 13 },
                    { 12, "Image", "Image.png", 12 },
                    { 11, "Image", "Image.png", 11 },
                    { 10, "Image", "Image.png", 10 },
                    { 9, "Image", "Image.png", 9 },
                    { 8, "Image", "Image.png", 8 },
                    { 7, "Image", "Image.png", 7 },
                    { 6, "Image", "Image.png", 6 },
                    { 5, "Image", "Image.png", 5 },
                    { 4, "Image", "Image.png", 4 },
                    { 3, "Image", "Image.png", 3 },
                    { 2, "Image", "Image.png", 2 },
                    { 19, "Image", "Image.png", 19 },
                    { 20, "Image", "Image.png", 20 }
                });

            migrationBuilder.InsertData(
                table: "ProductOrder",
                columns: new[] { "OrderId", "ProductId", "Amount" },
                values: new object[] { 1, 13, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product5182", 0.91614782899438774 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product7152", 0.11738257488113948 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product5693", 0.92056960748535099 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product6001", 0.16037584895285584 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product3151", 0.82966394342000782 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product3190", 0.3645309570080279 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product8297", 0.64483075665534972 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product8913", 0.3670397486384212 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product6578", 0.47091319992715175 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product5579", 0.59967039460300953 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product8583", 0.44632559849243869 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product6467", 0.60020305057997025 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product8471", 0.36230171768101943 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product4473", 0.67273645553399641 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product3103", 0.27191660193350009 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product6495", 0.89286698628816152 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product6035", 0.73443883924486064 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product6787", 0.006543357393957375 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product2022", 0.58759427982736112 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product5941", 0.25120682653561555 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductOrder",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.InsertData(
                table: "ProductOrder",
                columns: new[] { "OrderId", "ProductId", "Amount" },
                values: new object[] { 1, 15, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product2026", 0.96761751871910762 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product5064", 0.098140941512836588 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product6994", 0.33072846631087754 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product6671", 0.98885444225224406 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product6650", 0.21303140149127292 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product4344", 0.10333153843103514 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product6931", 0.02461951366840839 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product8064", 0.7403624703829933 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product9793", 0.35495251340556538 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product3178", 0.93979807288376527 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product4864", 0.013716898399273352 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product5319", 0.55084223325869175 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product4775", 0.8198520470503029 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product8128", 0.32081744182892957 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product2143", 0.41212658603309027 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product3555", 0.87413053627783921 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product2947", 0.65551696934528503 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product8715", 0.33351630872744897 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product6994", 0.084723982068115836 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product3045", 0.68084528515154741 });
        }
    }
}
