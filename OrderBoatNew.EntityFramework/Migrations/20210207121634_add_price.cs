using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderBoatNew.EntityFramework.Migrations
{
    public partial class add_price : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boats_Colors_ColorID",
                table: "Boats");

            migrationBuilder.DropForeignKey(
                name: "FK_Boats_Models_ModelID",
                table: "Boats");

            migrationBuilder.DropForeignKey(
                name: "FK_Boats_Woods_WoodID",
                table: "Boats");

            migrationBuilder.RenameColumn(
                name: "WoodID",
                table: "Boats",
                newName: "WoodId");

            migrationBuilder.RenameColumn(
                name: "ModelID",
                table: "Boats",
                newName: "ModelId");

            migrationBuilder.RenameColumn(
                name: "ColorID",
                table: "Boats",
                newName: "ColorId");

            migrationBuilder.RenameIndex(
                name: "IX_Boats_WoodID",
                table: "Boats",
                newName: "IX_Boats_WoodId");

            migrationBuilder.RenameIndex(
                name: "IX_Boats_ModelID",
                table: "Boats",
                newName: "IX_Boats_ModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Boats_ColorID",
                table: "Boats",
                newName: "IX_Boats_ColorId");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Woods",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Models",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Colors",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<int>(
                name: "WoodId",
                table: "Boats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ModelId",
                table: "Boats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ColorId",
                table: "Boats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Boats_Colors_ColorId",
                table: "Boats",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Boats_Models_ModelId",
                table: "Boats",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Boats_Woods_WoodId",
                table: "Boats",
                column: "WoodId",
                principalTable: "Woods",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boats_Colors_ColorId",
                table: "Boats");

            migrationBuilder.DropForeignKey(
                name: "FK_Boats_Models_ModelId",
                table: "Boats");

            migrationBuilder.DropForeignKey(
                name: "FK_Boats_Woods_WoodId",
                table: "Boats");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Woods");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Colors");

            migrationBuilder.RenameColumn(
                name: "WoodId",
                table: "Boats",
                newName: "WoodID");

            migrationBuilder.RenameColumn(
                name: "ModelId",
                table: "Boats",
                newName: "ModelID");

            migrationBuilder.RenameColumn(
                name: "ColorId",
                table: "Boats",
                newName: "ColorID");

            migrationBuilder.RenameIndex(
                name: "IX_Boats_WoodId",
                table: "Boats",
                newName: "IX_Boats_WoodID");

            migrationBuilder.RenameIndex(
                name: "IX_Boats_ModelId",
                table: "Boats",
                newName: "IX_Boats_ModelID");

            migrationBuilder.RenameIndex(
                name: "IX_Boats_ColorId",
                table: "Boats",
                newName: "IX_Boats_ColorID");

            migrationBuilder.AlterColumn<int>(
                name: "WoodID",
                table: "Boats",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ModelID",
                table: "Boats",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ColorID",
                table: "Boats",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Boats_Colors_ColorID",
                table: "Boats",
                column: "ColorID",
                principalTable: "Colors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Boats_Models_ModelID",
                table: "Boats",
                column: "ModelID",
                principalTable: "Models",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Boats_Woods_WoodID",
                table: "Boats",
                column: "WoodID",
                principalTable: "Woods",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
