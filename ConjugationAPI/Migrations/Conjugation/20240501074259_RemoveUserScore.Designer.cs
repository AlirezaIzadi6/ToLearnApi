﻿// <auto-generated />
using System;
using ConjugationAPI.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConjugationAPI.Migrations.Conjugation
{
    [DbContext(typeof(ConjugationContext))]
    [Migration("20240501074259_RemoveUserScore")]
    partial class RemoveUserScore
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ConjugationAPI.Models.Conjugation.Answer", b =>
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

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("answers");
                });

            modelBuilder.Entity("ConjugationAPI.Models.Conjugation.Conjugation", b =>
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

            modelBuilder.Entity("ConjugationAPI.Models.Conjugation.Profile", b =>
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

            modelBuilder.Entity("ConjugationAPI.Models.Conjugation.Question", b =>
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

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("questions");
                });
#pragma warning restore 612, 618
        }
    }
}