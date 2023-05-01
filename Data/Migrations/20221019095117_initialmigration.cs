using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Urban.Data.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductUrl",
                table: "Product",
                newName: "ProductImage");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductImage",
                table: "Product",
                newName: "ProductUrl");
        }
    }
}
