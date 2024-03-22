using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "core");

            migrationBuilder.CreateTable(
                name: "Categorys",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActivateCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    cv = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_Categorys_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "core",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PrivateNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                schema: "core",
                table: "User",
                columns: new[] { "Id", "CreatedDate", "DoctorId", "Email", "FirstName", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PersonId", "PrivateNumber", "Role" },
                values: new object[] { new Guid("d406dbf6-9728-41a4-bbb6-2dbd57696a9e"), new DateTime(2024, 3, 22, 23, 45, 26, 447, DateTimeKind.Local).AddTicks(3724), null, "1", "admin", false, "admin", new byte[] { 73, 174, 121, 19, 239, 92, 184, 77, 199, 190, 193, 20, 24, 50, 59, 4, 244, 153, 30, 199, 113, 198, 39, 65, 226, 89, 178, 183, 158, 23, 104, 238, 105, 164, 223, 86, 238, 235, 168, 169, 147, 227, 17, 207, 75, 25, 213, 72, 86, 155, 10, 85, 221, 188, 112, 224, 33, 129, 185, 0, 83, 30, 171, 91 }, new byte[] { 31, 76, 61, 87, 220, 144, 237, 117, 163, 93, 210, 2, 167, 220, 118, 65, 127, 129, 141, 183, 195, 82, 113, 16, 192, 168, 109, 131, 43, 216, 66, 173, 176, 71, 187, 39, 107, 12, 99, 210, 23, 75, 154, 238, 174, 48, 159, 206, 81, 87, 69, 177, 22, 45, 103, 94, 82, 114, 240, 225, 16, 45, 84, 205, 13, 184, 70, 219, 17, 54, 124, 91, 241, 3, 127, 29, 136, 135, 6, 40, 146, 49, 58, 249, 204, 178, 116, 90, 130, 124, 201, 67, 5, 194, 218, 151, 220, 62, 242, 86, 183, 105, 31, 52, 38, 161, 43, 232, 162, 91, 158, 165, 98, 154, 16, 225, 61, 79, 242, 35, 157, 240, 215, 157, 232, 167, 94, 154 }, null, "admin", 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_CategoryID",
                table: "Doctors",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_User_DoctorId",
                schema: "core",
                table: "User",
                column: "DoctorId",
                unique: true,
                filter: "[DoctorId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_User_PersonId",
                schema: "core",
                table: "User",
                column: "PersonId",
                unique: true,
                filter: "[PersonId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User",
                schema: "core");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Categorys");
        }
    }
}
