﻿// <auto-generated />
using MaternityWard;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MaternityWard.Migrations
{
    [DbContext(typeof(SqliteDbContext))]
    [Migration("20210626160444_CreatingForienKey")]
    partial class CreatingForienKey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("MaternityWard.Bonus", b =>
                {
                    b.Property<string>("BonousName")
                        .HasColumnType("TEXT");

                    b.Property<float>("PriceName")
                        .HasColumnType("REAL");

                    b.Property<string>("PriceName1")
                        .HasColumnType("TEXT");

                    b.HasKey("BonousName");

                    b.HasIndex("PriceName1");

                    b.ToTable("Bonuses");
                });

            modelBuilder.Entity("MaternityWard.Price", b =>
                {
                    b.Property<string>("PriceName")
                        .HasColumnType("TEXT");

                    b.Property<float>("PriceValue")
                        .HasColumnType("REAL");

                    b.HasKey("PriceName");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("MaternityWard.Worker", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<float>("HourlyWage")
                        .HasColumnType("REAL");

                    b.Property<string>("WorkerType")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("MaternityWard.Bonus", b =>
                {
                    b.HasOne("MaternityWard.Price", null)
                        .WithMany("lol")
                        .HasForeignKey("PriceName1");
                });

            modelBuilder.Entity("MaternityWard.Price", b =>
                {
                    b.Navigation("lol");
                });
#pragma warning restore 612, 618
        }
    }
}