using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class qqeq : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "core",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("477cb7db-b98a-44d4-9dec-ef17d8dc13c5"));

            migrationBuilder.InsertData(
                schema: "core",
                table: "User",
                columns: new[] { "Id", "CreatedDate", "DoctorId", "Email", "FirstName", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PersonId", "PrivateNumber", "Role" },
                values: new object[] { new Guid("3cf459f1-6eb1-40f7-bc7c-26aa2ba61e36"), new DateTime(2024, 5, 2, 20, 5, 33, 569, DateTimeKind.Local).AddTicks(7578), null, "1", "admin", false, "admin", new byte[] { 167, 84, 220, 197, 156, 122, 130, 47, 51, 251, 112, 57, 189, 170, 131, 225, 194, 86, 49, 222, 87, 189, 110, 19, 252, 199, 184, 125, 166, 149, 140, 178, 137, 185, 110, 148, 128, 245, 199, 95, 185, 30, 213, 170, 5, 129, 126, 232, 61, 51, 205, 239, 6, 156, 23, 56, 116, 142, 57, 80, 107, 225, 228, 82 }, new byte[] { 125, 108, 96, 205, 111, 116, 77, 135, 2, 110, 255, 243, 202, 143, 175, 192, 33, 111, 112, 78, 196, 100, 47, 223, 143, 225, 198, 85, 7, 40, 9, 206, 91, 119, 185, 86, 80, 13, 94, 159, 229, 86, 191, 159, 55, 231, 164, 5, 151, 102, 202, 247, 203, 114, 148, 157, 225, 106, 228, 161, 25, 134, 227, 134, 165, 27, 154, 194, 33, 149, 15, 197, 17, 15, 252, 19, 78, 2, 210, 78, 184, 178, 200, 221, 164, 89, 178, 106, 50, 61, 169, 16, 182, 243, 81, 108, 243, 55, 88, 36, 87, 29, 84, 147, 61, 212, 227, 245, 69, 157, 36, 23, 249, 114, 146, 216, 63, 155, 122, 214, 25, 85, 167, 77, 170, 56, 18, 11 }, null, "admin", 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "core",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("3cf459f1-6eb1-40f7-bc7c-26aa2ba61e36"));

            migrationBuilder.InsertData(
                schema: "core",
                table: "User",
                columns: new[] { "Id", "CreatedDate", "DoctorId", "Email", "FirstName", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PersonId", "PrivateNumber", "Role" },
                values: new object[] { new Guid("477cb7db-b98a-44d4-9dec-ef17d8dc13c5"), new DateTime(2024, 4, 24, 23, 7, 39, 175, DateTimeKind.Local).AddTicks(4553), null, "1", "admin", false, "admin", new byte[] { 110, 15, 152, 111, 114, 28, 60, 109, 54, 174, 216, 176, 251, 122, 66, 218, 118, 228, 109, 93, 141, 96, 190, 84, 169, 216, 137, 215, 208, 190, 7, 254, 24, 216, 209, 53, 59, 79, 227, 239, 125, 159, 146, 240, 236, 121, 134, 69, 111, 0, 201, 103, 253, 140, 40, 7, 228, 153, 26, 103, 236, 211, 42, 8 }, new byte[] { 3, 205, 156, 34, 197, 162, 186, 223, 89, 188, 32, 127, 159, 98, 60, 59, 98, 242, 106, 211, 73, 2, 77, 13, 170, 84, 25, 224, 172, 3, 248, 102, 60, 178, 176, 188, 46, 32, 10, 137, 193, 129, 84, 62, 3, 191, 22, 168, 152, 251, 139, 103, 111, 109, 25, 88, 86, 80, 240, 1, 136, 115, 76, 103, 161, 50, 215, 195, 120, 152, 49, 160, 139, 159, 113, 9, 8, 24, 107, 225, 113, 252, 217, 25, 72, 158, 167, 95, 23, 77, 245, 255, 41, 180, 104, 200, 48, 1, 185, 223, 76, 248, 150, 41, 253, 175, 139, 83, 149, 110, 125, 72, 67, 58, 251, 11, 238, 137, 30, 78, 250, 67, 163, 239, 25, 231, 151, 131 }, null, "admin", 0 });
        }
    }
}
