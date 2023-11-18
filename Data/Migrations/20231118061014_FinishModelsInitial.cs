using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PetShower.Data.Migrations
{
    /// <inheritdoc />
    public partial class FinishModelsInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "breeds",
                columns: new[] { "Id", "created_at", "description", "name", "updated_at" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2553), "Amigável e extrovertido", "Labrador Retriever", new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2553) },
                    { 2L, new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2555), "Leal e protetor", "Pastor Alemão", new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2555) },
                    { 3L, new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2556), "Inteligente e devoto", "Golden Retriever", new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2557) },
                    { 4L, new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2558), "Adorável e sociável", "Bulldog Francês", new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2558) },
                    { 5L, new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2560), "Inteligente e ativo", "Poodle", new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2560) },
                    { 6L, new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2561), "Corajoso e confiável", "Rottweiler", new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2562) },
                    { 7L, new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2563), "Amigável e determinado", "Bulldog Inglês", new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2563) },
                    { 8L, new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2565), "Energético e independente", "Husky Siberiano", new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2565) },
                    { 9L, new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2567), "Corajoso e curioso", "Dachshund", new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2567) },
                    { 10L, new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2568), "Brincalhão e devotado", "Boxer", new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2568) }
                });

            migrationBuilder.InsertData(
                table: "genders",
                columns: new[] { "Id", "created_at", "name", "updated_at" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2439), "Masculino", new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2448) },
                    { 2L, new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2449), "Feminino", new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2450) },
                    { 3L, new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2451), "Outro", new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2451) }
                });

            migrationBuilder.InsertData(
                table: "species",
                columns: new[] { "Id", "created_at", "description", "name", "updated_at" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2583), "Mamífero doméstico conhecido pela lealdade", "Cachorro", new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2583) },
                    { 2L, new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2585), "Animal de estimação doméstico conhecido pela independência", "Gato", new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2585) },
                    { 3L, new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2587), "Pequeno mamífero herbívoro", "Coelho", new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2587) },
                    { 4L, new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2588), "Ave de estimação com variadas espécies", "Pássaro", new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2588) },
                    { 5L, new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2590), "Animal aquático variado", "Peixe", new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2590) },
                    { 6L, new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2591), "Réptil com casco resistente", "Tartaruga", new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2591) },
                    { 7L, new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2592), "Animal roedor com diferentes raças", "Porquinho-da-índia", new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2593) },
                    { 8L, new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2594), "Roedor pequeno e popular como animal de estimação", "Hamster", new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2594) },
                    { 9L, new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2595), "Mamífero carnívoro domesticado", "Furão", new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2596) }
                });

            migrationBuilder.InsertData(
                table: "status",
                columns: new[] { "Id", "created_at", "description", "name", "updated_at" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2608), "Consulta agendada", "Agendada", new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2609) },
                    { 2L, new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2610), "Consulta concluída", "Concluída", new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2610) },
                    { 3L, new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2612), "Consulta cancelada", "Cancelada", new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2612) },
                    { 4L, new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2613), "Consulta remarcada", "Remarcada", new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2614) },
                    { 5L, new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2615), "Consulta em andamento", "Em andamento", new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2615) }
                });

            migrationBuilder.InsertData(
                table: "veterinarians",
                columns: new[] { "Id", "age", "created_at", "GenderId", "name", "updated_at" },
                values: new object[,]
                {
                    { 1L, 35, new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2627), 1L, "Dr. João Silva", new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2627) },
                    { 2L, 40, new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2629), 2L, "Dra. Maria Rodrigues", new DateTime(2023, 11, 18, 3, 10, 14, 585, DateTimeKind.Local).AddTicks(2629) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "breeds",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "breeds",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "breeds",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "breeds",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "breeds",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "breeds",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "breeds",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "breeds",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "breeds",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "breeds",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "genders",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "species",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "species",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "species",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "species",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "species",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "species",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "species",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "species",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "species",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "status",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "status",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "status",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "status",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "status",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "veterinarians",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "veterinarians",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "genders",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "genders",
                keyColumn: "Id",
                keyValue: 2L);
        }
    }
}
