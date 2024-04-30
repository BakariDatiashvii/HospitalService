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

            modelBuilder.Entity("HospitalService.Domain.Entities.Doctors.Person", b =>
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
                            Id = new Guid("477cb7db-b98a-44d4-9dec-ef17d8dc13c5"),
                            CreatedDate = new DateTime(2024, 4, 24, 23, 7, 39, 175, DateTimeKind.Local).AddTicks(4553),
                            Email = "1",
                            FirstName = "admin",
                            IsDeleted = false,
                            LastName = "admin",
                            PasswordHash = new byte[] { 110, 15, 152, 111, 114, 28, 60, 109, 54, 174, 216, 176, 251, 122, 66, 218, 118, 228, 109, 93, 141, 96, 190, 84, 169, 216, 137, 215, 208, 190, 7, 254, 24, 216, 209, 53, 59, 79, 227, 239, 125, 159, 146, 240, 236, 121, 134, 69, 111, 0, 201, 103, 253, 140, 40, 7, 228, 153, 26, 103, 236, 211, 42, 8 },
                            PasswordSalt = new byte[] { 3, 205, 156, 34, 197, 162, 186, 223, 89, 188, 32, 127, 159, 98, 60, 59, 98, 242, 106, 211, 73, 2, 77, 13, 170, 84, 25, 224, 172, 3, 248, 102, 60, 178, 176, 188, 46, 32, 10, 137, 193, 129, 84, 62, 3, 191, 22, 168, 152, 251, 139, 103, 111, 109, 25, 88, 86, 80, 240, 1, 136, 115, 76, 103, 161, 50, 215, 195, 120, 152, 49, 160, 139, 159, 113, 9, 8, 24, 107, 225, 113, 252, 217, 25, 72, 158, 167, 95, 23, 77, 245, 255, 41, 180, 104, 200, 48, 1, 185, 223, 76, 248, 150, 41, 253, 175, 139, 83, 149, 110, 125, 72, 67, 58, 251, 11, 238, 137, 30, 78, 250, 67, 163, 239, 25, 231, 151, 131 },
                            PrivateNumber = "admin",
                            Role = 0
                        });
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

                    b.HasOne("HospitalService.Domain.Entities.Doctors.Person", "Person")
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

                    b.Navigation("user");
                });

            modelBuilder.Entity("HospitalService.Domain.Entities.Doctors.Person", b =>
                {
                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
