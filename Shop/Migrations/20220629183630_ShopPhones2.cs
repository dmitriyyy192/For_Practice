using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations
{
    public partial class ShopPhones2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "shopPhoneId",
                table: "ShopPhonesItem",
                newName: "ShopPhoneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShopPhoneId",
                table: "ShopPhonesItem",
                newName: "shopPhoneId");
        }
    }
}
