using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace destinos.Migrations
{
    /// <inheritdoc />
    public partial class migration03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 1,
                column: "destino_url",
                value: "aaaaa.png");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 2,
                column: "destino_url",
                value: "bbbbbb.png");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "id",
                keyValue: 3,
                column: "destino_url",
                value: "ccccc.png");
        }
    }
}
