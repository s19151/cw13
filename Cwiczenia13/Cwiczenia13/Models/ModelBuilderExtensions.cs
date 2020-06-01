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
                new Klient { }
            );

            modelBuilder.Entity<Pracownik>().HasData
            (
                new Pracownik { }
            );

            modelBuilder.Entity<Zamowienie>().HasData
            (
                new Zamowienie { }
            );

            modelBuilder.Entity<WyrobCukierniczy>().HasData
            (
                new WyrobCukierniczy { }
            );

            modelBuilder.Entity<Zamowienie_WyrobCukierniczy>().HasData
            (
                new Zamowienie_WyrobCukierniczy { }
            );
        }
    }
}
