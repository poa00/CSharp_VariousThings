﻿// <auto-generated />
using AWSPluralSightDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AWSPluralSightDemo.Migrations
{
    [DbContext(typeof(BookContext))]
    partial class BookContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AWSPluralSightDemo.DomainClasses.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            Name = "Mico Yuk"
                        },
                        new
                        {
                            AuthorId = 2,
                            Name = "Arlan Hamilton"
                        },
                        new
                        {
                            AuthorId = 3,
                            Name = "Minda Harts"
                        },
                        new
                        {
                            AuthorId = 4,
                            Name = "Susanne Tedrick"
                        },
                        new
                        {
                            AuthorId = 5,
                            Name = "Abisoye Ajayi-Akinfolarin"
                        },
                        new
                        {
                            AuthorId = 6,
                            Name = "Kesha Williams"
                        });
                });

            modelBuilder.Entity("AWSPluralSightDemo.DomainClasses.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("BookId"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            AuthorId = 1,
                            Title = "Data Visualization for Dummies"
                        },
                        new
                        {
                            BookId = 2,
                            AuthorId = 2,
                            Title = "It's About Damn Time"
                        },
                        new
                        {
                            BookId = 3,
                            AuthorId = 3,
                            Title = "The Memo"
                        },
                        new
                        {
                            BookId = 4,
                            AuthorId = 4,
                            Title = "Women of Color in Tech"
                        },
                        new
                        {
                            BookId = 5,
                            AuthorId = 5,
                            Title = "I WOKE UP AT 30: How I Utilised Inertia for Global Impact"
                        },
                        new
                        {
                            BookId = 6,
                            AuthorId = 6,
                            Title = "No books but check out her Pluralsight courses!"
                        });
                });

            modelBuilder.Entity("AWSPluralSightDemo.DomainClasses.Book", b =>
                {
                    b.HasOne("AWSPluralSightDemo.DomainClasses.Author", null)
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AWSPluralSightDemo.DomainClasses.Author", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}