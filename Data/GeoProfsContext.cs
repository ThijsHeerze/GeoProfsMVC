using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GeoProfs.Models;

namespace GeoProfs.Data
{
    public class GeoProfsContext : DbContext
    {
        public GeoProfsContext (DbContextOptions<GeoProfsContext> options)
            : base(options)
        {
        }

        public DbSet<GeoProfs.Models.Verlof> Verlof { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Verlof>().ToTable("Verlof");
            modelBuilder.Entity<Medewerker>().ToTable("Medewerker");
            modelBuilder.Entity<Afdeling>().ToTable("Afdeling");
        }

        public DbSet<GeoProfs.Models.Medewerker>? Medewerker { get; set; }


        public DbSet<GeoProfs.Models.Afdeling>? Afdeling { get; set; }
    }
}
