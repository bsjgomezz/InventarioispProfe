using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class arreglo_localidades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Localidad_LocalidadId",
                table: "Clientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Localidad",
                table: "Localidad");

            migrationBuilder.RenameTable(
                name: "Localidad",
                newName: "Localidades");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Localidades",
                table: "Localidades",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_at",
                value: new DateTimeOffset(new DateTime(2026, 8, 26, 18, 47, 55, 701, DateTimeKind.Unspecified).AddTicks(3762), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_at",
                value: new DateTimeOffset(new DateTime(2026, 8, 26, 18, 47, 55, 701, DateTimeKind.Unspecified).AddTicks(3798), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_at",
                value: new DateTimeOffset(new DateTime(2026, 8, 26, 18, 47, 55, 701, DateTimeKind.Unspecified).AddTicks(3800), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Localidades_LocalidadId",
                table: "Clientes",
                column: "LocalidadId",
                principalTable: "Localidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Localidades_LocalidadId",
                table: "Clientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Localidades",
                table: "Localidades");

            migrationBuilder.RenameTable(
                name: "Localidades",
                newName: "Localidad");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Localidad",
                table: "Localidad",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_at",
                value: new DateTimeOffset(new DateTime(2026, 8, 26, 18, 40, 44, 448, DateTimeKind.Unspecified).AddTicks(7014), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_at",
                value: new DateTimeOffset(new DateTime(2026, 8, 26, 18, 40, 44, 448, DateTimeKind.Unspecified).AddTicks(7047), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_at",
                value: new DateTimeOffset(new DateTime(2026, 8, 26, 18, 40, 44, 448, DateTimeKind.Unspecified).AddTicks(7049), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Localidad_LocalidadId",
                table: "Clientes",
                column: "LocalidadId",
                principalTable: "Localidad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
