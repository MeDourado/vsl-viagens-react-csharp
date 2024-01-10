using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace destinos.Migrations
{
    /// <inheritdoc />
    public partial class migrations04 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 1,
                column: "destino_url",
                value: "https://img.freepik.com/free-photo/long-shot-bahia-nautico-museum-salvdor-brazil-cloudy-blue-skies_181624-19965.jpg?w=740&t=st=1704910800~exp=1704911400~hmac=7b29602f804eadf85c1aa194c8341e031793c80a230b94d2d8992be685d65e4b");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 2,
                column: "destino_url",
                value: "https://img.freepik.com/free-photo/complex-aerial-view-city_23-2148975280.jpg?w=740&t=st=1704910907~exp=1704911507~hmac=759676c01827d187c2d6fe90e7705c2888519d0cd26587d49d56c30ad9618e60");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 3,
                column: "destino_url",
                value: "https://img.freepik.com/free-photo/landscape-rio-de-janeiro-surrounded-by-sea-blue-sky-brazil_181624-17265.jpg?w=740&t=st=1704910969~exp=1704911569~hmac=b0a3bd03158cbf1952e175bc97642dd8c54ba8d13061b02f5e51f6b7bba203ca");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 4,
                column: "destino_url",
                value: "https://img.freepik.com/free-photo/morning-light-sonoran-desert-scottsdale-arizona_181624-48339.jpg?w=740&t=st=1704911051~exp=1704911651~hmac=de860a086becd28ab0fcedb8363da480cd1957e7411171d7c84d5931f372a527");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 5,
                column: "destino_url",
                value: "https://img.freepik.com/premium-photo/taquaral-lagoon-campinas-view-from-portugal-park-sao-paulo-brazil_361869-578.jpg?w=826");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "destino_nome", "destino_url" },
                values: new object[] { "Santos", "https://img.freepik.com/free-photo/boat-goes-blue-sea-deep-blue-sky_1304-4974.jpg?w=740&t=st=1704911307~exp=1704911907~hmac=6ff0da3b8d1709d42ac2f694c7e80956d9384ec7ac01ba0d44b697c6e3a38fd9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 1,
                column: "destino_url",
                value: "https://images-ext-2.discordapp.net/external/W7r1kRZ6dZP1DYw6VngZXZmAgAi9zq-ffmZIcpi3QM8/%3Fw%3D280%26h%3D187%26c%3D7%26r%3D0%26o/https/th.bing.com/th/id/OIP.8xXpo17vRbI0NpVdgyYoOAHaE7?format=webp&width=251&height=168");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 2,
                column: "destino_url",
                value: "https://images-ext-2.discordapp.net/external/W7r1kRZ6dZP1DYw6VngZXZmAgAi9zq-ffmZIcpi3QM8/%3Fw%3D280%26h%3D187%26c%3D7%26r%3D0%26o/https/th.bing.com/th/id/OIP.8xXpo17vRbI0NpVdgyYoOAHaE7?format=webp&width=251&height=168");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 3,
                column: "destino_url",
                value: "https://images-ext-2.discordapp.net/external/W7r1kRZ6dZP1DYw6VngZXZmAgAi9zq-ffmZIcpi3QM8/%3Fw%3D280%26h%3D187%26c%3D7%26r%3D0%26o/https/th.bing.com/th/id/OIP.8xXpo17vRbI0NpVdgyYoOAHaE7?format=webp&width=251&height=168");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 4,
                column: "destino_url",
                value: "ddddd.png");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 5,
                column: "destino_url",
                value: "eeeee.png");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "destino_nome", "destino_url" },
                values: new object[] { "Acre", "fffff.png" });

            migrationBuilder.InsertData(
                table: "Destinos",
                columns: new[] { "id", "destino_nome", "destino_preco", "destino_url" },
                values: new object[] { 7, "Pará", 1200.00m, "ggggg.png" });
        }
    }
}
