using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ggggg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "core",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a0ecda0e-a588-4e3b-8d0f-2703e4bb529e"));

            migrationBuilder.AddColumn<bool>(
                name: "VerifyUser",
                schema: "person",
                table: "Person",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                schema: "core",
                table: "User",
                columns: new[] { "Id", "CreatedDate", "DoctorId", "Email", "FirstName", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PersonId", "PrivateNumber", "Role" },
                values: new object[] { new Guid("56315fb9-f216-4864-914c-772a0b505c94"), new DateTime(2024, 3, 31, 3, 35, 10, 597, DateTimeKind.Local).AddTicks(77), null, "1", "admin", false, "admin", new byte[] { 158, 144, 187, 202, 125, 10, 55, 239, 64, 64, 218, 162, 61, 104, 248, 255, 194, 207, 147, 133, 11, 251, 252, 128, 39, 23, 136, 121, 141, 34, 205, 79, 184, 101, 148, 88, 85, 188, 56, 128, 63, 102, 33, 200, 175, 190, 186, 232, 80, 100, 23, 146, 189, 161, 108, 29, 5, 142, 249, 230, 254, 229, 235, 36 }, new byte[] { 140, 208, 212, 163, 4, 194, 30, 20, 74, 230, 174, 76, 174, 139, 150, 15, 13, 208, 243, 193, 176, 114, 71, 30, 29, 89, 245, 45, 42, 142, 155, 93, 121, 202, 188, 72, 102, 244, 249, 176, 86, 109, 155, 10, 134, 68, 93, 152, 52, 245, 44, 57, 169, 43, 171, 25, 145, 72, 211, 186, 92, 173, 229, 98, 170, 236, 4, 44, 239, 248, 125, 101, 247, 89, 34, 191, 185, 112, 224, 114, 138, 38, 68, 61, 59, 198, 55, 205, 219, 190, 242, 48, 228, 98, 20, 23, 184, 253, 186, 55, 250, 162, 226, 182, 7, 251, 187, 69, 252, 77, 174, 84, 100, 99, 250, 209, 52, 144, 189, 171, 132, 2, 114, 158, 106, 150, 100, 167 }, null, "admin", 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "core",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("56315fb9-f216-4864-914c-772a0b505c94"));

            migrationBuilder.DropColumn(
                name: "VerifyUser",
                schema: "person",
                table: "Person");

            migrationBuilder.InsertData(
                schema: "core",
                table: "User",
                columns: new[] { "Id", "CreatedDate", "DoctorId", "Email", "FirstName", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PersonId", "PrivateNumber", "Role" },
                values: new object[] { new Guid("a0ecda0e-a588-4e3b-8d0f-2703e4bb529e"), new DateTime(2024, 3, 30, 23, 3, 24, 791, DateTimeKind.Local).AddTicks(1833), null, "1", "admin", false, "admin", new byte[] { 226, 194, 152, 75, 163, 192, 84, 28, 164, 155, 98, 246, 176, 243, 31, 248, 246, 28, 6, 79, 140, 26, 157, 237, 10, 30, 39, 89, 105, 72, 252, 172, 162, 167, 47, 109, 112, 227, 231, 166, 114, 171, 19, 134, 125, 10, 15, 33, 229, 162, 91, 167, 252, 172, 82, 253, 221, 155, 41, 109, 114, 215, 249, 135 }, new byte[] { 162, 11, 169, 218, 116, 163, 120, 40, 52, 226, 3, 206, 125, 19, 179, 99, 3, 185, 219, 84, 117, 61, 159, 234, 248, 160, 64, 86, 96, 191, 84, 186, 225, 45, 128, 115, 188, 108, 149, 157, 158, 252, 214, 70, 167, 86, 221, 202, 105, 159, 245, 26, 130, 173, 53, 197, 107, 160, 223, 97, 230, 53, 106, 40, 131, 34, 224, 82, 28, 156, 148, 26, 174, 227, 228, 121, 179, 236, 208, 246, 122, 33, 147, 17, 108, 18, 102, 211, 10, 95, 152, 71, 233, 161, 250, 212, 116, 18, 58, 204, 223, 34, 247, 190, 17, 65, 131, 199, 104, 7, 9, 110, 212, 195, 233, 182, 3, 7, 29, 198, 150, 172, 18, 169, 157, 74, 252, 210 }, null, "admin", 0 });
        }
    }
}
