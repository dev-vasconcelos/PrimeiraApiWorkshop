using Microsoft.EntityFrameworkCore.Migrations;

namespace PrimeiraApiWorkshop.DataBase
{
    public partial class Brasil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "year",
                table: "tb_vehicle",
                newName: "ano");

            migrationBuilder.RenameColumn(
                name: "model",
                table: "tb_vehicle",
                newName: "modelo");

            migrationBuilder.RenameColumn(
                name: "brand",
                table: "tb_vehicle",
                newName: "marca");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "modelo",
                table: "tb_vehicle",
                newName: "model");

            migrationBuilder.RenameColumn(
                name: "marca",
                table: "tb_vehicle",
                newName: "brand");

            migrationBuilder.RenameColumn(
                name: "ano",
                table: "tb_vehicle",
                newName: "year");
        }
    }
}
