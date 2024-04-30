using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class tresdsdfsda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "core",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6ebe8acf-acd0-4e7f-bde5-d40e878f4f83"));

            migrationBuilder.AlterColumn<Guid>(
                name: "DoctorId",
                schema: "CategoryDoctor",
                table: "CategoryDoctor",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                schema: "CategoryDoctor",
                table: "CategoryDoctor",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                schema: "core",
                table: "User",
                columns: new[] { "Id", "CreatedDate", "DoctorId", "Email", "FirstName", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PersonId", "PrivateNumber", "Role" },
                values: new object[] { new Guid("57ce1bea-150b-4bfa-aa0f-5751381c520c"), new DateTime(2024, 4, 16, 17, 12, 18, 470, DateTimeKind.Local).AddTicks(9768), null, "1", "admin", false, "admin", new byte[] { 155, 240, 105, 241, 125, 101, 13, 41, 124, 151, 25, 129, 49, 217, 248, 135, 189, 223, 201, 230, 191, 165, 215, 47, 58, 28, 78, 239, 92, 163, 124, 71, 211, 64, 215, 246, 128, 119, 229, 185, 154, 45, 226, 25, 228, 240, 204, 17, 118, 19, 20, 79, 139, 194, 1, 223, 127, 156, 237, 196, 34, 175, 182, 215 }, new byte[] { 34, 197, 58, 248, 141, 81, 43, 50, 191, 82, 78, 17, 163, 238, 77, 167, 99, 156, 164, 13, 105, 118, 41, 200, 202, 36, 171, 182, 249, 115, 150, 180, 105, 157, 19, 122, 190, 64, 48, 8, 69, 217, 136, 97, 201, 153, 39, 162, 244, 34, 78, 169, 96, 74, 163, 152, 243, 216, 84, 150, 154, 124, 154, 12, 211, 255, 247, 155, 211, 217, 139, 43, 35, 203, 223, 95, 28, 3, 77, 138, 186, 75, 125, 79, 161, 28, 13, 236, 156, 66, 9, 53, 122, 119, 61, 82, 227, 52, 32, 49, 103, 92, 64, 144, 251, 146, 35, 212, 107, 17, 187, 254, 149, 226, 214, 150, 215, 121, 193, 108, 151, 193, 224, 244, 62, 162, 148, 69 }, null, "admin", 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "core",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("57ce1bea-150b-4bfa-aa0f-5751381c520c"));

            migrationBuilder.AlterColumn<Guid>(
                name: "DoctorId",
                schema: "CategoryDoctor",
                table: "CategoryDoctor",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                schema: "CategoryDoctor",
                table: "CategoryDoctor",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                schema: "core",
                table: "User",
                columns: new[] { "Id", "CreatedDate", "DoctorId", "Email", "FirstName", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PersonId", "PrivateNumber", "Role" },
                values: new object[] { new Guid("6ebe8acf-acd0-4e7f-bde5-d40e878f4f83"), new DateTime(2024, 4, 14, 18, 58, 4, 827, DateTimeKind.Local).AddTicks(7387), null, "1", "admin", false, "admin", new byte[] { 244, 15, 160, 83, 76, 252, 22, 155, 12, 45, 230, 119, 118, 22, 130, 127, 105, 47, 75, 140, 175, 116, 212, 171, 115, 1, 109, 89, 203, 223, 87, 17, 249, 38, 192, 135, 154, 71, 22, 170, 30, 224, 87, 157, 173, 76, 99, 80, 215, 227, 77, 234, 147, 157, 241, 203, 210, 100, 113, 156, 63, 170, 37, 90 }, new byte[] { 142, 69, 167, 16, 123, 223, 105, 93, 11, 22, 84, 150, 74, 105, 223, 85, 206, 215, 243, 65, 218, 62, 190, 229, 34, 155, 134, 86, 16, 43, 236, 161, 189, 50, 99, 93, 135, 37, 154, 115, 212, 36, 154, 120, 32, 168, 246, 149, 41, 127, 52, 110, 216, 250, 203, 34, 67, 20, 51, 79, 207, 104, 197, 126, 66, 50, 158, 140, 122, 138, 63, 147, 178, 226, 114, 159, 192, 85, 141, 91, 237, 206, 172, 32, 77, 102, 204, 36, 204, 101, 224, 63, 200, 14, 137, 54, 119, 231, 14, 241, 179, 197, 249, 43, 102, 145, 156, 225, 245, 37, 16, 210, 244, 150, 254, 29, 227, 102, 231, 101, 195, 44, 111, 128, 27, 153, 71, 45 }, null, "admin", 0 });
        }
    }
}
