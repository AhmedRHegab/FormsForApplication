﻿// <auto-generated />
using System;
using ApplicantsFromProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace NewFormsProject.Migrations
{
    [DbContext(typeof(DBFormsContext))]
    [Migration("20231015005121_first")]
    partial class first
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApplicantsFromProject.Models.ApplicantsFrom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Availability_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("CV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Current_Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Current_Salary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("E_Commerce_Apps_Experience")
                        .HasColumnType("bit");

                    b.Property<string>("Expected_Salary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FacultyId")
                        .HasColumnType("int");

                    b.Property<string>("Github_Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GovernorateId")
                        .HasColumnType("int");

                    b.Property<string>("Graduation_Year")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ITI_Graduate")
                        .HasColumnType("bit");

                    b.Property<bool>("Interested_Working_In_Cairo")
                        .HasColumnType("bit");

                    b.Property<string>("LinkedIn_Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Mobile_Apps_Experience")
                        .HasColumnType("bit");

                    b.Property<string>("Name_En")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Speciality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UniversityId")
                        .HasColumnType("int");

                    b.Property<string>("year_Of_Graduation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.HasIndex("GovernorateId");

                    b.HasIndex("UniversityId");

                    b.ToTable("ApplicantsFroms");
                });

            modelBuilder.Entity("ApplicantsFromProject.Models.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("ApplicantsFromProject.Models.Governorate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Governorates");
                });

            modelBuilder.Entity("ApplicantsFromProject.Models.University", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Universities");
                });

            modelBuilder.Entity("ApplicantsFromProject.Models.ApplicantsFrom", b =>
                {
                    b.HasOne("ApplicantsFromProject.Models.Faculty", "Faculty")
                        .WithMany("ApplicantsFroms")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicantsFromProject.Models.Governorate", "Governorate")
                        .WithMany("ApplicantsFroms")
                        .HasForeignKey("GovernorateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicantsFromProject.Models.University", "University")
                        .WithMany("ApplicantsFroms")
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");

                    b.Navigation("Governorate");

                    b.Navigation("University");
                });

            modelBuilder.Entity("ApplicantsFromProject.Models.Faculty", b =>
                {
                    b.Navigation("ApplicantsFroms");
                });

            modelBuilder.Entity("ApplicantsFromProject.Models.Governorate", b =>
                {
                    b.Navigation("ApplicantsFroms");
                });

            modelBuilder.Entity("ApplicantsFromProject.Models.University", b =>
                {
                    b.Navigation("ApplicantsFroms");
                });
#pragma warning restore 612, 618
        }
    }
}