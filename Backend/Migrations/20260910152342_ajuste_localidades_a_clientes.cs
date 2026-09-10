using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ajuste_localidades_a_clientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_at",
                value: new DateTimeOffset(new DateTime(2026, 9, 10, 12, 23, 41, 677, DateTimeKind.Unspecified).AddTicks(8669), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_at",
                value: new DateTimeOffset(new DateTime(2026, 9, 10, 12, 23, 41, 677, DateTimeKind.Unspecified).AddTicks(8701), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_at",
                value: new DateTimeOffset(new DateTime(2026, 9, 10, 12, 23, 41, 677, DateTimeKind.Unspecified).AddTicks(8703), new TimeSpan(0, -3, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_at",
                value: new DateTimeOffset(new DateTime(2026, 9, 1, 18, 46, 39, 167, DateTimeKind.Unspecified).AddTicks(5887), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_at",
                value: new DateTimeOffset(new DateTime(2026, 9, 1, 18, 46, 39, 167, DateTimeKind.Unspecified).AddTicks(5916), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_at",
                value: new DateTimeOffset(new DateTime(2026, 9, 1, 18, 46, 39, 167, DateTimeKind.Unspecified).AddTicks(5919), new TimeSpan(0, -3, 0, 0, 0)));
        }
    }
}
