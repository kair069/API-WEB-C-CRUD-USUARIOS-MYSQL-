﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyWebApi.Models;

#nullable disable

namespace MyWebApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MyWebApi.Models.AppDbContext+Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Correo")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
