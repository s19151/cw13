using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cwiczenia13.Migrations
{
    public partial class SeededDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Klient",
                columns: new[] { "IdKlient", "Imie", "Nazwisko" },
                values: new object[,]
                {
                    { 1, "Jan", "Kowalski" },
                    { 2, "Adam", "Nowak" },
                    { 3, "Anna", "Kowalska" },
                    { 4, "Aleksandra", "Nowak" },
                    { 5, "Piotr", "Piotrowski" }
                });

            migrationBuilder.InsertData(
                table: "Pracownik",
                columns: new[] { "IdPracownik", "Imie", "Nazwisko" },
                values: new object[,]
                {
                    { 1, "Jan", "Kowalski" },
                    { 2, "Adam", "Nowak" },
                    { 3, "Anna", "Kowalska" },
                    { 4, "Aleksandra", "Nowak" },
                    { 5, "Piotr", "Piotrowski" }
                });

            migrationBuilder.InsertData(
                table: "WyrobCukierniczy",
                columns: new[] { "IdWyrobuCukierniczego", "CenaZaSzt", "Nazwa", "Typ" },
                values: new object[,]
                {
                    { 1, 50.99f, "Tort urodzinowy", "Torty" },
                    { 2, 60f, "Ciasto czekoladowe", "Ciasta" },
                    { 3, 5.5f, "Ciastka orzechowe", "Ciastka" },
                    { 4, 6.6f, "Ciastka czekoladowe", "Ciastka" },
                    { 5, 47.59f, "Ciasto waniliowe", "Ciasta" }
                });

            migrationBuilder.InsertData(
                table: "Zamowienie",
                columns: new[] { "IdZamowienie", "DataPrzyjecia", "DataRealizacji", "IdKlient", "IdPracownik", "Uwagi" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, null },
                    { 4, new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, null },
                    { 3, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, null },
                    { 2, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4, "bezglutenowe" },
                    { 5, new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4, "bez orzechów" }
                });

            migrationBuilder.InsertData(
                table: "Zamowienie_WyrobCukierniczy",
                columns: new[] { "IdWyrobuCukierniczego", "IdZamowienia", "Ilosc", "Uwagi" },
                values: new object[,]
                {
                    { 1, 1, 5, null },
                    { 4, 4, 2, null },
                    { 2, 3, 10, null },
                    { 4, 3, 2, "ccccccc" },
                    { 1, 2, 1, "aaaaaaa" },
                    { 5, 2, 5, null },
                    { 3, 5, 3, "bbbbbbb" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Klient",
                keyColumn: "IdKlient",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Klient",
                keyColumn: "IdKlient",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pracownik",
                keyColumn: "IdPracownik",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pracownik",
                keyColumn: "IdPracownik",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Zamowienie_WyrobCukierniczy",
                keyColumns: new[] { "IdWyrobuCukierniczego", "IdZamowienia" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Zamowienie_WyrobCukierniczy",
                keyColumns: new[] { "IdWyrobuCukierniczego", "IdZamowienia" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Zamowienie_WyrobCukierniczy",
                keyColumns: new[] { "IdWyrobuCukierniczego", "IdZamowienia" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Zamowienie_WyrobCukierniczy",
                keyColumns: new[] { "IdWyrobuCukierniczego", "IdZamowienia" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "Zamowienie_WyrobCukierniczy",
                keyColumns: new[] { "IdWyrobuCukierniczego", "IdZamowienia" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "Zamowienie_WyrobCukierniczy",
                keyColumns: new[] { "IdWyrobuCukierniczego", "IdZamowienia" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "Zamowienie_WyrobCukierniczy",
                keyColumns: new[] { "IdWyrobuCukierniczego", "IdZamowienia" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "WyrobCukierniczy",
                keyColumn: "IdWyrobuCukierniczego",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WyrobCukierniczy",
                keyColumn: "IdWyrobuCukierniczego",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WyrobCukierniczy",
                keyColumn: "IdWyrobuCukierniczego",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WyrobCukierniczy",
                keyColumn: "IdWyrobuCukierniczego",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WyrobCukierniczy",
                keyColumn: "IdWyrobuCukierniczego",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Zamowienie",
                keyColumn: "IdZamowienie",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Zamowienie",
                keyColumn: "IdZamowienie",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Zamowienie",
                keyColumn: "IdZamowienie",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Zamowienie",
                keyColumn: "IdZamowienie",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Zamowienie",
                keyColumn: "IdZamowienie",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Klient",
                keyColumn: "IdKlient",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Klient",
                keyColumn: "IdKlient",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Klient",
                keyColumn: "IdKlient",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pracownik",
                keyColumn: "IdPracownik",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pracownik",
                keyColumn: "IdPracownik",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pracownik",
                keyColumn: "IdPracownik",
                keyValue: 4);
        }
    }
}
