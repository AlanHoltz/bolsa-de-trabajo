﻿// <auto-generated />
using System;
using BolsaTrabajo.Models.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace WebMVC.Migrations
{
    [DbContext(typeof(BolsaTrabajoContext))]
    [Migration("20221023011448_Status")]
    partial class Status
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CareerJobProfile", b =>
                {
                    b.Property<int>("CareersId")
                        .HasColumnType("int");

                    b.Property<int>("JobProfilesId")
                        .HasColumnType("int");

                    b.HasKey("CareersId", "JobProfilesId");

                    b.HasIndex("JobProfilesId");

                    b.ToTable("CareerJobProfile");
                });

            modelBuilder.Entity("WebMVC.Models.Career", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Careers");
                });

            modelBuilder.Entity("WebMVC.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProvinceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProvinceId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("WebMVC.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("CityZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cuit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferenceArea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferenceEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferenceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferencePhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferenceWorkingOnCompany")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("WebMVC.Models.Internship", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("Agreement")
                        .HasColumnType("bit");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<DateTime>("Starting")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Internships");
                });

            modelBuilder.Entity("WebMVC.Models.JobProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailReceptor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("JobProfiles");
                });

            modelBuilder.Entity("WebMVC.Models.JobProfilePerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("JobProfilesId")
                        .HasColumnType("int");

                    b.Property<string>("Observations")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("PersonsId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("JobProfilesId");

                    b.HasIndex("PersonsId");

                    b.ToTable("JobProfilePerson");
                });

            modelBuilder.Entity("WebMVC.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Cv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("WebMVC.Models.Province", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("WebMVC.Models.Relationship", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("WorkdayTime")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Relationships");
                });

            modelBuilder.Entity("WebMVC.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SignupDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CareerJobProfile", b =>
                {
                    b.HasOne("WebMVC.Models.Career", null)
                        .WithMany()
                        .HasForeignKey("CareersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebMVC.Models.JobProfile", null)
                        .WithMany()
                        .HasForeignKey("JobProfilesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebMVC.Models.City", b =>
                {
                    b.HasOne("WebMVC.Models.Province", "Province")
                        .WithMany("Cities")
                        .HasForeignKey("ProvinceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Province");
                });

            modelBuilder.Entity("WebMVC.Models.Company", b =>
                {
                    b.HasOne("WebMVC.Models.City", "City")
                        .WithMany("Companies")
                        .HasForeignKey("CityId");

                    b.HasOne("WebMVC.Models.User", "User")
                        .WithMany("Companies")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebMVC.Models.Internship", b =>
                {
                    b.HasOne("WebMVC.Models.JobProfile", "JobProfile")
                        .WithOne("Internship")
                        .HasForeignKey("WebMVC.Models.Internship", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JobProfile");
                });

            modelBuilder.Entity("WebMVC.Models.JobProfile", b =>
                {
                    b.HasOne("WebMVC.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("WebMVC.Models.JobProfilePerson", b =>
                {
                    b.HasOne("WebMVC.Models.JobProfile", "JobProfiles")
                        .WithMany("JobProfilePerson")
                        .HasForeignKey("JobProfilesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebMVC.Models.Person", "Persons")
                        .WithMany("JobProfilePerson")
                        .HasForeignKey("PersonsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JobProfiles");

                    b.Navigation("Persons");
                });

            modelBuilder.Entity("WebMVC.Models.Person", b =>
                {
                    b.HasOne("WebMVC.Models.User", "User")
                        .WithMany("Persons")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebMVC.Models.Relationship", b =>
                {
                    b.HasOne("WebMVC.Models.JobProfile", "JobProfile")
                        .WithOne("Relationship")
                        .HasForeignKey("WebMVC.Models.Relationship", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JobProfile");
                });

            modelBuilder.Entity("WebMVC.Models.City", b =>
                {
                    b.Navigation("Companies");
                });

            modelBuilder.Entity("WebMVC.Models.JobProfile", b =>
                {
                    b.Navigation("Internship");

                    b.Navigation("JobProfilePerson");

                    b.Navigation("Relationship");
                });

            modelBuilder.Entity("WebMVC.Models.Person", b =>
                {
                    b.Navigation("JobProfilePerson");
                });

            modelBuilder.Entity("WebMVC.Models.Province", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("WebMVC.Models.User", b =>
                {
                    b.Navigation("Companies");

                    b.Navigation("Persons");
                });
#pragma warning restore 612, 618
        }
    }
}
