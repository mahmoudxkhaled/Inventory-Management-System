using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Retail.DAL.Migrations
{
    /// <inheritdoc />
    public partial class v0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("16872cb4-4a80-46c5-b0ef-cea3f6a91c5d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("1be78c53-77d7-4a95-85fa-dc63e744018e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("258d4faf-cfba-40be-bf12-759e376de126"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("2a199636-d4fc-419c-b3ad-80943acc3fff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("3793aea2-8c7e-423d-ba29-1ef786a75a10"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("3b349230-e864-4cce-a853-0063529fdf38"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("74495e9d-7feb-4ac5-90b6-54b86c25711f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("76defb07-47c0-437c-a58e-2b1cdf012057"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("9b030847-9e86-4eae-8779-c2aa3d8b16bb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("b1295cdf-d372-471a-b28f-7636749453d2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("cc71f8f9-d5ca-42e9-a92c-ef1e1fb2a3ac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("ce8490af-5fd6-4f45-afff-b81db2a5c1dd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("d997d404-7986-44cb-ad46-2e2a6d8cd811"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("e70f97c3-9d56-42a8-bc42-989cf7300757"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("eaaee255-7eef-4b21-9660-36f5f6e7bf77"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CATEGORY_ID", "DESCRIPTION", "NAME", "PIC", "PRICE", "QTY" },
                values: new object[,]
                {
                    { new Guid("1375aec5-624f-49cd-86d7-56e88db3d17e"), new Guid("e18e42b7-799e-4b3b-a084-c55d4bb5da3f"), "Complete smart home security solution.", "Smart Home Security System", "images/Electronic/Smart Home Security System.jpeg", 29999m, 0 },
                    { new Guid("185e17f5-4384-44ff-a9ae-8b7a1a95c397"), new Guid("c2ae51c9-913a-4e7d-a7b5-ef1efc8f9d3e"), "Solid wood dining table set with chairs.", "Wooden Dining Table Set", "images/Furniture/Wooden Dining Table Set.jpeg", 1499m, 20 },
                    { new Guid("1f1eb7aa-2f9d-4dd5-852b-58458b880aba"), new Guid("4b9ad45e-864e-497c-94e8-37dd14027978"), "Elegant formal shoes for men.", "Formal Shoes - Men", "images/Shoes/Formal Shoes - Men.jpeg", 699m, 145 },
                    { new Guid("3d10d175-f156-48e6-8443-eb06324b55b6"), new Guid("e18e42b7-799e-4b3b-a084-c55d4bb5da3f"), "On-ear Black Headphones - these headphones are not wireless", "On-ear Black Headphones", "images/Electronic/On-ear Black Headphones.jpeg", 9977m, 37 },
                    { new Guid("53483415-caf8-4b0b-a6ca-880c7eeac0d3"), new Guid("4b9ad45e-864e-497c-94e8-37dd14027978"), "Stylish and comfortable casual sneakers for women", "Casual Sneakers - Women", "images/Shoes/Casual Sneakers - Women.jpeg", 499m, 0 },
                    { new Guid("6348d82c-25ad-4ce5-97e0-1176814cbb17"), new Guid("c2ae51c9-913a-4e7d-a7b5-ef1efc8f9d3e"), "Elegant and comfortable luxury leather sofa.", "Luxury Leather Sofa", "images/Furniture/Luxury Leather Sofa.jpeg", 1000m, 0 },
                    { new Guid("7328a266-a10b-4460-a98e-334ecfae1fcf"), new Guid("c2ae51c9-913a-4e7d-a7b5-ef1efc8f9d3e"), "Very comfortable Silver lounge chair", "Silver Lounge Chair", "images/Furniture/Silver Lounge Chair.jpeg", 2999m, 77 },
                    { new Guid("a8d78681-f5c9-4041-9c50-1f9876447369"), new Guid("e18e42b7-799e-4b3b-a084-c55d4bb5da3f"), "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod", "Sennheiser Digital Camera with Tripod", "images/Electronic/Sennheiser Digital Camera with Tripod.jpeg", 14999m, 20 },
                    { new Guid("b69cbb1b-6b05-44fa-941b-ce380fb2a00d"), new Guid("4b9ad45e-864e-497c-94e8-37dd14027978"), "Classic leather boots suitable for both men and women.", "Leather Boots - Unisex", "images/Shoes/Leather Boots - Unisex.jpeg", 334m, 95 },
                    { new Guid("b870ddcd-5ebe-4270-8db0-d85f4b5f9f9a"), new Guid("e18e42b7-799e-4b3b-a084-c55d4bb5da3f"), "Professional digital camera with accessories.", "Digital Camera Kit", "images/Electronic/Digital Camera Kit.jpeg", 19999m, 15 },
                    { new Guid("bbfa55f0-9a83-405a-b2b4-bcff04cb8815"), new Guid("4b9ad45e-864e-497c-94e8-37dd14027978"), "High-performance running shoes for men.", "Running Shoes - Men", "images/Shoes/Running Shoes - Men.jpeg", 299m, 58 },
                    { new Guid("d4a30a75-7605-4c3a-8188-cf6152a397dc"), new Guid("c2ae51c9-913a-4e7d-a7b5-ef1efc8f9d3e"), "Very comfortable pink leather office chair", "Pink Leather Office Chair", "images/Furniture/Pink Leather Office Chair.jpeg", 4999m, 56 },
                    { new Guid("dd545746-b063-4d11-8187-9e331f179e9e"), new Guid("c2ae51c9-913a-4e7d-a7b5-ef1efc8f9d3e"), "Very comfortable lounge chair", "Lounge Chair", "images/Furniture/Lounge Chair.jpeg", 999m, 10 },
                    { new Guid("e0d0da98-21c4-4a75-9804-3b5c8ba5682b"), new Guid("e18e42b7-799e-4b3b-a084-c55d4bb5da3f"), "Canon Digital Camera - High quality digital camera provided by Canon", "Canon Digital Camera", "images/Electronic/Canon Digital Camera.jpeg", 9999m, 8 },
                    { new Guid("eb473be4-b132-4208-8a70-87a5b2031f78"), new Guid("4b9ad45e-864e-497c-94e8-37dd14027978"), "Comfortable sandals designed for arch support", "Sandals with Arch Support", "images/Shoes/Sandals with Arch Support.jpeg", 99m, 90 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("1375aec5-624f-49cd-86d7-56e88db3d17e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("185e17f5-4384-44ff-a9ae-8b7a1a95c397"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("1f1eb7aa-2f9d-4dd5-852b-58458b880aba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("3d10d175-f156-48e6-8443-eb06324b55b6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("53483415-caf8-4b0b-a6ca-880c7eeac0d3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("6348d82c-25ad-4ce5-97e0-1176814cbb17"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("7328a266-a10b-4460-a98e-334ecfae1fcf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("a8d78681-f5c9-4041-9c50-1f9876447369"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("b69cbb1b-6b05-44fa-941b-ce380fb2a00d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("b870ddcd-5ebe-4270-8db0-d85f4b5f9f9a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("bbfa55f0-9a83-405a-b2b4-bcff04cb8815"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("d4a30a75-7605-4c3a-8188-cf6152a397dc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("dd545746-b063-4d11-8187-9e331f179e9e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("e0d0da98-21c4-4a75-9804-3b5c8ba5682b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("eb473be4-b132-4208-8a70-87a5b2031f78"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CATEGORY_ID", "DESCRIPTION", "NAME", "PIC", "PRICE", "QTY" },
                values: new object[,]
                {
                    { new Guid("16872cb4-4a80-46c5-b0ef-cea3f6a91c5d"), new Guid("4b9ad45e-864e-497c-94e8-37dd14027978"), "Classic leather boots suitable for both men and women.", "Leather Boots - Unisex", "images/Shoes/Leather Boots - Unisex.jpeg", 334m, 95 },
                    { new Guid("1be78c53-77d7-4a95-85fa-dc63e744018e"), new Guid("e18e42b7-799e-4b3b-a084-c55d4bb5da3f"), "Canon Digital Camera - High quality digital camera provided by Canon", "Canon Digital Camera", "images/Electronic/Canon Digital Camera.jpeg", 9999m, 8 },
                    { new Guid("258d4faf-cfba-40be-bf12-759e376de126"), new Guid("c2ae51c9-913a-4e7d-a7b5-ef1efc8f9d3e"), "Very comfortable pink leather office chair", "Pink Leather Office Chair", "images/Furniture/Pink Leather Office Chair.jpeg", 4999m, 56 },
                    { new Guid("2a199636-d4fc-419c-b3ad-80943acc3fff"), new Guid("4b9ad45e-864e-497c-94e8-37dd14027978"), "Comfortable sandals designed for arch support", "Sandals with Arch Support", "images/Shoes/Sandals with Arch Support.jpeg", 99m, 90 },
                    { new Guid("3793aea2-8c7e-423d-ba29-1ef786a75a10"), new Guid("4b9ad45e-864e-497c-94e8-37dd14027978"), "Elegant formal shoes for men.", "Formal Shoes - Men", "images/Shoes/Formal Shoes - Men.jpeg", 699m, 145 },
                    { new Guid("3b349230-e864-4cce-a853-0063529fdf38"), new Guid("e18e42b7-799e-4b3b-a084-c55d4bb5da3f"), "Professional digital camera with accessories.", "Digital Camera Kit", "images/Electronic/Digital Camera Kit.jpeg", 19999m, 15 },
                    { new Guid("74495e9d-7feb-4ac5-90b6-54b86c25711f"), new Guid("c2ae51c9-913a-4e7d-a7b5-ef1efc8f9d3e"), "Very comfortable lounge chair", "Lounge Chair", "images/Furniture/Lounge Chair.jpeg", 999m, 10 },
                    { new Guid("76defb07-47c0-437c-a58e-2b1cdf012057"), new Guid("c2ae51c9-913a-4e7d-a7b5-ef1efc8f9d3e"), "Very comfortable Silver lounge chair", "Silver Lounge Chair", "images/Furniture/Silver Lounge Chair.jpeg", 2999m, 77 },
                    { new Guid("9b030847-9e86-4eae-8779-c2aa3d8b16bb"), new Guid("4b9ad45e-864e-497c-94e8-37dd14027978"), "Stylish and comfortable casual sneakers for women", "Casual Sneakers - Women", "images/Shoes/Casual Sneakers - Women.jpeg", 499m, 0 },
                    { new Guid("b1295cdf-d372-471a-b28f-7636749453d2"), new Guid("e18e42b7-799e-4b3b-a084-c55d4bb5da3f"), "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod", "Sennheiser Digital Camera with Tripod", "images/Electronic/Sennheiser Digital Camera with Tripod.jpeg", 14999m, 20 },
                    { new Guid("cc71f8f9-d5ca-42e9-a92c-ef1e1fb2a3ac"), new Guid("4b9ad45e-864e-497c-94e8-37dd14027978"), "High-performance running shoes for men.", "Running Shoes - Men", "images/Shoes/Running Shoes - Men.jpeg", 299m, 58 },
                    { new Guid("ce8490af-5fd6-4f45-afff-b81db2a5c1dd"), new Guid("c2ae51c9-913a-4e7d-a7b5-ef1efc8f9d3e"), "Elegant and comfortable luxury leather sofa.", "Luxury Leather Sofa", "images/Furniture/Luxury Leather Sofa.jpeg", 1000m, 0 },
                    { new Guid("d997d404-7986-44cb-ad46-2e2a6d8cd811"), new Guid("e18e42b7-799e-4b3b-a084-c55d4bb5da3f"), "Complete smart home security solution.", "Smart Home Security System", "images/Electronic/Smart Home Security System.jpeg", 29999m, 0 },
                    { new Guid("e70f97c3-9d56-42a8-bc42-989cf7300757"), new Guid("e18e42b7-799e-4b3b-a084-c55d4bb5da3f"), "On-ear Black Headphones - these headphones are not wireless", "On-ear Black Headphones", "images/Electronic/On-ear Black Headphones.jpeg", 9977m, 37 },
                    { new Guid("eaaee255-7eef-4b21-9660-36f5f6e7bf77"), new Guid("c2ae51c9-913a-4e7d-a7b5-ef1efc8f9d3e"), "Solid wood dining table set with chairs.", "Wooden Dining Table Set", "images/Furniture/Wooden Dining Table Set.jpeg", 1499m, 20 }
                });
        }
    }
}
