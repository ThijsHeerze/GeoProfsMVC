﻿// <auto-generated />
using System;
using GeoProfs.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeoProfs.Migrations
{
    [DbContext(typeof(GeoProfsContext))]
    partial class GeoProfsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GeoProfs.Models.Verlof", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.Property<string>("RedenVerlof")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WerknemerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Verlof");
                });
#pragma warning restore 612, 618
        }
    }
}
