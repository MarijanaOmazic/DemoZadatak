﻿// <auto-generated />
using System;
using DemoZadatak.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DemoZadatak.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230108195959_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DemoZadatak.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OIB")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Darko",
                            LastName = "Krofak",
                            OIB = "01234567890"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1998, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Marko",
                            LastName = "Markovic",
                            OIB = "12345678900"
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(1990, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Zarko",
                            LastName = "Zarkovic",
                            OIB = "23456789001"
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(1992, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Milo",
                            LastName = "Hrnic",
                            OIB = "34567890012"
                        },
                        new
                        {
                            Id = 5,
                            BirthDate = new DateTime(2001, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Ana",
                            LastName = "Klaric",
                            OIB = "45678900123"
                        },
                        new
                        {
                            Id = 6,
                            BirthDate = new DateTime(2000, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Kata",
                            LastName = "Katic",
                            OIB = "56789001234"
                        },
                        new
                        {
                            Id = 7,
                            BirthDate = new DateTime(1999, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Ante",
                            LastName = "Antic",
                            OIB = "67890012345"
                        },
                        new
                        {
                            Id = 8,
                            BirthDate = new DateTime(1989, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Ivan",
                            LastName = "Krolo",
                            OIB = "78900123456"
                        },
                        new
                        {
                            Id = 9,
                            BirthDate = new DateTime(1993, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Marijana",
                            LastName = "Omazic",
                            OIB = "89001234567"
                        },
                        new
                        {
                            Id = 10,
                            BirthDate = new DateTime(1970, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Ivo",
                            LastName = "Ivic",
                            OIB = "90012345678"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
