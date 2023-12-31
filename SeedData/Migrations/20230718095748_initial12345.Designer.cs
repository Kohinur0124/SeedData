﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SeedData.Data;

#nullable disable

namespace SeedData.Migrations
{
    [DbContext(typeof(DbUser))]
    [Migration("20230718095748_initial12345")]
    partial class initial12345
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SeedData.Medels.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "sev@gmail.com",
                            Name = "Sevinch",
                            Password = "0124"
                        },
                        new
                        {
                            Id = 2,
                            Email = "sad@gamil.com",
                            Name = "Sadaf",
                            Password = "0123"
                        },
                        new
                        {
                            Id = 3,
                            Email = "gozal@gmail.com",
                            Name = "Go`zal",
                            Password = "0213"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
