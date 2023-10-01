using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceTermProject.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ListProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    State = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    Zipcode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListProduct", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ListProduct",
                columns: new[] { "Id", "Address", "City", "ProductName", "State", "Zipcode" },
                values: new object[] { 1, null, "Detroit", "PlayStation 5", "MI", null });

            migrationBuilder.InsertData(
                table: "ListProduct",
                columns: new[] { "Id", "Address", "City", "ProductName", "State", "Zipcode" },
                values: new object[] { 2, null, "Memphis", "Leather Couch", "TN", null });

            migrationBuilder.InsertData(
                table: "ListProduct",
                columns: new[] { "Id", "Address", "City", "ProductName", "State", "Zipcode" },
                values: new object[] { 3, null, "Detroit", "", "MI", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListProduct");
        }
    }
}
