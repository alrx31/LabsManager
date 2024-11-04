﻿// <auto-generated />
using System;
using LabsManager.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LabsManager.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("LabsManager.Entities.Laba", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("LastTimeToPass")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("file")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<string>("materials")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("teacherId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("teacherId");

                    b.ToTable("Labs");
                });

            modelBuilder.Entity("LabsManager.Entities.PassModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("comment")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("fileExtension")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isChecked")
                        .HasColumnType("boolean");

                    b.Property<bool>("isPassed")
                        .HasColumnType("boolean");

                    b.Property<int>("labId")
                        .HasColumnType("integer");

                    b.Property<float>("mark")
                        .HasColumnType("real");

                    b.Property<byte[]>("report")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<int>("studentId")
                        .HasColumnType("integer");

                    b.Property<int>("teacherId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("labId");

                    b.HasIndex("studentId");

                    b.HasIndex("teacherId");

                    b.ToTable("PassModels");
                });

            modelBuilder.Entity("LabsManager.Entities.Student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("group")
                        .IsRequired()
                        .HasColumnType("text");

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

                    b.ToTable("Students");
                });

            modelBuilder.Entity("LabsManager.Entities.Teacher", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("cafedra")
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

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("LabsManager.Entities.Laba", b =>
                {
                    b.HasOne("LabsManager.Entities.Teacher", "teacher")
                        .WithMany("labs")
                        .HasForeignKey("teacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("teacher");
                });

            modelBuilder.Entity("LabsManager.Entities.PassModel", b =>
                {
                    b.HasOne("LabsManager.Entities.Laba", "lab")
                        .WithMany("passLabs")
                        .HasForeignKey("labId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LabsManager.Entities.Student", "student")
                        .WithMany("passModels")
                        .HasForeignKey("studentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LabsManager.Entities.Teacher", "teacher")
                        .WithMany("passModels")
                        .HasForeignKey("teacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("lab");

                    b.Navigation("student");

                    b.Navigation("teacher");
                });

            modelBuilder.Entity("LabsManager.Entities.Laba", b =>
                {
                    b.Navigation("passLabs");
                });

            modelBuilder.Entity("LabsManager.Entities.Student", b =>
                {
                    b.Navigation("passModels");
                });

            modelBuilder.Entity("LabsManager.Entities.Teacher", b =>
                {
                    b.Navigation("labs");

                    b.Navigation("passModels");
                });
#pragma warning restore 612, 618
        }
    }
}
