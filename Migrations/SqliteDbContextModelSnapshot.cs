﻿// <auto-generated />
using MaternityWard;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MaternityWard.Migrations
{
    [DbContext(typeof(SqliteDbContext))]
    partial class SqliteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("MaternityWard.Tables.Bonus", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<float>("BonusPercentage")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Bonuses");
                });

            modelBuilder.Entity("MaternityWard.Tables.HourlyRate", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<float>("Value")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("HourlyRates");
                });

            modelBuilder.Entity("MaternityWard.Tables.MonthActualWorkHours", b =>
                {
                    b.Property<string>("WorkerId")
                        .HasColumnType("TEXT");

                    b.Property<float>("Hours")
                        .HasColumnType("REAL");

                    b.HasKey("WorkerId");

                    b.ToTable("MonthActualWorkHours");
                });

            modelBuilder.Entity("MaternityWard.Tables.MonthMinimunWorkHours", b =>
                {
                    b.Property<string>("Rank")
                        .HasColumnType("TEXT");

                    b.Property<float>("Hours")
                        .HasColumnType("REAL");

                    b.HasKey("Rank");

                    b.ToTable("MonthMinimunWorkHours");
                });

            modelBuilder.Entity("MaternityWard.Tables.MonthWorkHours", b =>
                {
                    b.Property<string>("WorkerId")
                        .HasColumnType("TEXT");

                    b.Property<float>("Hours")
                        .HasColumnType("REAL");

                    b.HasKey("WorkerId");

                    b.ToTable("MonthWorkHours");
                });

            modelBuilder.Entity("MaternityWard.Tables.Worker", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkerType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("MaternityWard.Tables.WorkerTypeRank", b =>
                {
                    b.Property<string>("WorkerType")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rank")
                        .HasColumnType("TEXT");

                    b.HasKey("WorkerType", "Rank");

                    b.ToTable("WorkerTypeRank");
                });

            modelBuilder.Entity("MaternityWard.Tables.MonthActualWorkHours", b =>
                {
                    b.HasOne("MaternityWard.Tables.Worker", "Worker")
                        .WithMany()
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Worker");
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
#pragma warning restore 612, 618
        }
    }
}
