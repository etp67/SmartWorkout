﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartWorkout.Components.Data;

#nullable disable

namespace SmartWorkout.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240911153915_added exercise instance table")]
    partial class addedexerciseinstancetable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SmartWorkout.Components.Data.Models.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SetRepRange")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Exercise");
                });

            modelBuilder.Entity("SmartWorkout.Components.Data.Models.Exercise_Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Exercise_Category");
                });

            modelBuilder.Entity("SmartWorkout.Components.Data.Models.Exercise_Instance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<int>("NumRepsPerSet")
                        .HasColumnType("int");

                    b.Property<int>("NumSets")
                        .HasColumnType("int");

                    b.Property<decimal>("WeightLbs")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("WorkoutId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("WorkoutId");

                    b.ToTable("Exercise_Instance");
                });

            modelBuilder.Entity("SmartWorkout.Components.Data.Models.Workout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Workout");
                });

            modelBuilder.Entity("SmartWorkout.Components.Data.Models.Exercise", b =>
                {
                    b.HasOne("SmartWorkout.Components.Data.Models.Exercise_Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("SmartWorkout.Components.Data.Models.Exercise_Instance", b =>
                {
                    b.HasOne("SmartWorkout.Components.Data.Models.Exercise", "Exercise")
                        .WithMany()
                        .HasForeignKey("ExerciseId");

                    b.HasOne("SmartWorkout.Components.Data.Models.Workout", "Workout")
                        .WithMany()
                        .HasForeignKey("WorkoutId");

                    b.Navigation("Exercise");

                    b.Navigation("Workout");
                });
#pragma warning restore 612, 618
        }
    }
}