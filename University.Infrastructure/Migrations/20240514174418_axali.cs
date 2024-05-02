using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class axali : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "core",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("3cf459f1-6eb1-40f7-bc7c-26aa2ba61e36"));

            migrationBuilder.EnsureSchema(
                name: "Calendary");

            migrationBuilder.CreateTable(
                name: "Calendary",
                schema: "Calendary",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calendary_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalSchema: "doctor",
                        principalTable: "Doctor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Calendary_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "person",
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                schema: "core",
                table: "User",
                columns: new[] { "Id", "CreatedDate", "DoctorId", "Email", "FirstName", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PersonId", "PrivateNumber", "Role" },
                values: new object[] { new Guid("2f41cc2e-ef91-40a4-be92-1847666b7c85"), new DateTime(2024, 5, 14, 21, 44, 18, 707, DateTimeKind.Local).AddTicks(5810), null, "1", "admin", false, "admin", new byte[] { 122, 160, 197, 158, 19, 183, 151, 51, 81, 240, 175, 56, 55, 46, 146, 53, 44, 42, 197, 239, 8, 8, 74, 9, 38, 31, 131, 219, 119, 247, 218, 224, 200, 22, 52, 148, 23, 62, 246, 170, 191, 205, 39, 75, 162, 204, 210, 193, 117, 34, 70, 218, 172, 60, 209, 136, 233, 38, 147, 182, 53, 231, 74, 45 }, new byte[] { 252, 224, 228, 183, 165, 254, 198, 59, 1, 232, 249, 125, 31, 60, 106, 92, 161, 187, 54, 183, 164, 212, 248, 116, 180, 25, 249, 158, 69, 132, 20, 38, 249, 222, 161, 56, 187, 1, 66, 206, 230, 27, 127, 72, 57, 157, 21, 82, 202, 184, 219, 148, 141, 153, 55, 135, 86, 161, 149, 88, 67, 70, 240, 47, 72, 36, 241, 101, 252, 223, 81, 24, 123, 160, 163, 81, 6, 219, 142, 62, 171, 231, 111, 215, 235, 157, 143, 10, 167, 57, 87, 46, 182, 221, 80, 48, 183, 23, 153, 66, 144, 37, 176, 13, 172, 38, 5, 78, 172, 250, 17, 129, 160, 32, 254, 135, 201, 127, 67, 57, 68, 106, 136, 25, 186, 199, 20, 30 }, null, "admin", 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Calendary_DoctorId",
                schema: "Calendary",
                table: "Calendary",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Calendary_PersonId",
                schema: "Calendary",
                table: "Calendary",
                column: "PersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calendary",
                schema: "Calendary");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2f41cc2e-ef91-40a4-be92-1847666b7c85"));

            migrationBuilder.InsertData(
                schema: "core",
                table: "User",
                columns: new[] { "Id", "CreatedDate", "DoctorId", "Email", "FirstName", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PersonId", "PrivateNumber", "Role" },
                values: new object[] { new Guid("3cf459f1-6eb1-40f7-bc7c-26aa2ba61e36"), new DateTime(2024, 5, 2, 20, 5, 33, 569, DateTimeKind.Local).AddTicks(7578), null, "1", "admin", false, "admin", new byte[] { 167, 84, 220, 197, 156, 122, 130, 47, 51, 251, 112, 57, 189, 170, 131, 225, 194, 86, 49, 222, 87, 189, 110, 19, 252, 199, 184, 125, 166, 149, 140, 178, 137, 185, 110, 148, 128, 245, 199, 95, 185, 30, 213, 170, 5, 129, 126, 232, 61, 51, 205, 239, 6, 156, 23, 56, 116, 142, 57, 80, 107, 225, 228, 82 }, new byte[] { 125, 108, 96, 205, 111, 116, 77, 135, 2, 110, 255, 243, 202, 143, 175, 192, 33, 111, 112, 78, 196, 100, 47, 223, 143, 225, 198, 85, 7, 40, 9, 206, 91, 119, 185, 86, 80, 13, 94, 159, 229, 86, 191, 159, 55, 231, 164, 5, 151, 102, 202, 247, 203, 114, 148, 157, 225, 106, 228, 161, 25, 134, 227, 134, 165, 27, 154, 194, 33, 149, 15, 197, 17, 15, 252, 19, 78, 2, 210, 78, 184, 178, 200, 221, 164, 89, 178, 106, 50, 61, 169, 16, 182, 243, 81, 108, 243, 55, 88, 36, 87, 29, 84, 147, 61, 212, 227, 245, 69, 157, 36, 23, 249, 114, 146, 216, 63, 155, 122, 214, 25, 85, 167, 77, 170, 56, 18, 11 }, null, "admin", 0 });
        }
    }
}
