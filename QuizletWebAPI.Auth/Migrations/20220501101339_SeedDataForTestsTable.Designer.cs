﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuizletWebAPI.Auth.Data;

#nullable disable

namespace QuizletWebAPI.Auth.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220501101339_SeedDataForTestsTable")]
    partial class SeedDataForTestsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("QuizletWebAPI.Auth.Models.Access", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TestId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Accesses");
                });

            modelBuilder.Entity("QuizletWebAPI.Auth.Models.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("QuizletWebAPI.Auth.Models.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Answers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Questions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tests", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Answers = "[{\"questionNumber\":1,\"bodyAnswer\":[{\"text\":\":\",\"isCorrect\":true},{\"text\":\";\",\"isCorrect\":false},{\"text\":\"!\",\"isCorrect\":false}]},{\"questionNumber\":2,\"bodyAnswer\":[{\"text\":\"string\",\"isCorrect\":false},{\"text\":\"boolean\",\"isCorrect\":false},{\"text\":\"enum\",\"isCorrect\":true}]},{\"questionNumber\":3,\"bodyAnswer\":[{\"text\":\"Use classes.\",\"isCorrect\":false},{\"text\":\"Use interfaces.\",\"isCorrect\":true},{\"text\":\"Use enums.\",\"isCorrect\":false}]},{\"questionNumber\":4,\"bodyAnswer\":[{\"text\":\"@number\",\"isCorrect\":false},{\"text\":\"number[]\",\"isCorrect\":true},{\"text\":\"number?\",\"isCorrect\":false}]},{\"questionNumber\":5,\"bodyAnswer\":[{\"text\":\"constructor\",\"isCorrect\":true},{\"text\":\"destructor\",\"isCorrect\":false},{\"text\":\"import\",\"isCorrect\":false}]},{\"questionNumber\":6,\"bodyAnswer\":[{\"text\":\"protected\",\"isCorrect\":false},{\"text\":\"public\",\"isCorrect\":false},{\"text\":\"async\",\"isCorrect\":true}]},{\"questionNumber\":7,\"bodyAnswer\":[{\"text\":\"constructor\",\"isCorrect\":false},{\"text\":\"import\",\"isCorrect\":false},{\"text\":\"export\",\"isCorrect\":true}]},{\"questionNumber\":8,\"bodyAnswer\":[{\"text\":\"filter\",\"isCorrect\":true},{\"text\":\"map\",\"isCorrect\":false},{\"text\":\"enum\",\"isCorrect\":false}]},{\"questionNumber\":9,\"bodyAnswer\":[{\"text\":\"Arrow function\",\"isCorrect\":false},{\"text\":\"Accessors\",\"isCorrect\":false},{\"text\":\"Using this.propertyName\",\"isCorrect\":true}]}]",
                            Description = "TypeScript knowledge test",
                            Name = "Test 1",
                            Questions = "[{\"number\":1,\"body\":\"Which of the following does TypeScript use to specify types?\"},{\"number\":2,\"body\":\"Which of the following is NOT a type used in TypeScript?\"},{\"number\":3,\"body\":\"How can we specify properties and methods for an object in TypeScript?\"},{\"number\":4,\"body\":\"How else can Array\\u003Cnumber\\u003E be written in TypeScript?\"},{\"number\":5,\"body\":\"In which of these does a class take parameters?\"},{\"number\":6,\"body\":\"Which is NOT an access modifier?\"},{\"number\":7,\"body\":\"Which keyword allows us to share information between files in TypeScript?\"},{\"number\":8,\"body\":\"Which is an array method to generate a new array based on a condition?\"},{\"number\":9,\"body\":\"How is a property accessible within a class?\"}]"
                        },
                        new
                        {
                            Id = 2,
                            Answers = "[{\"questionNumber\":1,\"bodyAnswer\":[{\"text\":\":\",\"isCorrect\":true},{\"text\":\";\",\"isCorrect\":false},{\"text\":\"!\",\"isCorrect\":false}]},{\"questionNumber\":2,\"bodyAnswer\":[{\"text\":\"string\",\"isCorrect\":false},{\"text\":\"boolean\",\"isCorrect\":false},{\"text\":\"enum\",\"isCorrect\":true}]},{\"questionNumber\":3,\"bodyAnswer\":[{\"text\":\"Use classes.\",\"isCorrect\":false},{\"text\":\"Use interfaces.\",\"isCorrect\":true},{\"text\":\"Use enums.\",\"isCorrect\":false}]},{\"questionNumber\":4,\"bodyAnswer\":[{\"text\":\"@number\",\"isCorrect\":false},{\"text\":\"number[]\",\"isCorrect\":true},{\"text\":\"number?\",\"isCorrect\":false}]},{\"questionNumber\":5,\"bodyAnswer\":[{\"text\":\"constructor\",\"isCorrect\":true},{\"text\":\"destructor\",\"isCorrect\":false},{\"text\":\"import\",\"isCorrect\":false}]},{\"questionNumber\":6,\"bodyAnswer\":[{\"text\":\"protected\",\"isCorrect\":false},{\"text\":\"public\",\"isCorrect\":false},{\"text\":\"async\",\"isCorrect\":true}]},{\"questionNumber\":7,\"bodyAnswer\":[{\"text\":\"constructor\",\"isCorrect\":false},{\"text\":\"import\",\"isCorrect\":false},{\"text\":\"export\",\"isCorrect\":true}]},{\"questionNumber\":8,\"bodyAnswer\":[{\"text\":\"filter\",\"isCorrect\":true},{\"text\":\"map\",\"isCorrect\":false},{\"text\":\"enum\",\"isCorrect\":false}]},{\"questionNumber\":9,\"bodyAnswer\":[{\"text\":\"Arrow function\",\"isCorrect\":false},{\"text\":\"Accessors\",\"isCorrect\":false},{\"text\":\"Using this.propertyName\",\"isCorrect\":true}]}]",
                            Description = "TypeScript knowledge test",
                            Name = "Test 2",
                            Questions = "[{\"number\":1,\"body\":\"Which of the following does TypeScript use to specify types?\"},{\"number\":2,\"body\":\"Which of the following is NOT a type used in TypeScript?\"},{\"number\":3,\"body\":\"How can we specify properties and methods for an object in TypeScript?\"},{\"number\":4,\"body\":\"How else can Array\\u003Cnumber\\u003E be written in TypeScript?\"},{\"number\":5,\"body\":\"In which of these does a class take parameters?\"},{\"number\":6,\"body\":\"Which is NOT an access modifier?\"},{\"number\":7,\"body\":\"Which keyword allows us to share information between files in TypeScript?\"},{\"number\":8,\"body\":\"Which is an array method to generate a new array based on a condition?\"},{\"number\":9,\"body\":\"How is a property accessible within a class?\"}]"
                        },
                        new
                        {
                            Id = 3,
                            Answers = "[{\"questionNumber\":1,\"bodyAnswer\":[{\"text\":\":\",\"isCorrect\":true},{\"text\":\";\",\"isCorrect\":false},{\"text\":\"!\",\"isCorrect\":false}]},{\"questionNumber\":2,\"bodyAnswer\":[{\"text\":\"string\",\"isCorrect\":false},{\"text\":\"boolean\",\"isCorrect\":false},{\"text\":\"enum\",\"isCorrect\":true}]},{\"questionNumber\":3,\"bodyAnswer\":[{\"text\":\"Use classes.\",\"isCorrect\":false},{\"text\":\"Use interfaces.\",\"isCorrect\":true},{\"text\":\"Use enums.\",\"isCorrect\":false}]},{\"questionNumber\":4,\"bodyAnswer\":[{\"text\":\"@number\",\"isCorrect\":false},{\"text\":\"number[]\",\"isCorrect\":true},{\"text\":\"number?\",\"isCorrect\":false}]},{\"questionNumber\":5,\"bodyAnswer\":[{\"text\":\"constructor\",\"isCorrect\":true},{\"text\":\"destructor\",\"isCorrect\":false},{\"text\":\"import\",\"isCorrect\":false}]},{\"questionNumber\":6,\"bodyAnswer\":[{\"text\":\"protected\",\"isCorrect\":false},{\"text\":\"public\",\"isCorrect\":false},{\"text\":\"async\",\"isCorrect\":true}]},{\"questionNumber\":7,\"bodyAnswer\":[{\"text\":\"constructor\",\"isCorrect\":false},{\"text\":\"import\",\"isCorrect\":false},{\"text\":\"export\",\"isCorrect\":true}]},{\"questionNumber\":8,\"bodyAnswer\":[{\"text\":\"filter\",\"isCorrect\":true},{\"text\":\"map\",\"isCorrect\":false},{\"text\":\"enum\",\"isCorrect\":false}]},{\"questionNumber\":9,\"bodyAnswer\":[{\"text\":\"Arrow function\",\"isCorrect\":false},{\"text\":\"Accessors\",\"isCorrect\":false},{\"text\":\"Using this.propertyName\",\"isCorrect\":true}]}]",
                            Description = "TypeScript knowledge test",
                            Name = "Test 3",
                            Questions = "[{\"number\":1,\"body\":\"Which of the following does TypeScript use to specify types?\"},{\"number\":2,\"body\":\"Which of the following is NOT a type used in TypeScript?\"},{\"number\":3,\"body\":\"How can we specify properties and methods for an object in TypeScript?\"},{\"number\":4,\"body\":\"How else can Array\\u003Cnumber\\u003E be written in TypeScript?\"},{\"number\":5,\"body\":\"In which of these does a class take parameters?\"},{\"number\":6,\"body\":\"Which is NOT an access modifier?\"},{\"number\":7,\"body\":\"Which keyword allows us to share information between files in TypeScript?\"},{\"number\":8,\"body\":\"Which is an array method to generate a new array based on a condition?\"},{\"number\":9,\"body\":\"How is a property accessible within a class?\"}]"
                        },
                        new
                        {
                            Id = 4,
                            Answers = "[{\"questionNumber\":1,\"bodyAnswer\":[{\"text\":\":\",\"isCorrect\":true},{\"text\":\";\",\"isCorrect\":false},{\"text\":\"!\",\"isCorrect\":false}]},{\"questionNumber\":2,\"bodyAnswer\":[{\"text\":\"string\",\"isCorrect\":false},{\"text\":\"boolean\",\"isCorrect\":false},{\"text\":\"enum\",\"isCorrect\":true}]},{\"questionNumber\":3,\"bodyAnswer\":[{\"text\":\"Use classes.\",\"isCorrect\":false},{\"text\":\"Use interfaces.\",\"isCorrect\":true},{\"text\":\"Use enums.\",\"isCorrect\":false}]},{\"questionNumber\":4,\"bodyAnswer\":[{\"text\":\"@number\",\"isCorrect\":false},{\"text\":\"number[]\",\"isCorrect\":true},{\"text\":\"number?\",\"isCorrect\":false}]},{\"questionNumber\":5,\"bodyAnswer\":[{\"text\":\"constructor\",\"isCorrect\":true},{\"text\":\"destructor\",\"isCorrect\":false},{\"text\":\"import\",\"isCorrect\":false}]},{\"questionNumber\":6,\"bodyAnswer\":[{\"text\":\"protected\",\"isCorrect\":false},{\"text\":\"public\",\"isCorrect\":false},{\"text\":\"async\",\"isCorrect\":true}]},{\"questionNumber\":7,\"bodyAnswer\":[{\"text\":\"constructor\",\"isCorrect\":false},{\"text\":\"import\",\"isCorrect\":false},{\"text\":\"export\",\"isCorrect\":true}]},{\"questionNumber\":8,\"bodyAnswer\":[{\"text\":\"filter\",\"isCorrect\":true},{\"text\":\"map\",\"isCorrect\":false},{\"text\":\"enum\",\"isCorrect\":false}]},{\"questionNumber\":9,\"bodyAnswer\":[{\"text\":\"Arrow function\",\"isCorrect\":false},{\"text\":\"Accessors\",\"isCorrect\":false},{\"text\":\"Using this.propertyName\",\"isCorrect\":true}]}]",
                            Description = "TypeScript knowledge test",
                            Name = "Test 4",
                            Questions = "[{\"number\":1,\"body\":\"Which of the following does TypeScript use to specify types?\"},{\"number\":2,\"body\":\"Which of the following is NOT a type used in TypeScript?\"},{\"number\":3,\"body\":\"How can we specify properties and methods for an object in TypeScript?\"},{\"number\":4,\"body\":\"How else can Array\\u003Cnumber\\u003E be written in TypeScript?\"},{\"number\":5,\"body\":\"In which of these does a class take parameters?\"},{\"number\":6,\"body\":\"Which is NOT an access modifier?\"},{\"number\":7,\"body\":\"Which keyword allows us to share information between files in TypeScript?\"},{\"number\":8,\"body\":\"Which is an array method to generate a new array based on a condition?\"},{\"number\":9,\"body\":\"How is a property accessible within a class?\"}]"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
