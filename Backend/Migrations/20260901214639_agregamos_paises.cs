using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class agregamos_paises : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaisId",
                table: "Provincias",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ProvinciaId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.Id);
                });

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

            migrationBuilder.UpdateData(
                table: "Localidades",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProvinciaId",
                value: 2);

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "Id", "IsDeleted", "Name", "ProvinciaId" },
                values: new object[,]
                {
                    { 1, false, "Argentina", 0 },
                    { 2, false, "Brasil", 0 },
                    { 3, false, "Uruguay", 0 }
                });

            migrationBuilder.UpdateData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaisId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaisId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: 3,
                column: "PaisId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Provincias_PaisId",
                table: "Provincias",
                column: "PaisId");

            migrationBuilder.AddForeignKey(
                name: "FK_Provincias_Paises_PaisId",
                table: "Provincias",
                column: "PaisId",
                principalTable: "Paises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Provincias_Paises_PaisId",
                table: "Provincias");

            migrationBuilder.DropTable(
                name: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Provincias_PaisId",
                table: "Provincias");

            migrationBuilder.DropColumn(
                name: "PaisId",
                table: "Provincias");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_at",
                value: new DateTimeOffset(new DateTime(2026, 9, 1, 17, 13, 56, 893, DateTimeKind.Unspecified).AddTicks(4096), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_at",
                value: new DateTimeOffset(new DateTime(2026, 9, 1, 17, 13, 56, 893, DateTimeKind.Unspecified).AddTicks(4125), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_at",
                value: new DateTimeOffset(new DateTime(2026, 9, 1, 17, 13, 56, 893, DateTimeKind.Unspecified).AddTicks(4127), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Localidades",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProvinciaId",
                value: 3);
        }
    }
}
