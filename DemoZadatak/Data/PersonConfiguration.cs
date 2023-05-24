using DemoZadatak.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DemoZadatak.Data
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Persons");

            builder.HasKey(c => c.Id);

            SeedData(builder);
        }
        private static void SeedData(EntityTypeBuilder<Person> builder)
        {
            builder.HasData(
                           new Person { Id = 1, FirstName = "Darko", LastName = "Krofak", OIB = "01234567890", BirthDate = DateTime.Parse("01.01.2010") },
                           new Person { Id = 2, FirstName = "Marko", LastName = "Markovic", OIB = "12345678900", BirthDate = DateTime.Parse("02.09.1998") },
                           new Person { Id = 3, FirstName = "Zarko", LastName = "Zarkovic", OIB = "23456789001", BirthDate = DateTime.Parse("03.08.1990") },
                           new Person { Id = 4, FirstName = "Milo", LastName = "Hrnic", OIB = "34567890012", BirthDate = DateTime.Parse("04.07.1992") },
                           new Person { Id = 5, FirstName = "Ana", LastName = "Klaric", OIB = "45678900123", BirthDate = DateTime.Parse("05.10.2001") },
                           new Person { Id = 6, FirstName = "Kata", LastName = "Katic", OIB = "56789001234", BirthDate = DateTime.Parse("06.12.2000") },
                           new Person { Id = 7, FirstName = "Ante", LastName = "Antic", OIB = "67890012345", BirthDate = DateTime.Parse("07.05.1999") },
                           new Person { Id = 8, FirstName = "Ivan", LastName = "Krolo", OIB = "78900123456", BirthDate = DateTime.Parse("08.04.1989") },
                           new Person { Id = 9, FirstName = "Marijana", LastName = "Omazic", OIB = "89001234567", BirthDate = DateTime.Parse("09.08.1993") },
                           new Person { Id = 10, FirstName = "Ivo", LastName = "Ivic", OIB = "90012345678", BirthDate = DateTime.Parse("10.11.1970") });
        }
    }
}