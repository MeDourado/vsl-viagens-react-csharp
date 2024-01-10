using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace destinos.Migrations
{
    /// <inheritdoc />
    public partial class lastmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Destinos",
                columns: new[] { "id", "destino_nome", "destino_preco", "destino_url" },
                values: new object[,]
                {
                    { 1, "Salvador", 799.99m, "aaaaa.png" },
                    { 2, "São Paulo", 899.99m, "bbbbbb.png" },
                    { 3, "Rio de Janeiro", 999.99m, "ccccc.png" },
                    { 4, "Paraiba", 699.99m, "ddddd.png" },
                    { 5, "Minas Gerais", 1099.99m, "eeeee.png" },
                    { 6, "Acre", 759.99m, "fffff.png" },
                    { 7, "Pará", 1200.00m, "ggggg.png" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 7);
        }
    }
}
