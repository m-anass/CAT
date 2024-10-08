﻿// <auto-generated />
using System;
using EF_Tasks.Part_1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_Tasks.Part_1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentSr_Id")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "StudentSr_Id");

                    b.HasIndex("StudentSr_Id");

                    b.ToTable("StudentCourse", (string)null);
                });

            modelBuilder.Entity("EF_Tasks.Part_1.Models.Car", b =>
                {
                    b.Property<string>("LicensePlate")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.HasKey("LicensePlate");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("EF_Tasks.Part_1.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("CName")
                        .HasComment("this a new comment");

                    b.HasKey("Id")
                        .HasName("CourID");

                    b.ToTable("courses");
                });

            modelBuilder.Entity("EF_Tasks.Part_1.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameId")
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("nvarchar(max)")
                        .HasComputedColumnSql("[NAME] + ', ' + [ID]");

                    b.Property<DateTime>("RollDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.HasKey("Id");

                    b.HasIndex("InstructorId")
                        .IsUnique()
                        .HasFilter("[InstructorId] IS NOT NULL");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("EF_Tasks.Part_1.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("LicensePlate");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("EF_Tasks.Part_1.Models.Student", b =>
                {
                    b.Property<int>("Sr_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Sr_Id"));

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Sr_Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.HasOne("EF_Tasks.Part_1.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_Tasks.Part_1.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentSr_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EF_Tasks.Part_1.Models.Instructor", b =>
                {
                    b.HasOne("EF_Tasks.Part_1.Models.Instructor", null)
                        .WithOne()
                        .HasForeignKey("EF_Tasks.Part_1.Models.Instructor", "InstructorId");
                });

            modelBuilder.Entity("EF_Tasks.Part_1.Models.Sale", b =>
                {
                    b.HasOne("EF_Tasks.Part_1.Models.Car", null)
                        .WithMany()
                        .HasForeignKey("LicensePlate")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
