﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Survivor.Context;

#nullable disable

namespace Survivor.Migrations
{
    [DbContext(typeof(CompetitorCategoryContext))]
    [Migration("20241224024537_ılk")]
    partial class ılk
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Survivor.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Utc),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Ünlüler"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Utc),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Gönüllüler"
                        });
                });

            modelBuilder.Entity("Survivor.Models.Competitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Competitors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Acun",
                            IsDeleted = false,
                            LastName = "Ilıcalı",
                            ModifiedDate = new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Ali",
                            IsDeleted = false,
                            LastName = "Koç",
                            ModifiedDate = new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Mehmet",
                            IsDeleted = false,
                            LastName = "Türkan",
                            ModifiedDate = new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Ahmet",
                            IsDeleted = false,
                            LastName = "Yılmaz",
                            ModifiedDate = new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Dursun",
                            IsDeleted = false,
                            LastName = "Ozbek",
                            ModifiedDate = new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Utc)
                        });
                });

            modelBuilder.Entity("Survivor.Models.Competitor", b =>
                {
                    b.HasOne("Survivor.Models.Category", "Category")
                        .WithMany("Competitors")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Survivor.Models.Category", b =>
                {
                    b.Navigation("Competitors");
                });
#pragma warning restore 612, 618
        }
    }
}
