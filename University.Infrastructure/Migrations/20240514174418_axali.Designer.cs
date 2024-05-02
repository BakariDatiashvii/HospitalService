﻿// <auto-generated />
using System;
using HospitalService.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HospitalService.Infrastructure.Migrations
{
    [DbContext(typeof(HospitalDbContext))]
    [Migration("20240514174418_axali")]
    partial class axali
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HospitalService.Domain.Entities.Calendaries.Calendary", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("DoctorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("PersonId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PersonId");

                    b.ToTable("Calendary", "Calendary");
                });

            modelBuilder.Entity("HospitalService.Domain.Entities.Categories.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Category", "category");
                });

            modelBuilder.Entity("HospitalService.Domain.Entities.CategoryDoctors.CategoryDoctor", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DoctorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("DoctorId");

                    b.ToTable("CategoryDoctor", "CategoryDoctor");
                });

            modelBuilder.Entity("HospitalService.Domain.Entities.Doctors.Doctor", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<byte[]>("cv")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("photo")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Doctor", "doctor");
                });

            modelBuilder.Entity("HospitalService.Domain.Entities.Persons.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("ActivateCode")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("VerifyUser")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Person", "person");
                });

            modelBuilder.Entity("HospitalService.Domain.Entities.Users.User", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DoctorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<Guid?>("PersonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PrivateNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId")
                        .IsUnique()
                        .HasFilter("[DoctorId] IS NOT NULL");

                    b.HasIndex("PersonId")
                        .IsUnique()
                        .HasFilter("[PersonId] IS NOT NULL");

                    b.ToTable("User", "core");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2f41cc2e-ef91-40a4-be92-1847666b7c85"),
                            CreatedDate = new DateTime(2024, 5, 14, 21, 44, 18, 707, DateTimeKind.Local).AddTicks(5810),
                            Email = "1",
                            FirstName = "admin",
                            IsDeleted = false,
                            LastName = "admin",
                            PasswordHash = new byte[] { 122, 160, 197, 158, 19, 183, 151, 51, 81, 240, 175, 56, 55, 46, 146, 53, 44, 42, 197, 239, 8, 8, 74, 9, 38, 31, 131, 219, 119, 247, 218, 224, 200, 22, 52, 148, 23, 62, 246, 170, 191, 205, 39, 75, 162, 204, 210, 193, 117, 34, 70, 218, 172, 60, 209, 136, 233, 38, 147, 182, 53, 231, 74, 45 },
                            PasswordSalt = new byte[] { 252, 224, 228, 183, 165, 254, 198, 59, 1, 232, 249, 125, 31, 60, 106, 92, 161, 187, 54, 183, 164, 212, 248, 116, 180, 25, 249, 158, 69, 132, 20, 38, 249, 222, 161, 56, 187, 1, 66, 206, 230, 27, 127, 72, 57, 157, 21, 82, 202, 184, 219, 148, 141, 153, 55, 135, 86, 161, 149, 88, 67, 70, 240, 47, 72, 36, 241, 101, 252, 223, 81, 24, 123, 160, 163, 81, 6, 219, 142, 62, 171, 231, 111, 215, 235, 157, 143, 10, 167, 57, 87, 46, 182, 221, 80, 48, 183, 23, 153, 66, 144, 37, 176, 13, 172, 38, 5, 78, 172, 250, 17, 129, 160, 32, 254, 135, 201, 127, 67, 57, 68, 106, 136, 25, 186, 199, 20, 30 },
                            PrivateNumber = "admin",
                            Role = 0
                        });
                });

            modelBuilder.Entity("HospitalService.Domain.Entities.Calendaries.Calendary", b =>
                {
                    b.HasOne("HospitalService.Domain.Entities.Doctors.Doctor", "Doctors")
                        .WithMany("calendaries")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("HospitalService.Domain.Entities.Persons.Person", "Persons")
                        .WithMany("calendaries")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Doctors");

                    b.Navigation("Persons");
                });

            modelBuilder.Entity("HospitalService.Domain.Entities.CategoryDoctors.CategoryDoctor", b =>
                {
                    b.HasOne("HospitalService.Domain.Entities.Categories.Category", "Category")
                        .WithMany("doctors")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HospitalService.Domain.Entities.Doctors.Doctor", "Doctor")
                        .WithMany("Categories")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("HospitalService.Domain.Entities.Users.User", b =>
                {
                    b.HasOne("HospitalService.Domain.Entities.Doctors.Doctor", "Doctor")
                        .WithOne("user")
                        .HasForeignKey("HospitalService.Domain.Entities.Users.User", "DoctorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("HospitalService.Domain.Entities.Persons.Person", "Person")
                        .WithOne("User")
                        .HasForeignKey("HospitalService.Domain.Entities.Users.User", "PersonId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Doctor");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("HospitalService.Domain.Entities.Categories.Category", b =>
                {
                    b.Navigation("doctors");
                });

            modelBuilder.Entity("HospitalService.Domain.Entities.Doctors.Doctor", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("calendaries");

                    b.Navigation("user");
                });

            modelBuilder.Entity("HospitalService.Domain.Entities.Persons.Person", b =>
                {
                    b.Navigation("User");

                    b.Navigation("calendaries");
                });
#pragma warning restore 612, 618
        }
    }
}