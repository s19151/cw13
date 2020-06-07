﻿// <auto-generated />
using System;
using Cwiczenia13.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cwiczenia13.Migrations
{
    [DbContext(typeof(CukierniaContext))]
    partial class CukierniaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cwiczenia13.Models.Klient", b =>
                {
                    b.Property<int>("IdKlient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("IdKlient");

                    b.ToTable("Klient");

                    b.HasData(
                        new
                        {
                            IdKlient = 1,
                            Imie = "Jan",
                            Nazwisko = "Kowalski"
                        },
                        new
                        {
                            IdKlient = 2,
                            Imie = "Adam",
                            Nazwisko = "Nowak"
                        },
                        new
                        {
                            IdKlient = 3,
                            Imie = "Anna",
                            Nazwisko = "Kowalska"
                        },
                        new
                        {
                            IdKlient = 4,
                            Imie = "Aleksandra",
                            Nazwisko = "Nowak"
                        },
                        new
                        {
                            IdKlient = 5,
                            Imie = "Piotr",
                            Nazwisko = "Piotrowski"
                        });
                });

            modelBuilder.Entity("Cwiczenia13.Models.Pracownik", b =>
                {
                    b.Property<int>("IdPracownik")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("IdPracownik");

                    b.ToTable("Pracownik");

                    b.HasData(
                        new
                        {
                            IdPracownik = 1,
                            Imie = "Jan",
                            Nazwisko = "Kowalski"
                        },
                        new
                        {
                            IdPracownik = 2,
                            Imie = "Adam",
                            Nazwisko = "Nowak"
                        },
                        new
                        {
                            IdPracownik = 3,
                            Imie = "Anna",
                            Nazwisko = "Kowalska"
                        },
                        new
                        {
                            IdPracownik = 4,
                            Imie = "Aleksandra",
                            Nazwisko = "Nowak"
                        },
                        new
                        {
                            IdPracownik = 5,
                            Imie = "Piotr",
                            Nazwisko = "Piotrowski"
                        });
                });

            modelBuilder.Entity("Cwiczenia13.Models.WyrobCukierniczy", b =>
                {
                    b.Property<int>("IdWyrobuCukierniczego")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("CenaZaSzt")
                        .HasColumnType("real");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Typ")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.HasKey("IdWyrobuCukierniczego");

                    b.ToTable("WyrobCukierniczy");

                    b.HasData(
                        new
                        {
                            IdWyrobuCukierniczego = 1,
                            CenaZaSzt = 50.99f,
                            Nazwa = "Tort urodzinowy",
                            Typ = "Torty"
                        },
                        new
                        {
                            IdWyrobuCukierniczego = 2,
                            CenaZaSzt = 60f,
                            Nazwa = "Ciasto czekoladowe",
                            Typ = "Ciasta"
                        },
                        new
                        {
                            IdWyrobuCukierniczego = 3,
                            CenaZaSzt = 5.5f,
                            Nazwa = "Ciastka orzechowe",
                            Typ = "Ciastka"
                        },
                        new
                        {
                            IdWyrobuCukierniczego = 4,
                            CenaZaSzt = 6.6f,
                            Nazwa = "Ciastka czekoladowe",
                            Typ = "Ciastka"
                        },
                        new
                        {
                            IdWyrobuCukierniczego = 5,
                            CenaZaSzt = 47.59f,
                            Nazwa = "Ciasto waniliowe",
                            Typ = "Ciasta"
                        });
                });

            modelBuilder.Entity("Cwiczenia13.Models.Zamowienie", b =>
                {
                    b.Property<int>("IdZamowienie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataPrzyjecia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataRealizacji")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdKlient")
                        .HasColumnType("int");

                    b.Property<int>("IdPracownik")
                        .HasColumnType("int");

                    b.Property<string>("Uwagi")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.HasKey("IdZamowienie");

                    b.HasIndex("IdKlient");

                    b.HasIndex("IdPracownik");

                    b.ToTable("Zamowienie");

                    b.HasData(
                        new
                        {
                            IdZamowienie = 1,
                            DataPrzyjecia = new DateTime(2020, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataRealizacji = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdKlient = 1,
                            IdPracownik = 1
                        },
                        new
                        {
                            IdZamowienie = 2,
                            DataPrzyjecia = new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataRealizacji = new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdKlient = 2,
                            IdPracownik = 4,
                            Uwagi = "bezglutenowe"
                        },
                        new
                        {
                            IdZamowienie = 3,
                            DataPrzyjecia = new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataRealizacji = new DateTime(2020, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdKlient = 3,
                            IdPracownik = 2
                        },
                        new
                        {
                            IdZamowienie = 4,
                            DataPrzyjecia = new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataRealizacji = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdKlient = 2,
                            IdPracownik = 1
                        },
                        new
                        {
                            IdZamowienie = 5,
                            DataPrzyjecia = new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataRealizacji = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdKlient = 1,
                            IdPracownik = 4,
                            Uwagi = "bez orzechów"
                        });
                });

            modelBuilder.Entity("Cwiczenia13.Models.Zamowienie_WyrobCukierniczy", b =>
                {
                    b.Property<int>("IdWyrobuCukierniczego")
                        .HasColumnType("int");

                    b.Property<int>("IdZamowienia")
                        .HasColumnType("int");

                    b.Property<int>("Ilosc")
                        .HasColumnType("int");

                    b.Property<string>("Uwagi")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.HasKey("IdWyrobuCukierniczego", "IdZamowienia");

                    b.HasIndex("IdZamowienia");

                    b.ToTable("Zamowienie_WyrobCukierniczy");

                    b.HasData(
                        new
                        {
                            IdWyrobuCukierniczego = 1,
                            IdZamowienia = 1,
                            Ilosc = 5
                        },
                        new
                        {
                            IdWyrobuCukierniczego = 1,
                            IdZamowienia = 2,
                            Ilosc = 1,
                            Uwagi = "aaaaaaa"
                        },
                        new
                        {
                            IdWyrobuCukierniczego = 2,
                            IdZamowienia = 3,
                            Ilosc = 10
                        },
                        new
                        {
                            IdWyrobuCukierniczego = 3,
                            IdZamowienia = 5,
                            Ilosc = 3,
                            Uwagi = "bbbbbbb"
                        },
                        new
                        {
                            IdWyrobuCukierniczego = 4,
                            IdZamowienia = 3,
                            Ilosc = 2,
                            Uwagi = "ccccccc"
                        },
                        new
                        {
                            IdWyrobuCukierniczego = 4,
                            IdZamowienia = 4,
                            Ilosc = 2
                        },
                        new
                        {
                            IdWyrobuCukierniczego = 5,
                            IdZamowienia = 2,
                            Ilosc = 5
                        });
                });

            modelBuilder.Entity("Cwiczenia13.Models.Zamowienie", b =>
                {
                    b.HasOne("Cwiczenia13.Models.Klient", "Klient")
                        .WithMany("Zamowienia")
                        .HasForeignKey("IdKlient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cwiczenia13.Models.Pracownik", "Pracownik")
                        .WithMany("Zamowienia")
                        .HasForeignKey("IdPracownik")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cwiczenia13.Models.Zamowienie_WyrobCukierniczy", b =>
                {
                    b.HasOne("Cwiczenia13.Models.WyrobCukierniczy", "WyrobCukierniczy")
                        .WithMany("Zamowienia_WyrobyCukiernicze")
                        .HasForeignKey("IdWyrobuCukierniczego")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cwiczenia13.Models.Zamowienie", "Zamowienie")
                        .WithMany("Zamowienia_WyrobyCukiernicze")
                        .HasForeignKey("IdZamowienia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
