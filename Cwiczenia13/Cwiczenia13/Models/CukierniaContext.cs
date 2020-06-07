using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia13.Models
{
    public class CukierniaContext : DbContext
    {
        public virtual DbSet<Klient> Klient { get; set; }
        public virtual DbSet<Pracownik> Pracownik { get; set; }
        public virtual DbSet<Zamowienie> Zamowienie { get; set; }
        public virtual DbSet<WyrobCukierniczy> WyrobCukierniczy { get; set; }
        public virtual DbSet<Zamowienie_WyrobCukierniczy> Zamowienie_WyrobCukierniczy { get; set; }

        public CukierniaContext()
        { }

        public CukierniaContext(DbContextOptions<CukierniaContext> options)
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=db-mssql;Initial Catalog=s19151;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Klient>((builder) =>
            {
                builder.HasKey(k => k.IdKlient);
                builder.Property(k => k.IdKlient).ValueGeneratedOnAdd();

                builder.Property(k => k.Imie).HasMaxLength(50);
                builder.Property(k => k.Imie).IsRequired();
                builder.Property(k => k.Nazwisko).HasMaxLength(60);
                builder.Property(k => k.Nazwisko).IsRequired();

                builder.HasMany(k => k.Zamowienia)
                    .WithOne(z => z.Klient)
                    .HasForeignKey(z => z.IdKlient)
                    .IsRequired();
            });


            modelBuilder.Entity<Pracownik>((builder) =>
            {
                builder.HasKey(p => p.IdPracownik);
                builder.Property(p => p.IdPracownik).ValueGeneratedOnAdd();

                builder.Property(p => p.Imie).HasMaxLength(50);
                builder.Property(p => p.Imie).IsRequired();
                builder.Property(p => p.Nazwisko).HasMaxLength(60);
                builder.Property(p => p.Nazwisko).IsRequired();

                builder.HasMany(p => p.Zamowienia)
                    .WithOne(z => z.Pracownik)
                    .HasForeignKey(z => z.IdPracownik)
                    .IsRequired();
            });

            modelBuilder.Entity<Zamowienie>((builder) =>
            {
                builder.HasKey(z => z.IdZamowienie);
                builder.Property(z => z.IdZamowienie).ValueGeneratedOnAdd();

                builder.Property(z => z.DataPrzyjecia).IsRequired();
                builder.Property(z => z.Uwagi).HasMaxLength(300);
                builder.Property(z => z.IdKlient).IsRequired();
                builder.Property(z => z.IdZamowienie).IsRequired();

                builder.HasMany(z => z.Zamowienia_WyrobyCukiernicze)
                    .WithOne(zw => zw.Zamowienie)
                    .HasForeignKey(zw => zw.IdZamowienia)
                    .IsRequired();
            });

            modelBuilder.Entity<WyrobCukierniczy>((builder) =>
            {
                builder.HasKey(w => w.IdWyrobuCukierniczego);
                builder.Property(w => w.IdWyrobuCukierniczego).ValueGeneratedOnAdd();

                builder.Property(w => w.Nazwa).HasMaxLength(200);
                builder.Property(w => w.Nazwa).IsRequired();
                builder.Property(w => w.CenaZaSzt).IsRequired();
                builder.Property(w => w.Typ).HasMaxLength(40);
                builder.Property(w => w.Typ).IsRequired();

                builder.HasMany(w => w.Zamowienia_WyrobyCukiernicze)
                    .WithOne(zw => zw.WyrobCukierniczy)
                    .HasForeignKey(zw => zw.IdWyrobuCukierniczego)
                    .IsRequired();
            });

            modelBuilder.Entity<Zamowienie_WyrobCukierniczy>((builder) =>
            {
                builder.HasKey(zw => new
                {
                    zw.IdWyrobuCukierniczego,
                    zw.IdZamowienia
                });

                builder.Property(zw => zw.Ilosc).IsRequired();
                builder.Property(zw => zw.Uwagi).HasMaxLength(300);
            });

            modelBuilder.Seed();
        }
    }
}
