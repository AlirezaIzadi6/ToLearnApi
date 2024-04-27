﻿// <auto-generated />
using ConjugationAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConjugationAPI.Migrations
{
    [DbContext(typeof(ConjugationContext))]
    partial class ConjugationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Conjugation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Form1P")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Form1S")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Form2P")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Form2S")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Form3P")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Form3S")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gerund")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GerundEnglish")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Infinitive")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InfinitiveEnglish")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mood")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoodEnglish")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PastParticiple")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PastParticipleEnglish")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tense")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenseEnglish")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VerbEnglish")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("conjugations");
                });

            modelBuilder.Entity("ConjugationAPI.Models.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AnswerText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("answers");
                });

            modelBuilder.Entity("ConjugationAPI.Models.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Infinitives")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Moods")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Persons")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("ConjugationAPI.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HasBeenAnswered")
                        .HasColumnType("bit");

                    b.Property<string>("Infinitive")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mood")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Person")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("questions");
                });

            modelBuilder.Entity("ConjugationAPI.Models.UserScore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Userscores");
                });
#pragma warning restore 612, 618
        }
    }
}
