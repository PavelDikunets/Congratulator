﻿// <auto-generated />
using System;
using Congratulator.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Congratulator.Db.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230221021254_AddTestPersons")]
    partial class AddTestPersons
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Congratulator.Db.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SocialStatus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1990, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "TestUser1",
                            LastName = "testUser1",
                            SocialStatus = 1
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1987, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "TestUser2",
                            LastName = "testUser2",
                            SocialStatus = 2
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(1989, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "TestUser3",
                            LastName = "testUser3",
                            SocialStatus = 0
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(1997, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "TestUser4",
                            LastName = "testUser4",
                            SocialStatus = 2
                        },
                        new
                        {
                            Id = 5,
                            BirthDate = new DateTime(1999, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "TestUser5",
                            LastName = "testUser5",
                            SocialStatus = 1
                        },
                        new
                        {
                            Id = 6,
                            BirthDate = new DateTime(1991, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "TestUser6",
                            LastName = "testUser6",
                            SocialStatus = 0
                        },
                        new
                        {
                            Id = 7,
                            BirthDate = new DateTime(2000, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "TestUser7",
                            LastName = "testUser7",
                            SocialStatus = 1
                        },
                        new
                        {
                            Id = 8,
                            BirthDate = new DateTime(1985, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "TestUser8",
                            LastName = "testUser8",
                            SocialStatus = 2
                        },
                        new
                        {
                            Id = 9,
                            BirthDate = new DateTime(1995, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "TestUser9",
                            LastName = "testUser9",
                            SocialStatus = 1
                        },
                        new
                        {
                            Id = 10,
                            BirthDate = new DateTime(1986, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "TestUser10",
                            LastName = "testUser10",
                            SocialStatus = 1
                        },
                        new
                        {
                            Id = 11,
                            BirthDate = new DateTime(2001, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "TestUser11",
                            LastName = "testUser11",
                            SocialStatus = 0
                        },
                        new
                        {
                            Id = 12,
                            BirthDate = new DateTime(1985, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "TestUser12",
                            LastName = "testUser12",
                            SocialStatus = 1
                        },
                        new
                        {
                            Id = 13,
                            BirthDate = new DateTime(2003, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "TestUser13",
                            LastName = "testUser13",
                            SocialStatus = 2
                        },
                        new
                        {
                            Id = 14,
                            BirthDate = new DateTime(1992, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "TestUser14",
                            LastName = "testUser14",
                            SocialStatus = 0
                        },
                        new
                        {
                            Id = 15,
                            BirthDate = new DateTime(1992, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "TestUser15",
                            LastName = "testUser15",
                            SocialStatus = 1
                        },
                        new
                        {
                            Id = 16,
                            BirthDate = new DateTime(1983, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "TestUser16",
                            LastName = "testUser16",
                            SocialStatus = 2
                        },
                        new
                        {
                            Id = 17,
                            BirthDate = new DateTime(1997, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "TestUser17",
                            LastName = "testUser17",
                            SocialStatus = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
