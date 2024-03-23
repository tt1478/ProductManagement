using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductManagement.EntityFrameworkCore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Barcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreationTime", "CreatorId", "DeleterId", "DeletionTime", "LastModificationTime", "LastModifierId", "Name" },
                values: new object[,]
                {
                    { new Guid("6866ae00-820d-ec66-9c60-3a0f48228716"), new DateTime(2024, 3, 23, 0, 14, 29, 431, DateTimeKind.Utc).AddTicks(952), null, null, null, null, null, "Category-1" },
                    { new Guid("a8452e0c-40b2-df77-0408-3a0f48228717"), new DateTime(2024, 3, 23, 0, 14, 29, 431, DateTimeKind.Utc).AddTicks(985), null, null, null, null, null, "Category-2" },
                    { new Guid("c0b86591-0a77-be3a-0a64-3a0f48228717"), new DateTime(2024, 3, 23, 0, 14, 29, 431, DateTimeKind.Utc).AddTicks(996), null, null, null, null, null, "Category-4" },
                    { new Guid("c72bf8dd-dab6-d187-048c-3a0f48228717"), new DateTime(2024, 3, 23, 0, 14, 29, 431, DateTimeKind.Utc).AddTicks(991), null, null, null, null, null, "Category-3" },
                    { new Guid("f1dc7eeb-85ed-9967-0e32-3a0f48228717"), new DateTime(2024, 3, 23, 0, 14, 29, 431, DateTimeKind.Utc).AddTicks(1001), null, null, null, null, null, "Category-5" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Barcode", "CategoryId", "CreationTime", "CreatorId", "DeleterId", "DeletionTime", "Description", "LastModificationTime", "LastModifierId", "Name", "Status", "Weight" },
                values: new object[,]
                {
                    { new Guid("065b7d83-eaa9-4df9-a630-c5c057386369"), "123456789", new Guid("a8452e0c-40b2-df77-0408-3a0f48228717"), new DateTime(2024, 3, 23, 0, 14, 29, 432, DateTimeKind.Utc).AddTicks(148), null, null, null, "Descrition-8", null, null, "Product-8", (byte)2, 10m },
                    { new Guid("2c2b97ae-01cd-4b95-afdc-fea237aa56a3"), "123456789", new Guid("c72bf8dd-dab6-d187-048c-3a0f48228717"), new DateTime(2024, 3, 23, 0, 14, 29, 432, DateTimeKind.Utc).AddTicks(171), null, null, null, "Descrition-11", null, null, "Product-11", (byte)2, 10m },
                    { new Guid("3ecb25ec-4248-4862-b7be-c0f8533d2ec4"), "123456789", new Guid("6866ae00-820d-ec66-9c60-3a0f48228716"), new DateTime(2024, 3, 23, 0, 14, 29, 432, DateTimeKind.Utc).AddTicks(62), null, null, null, "Descrition-1", null, null, "Product-1", (byte)1, 10m },
                    { new Guid("46adea2c-ef9d-4a48-8a51-c950d0336ba5"), "123456789", new Guid("a8452e0c-40b2-df77-0408-3a0f48228717"), new DateTime(2024, 3, 23, 0, 14, 29, 432, DateTimeKind.Utc).AddTicks(133), null, null, null, "Descrition-6", null, null, "Product-6", (byte)1, 10m },
                    { new Guid("48250c6f-808c-4227-9256-f5da9e4ecc50"), "123456789", new Guid("a8452e0c-40b2-df77-0408-3a0f48228717"), new DateTime(2024, 3, 23, 0, 14, 29, 432, DateTimeKind.Utc).AddTicks(140), null, null, null, "Descrition-7", null, null, "Product-7", (byte)1, 10m },
                    { new Guid("5231f2df-081e-46ed-9f8d-0051eb389be7"), "123456789", new Guid("6866ae00-820d-ec66-9c60-3a0f48228716"), new DateTime(2024, 3, 23, 0, 14, 29, 432, DateTimeKind.Utc).AddTicks(96), null, null, null, "Descrition-5", null, null, "Product-5", (byte)1, 10m },
                    { new Guid("550e3e5e-b7dc-43fc-9866-268e3868a27e"), "123456789", new Guid("c72bf8dd-dab6-d187-048c-3a0f48228717"), new DateTime(2024, 3, 23, 0, 14, 29, 432, DateTimeKind.Utc).AddTicks(178), null, null, null, "Descrition-12", null, null, "Product-12", (byte)2, 10m },
                    { new Guid("57083701-90e0-45a0-9463-b8453e7ff336"), "123456789", new Guid("c72bf8dd-dab6-d187-048c-3a0f48228717"), new DateTime(2024, 3, 23, 0, 14, 29, 432, DateTimeKind.Utc).AddTicks(201), null, null, null, "Descrition-14", null, null, "Product-14", (byte)2, 10m },
                    { new Guid("5d18146f-f6d1-41ad-9f34-88f04371d535"), "123456789", new Guid("c0b86591-0a77-be3a-0a64-3a0f48228717"), new DateTime(2024, 3, 23, 0, 14, 29, 432, DateTimeKind.Utc).AddTicks(223), null, null, null, "Descrition-17", null, null, "Product-17", (byte)0, 10m },
                    { new Guid("639d3da3-814e-426f-af77-b63056977142"), "123456789", new Guid("c0b86591-0a77-be3a-0a64-3a0f48228717"), new DateTime(2024, 3, 23, 0, 14, 29, 432, DateTimeKind.Utc).AddTicks(231), null, null, null, "Descrition-18", null, null, "Product-18", (byte)0, 10m },
                    { new Guid("74197aa1-f129-4b00-ae4b-2bf4acafb564"), "123456789", new Guid("6866ae00-820d-ec66-9c60-3a0f48228716"), new DateTime(2024, 3, 23, 0, 14, 29, 432, DateTimeKind.Utc).AddTicks(73), null, null, null, "Descrition-2", null, null, "Product-2", (byte)1, 10m },
                    { new Guid("8454bc32-1643-4641-b7b3-60bfa2c99048"), "123456789", new Guid("c72bf8dd-dab6-d187-048c-3a0f48228717"), new DateTime(2024, 3, 23, 0, 14, 29, 432, DateTimeKind.Utc).AddTicks(208), null, null, null, "Descrition-15", null, null, "Product-15", (byte)0, 10m },
                    { new Guid("a95cc2a3-547c-4585-9434-3325eb98a5eb"), "123456789", new Guid("a8452e0c-40b2-df77-0408-3a0f48228717"), new DateTime(2024, 3, 23, 0, 14, 29, 432, DateTimeKind.Utc).AddTicks(163), null, null, null, "Descrition-10", null, null, "Product-10", (byte)2, 10m },
                    { new Guid("b3462ec3-1d6d-4af0-a109-e689f67f8708"), "123456789", new Guid("c0b86591-0a77-be3a-0a64-3a0f48228717"), new DateTime(2024, 3, 23, 0, 14, 29, 432, DateTimeKind.Utc).AddTicks(245), null, null, null, "Descrition-20", null, null, "Product-20", (byte)0, 10m },
                    { new Guid("c14e6f99-2ef0-483e-ab52-c11179f67214"), "123456789", new Guid("c72bf8dd-dab6-d187-048c-3a0f48228717"), new DateTime(2024, 3, 23, 0, 14, 29, 432, DateTimeKind.Utc).AddTicks(185), null, null, null, "Descrition-13", null, null, "Product-13", (byte)2, 10m },
                    { new Guid("c4899242-9e13-42fd-90b9-a64ec88d9307"), "123456789", new Guid("c0b86591-0a77-be3a-0a64-3a0f48228717"), new DateTime(2024, 3, 23, 0, 14, 29, 432, DateTimeKind.Utc).AddTicks(238), null, null, null, "Descrition-19", null, null, "Product-19", (byte)0, 10m },
                    { new Guid("cb2bba1f-b325-4286-b926-3bd19487d5a2"), "123456789", new Guid("6866ae00-820d-ec66-9c60-3a0f48228716"), new DateTime(2024, 3, 23, 0, 14, 29, 432, DateTimeKind.Utc).AddTicks(89), null, null, null, "Descrition-4", null, null, "Product-4", (byte)1, 10m },
                    { new Guid("e42e9580-80d8-41f3-a819-b61ffdaa0969"), "123456789", new Guid("a8452e0c-40b2-df77-0408-3a0f48228717"), new DateTime(2024, 3, 23, 0, 14, 29, 432, DateTimeKind.Utc).AddTicks(156), null, null, null, "Descrition-9", null, null, "Product-9", (byte)2, 10m },
                    { new Guid("f68af4a3-a354-4404-934c-a67503890727"), "123456789", new Guid("c0b86591-0a77-be3a-0a64-3a0f48228717"), new DateTime(2024, 3, 23, 0, 14, 29, 432, DateTimeKind.Utc).AddTicks(215), null, null, null, "Descrition-16", null, null, "Product-16", (byte)0, 10m },
                    { new Guid("fa3d93c9-e2ca-463d-97c7-3153a0284716"), "123456789", new Guid("6866ae00-820d-ec66-9c60-3a0f48228716"), new DateTime(2024, 3, 23, 0, 14, 29, 432, DateTimeKind.Utc).AddTicks(82), null, null, null, "Descrition-3", null, null, "Product-3", (byte)1, 10m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Name",
                table: "Categories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Status",
                table: "Products",
                column: "Status");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
