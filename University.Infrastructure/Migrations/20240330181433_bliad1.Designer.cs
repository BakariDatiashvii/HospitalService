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
    [Migration("20240330181433_bliad1")]
    partial class bliad1
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

            modelBuilder.Entity("HospitalService.Domain.Entities.Doctors.Doctor", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryID")
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

                    b.HasIndex("CategoryID");

                    b.ToTable("Doctor", "doctor");
                });

            modelBuilder.Entity("HospitalService.Domain.Entities.Persons.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ActivateCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

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
                            Id = new Guid("a740ca29-3c80-4d7e-b814-03af7a90a3a5"),
                            CreatedDate = new DateTime(2024, 3, 30, 22, 14, 33, 607, DateTimeKind.Local).AddTicks(7246),
                            Email = "1",
                            FirstName = "admin",
                            IsDeleted = false,
                            LastName = "admin",
                            PasswordHash = new byte[] { 235, 181, 70, 169, 119, 71, 196, 213, 117, 7, 137, 77, 235, 238, 203, 71, 178, 61, 121, 85, 159, 162, 58, 99, 204, 8, 171, 50, 47, 252, 165, 234, 89, 241, 102, 244, 26, 25, 6, 188, 141, 154, 176, 189, 78, 64, 208, 197, 75, 174, 17, 38, 137, 53, 93, 211, 136, 14, 163, 133, 244, 146, 21, 188 },
                            PasswordSalt = new byte[] { 193, 61, 152, 71, 172, 141, 126, 2, 198, 128, 196, 29, 146, 77, 48, 240, 138, 146, 61, 127, 201, 127, 141, 202, 86, 124, 173, 28, 186, 205, 94, 71, 204, 21, 142, 104, 254, 138, 7, 112, 94, 231, 23, 185, 132, 21, 151, 132, 4, 15, 136, 218, 98, 80, 33, 192, 126, 24, 114, 63, 4, 166, 253, 220, 57, 173, 60, 253, 19, 224, 115, 32, 151, 247, 126, 236, 85, 230, 45, 141, 35, 7, 98, 153, 48, 96, 45, 98, 180, 116, 195, 146, 57, 138, 136, 241, 93, 88, 5, 165, 145, 218, 119, 179, 128, 139, 176, 126, 84, 51, 151, 242, 13, 146, 145, 62, 254, 223, 163, 174, 152, 53, 142, 125, 160, 212, 24, 157 },
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