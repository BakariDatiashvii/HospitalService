using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class bliad1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Categorys_CategoryID",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Doctors_DoctorId",
                schema: "core",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Persons_PersonId",
                schema: "core",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorys",
                table: "Categorys");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d406dbf6-9728-41a4-bbb6-2dbd57696a9e"));

            migrationBuilder.EnsureSchema(
                name: "category");

            migrationBuilder.EnsureSchema(
                name: "doctor");

            migrationBuilder.EnsureSchema(
                name: "person");

            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "Person",
                newSchema: "person");

            migrationBuilder.RenameTable(
                name: "Doctors",
                newName: "Doctor",
                newSchema: "doctor");

            migrationBuilder.RenameTable(
                name: "Categorys",
                newName: "Category",
                newSchema: "category");

            migrationBuilder.RenameIndex(
                name: "IX_Doctors_CategoryID",
                schema: "doctor",
                table: "Doctor",
                newName: "IX_Doctor_CategoryID");

            migrationBuilder.AlterColumn<string>(
                name: "ActivateCode",
                schema: "person",
                table: "Person",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                schema: "person",
                table: "Person",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "photo",
                schema: "doctor",
                table: "Doctor",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "cv",
                schema: "doctor",
                table: "Doctor",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "category",
                table: "Category",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                schema: "person",
                table: "Person",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctor",
                schema: "doctor",
                table: "Doctor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                schema: "category",
                table: "Category",
                column: "Id");

            migrationBuilder.InsertData(
                schema: "core",
                table: "User",
                columns: new[] { "Id", "CreatedDate", "DoctorId", "Email", "FirstName", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PersonId", "PrivateNumber", "Role" },
                values: new object[] { new Guid("a740ca29-3c80-4d7e-b814-03af7a90a3a5"), new DateTime(2024, 3, 30, 22, 14, 33, 607, DateTimeKind.Local).AddTicks(7246), null, "1", "admin", false, "admin", new byte[] { 235, 181, 70, 169, 119, 71, 196, 213, 117, 7, 137, 77, 235, 238, 203, 71, 178, 61, 121, 85, 159, 162, 58, 99, 204, 8, 171, 50, 47, 252, 165, 234, 89, 241, 102, 244, 26, 25, 6, 188, 141, 154, 176, 189, 78, 64, 208, 197, 75, 174, 17, 38, 137, 53, 93, 211, 136, 14, 163, 133, 244, 146, 21, 188 }, new byte[] { 193, 61, 152, 71, 172, 141, 126, 2, 198, 128, 196, 29, 146, 77, 48, 240, 138, 146, 61, 127, 201, 127, 141, 202, 86, 124, 173, 28, 186, 205, 94, 71, 204, 21, 142, 104, 254, 138, 7, 112, 94, 231, 23, 185, 132, 21, 151, 132, 4, 15, 136, 218, 98, 80, 33, 192, 126, 24, 114, 63, 4, 166, 253, 220, 57, 173, 60, 253, 19, 224, 115, 32, 151, 247, 126, 236, 85, 230, 45, 141, 35, 7, 98, 153, 48, 96, 45, 98, 180, 116, 195, 146, 57, 138, 136, 241, 93, 88, 5, 165, 145, 218, 119, 179, 128, 139, 176, 126, 84, 51, 151, 242, 13, 146, 145, 62, 254, 223, 163, 174, 152, 53, 142, 125, 160, 212, 24, 157 }, null, "admin", 0 });

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Category_CategoryID",
                schema: "doctor",
                table: "Doctor",
                column: "CategoryID",
                principalSchema: "category",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Doctor_DoctorId",
                schema: "core",
                table: "User",
                column: "DoctorId",
                principalSchema: "doctor",
                principalTable: "Doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Person_PersonId",
                schema: "core",
                table: "User",
                column: "PersonId",
                principalSchema: "person",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Category_CategoryID",
                schema: "doctor",
                table: "Doctor");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Doctor_DoctorId",
                schema: "core",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Person_PersonId",
                schema: "core",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                schema: "person",
                table: "Person");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctor",
                schema: "doctor",
                table: "Doctor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                schema: "category",
                table: "Category");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a740ca29-3c80-4d7e-b814-03af7a90a3a5"));

            migrationBuilder.DropColumn(
                name: "UserId",
                schema: "person",
                table: "Person");

            migrationBuilder.RenameTable(
                name: "Person",
                schema: "person",
                newName: "Persons");

            migrationBuilder.RenameTable(
                name: "Doctor",
                schema: "doctor",
                newName: "Doctors");

            migrationBuilder.RenameTable(
                name: "Category",
                schema: "category",
                newName: "Categorys");

            migrationBuilder.RenameIndex(
                name: "IX_Doctor_CategoryID",
                table: "Doctors",
                newName: "IX_Doctors_CategoryID");

            migrationBuilder.AlterColumn<string>(
                name: "ActivateCode",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<byte[]>(
                name: "photo",
                table: "Doctors",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AlterColumn<byte[]>(
                name: "cv",
                table: "Doctors",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categorys",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "Persons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorys",
                table: "Categorys",
                column: "Id");

            migrationBuilder.InsertData(
                schema: "core",
                table: "User",
                columns: new[] { "Id", "CreatedDate", "DoctorId", "Email", "FirstName", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PersonId", "PrivateNumber", "Role" },
                values: new object[] { new Guid("d406dbf6-9728-41a4-bbb6-2dbd57696a9e"), new DateTime(2024, 3, 22, 23, 45, 26, 447, DateTimeKind.Local).AddTicks(3724), null, "1", "admin", false, "admin", new byte[] { 73, 174, 121, 19, 239, 92, 184, 77, 199, 190, 193, 20, 24, 50, 59, 4, 244, 153, 30, 199, 113, 198, 39, 65, 226, 89, 178, 183, 158, 23, 104, 238, 105, 164, 223, 86, 238, 235, 168, 169, 147, 227, 17, 207, 75, 25, 213, 72, 86, 155, 10, 85, 221, 188, 112, 224, 33, 129, 185, 0, 83, 30, 171, 91 }, new byte[] { 31, 76, 61, 87, 220, 144, 237, 117, 163, 93, 210, 2, 167, 220, 118, 65, 127, 129, 141, 183, 195, 82, 113, 16, 192, 168, 109, 131, 43, 216, 66, 173, 176, 71, 187, 39, 107, 12, 99, 210, 23, 75, 154, 238, 174, 48, 159, 206, 81, 87, 69, 177, 22, 45, 103, 94, 82, 114, 240, 225, 16, 45, 84, 205, 13, 184, 70, 219, 17, 54, 124, 91, 241, 3, 127, 29, 136, 135, 6, 40, 146, 49, 58, 249, 204, 178, 116, 90, 130, 124, 201, 67, 5, 194, 218, 151, 220, 62, 242, 86, 183, 105, 31, 52, 38, 161, 43, 232, 162, 91, 158, 165, 98, 154, 16, 225, 61, 79, 242, 35, 157, 240, 215, 157, 232, 167, 94, 154 }, null, "admin", 0 });

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Categorys_CategoryID",
                table: "Doctors",
                column: "CategoryID",
                principalTable: "Categorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Doctors_DoctorId",
                schema: "core",
                table: "User",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Persons_PersonId",
                schema: "core",
                table: "User",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
