﻿// <auto-generated />
using System;
using MaternityWard;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MaternityWard.Migrations
{
    [DbContext(typeof(SqliteDbContext))]
    [Migration("20210626185435_AddWorkTime4")]
    partial class AddWorkTime4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("MaternityWard.Tables.MonthWorkHours", b =>
                {
                    b.Property<float>("Hours")
                        .HasColumnType("REAL");

                    b.Property<Guid>("WorkerId")
                        .HasColumnType("TEXT");

                    b.HasIndex("WorkerId");

                    b.ToTable("MonthWorkHours");
                });

            modelBuilder.Entity("MaternityWard.Tables.Price", b =>
                {
                    b.Property<string>("PriceName")
                        .HasColumnType("TEXT");

                    b.Property<float>("PriceValue")
                        .HasColumnType("REAL");

                    b.HasKey("PriceName");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("MaternityWard.Tables.RankBonus", b =>
                {
                    b.Property<string>("Rank")
                        .HasColumnType("TEXT");

                    b.Property<float>("BonusPercentages")
                        .HasColumnType("REAL");

                    b.Property<string>("PriceName")
                        .HasColumnType("TEXT");

                    b.HasKey("Rank");

                    b.HasIndex("PriceName");

                    b.ToTable("RankBonuses");
                });

            modelBuilder.Entity("MaternityWard.Tables.WorkTime", b =>
                {
                    b.Property<Guid>("WorkerId")
                        .HasColumnType("TEXT");

                    b.Property<float>("Hours")
                        .HasColumnType("REAL");

                    b.HasKey("WorkerId");

                    b.ToTable("WorkTimes");
                });

            modelBuilder.Entity("MaternityWard.Tables.Worker", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<float>("HourlyWage")
                        .HasColumnType("REAL");

                    b.Property<string>("WorkerType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("MaternityWard.Tables.MonthWorkHours", b =>
                {
                    b.HasOne("MaternityWard.Tables.Worker", "Worker")
                        .WithMany()
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("MaternityWard.Tables.RankBonus", b =>
                {
                    b.HasOne("MaternityWard.Tables.Price", null)
                        .WithMany("Bonuses")
                        .HasForeignKey("PriceName");
                });

            modelBuilder.Entity("MaternityWard.Tables.WorkTime", b =>
                {
                    b.HasOne("MaternityWard.Tables.Worker", "Worker")
                        .WithMany()
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("MaternityWard.Tables.Price", b =>
                {
                    b.Navigation("Bonuses");
                });
#pragma warning restore 612, 618
        }
    }
}
