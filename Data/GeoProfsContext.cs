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
        public DbSet<GeoProfs.Models.Medewerker> Medewerker { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Verlof>().ToTable("Verlof");
        }
    }
}
