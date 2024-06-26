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
    [Migration("20240322194526_test")]
    partial class test
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HospitalService.Domain.Entities.Categories.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categorys");
                });

            modelBuilder.Entity("HospitalService.Domain.Entities.Doctors.Doctor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<byte[]>("cv")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("photo")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryID");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("HospitalService.Domain.Entities.Persons.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ActivateCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Persons");
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
                            Id = new Guid("d406dbf6-9728-41a4-bbb6-2dbd57696a9e"),
                            CreatedDate = new DateTime(2024, 3, 22, 23, 45, 26, 447, DateTimeKind.Local).AddTicks(3724),
                            Email = "1",
                            FirstName = "admin",
                            IsDeleted = false,
                            LastName = "admin",
                            PasswordHash = new byte[] { 73, 174, 121, 19, 239, 92, 184, 77, 199, 190, 193, 20, 24, 50, 59, 4, 244, 153, 30, 199, 113, 198, 39, 65, 226, 89, 178, 183, 158, 23, 104, 238, 105, 164, 223, 86, 238, 235, 168, 169, 147, 227, 17, 207, 75, 25, 213, 72, 86, 155, 10, 85, 221, 188, 112, 224, 33, 129, 185, 0, 83, 30, 171, 91 },
                            PasswordSalt = new byte[] { 31, 76, 61, 87, 220, 144, 237, 117, 163, 93, 210, 2, 167, 220, 118, 65, 127, 129, 141, 183, 195, 82, 113, 16, 192, 168, 109, 131, 43, 216, 66, 173, 176, 71, 187, 39, 107, 12, 99, 210, 23, 75, 154, 238, 174, 48, 159, 206, 81, 87, 69, 177, 22, 45, 103, 94, 82, 114, 240, 225, 16, 45, 84, 205, 13, 184, 70, 219, 17, 54, 124, 91, 241, 3, 127, 29, 136, 135, 6, 40, 146, 49, 58, 249, 204, 178, 116, 90, 130, 124, 201, 67, 5, 194, 218, 151, 220, 62, 242, 86, 183, 105, 31, 52, 38, 161, 43, 232, 162, 91, 158, 165, 98, 154, 16, 225, 61, 79, 242, 35, 157, 240, 215, 157, 232, 167, 94, 154 },
                            PrivateNumber = "admin",
                            Role = 0
                        });
                });

            modelBuilder.Entity("HospitalService.Domain.Entities.Doctors.Doctor", b =>
                {
                    b.HasOne("HospitalService.Domain.Entities.Categories.Category", "Category")
                        .WithMany("Doctors")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");
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
                    b.Navigation("Doctors");
                });

            modelBuilder.Entity("HospitalService.Domain.Entities.Doctors.Doctor", b =>
                {
                    b.Navigation("user");
                });

            modelBuilder.Entity("HospitalService.Domain.Entities.Persons.Person", b =>
                {
                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
