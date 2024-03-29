﻿// <auto-generated />
using BlazorRenderErrorTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorRenderErrorTest.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("BlazorRenderErrorTest.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<long>("Tel")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Kceilorty",
                            Tel = 77448545664L
                        },
                        new
                        {
                            Id = 2,
                            Name = "Zurokiea",
                            Tel = 77448545664L
                        },
                        new
                        {
                            Id = 3,
                            Name = "Stymliea",
                            Tel = 77448545664L
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
