using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations
{
    public partial class ShopPhones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShopPhonesItem",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    phoneid = table.Column<int>(nullable: true),
                    price = table.Column<int>(nullable: false),
                    shopPhoneId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopPhonesItem", x => x.id);
                    table.ForeignKey(
                        name: "FK_ShopPhonesItem_Phone_phoneid",
                        column: x => x.phoneid,
                        principalTable: "Phone",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShopPhonesItem_phoneid",
                table: "ShopPhonesItem",
                column: "phoneid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopPhonesItem");
        }
    }
}
