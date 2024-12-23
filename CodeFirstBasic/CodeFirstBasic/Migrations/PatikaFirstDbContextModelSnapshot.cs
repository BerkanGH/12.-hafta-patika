﻿// <auto-generated />
using CodeFirstBasic.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CodeFirstBasic.Migrations
{
    [DbContext(typeof(PatikaFirstDbContext))]
    partial class PatikaFirstDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CodeFirstBasic.Data.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Platform")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Rating")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "futbol",
                            Platform = "ucl",
                            Rating = 10m
                        },
                        new
                        {
                            Id = 2,
                            Name = "last of us2",
                            Platform = "ps",
                            Rating = 10m
                        },
                        new
                        {
                            Id = 3,
                            Name = "lol",
                            Platform = "pc",
                            Rating = 0m
                        });
                });

            modelBuilder.Entity("CodeFirstBasic.Data.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Genre = "action",
                            ReleaseYear = 2000,
                            Title = "Action Film1"
                        },
                        new
                        {
                            Id = 2,
                            Genre = "fantastic",
                            ReleaseYear = 2000,
                            Title = "fantastic Film1"
                        },
                        new
                        {
                            Id = 3,
                            Genre = "action",
                            ReleaseYear = 2000,
                            Title = "Action Film2"
                        },
                        new
                        {
                            Id = 4,
                            Genre = "drama",
                            ReleaseYear = 2000,
                            Title = "Drama Film1"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
