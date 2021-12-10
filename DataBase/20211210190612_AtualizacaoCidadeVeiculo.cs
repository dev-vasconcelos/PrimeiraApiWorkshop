using Microsoft.EntityFrameworkCore.Migrations;

namespace PrimeiraApiWorkshop.DataBase
{
    public partial class AtualizacaoCidadeVeiculo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cidade_fabricacao",
                table: "tb_vehicle",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cidade_fabricacao",
                table: "tb_vehicle");
        }
    }
}
