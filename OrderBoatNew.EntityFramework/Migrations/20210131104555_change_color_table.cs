using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderBoatNew.EntityFramework.Migrations
{
    public partial class change_color_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ForAdditionalMoney",
                table: "Colors",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ForAdditionalMoney",
                table: "Colors");
        }
    }
}
