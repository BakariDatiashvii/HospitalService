using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ffddf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Category_CategoryID",  
                schema: "doctor",
                table: "Doctor");

            migrationBuilder.DropIndex(
                name: "IX_Doctor_CategoryID",
                schema: "doctor",
                table: "Doctor");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d9778054-1a7d-4bf5-a776-0ef279004826"));

            migrationBuilder.DropColumn(
                name: "CategoryID",
                schema: "doctor",
                table: "Doctor");

            migrationBuilder.EnsureSchema(
                name: "CategoryDoctor");

            migrationBuilder.CreateTable(
                name: "CategoryDoctor",
                schema: "CategoryDoctor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryDoctor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryDoctor_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "category",
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CategoryDoctor_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalSchema: "doctor",
                        principalTable: "Doctor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                schema: "core",
                table: "User",
                columns: new[] { "Id", "CreatedDate", "DoctorId", "Email", "FirstName", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PersonId", "PrivateNumber", "Role" },
                values: new object[] { new Guid("6ebe8acf-acd0-4e7f-bde5-d40e878f4f83"), new DateTime(2024, 4, 14, 18, 58, 4, 827, DateTimeKind.Local).AddTicks(7387), null, "1", "admin", false, "admin", new byte[] { 244, 15, 160, 83, 76, 252, 22, 155, 12, 45, 230, 119, 118, 22, 130, 127, 105, 47, 75, 140, 175, 116, 212, 171, 115, 1, 109, 89, 203, 223, 87, 17, 249, 38, 192, 135, 154, 71, 22, 170, 30, 224, 87, 157, 173, 76, 99, 80, 215, 227, 77, 234, 147, 157, 241, 203, 210, 100, 113, 156, 63, 170, 37, 90 }, new byte[] { 142, 69, 167, 16, 123, 223, 105, 93, 11, 22, 84, 150, 74, 105, 223, 85, 206, 215, 243, 65, 218, 62, 190, 229, 34, 155, 134, 86, 16, 43, 236, 161, 189, 50, 99, 93, 135, 37, 154, 115, 212, 36, 154, 120, 32, 168, 246, 149, 41, 127, 52, 110, 216, 250, 203, 34, 67, 20, 51, 79, 207, 104, 197, 126, 66, 50, 158, 140, 122, 138, 63, 147, 178, 226, 114, 159, 192, 85, 141, 91, 237, 206, 172, 32, 77, 102, 204, 36, 204, 101, 224, 63, 200, 14, 137, 54, 119, 231, 14, 241, 179, 197, 249, 43, 102, 145, 156, 225, 245, 37, 16, 210, 244, 150, 254, 29, 227, 102, 231, 101, 195, 44, 111, 128, 27, 153, 71, 45 }, null, "admin", 0 });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryDoctor_CategoryId",
                schema: "CategoryDoctor",
                table: "CategoryDoctor",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryDoctor_DoctorId",
                schema: "CategoryDoctor",
                table: "CategoryDoctor",
                column: "DoctorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryDoctor",
                schema: "CategoryDoctor");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6ebe8acf-acd0-4e7f-bde5-d40e878f4f83"));

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryID",
                schema: "doctor",
                table: "Doctor",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                schema: "core",
                table: "User",
                columns: new[] { "Id", "CreatedDate", "DoctorId", "Email", "FirstName", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PersonId", "PrivateNumber", "Role" },
                values: new object[] { new Guid("d9778054-1a7d-4bf5-a776-0ef279004826"), new DateTime(2024, 3, 31, 18, 25, 14, 18, DateTimeKind.Local).AddTicks(9502), null, "1", "admin", false, "admin", new byte[] { 187, 148, 36, 76, 14, 83, 20, 24, 86, 118, 63, 54, 109, 159, 231, 39, 74, 19, 116, 19, 64, 75, 245, 119, 118, 251, 11, 72, 42, 40, 255, 59, 224, 196, 111, 103, 156, 198, 226, 242, 96, 104, 251, 218, 69, 118, 126, 143, 110, 140, 27, 235, 212, 208, 254, 61, 31, 108, 24, 96, 48, 77, 167, 94 }, new byte[] { 101, 118, 107, 130, 210, 39, 74, 238, 236, 223, 130, 58, 241, 114, 126, 197, 60, 161, 69, 71, 19, 111, 170, 128, 101, 56, 216, 180, 161, 28, 238, 33, 96, 116, 179, 29, 10, 18, 77, 18, 205, 89, 218, 65, 150, 234, 177, 38, 254, 158, 42, 197, 201, 34, 81, 67, 190, 77, 42, 65, 115, 65, 28, 254, 36, 127, 69, 127, 185, 249, 138, 191, 122, 149, 7, 147, 5, 73, 176, 174, 78, 117, 246, 244, 196, 94, 48, 58, 190, 187, 215, 75, 55, 165, 133, 210, 169, 165, 106, 117, 20, 255, 146, 98, 34, 136, 32, 220, 96, 105, 120, 214, 8, 143, 72, 104, 97, 41, 62, 178, 108, 120, 128, 6, 47, 17, 92, 18 }, null, "admin", 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_CategoryID",
                schema: "doctor",
                table: "Doctor",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Category_CategoryID",
                schema: "doctor",
                table: "Doctor",
                column: "CategoryID",
                principalSchema: "category",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
