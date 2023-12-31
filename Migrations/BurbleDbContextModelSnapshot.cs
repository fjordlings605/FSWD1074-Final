﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using burble_api.Migrations;

#nullable disable

namespace burble_api.Migrations
{
    [DbContext(typeof(BurbleDbContext))]
    partial class BurbleDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("burble_api.Models.Burble", b =>
                {
                    b.Property<string>("BurbId")
                        .HasColumnType("TEXT");

                    b.Property<string>("BurbTxt")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TimeDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("BurbId");

                    b.ToTable("Burble");

                    b.HasData(
                        new
                        {
                            BurbId = "1",
                            BurbTxt = "First Burb Ever!  Woot Woot!",
                            TimeDate = new DateTime(2023, 10, 30, 23, 49, 23, 869, DateTimeKind.Local).AddTicks(4082),
                            Username = "Default01"
                        },
                        new
                        {
                            BurbId = "2",
                            BurbTxt = "Second Burb, Great as the First!  BlblBlblbrblrblbrbrlbrbbrbll!",
                            TimeDate = new DateTime(2023, 10, 30, 23, 49, 23, 869, DateTimeKind.Local).AddTicks(4142),
                            Username = "Default02"
                        });
                });

            modelBuilder.Entity("burble_api.Models.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
