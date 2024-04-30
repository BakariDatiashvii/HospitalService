using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class adadd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "core",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("56315fb9-f216-4864-914c-772a0b505c94"));

            migrationBuilder.AlterColumn<int>(
                name: "ActivateCode",
                schema: "person",
                table: "Person",
                type: "int",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 20);

            migrationBuilder.InsertData(
                schema: "core",
                table: "User",
                columns: new[] { "Id", "CreatedDate", "DoctorId", "Email", "FirstName", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PersonId", "PrivateNumber", "Role" },
                values: new object[] { new Guid("f11ea811-0e3d-44bb-87ab-43dc283fd8ec"), new DateTime(2024, 3, 31, 17, 0, 58, 517, DateTimeKind.Local).AddTicks(9802), null, "1", "admin", false, "admin", new byte[] { 10, 7, 220, 133, 172, 17, 245, 177, 60, 9, 222, 84, 93, 177, 57, 37, 228, 239, 233, 63, 72, 151, 135, 246, 92, 236, 189, 237, 169, 197, 86, 160, 73, 253, 240, 200, 23, 7, 10, 156, 159, 48, 76, 139, 121, 112, 167, 113, 140, 153, 151, 72, 36, 7, 4, 159, 97, 176, 5, 190, 147, 245, 16, 75 }, new byte[] { 251, 103, 161, 18, 247, 36, 255, 80, 60, 8, 215, 132, 63, 184, 150, 231, 207, 155, 163, 124, 218, 56, 255, 219, 111, 207, 69, 62, 108, 26, 198, 187, 116, 74, 224, 175, 64, 39, 85, 149, 237, 146, 68, 245, 235, 188, 133, 97, 230, 178, 183, 176, 177, 5, 20, 199, 205, 146, 104, 34, 65, 102, 209, 46, 193, 218, 22, 245, 180, 219, 218, 176, 219, 173, 118, 48, 40, 87, 155, 6, 235, 228, 72, 114, 26, 24, 87, 216, 162, 5, 173, 23, 221, 216, 187, 58, 60, 211, 224, 122, 21, 199, 149, 3, 252, 69, 0, 5, 200, 214, 132, 25, 239, 146, 90, 208, 230, 68, 194, 108, 247, 209, 10, 136, 250, 245, 1, 48 }, null, "admin", 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "core",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f11ea811-0e3d-44bb-87ab-43dc283fd8ec"));

            migrationBuilder.AlterColumn<int>(
                name: "ActivateCode",
                schema: "person",
                table: "Person",
                type: "int",
                maxLength: 20,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.InsertData(
                schema: "core",
                table: "User",
                columns: new[] { "Id", "CreatedDate", "DoctorId", "Email", "FirstName", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PersonId", "PrivateNumber", "Role" },
                values: new object[] { new Guid("56315fb9-f216-4864-914c-772a0b505c94"), new DateTime(2024, 3, 31, 3, 35, 10, 597, DateTimeKind.Local).AddTicks(77), null, "1", "admin", false, "admin", new byte[] { 158, 144, 187, 202, 125, 10, 55, 239, 64, 64, 218, 162, 61, 104, 248, 255, 194, 207, 147, 133, 11, 251, 252, 128, 39, 23, 136, 121, 141, 34, 205, 79, 184, 101, 148, 88, 85, 188, 56, 128, 63, 102, 33, 200, 175, 190, 186, 232, 80, 100, 23, 146, 189, 161, 108, 29, 5, 142, 249, 230, 254, 229, 235, 36 }, new byte[] { 140, 208, 212, 163, 4, 194, 30, 20, 74, 230, 174, 76, 174, 139, 150, 15, 13, 208, 243, 193, 176, 114, 71, 30, 29, 89, 245, 45, 42, 142, 155, 93, 121, 202, 188, 72, 102, 244, 249, 176, 86, 109, 155, 10, 134, 68, 93, 152, 52, 245, 44, 57, 169, 43, 171, 25, 145, 72, 211, 186, 92, 173, 229, 98, 170, 236, 4, 44, 239, 248, 125, 101, 247, 89, 34, 191, 185, 112, 224, 114, 138, 38, 68, 61, 59, 198, 55, 205, 219, 190, 242, 48, 228, 98, 20, 23, 184, 253, 186, 55, 250, 162, 226, 182, 7, 251, 187, 69, 252, 77, 174, 84, 100, 99, 250, 209, 52, 144, 189, 171, 132, 2, 114, 158, 106, 150, 100, 167 }, null, "admin", 0 });
        }
    }
}
