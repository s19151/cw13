using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia13.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Klient>().HasData
            (
                new Klient { IdKlient = 1, Imie = "Jan", Nazwisko = "Kowalski" },
                new Klient { IdKlient = 2, Imie = "Adam", Nazwisko = "Nowak" },
                new Klient { IdKlient = 3, Imie = "Anna", Nazwisko = "Kowalska" },
                new Klient { IdKlient = 4, Imie = "Aleksandra", Nazwisko = "Nowak" },
                new Klient { IdKlient = 5, Imie = "Piotr", Nazwisko = "Piotrowski" }
            );

            modelBuilder.Entity<Pracownik>().HasData
            (
                new Pracownik { IdPracownik = 1, Imie = "Jan", Nazwisko = "Kowalski" },
                new Pracownik { IdPracownik = 2, Imie = "Adam", Nazwisko = "Nowak" },
                new Pracownik { IdPracownik = 3, Imie = "Anna", Nazwisko = "Kowalska" },
                new Pracownik { IdPracownik = 4, Imie = "Aleksandra", Nazwisko = "Nowak" },
                new Pracownik { IdPracownik = 5, Imie = "Piotr", Nazwisko = "Piotrowski" }
            );

            modelBuilder.Entity<Zamowienie>().HasData
            (
                new Zamowienie { IdZamowienie = 1, DataPrzyjecia = DateTime.Parse("19.02.2020"), IdKlient = 1, IdPracownik = 1 },
                new Zamowienie { IdZamowienie = 2, DataPrzyjecia = DateTime.Parse("20.05.2020"), DataRealizacji = DateTime.Parse("30.05.2020"), Uwagi = "bezglutenowe", IdKlient = 2, IdPracownik = 4 },
                new Zamowienie { IdZamowienie = 3, DataPrzyjecia = DateTime.Parse("01.06.2020"), DataRealizacji = DateTime.Parse("14.06.2020"), IdKlient = 3, IdPracownik = 2 },
                new Zamowienie { IdZamowienie = 4, DataPrzyjecia = DateTime.Parse("04.06.2020"), IdKlient = 2, IdPracownik = 1 },
                new Zamowienie { IdZamowienie = 5, DataPrzyjecia = DateTime.Parse("07.06.2020"), Uwagi = "bez orzechów", IdKlient = 1, IdPracownik = 4 }
            );

            modelBuilder.Entity<WyrobCukierniczy>().HasData
            (
                new WyrobCukierniczy { IdWyrobuCukierniczego = 1, Nazwa = "Tort urodzinowy", CenaZaSzt = 50.99f, Typ = "Torty" },
                new WyrobCukierniczy { IdWyrobuCukierniczego = 2, Nazwa = "Ciasto czekoladowe", CenaZaSzt = 60.00f, Typ = "Ciasta" },
                new WyrobCukierniczy { IdWyrobuCukierniczego = 3, Nazwa = "Ciastka orzechowe", CenaZaSzt = 5.50f, Typ = "Ciastka" },
                new WyrobCukierniczy { IdWyrobuCukierniczego = 4, Nazwa = "Ciastka czekoladowe", CenaZaSzt = 6.60f, Typ = "Ciastka" },
                new WyrobCukierniczy { IdWyrobuCukierniczego = 5, Nazwa = "Ciasto waniliowe", CenaZaSzt = 47.59f, Typ = "Ciasta" }
            );

            modelBuilder.Entity<Zamowienie_WyrobCukierniczy>().HasData
            (
                new Zamowienie_WyrobCukierniczy { IdWyrobuCukierniczego = 1, IdZamowienia = 1, Ilosc = 5 },
                new Zamowienie_WyrobCukierniczy { IdWyrobuCukierniczego = 1, IdZamowienia = 2, Ilosc = 1, Uwagi = "aaaaaaa" },
                new Zamowienie_WyrobCukierniczy { IdWyrobuCukierniczego = 2, IdZamowienia = 3, Ilosc = 10 },
                new Zamowienie_WyrobCukierniczy { IdWyrobuCukierniczego = 3, IdZamowienia = 5, Ilosc = 3, Uwagi = "bbbbbbb" },
                new Zamowienie_WyrobCukierniczy { IdWyrobuCukierniczego = 4, IdZamowienia = 3, Ilosc = 2, Uwagi = "ccccccc" },
                new Zamowienie_WyrobCukierniczy { IdWyrobuCukierniczego = 4, IdZamowienia = 4, Ilosc = 2 },
                new Zamowienie_WyrobCukierniczy { IdWyrobuCukierniczego = 5, IdZamowienia = 2, Ilosc = 5 }
            );
        }
    }
}
