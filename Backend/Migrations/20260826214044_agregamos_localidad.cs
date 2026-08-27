using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class agregamos_localidad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocalidadId",
                table: "Clientes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Localidad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localidad", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "LocalidadId" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 8, 26, 18, 40, 44, 448, DateTimeKind.Unspecified).AddTicks(7014), new TimeSpan(0, -3, 0, 0, 0)), 1 });

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "LocalidadId" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 8, 26, 18, 40, 44, 448, DateTimeKind.Unspecified).AddTicks(7047), new TimeSpan(0, -3, 0, 0, 0)), 2 });

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "LocalidadId" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 8, 26, 18, 40, 44, 448, DateTimeKind.Unspecified).AddTicks(7049), new TimeSpan(0, -3, 0, 0, 0)), 3 });

            migrationBuilder.InsertData(
                table: "Localidad",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, false, "Buenos Aires" },
                    { 2, false, "Santa Fe" },
                    { 3, false, "Vera y Pintado" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_LocalidadId",
                table: "Clientes",
                column: "LocalidadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Localidad_LocalidadId",
                table: "Clientes",
                column: "LocalidadId",
                principalTable: "Localidad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Localidad_LocalidadId",
                table: "Clientes");

            migrationBuilder.DropTable(
                name: "Localidad");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_LocalidadId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "LocalidadId",
                table: "Clientes");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_at",
                value: new DateTimeOffset(new DateTime(2026, 8, 26, 17, 54, 31, 167, DateTimeKind.Unspecified).AddTicks(5016), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_at",
                value: new DateTimeOffset(new DateTime(2026, 8, 26, 17, 54, 31, 167, DateTimeKind.Unspecified).AddTicks(5047), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_at",
                value: new DateTimeOffset(new DateTime(2026, 8, 26, 17, 54, 31, 167, DateTimeKind.Unspecified).AddTicks(5049), new TimeSpan(0, -3, 0, 0, 0)));
        }
    }
}
