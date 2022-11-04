﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnetAPI.Data;

#nullable disable

namespace dotnetAPI.Migrations
{
    [DbContext(typeof(NZWalksDbContext))]
    partial class NZWalksDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("dotnetAPI.model.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Area")
                        .HasColumnType("double");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Lat")
                        .HasColumnType("double");

                    b.Property<double>("Long")
                        .HasColumnType("double");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("Population")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("dotnetAPI.model.Walk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Length")
                        .HasColumnType("double");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.Property<int>("WalkDifficultyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.HasIndex("WalkDifficultyId");

                    b.ToTable("Walks");
                });

            modelBuilder.Entity("dotnetAPI.model.WalkDifficulty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("WalkDifficulty");
                });

            modelBuilder.Entity("dotnetAPI.model.Walk", b =>
                {
                    b.HasOne("dotnetAPI.model.Region", "Region")
                        .WithMany("Walks")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dotnetAPI.model.WalkDifficulty", "WalkDifficulty")
                        .WithMany()
                        .HasForeignKey("WalkDifficultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");

                    b.Navigation("WalkDifficulty");
                });

            modelBuilder.Entity("dotnetAPI.model.Region", b =>
                {
                    b.Navigation("Walks");
                });
#pragma warning restore 612, 618
        }
    }
}
