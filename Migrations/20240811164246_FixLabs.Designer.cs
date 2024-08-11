﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using infrastructure.persistence;

#nullable disable

namespace LabsManager.Migrations
{
    [DbContext(typeof(LabsManagerDbContext))]
    [Migration("20240811164246_FixLabs")]
    partial class FixLabs
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("domain.entities.FollowStudentSubject", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<DateTime>("followDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("studentId")
                        .HasColumnType("integer");

                    b.Property<int>("subjectId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("studentId");

                    b.HasIndex("subjectId");

                    b.ToTable("follows");
                });

            modelBuilder.Entity("domain.entities.Lab", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("exercises")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<string>("materials")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("subjectId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("subjectId");

                    b.ToTable("labs");
                });

            modelBuilder.Entity("domain.entities.Student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("faculty")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("group")
                        .HasColumnType("integer");

                    b.Property<string>("login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("students");
                });

            modelBuilder.Entity("domain.entities.Subject", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("authorId")
                        .HasColumnType("integer");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("needHours")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("authorId");

                    b.ToTable("subjects");
                });

            modelBuilder.Entity("domain.entities.Teacher", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("cafedra")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("faculty")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isAdmin")
                        .HasColumnType("boolean");

                    b.Property<string>("login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("teachers");
                });

            modelBuilder.Entity("domain.entities.FollowStudentSubject", b =>
                {
                    b.HasOne("domain.entities.Student", "student")
                        .WithMany("subjects")
                        .HasForeignKey("studentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("domain.entities.Subject", "subject")
                        .WithMany("followStudentSubjects")
                        .HasForeignKey("subjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("student");

                    b.Navigation("subject");
                });

            modelBuilder.Entity("domain.entities.Lab", b =>
                {
                    b.HasOne("domain.entities.Subject", "subject")
                        .WithMany("labs")
                        .HasForeignKey("subjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("subject");
                });

            modelBuilder.Entity("domain.entities.Subject", b =>
                {
                    b.HasOne("domain.entities.Teacher", "author")
                        .WithMany("subjects")
                        .HasForeignKey("authorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("author");
                });

            modelBuilder.Entity("domain.entities.Student", b =>
                {
                    b.Navigation("subjects");
                });

            modelBuilder.Entity("domain.entities.Subject", b =>
                {
                    b.Navigation("followStudentSubjects");

                    b.Navigation("labs");
                });

            modelBuilder.Entity("domain.entities.Teacher", b =>
                {
                    b.Navigation("subjects");
                });
#pragma warning restore 612, 618
        }
    }
}
