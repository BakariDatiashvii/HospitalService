using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class adaddo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "core",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f11ea811-0e3d-44bb-87ab-43dc283fd8ec"));

            migrationBuilder.InsertData(
                schema: "core",
                table: "User",
                columns: new[] { "Id", "CreatedDate", "DoctorId", "Email", "FirstName", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PersonId", "PrivateNumber", "Role" },
                values: new object[] { new Guid("d9778054-1a7d-4bf5-a776-0ef279004826"), new DateTime(2024, 3, 31, 18, 25, 14, 18, DateTimeKind.Local).AddTicks(9502), null, "1", "admin", false, "admin", new byte[] { 187, 148, 36, 76, 14, 83, 20, 24, 86, 118, 63, 54, 109, 159, 231, 39, 74, 19, 116, 19, 64, 75, 245, 119, 118, 251, 11, 72, 42, 40, 255, 59, 224, 196, 111, 103, 156, 198, 226, 242, 96, 104, 251, 218, 69, 118, 126, 143, 110, 140, 27, 235, 212, 208, 254, 61, 31, 108, 24, 96, 48, 77, 167, 94 }, new byte[] { 101, 118, 107, 130, 210, 39, 74, 238, 236, 223, 130, 58, 241, 114, 126, 197, 60, 161, 69, 71, 19, 111, 170, 128, 101, 56, 216, 180, 161, 28, 238, 33, 96, 116, 179, 29, 10, 18, 77, 18, 205, 89, 218, 65, 150, 234, 177, 38, 254, 158, 42, 197, 201, 34, 81, 67, 190, 77, 42, 65, 115, 65, 28, 254, 36, 127, 69, 127, 185, 249, 138, 191, 122, 149, 7, 147, 5, 73, 176, 174, 78, 117, 246, 244, 196, 94, 48, 58, 190, 187, 215, 75, 55, 165, 133, 210, 169, 165, 106, 117, 20, 255, 146, 98, 34, 136, 32, 220, 96, 105, 120, 214, 8, 143, 72, 104, 97, 41, 62, 178, 108, 120, 128, 6, 47, 17, 92, 18 }, null, "admin", 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "core",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d9778054-1a7d-4bf5-a776-0ef279004826"));

            migrationBuilder.InsertData(
                schema: "core",
                table: "User",
                columns: new[] { "Id", "CreatedDate", "DoctorId", "Email", "FirstName", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PersonId", "PrivateNumber", "Role" },
                values: new object[] { new Guid("f11ea811-0e3d-44bb-87ab-43dc283fd8ec"), new DateTime(2024, 3, 31, 17, 0, 58, 517, DateTimeKind.Local).AddTicks(9802), null, "1", "admin", false, "admin", new byte[] { 10, 7, 220, 133, 172, 17, 245, 177, 60, 9, 222, 84, 93, 177, 57, 37, 228, 239, 233, 63, 72, 151, 135, 246, 92, 236, 189, 237, 169, 197, 86, 160, 73, 253, 240, 200, 23, 7, 10, 156, 159, 48, 76, 139, 121, 112, 167, 113, 140, 153, 151, 72, 36, 7, 4, 159, 97, 176, 5, 190, 147, 245, 16, 75 }, new byte[] { 251, 103, 161, 18, 247, 36, 255, 80, 60, 8, 215, 132, 63, 184, 150, 231, 207, 155, 163, 124, 218, 56, 255, 219, 111, 207, 69, 62, 108, 26, 198, 187, 116, 74, 224, 175, 64, 39, 85, 149, 237, 146, 68, 245, 235, 188, 133, 97, 230, 178, 183, 176, 177, 5, 20, 199, 205, 146, 104, 34, 65, 102, 209, 46, 193, 218, 22, 245, 180, 219, 218, 176, 219, 173, 118, 48, 40, 87, 155, 6, 235, 228, 72, 114, 26, 24, 87, 216, 162, 5, 173, 23, 221, 216, 187, 58, 60, 211, 224, 122, 21, 199, 149, 3, 252, 69, 0, 5, 200, 214, 132, 25, 239, 146, 90, 208, 230, 68, 194, 108, 247, 209, 10, 136, 250, 245, 1, 48 }, null, "admin", 0 });
        }
    }
}
