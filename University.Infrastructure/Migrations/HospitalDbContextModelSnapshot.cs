﻿// <auto-generated />
using System;
using HospitalService.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HospitalService.Infrastructure.Migrations
{
    [DbContext(typeof(HospitalDbContext))]
    partial class HospitalDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("3cf459f1-6eb1-40f7-bc7c-26aa2ba61e36"),
                            CreatedDate = new DateTime(2024, 5, 2, 20, 5, 33, 569, DateTimeKind.Local).AddTicks(7578),
                            Email = "1",
                            FirstName = "admin",
                            IsDeleted = false,
                            LastName = "admin",
                            PasswordHash = new byte[] { 167, 84, 220, 197, 156, 122, 130, 47, 51, 251, 112, 57, 189, 170, 131, 225, 194, 86, 49, 222, 87, 189, 110, 19, 252, 199, 184, 125, 166, 149, 140, 178, 137, 185, 110, 148, 128, 245, 199, 95, 185, 30, 213, 170, 5, 129, 126, 232, 61, 51, 205, 239, 6, 156, 23, 56, 116, 142, 57, 80, 107, 225, 228, 82 },
                            PasswordSalt = new byte[] { 125, 108, 96, 205, 111, 116, 77, 135, 2, 110, 255, 243, 202, 143, 175, 192, 33, 111, 112, 78, 196, 100, 47, 223, 143, 225, 198, 85, 7, 40, 9, 206, 91, 119, 185, 86, 80, 13, 94, 159, 229, 86, 191, 159, 55, 231, 164, 5, 151, 102, 202, 247, 203, 114, 148, 157, 225, 106, 228, 161, 25, 134, 227, 134, 165, 27, 154, 194, 33, 149, 15, 197, 17, 15, 252, 19, 78, 2, 210, 78, 184, 178, 200, 221, 164, 89, 178, 106, 50, 61, 169, 16, 182, 243, 81, 108, 243, 55, 88, 36, 87, 29, 84, 147, 61, 212, 227, 245, 69, 157, 36, 23, 249, 114, 146, 216, 63, 155, 122, 214, 25, 85, 167, 77, 170, 56, 18, 11 },
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
