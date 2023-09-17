﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SocialNetworkClone.Data;

#nullable disable

namespace SocialNetworkClone.Migrations
{
    [DbContext(typeof(SocialNetworkDbContext))]
    [Migration("20230917134845_newPosts")]
    partial class newPosts
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SocialNetworkClone.Data.Entities.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TextContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            ImageLink = "https://images.unsplash.com/photo-1528717663417-3742fee05a29?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTR8fHBvc3R8ZW58MHx8MHx8fDA%3D&auto=format&fit=crop&w=500&q=60",
                            TextContent = "Це пост користувача 3",
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            ImageLink = "https://images.unsplash.com/photo-1487700160041-babef9c3cb55?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MjB8fHBvc3R8ZW58MHx8MHx8fDA%3D&auto=format&fit=crop&w=500&q=60",
                            TextContent = "Це пост користувача 4",
                            UserId = 4
                        },
                        new
                        {
                            Id = 5,
                            ImageLink = "https://images.unsplash.com/photo-1619211142200-0d30ded30ca8?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MjN8fHBvc3R8ZW58MHx8MHx8fDA%3D&auto=format&fit=crop&w=500&q=60",
                            TextContent = "Це пост користувача 5",
                            UserId = 5
                        },
                        new
                        {
                            Id = 6,
                            ImageLink = "https://images.unsplash.com/photo-1531564701487-f238224b7ce3?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8M3x8cG9zdHxlbnwwfHwwfHx8MA%3D%3D&auto=format&fit=crop&w=500&q=60",
                            TextContent = "Це пост користувача 5",
                            UserId = 5
                        },
                        new
                        {
                            Id = 8,
                            ImageLink = "https://plus.unsplash.com/premium_photo-1669006982986-b87b59ff8b7c?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MzF8fHBvc3R8ZW58MHx8MHx8fDA%3D&auto=format&fit=crop&w=500&q=60",
                            TextContent = "Це пост користувача 3",
                            UserId = 3
                        },
                        new
                        {
                            Id = 7,
                            ImageLink = "https://images.unsplash.com/photo-1518495973542-4542c06a5843?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NHx8cG9zdHxlbnwwfHwwfHx8MA%3D%3D&auto=format&fit=crop&w=500&q=60",
                            TextContent = "Це пост користувача 5",
                            UserId = 5
                        });
                });

            modelBuilder.Entity("SocialNetworkClone.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthdayDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthdayDate = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "user1@example.com",
                            FirstName = "Артур",
                            LastName = "Кутуков",
                            NickName = "user1",
                            Password = "hashed_password1",
                            RegistrationDate = new DateTime(2023, 9, 17, 16, 48, 45, 297, DateTimeKind.Local).AddTicks(2780)
                        },
                        new
                        {
                            Id = 2,
                            BirthdayDate = new DateTime(1995, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "user2@example.com",
                            FirstName = "Дмитро",
                            LastName = "Довжаниця",
                            NickName = "user2",
                            Password = "hashed_password2",
                            RegistrationDate = new DateTime(2023, 9, 17, 16, 48, 45, 297, DateTimeKind.Local).AddTicks(2910)
                        },
                        new
                        {
                            Id = 3,
                            BirthdayDate = new DateTime(1985, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "user3@example.com",
                            FirstName = "Микола",
                            LastName = "Панченко",
                            NickName = "user3",
                            Password = "hashed_password3",
                            RegistrationDate = new DateTime(2023, 9, 17, 16, 48, 45, 297, DateTimeKind.Local).AddTicks(2917)
                        },
                        new
                        {
                            Id = 4,
                            BirthdayDate = new DateTime(1992, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "user4@example.com",
                            FirstName = "Дарина",
                            LastName = "Мищук",
                            NickName = "user4",
                            Password = "hashed_password4",
                            RegistrationDate = new DateTime(2023, 9, 17, 16, 48, 45, 297, DateTimeKind.Local).AddTicks(2922)
                        },
                        new
                        {
                            Id = 5,
                            BirthdayDate = new DateTime(1988, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "user5@example.com",
                            FirstName = "Петро",
                            LastName = "Павлов",
                            NickName = "user5",
                            Password = "hashed_password5",
                            RegistrationDate = new DateTime(2023, 9, 17, 16, 48, 45, 297, DateTimeKind.Local).AddTicks(2927)
                        });
                });

            modelBuilder.Entity("SocialNetworkClone.Data.Entities.Post", b =>
                {
                    b.HasOne("SocialNetworkClone.Data.Entities.User", null)
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SocialNetworkClone.Data.Entities.User", b =>
                {
                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
