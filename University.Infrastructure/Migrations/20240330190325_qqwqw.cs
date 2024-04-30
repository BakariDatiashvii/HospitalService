using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class qqwqw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "core",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a740ca29-3c80-4d7e-b814-03af7a90a3a5"));

            migrationBuilder.AlterColumn<int>(
                name: "ActivateCode",
                schema: "person",
                table: "Person",
                type: "int",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.InsertData(
                schema: "core",
                table: "User",
                columns: new[] { "Id", "CreatedDate", "DoctorId", "Email", "FirstName", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PersonId", "PrivateNumber", "Role" },
                values: new object[] { new Guid("a0ecda0e-a588-4e3b-8d0f-2703e4bb529e"), new DateTime(2024, 3, 30, 23, 3, 24, 791, DateTimeKind.Local).AddTicks(1833), null, "1", "admin", false, "admin", new byte[] { 226, 194, 152, 75, 163, 192, 84, 28, 164, 155, 98, 246, 176, 243, 31, 248, 246, 28, 6, 79, 140, 26, 157, 237, 10, 30, 39, 89, 105, 72, 252, 172, 162, 167, 47, 109, 112, 227, 231, 166, 114, 171, 19, 134, 125, 10, 15, 33, 229, 162, 91, 167, 252, 172, 82, 253, 221, 155, 41, 109, 114, 215, 249, 135 }, new byte[] { 162, 11, 169, 218, 116, 163, 120, 40, 52, 226, 3, 206, 125, 19, 179, 99, 3, 185, 219, 84, 117, 61, 159, 234, 248, 160, 64, 86, 96, 191, 84, 186, 225, 45, 128, 115, 188, 108, 149, 157, 158, 252, 214, 70, 167, 86, 221, 202, 105, 159, 245, 26, 130, 173, 53, 197, 107, 160, 223, 97, 230, 53, 106, 40, 131, 34, 224, 82, 28, 156, 148, 26, 174, 227, 228, 121, 179, 236, 208, 246, 122, 33, 147, 17, 108, 18, 102, 211, 10, 95, 152, 71, 233, 161, 250, 212, 116, 18, 58, 204, 223, 34, 247, 190, 17, 65, 131, 199, 104, 7, 9, 110, 212, 195, 233, 182, 3, 7, 29, 198, 150, 172, 18, 169, 157, 74, 252, 210 }, null, "admin", 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "core",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a0ecda0e-a588-4e3b-8d0f-2703e4bb529e"));

            migrationBuilder.AlterColumn<string>(
                name: "ActivateCode",
                schema: "person",
                table: "Person",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 20);

            migrationBuilder.InsertData(
                schema: "core",
                table: "User",
                columns: new[] { "Id", "CreatedDate", "DoctorId", "Email", "FirstName", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PersonId", "PrivateNumber", "Role" },
                values: new object[] { new Guid("a740ca29-3c80-4d7e-b814-03af7a90a3a5"), new DateTime(2024, 3, 30, 22, 14, 33, 607, DateTimeKind.Local).AddTicks(7246), null, "1", "admin", false, "admin", new byte[] { 235, 181, 70, 169, 119, 71, 196, 213, 117, 7, 137, 77, 235, 238, 203, 71, 178, 61, 121, 85, 159, 162, 58, 99, 204, 8, 171, 50, 47, 252, 165, 234, 89, 241, 102, 244, 26, 25, 6, 188, 141, 154, 176, 189, 78, 64, 208, 197, 75, 174, 17, 38, 137, 53, 93, 211, 136, 14, 163, 133, 244, 146, 21, 188 }, new byte[] { 193, 61, 152, 71, 172, 141, 126, 2, 198, 128, 196, 29, 146, 77, 48, 240, 138, 146, 61, 127, 201, 127, 141, 202, 86, 124, 173, 28, 186, 205, 94, 71, 204, 21, 142, 104, 254, 138, 7, 112, 94, 231, 23, 185, 132, 21, 151, 132, 4, 15, 136, 218, 98, 80, 33, 192, 126, 24, 114, 63, 4, 166, 253, 220, 57, 173, 60, 253, 19, 224, 115, 32, 151, 247, 126, 236, 85, 230, 45, 141, 35, 7, 98, 153, 48, 96, 45, 98, 180, 116, 195, 146, 57, 138, 136, 241, 93, 88, 5, 165, 145, 218, 119, 179, 128, 139, 176, 126, 84, 51, 151, 242, 13, 146, 145, 62, 254, 223, 163, 174, 152, 53, 142, 125, 160, 212, 24, 157 }, null, "admin", 0 });
        }
    }
}
