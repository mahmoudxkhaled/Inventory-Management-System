using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Retail.DAL.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    PRICE = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QTY = table.Column<int>(type: "int", nullable: false),
                    PIC = table.Column<string>(type: "NVARCHAR(MAX)", nullable: true),
                    CATEGORY_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CATEGORY_ID",
                        column: x => x.CATEGORY_ID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "DESCRIPTION", "NAME" },
                values: new object[,]
                {
                    { new Guid("4b9ad45e-864e-497c-94e8-37dd14027978"), "Step into a world of fashion and comfort with our diverse range of shoes. From casual to formal, our footwear collection is curated to elevate your style and keep you on-trend.", "Shoes" },
                    { new Guid("c2ae51c9-913a-4e7d-a7b5-ef1efc8f9d3e"), "Experience unparalleled comfort and style with our exquisite collection of furniture. Transform your living spaces with our carefully crafted pieces, designed for both beauty and functionality.", "Furnitures" },
                    { new Guid("e18e42b7-799e-4b3b-a084-c55d4bb5da3f"), "Explore cutting-edge technology and innovation with our electronic products. Our selection includes high-quality gadgets and devices that are designed to enhance your lifestyle and keep you connected.", "Electronics" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Categories_NAME",
                table: "Categories",
                column: "NAME",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CATEGORY_ID",
                table: "Products",
                column: "CATEGORY_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_NAME",
                table: "Products",
                column: "NAME",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
