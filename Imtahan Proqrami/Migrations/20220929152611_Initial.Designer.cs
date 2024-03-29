﻿// <auto-generated />
using System;
using Imtahan_Proqrami.DAL.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Imtahan_Proqrami.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220929152611_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Imtahan_Proqrami.Entities.Exam", b =>
                {
                    b.Property<int>("ExamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("ExamDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("LessonId")
                        .HasColumnType("integer");

                    b.Property<int>("PupilId")
                        .HasColumnType("integer");

                    b.Property<int>("Score")
                        .HasColumnType("integer");

                    b.HasKey("ExamId");

                    b.HasIndex("LessonId");

                    b.HasIndex("PupilId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("Imtahan_Proqrami.Entities.Lesson", b =>
                {
                    b.Property<int>("LessonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Class")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("LessonCode")
                        .HasColumnType("integer");

                    b.Property<string>("LessonName")
                        .HasColumnType("text");

                    b.Property<string>("LessonTeacherName")
                        .HasColumnType("text");

                    b.Property<string>("LessonTeacherSurname")
                        .HasColumnType("text");

                    b.HasKey("LessonId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("Imtahan_Proqrami.Entities.Pupil", b =>
                {
                    b.Property<int>("PupilId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Class")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("PupilName")
                        .HasColumnType("text");

                    b.Property<int>("PupilNumber")
                        .HasColumnType("integer");

                    b.Property<string>("PupilSurname")
                        .HasColumnType("text");

                    b.HasKey("PupilId");

                    b.ToTable("Pupils");
                });

            modelBuilder.Entity("Imtahan_Proqrami.Entities.Exam", b =>
                {
                    b.HasOne("Imtahan_Proqrami.Entities.Lesson", "Lesson")
                        .WithMany()
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Imtahan_Proqrami.Entities.Pupil", "Pupil")
                        .WithMany()
                        .HasForeignKey("PupilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lesson");

                    b.Navigation("Pupil");
                });
#pragma warning restore 612, 618
        }
    }
}
