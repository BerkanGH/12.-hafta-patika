﻿// <auto-generated />
using CodeFirstRelation.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CodeFirstRelation.Migrations
{
    [DbContext(typeof(PatikaSecondDbContext))]
    partial class PatikaSecondDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CodeFirstRelation.Data.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "haber",
                            Title = "ülke gündemi",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Content = "futbol",
                            Title = "avrupa ligi",
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            Content = "magazin",
                            Title = "dümenden haber",
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            Content = "haber",
                            Title = "ekonomi",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("CodeFirstRelation.Data.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "ali@gmail.com",
                            UserName = "ali"
                        },
                        new
                        {
                            Id = 2,
                            Email = "merve@gmail.com",
                            UserName = "merve"
                        },
                        new
                        {
                            Id = 3,
                            Email = "sinem@gmail.com",
                            UserName = "sinem"
                        });
                });

            modelBuilder.Entity("CodeFirstRelation.Data.Post", b =>
                {
                    b.HasOne("CodeFirstRelation.Data.User", "user")
                        .WithMany("Post")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("CodeFirstRelation.Data.User", b =>
                {
                    b.Navigation("Post");
                });
#pragma warning restore 612, 618
        }
    }
}
