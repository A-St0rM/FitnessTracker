﻿// <auto-generated />
using System;
using FitnessTracker.Server.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FitnessTracker.Server.Migrations
{
    [DbContext(typeof(FitnessTrackerDBContext))]
    partial class FitnessTrackerDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FitnessTracker.Server.Models.Exercise", b =>
                {
                    b.Property<int>("Exercise_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Exercise_Id"));

                    b.Property<string>("ExerciseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Repetitions")
                        .HasColumnType("int");

                    b.Property<int>("Set")
                        .HasColumnType("int");

                    b.HasKey("Exercise_Id");

                    b.ToTable("exercises");
                });

            modelBuilder.Entity("FitnessTracker.Server.Models.ExerciseWorkoutProgram", b =>
                {
                    b.Property<int>("ExerciseWorkoutProgram_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExerciseWorkoutProgram_Id"));

                    b.Property<int>("Exercise_Id")
                        .HasColumnType("int");

                    b.Property<int>("WorkoutProgram_Id")
                        .HasColumnType("int");

                    b.HasKey("ExerciseWorkoutProgram_Id");

                    b.HasIndex("Exercise_Id");

                    b.HasIndex("WorkoutProgram_Id");

                    b.ToTable("exerciseWorkoutPrograms");
                });

            modelBuilder.Entity("FitnessTracker.Server.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("FitnessTracker.Server.Models.WorkoutDay", b =>
                {
                    b.Property<int>("WorkoutDay_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WorkoutDay_Id"));

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int>("WorkoutProgram_Id")
                        .HasColumnType("int");

                    b.HasKey("WorkoutDay_Id");

                    b.HasIndex("WorkoutProgram_Id");

                    b.ToTable("workoutDays");
                });

            modelBuilder.Entity("FitnessTracker.Server.Models.WorkoutProgram", b =>
                {
                    b.Property<int>("WorkoutProgram_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WorkoutProgram_Id"));

                    b.Property<string>("ProgramName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WorkoutProgram_Id");

                    b.ToTable("workoutPrograms");
                });

            modelBuilder.Entity("FitnessTracker.Server.Models.ExerciseWorkoutProgram", b =>
                {
                    b.HasOne("FitnessTracker.Server.Models.Exercise", "Exercise")
                        .WithMany("ExerciseWorkoutPrograms")
                        .HasForeignKey("Exercise_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FitnessTracker.Server.Models.WorkoutProgram", "WorkoutProgram")
                        .WithMany("ExerciseWorkoutPrograms")
                        .HasForeignKey("WorkoutProgram_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("WorkoutProgram");
                });

            modelBuilder.Entity("FitnessTracker.Server.Models.WorkoutDay", b =>
                {
                    b.HasOne("FitnessTracker.Server.Models.WorkoutProgram", "WorkoutProgram")
                        .WithMany("WorkoutDays")
                        .HasForeignKey("WorkoutProgram_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WorkoutProgram");
                });

            modelBuilder.Entity("FitnessTracker.Server.Models.Exercise", b =>
                {
                    b.Navigation("ExerciseWorkoutPrograms");
                });

            modelBuilder.Entity("FitnessTracker.Server.Models.WorkoutProgram", b =>
                {
                    b.Navigation("ExerciseWorkoutPrograms");

                    b.Navigation("WorkoutDays");
                });
#pragma warning restore 612, 618
        }
    }
}
