using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class qwert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "core",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("57ce1bea-150b-4bfa-aa0f-5751381c520c"));

            migrationBuilder.InsertData(
                schema: "core",
                table: "User",
                columns: new[] { "Id", "CreatedDate", "DoctorId", "Email", "FirstName", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PersonId", "PrivateNumber", "Role" },
                values: new object[] { new Guid("477cb7db-b98a-44d4-9dec-ef17d8dc13c5"), new DateTime(2024, 4, 24, 23, 7, 39, 175, DateTimeKind.Local).AddTicks(4553), null, "1", "admin", false, "admin", new byte[] { 110, 15, 152, 111, 114, 28, 60, 109, 54, 174, 216, 176, 251, 122, 66, 218, 118, 228, 109, 93, 141, 96, 190, 84, 169, 216, 137, 215, 208, 190, 7, 254, 24, 216, 209, 53, 59, 79, 227, 239, 125, 159, 146, 240, 236, 121, 134, 69, 111, 0, 201, 103, 253, 140, 40, 7, 228, 153, 26, 103, 236, 211, 42, 8 }, new byte[] { 3, 205, 156, 34, 197, 162, 186, 223, 89, 188, 32, 127, 159, 98, 60, 59, 98, 242, 106, 211, 73, 2, 77, 13, 170, 84, 25, 224, 172, 3, 248, 102, 60, 178, 176, 188, 46, 32, 10, 137, 193, 129, 84, 62, 3, 191, 22, 168, 152, 251, 139, 103, 111, 109, 25, 88, 86, 80, 240, 1, 136, 115, 76, 103, 161, 50, 215, 195, 120, 152, 49, 160, 139, 159, 113, 9, 8, 24, 107, 225, 113, 252, 217, 25, 72, 158, 167, 95, 23, 77, 245, 255, 41, 180, 104, 200, 48, 1, 185, 223, 76, 248, 150, 41, 253, 175, 139, 83, 149, 110, 125, 72, 67, 58, 251, 11, 238, 137, 30, 78, 250, 67, 163, 239, 25, 231, 151, 131 }, null, "admin", 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("57ce1bea-150b-4bfa-aa0f-5751381c520c"), new DateTime(2024, 4, 16, 17, 12, 18, 470, DateTimeKind.Local).AddTicks(9768), null, "1", "admin", false, "admin", new byte[] { 155, 240, 105, 241, 125, 101, 13, 41, 124, 151, 25, 129, 49, 217, 248, 135, 189, 223, 201, 230, 191, 165, 215, 47, 58, 28, 78, 239, 92, 163, 124, 71, 211, 64, 215, 246, 128, 119, 229, 185, 154, 45, 226, 25, 228, 240, 204, 17, 118, 19, 20, 79, 139, 194, 1, 223, 127, 156, 237, 196, 34, 175, 182, 215 }, new byte[] { 34, 197, 58, 248, 141, 81, 43, 50, 191, 82, 78, 17, 163, 238, 77, 167, 99, 156, 164, 13, 105, 118, 41, 200, 202, 36, 171, 182, 249, 115, 150, 180, 105, 157, 19, 122, 190, 64, 48, 8, 69, 217, 136, 97, 201, 153, 39, 162, 244, 34, 78, 169, 96, 74, 163, 152, 243, 216, 84, 150, 154, 124, 154, 12, 211, 255, 247, 155, 211, 217, 139, 43, 35, 203, 223, 95, 28, 3, 77, 138, 186, 75, 125, 79, 161, 28, 13, 236, 156, 66, 9, 53, 122, 119, 61, 82, 227, 52, 32, 49, 103, 92, 64, 144, 251, 146, 35, 212, 107, 17, 187, 254, 149, 226, 214, 150, 215, 121, 193, 108, 151, 193, 224, 244, 62, 162, 148, 69 }, null, "admin", 0 });
        }
    }
}
