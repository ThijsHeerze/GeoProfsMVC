/*using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GeoProfs.Data;
using System;
using System.Linq;

namespace GeoProfs.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GeoProfsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GeoProfsContext>>()))
            {

                if (context.Verlof.Any())
                {
                    return;   // DB has been seeded
                }

                context.Verlof.AddRange(
                    new Verlof
                    {
                        Naam = "Harry",
                        Datum = DateTime.Parse("1989-2-12"),
                        RedenVerlof = "Ziek",
                        Afdeling = 1,
                    },

                    new Verlof
                    {
                        Naam = "Harry",
                        Datum = DateTime.Parse("1989-2-12"),
                        RedenVerlof = "Ziek",
                        Afdeling = 1,
                    },

                    new Verlof
                    {
                        Naam = "Harry",
                        Datum = DateTime.Parse("1989-2-12"),
                        RedenVerlof = "Ziek",
                        Afdeling = 1,
                    },

                    new Verlof
                    {
                        Naam = "Harry",
                        Datum = DateTime.Parse("1989-2-12"),
                        RedenVerlof = "Ziek",
                        Afdeling = 1,
                    }
                );
                context.SaveChanges();
            }
        }
    }
}*/