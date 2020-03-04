using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ManageHospitalData.Migrations.Scripts
{
    public partial class addhosptalToappointment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointements_Patients_PatienceId",
                table: "Appointements");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("88686740-0f27-49cf-97f2-785864406675"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a7a01c07-13fe-4640-bdd2-1f474d9c4a00"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d91658f3-b49b-43a5-b85a-53b44788f587"));

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Assurance",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentityNo",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Users",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "Remark" },
                values: new object[] { new Guid("6ca12e73-c65c-428a-a4c5-ce1d9ef2f79f"), "Patient", "Patient" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "Remark" },
                values: new object[] { new Guid("c70f31f2-5791-4729-9d2a-f2a3db47b6f1"), "Assusstance", "Assusstance" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "Remark" },
                values: new object[] { new Guid("7a23f6a1-7a76-410b-b2c7-cf6f90419e29"), "Doctor", "Doctor" });

            migrationBuilder.AddForeignKey(
                name: "FK_Appointements_Users_PatienceId",
                table: "Appointements",
                column: "PatienceId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointements_Users_PatienceId",
                table: "Appointements");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6ca12e73-c65c-428a-a4c5-ce1d9ef2f79f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7a23f6a1-7a76-410b-b2c7-cf6f90419e29"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c70f31f2-5791-4729-9d2a-f2a3db47b6f1"));

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Assurance",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IdentityNo",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Assurance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentityNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sexe = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "Remark" },
                values: new object[] { new Guid("88686740-0f27-49cf-97f2-785864406675"), "Patient", "Patient" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "Remark" },
                values: new object[] { new Guid("a7a01c07-13fe-4640-bdd2-1f474d9c4a00"), "Assusstance", "Assusstance" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "Remark" },
                values: new object[] { new Guid("d91658f3-b49b-43a5-b85a-53b44788f587"), "Doctor", "Doctor" });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_ContactId",
                table: "Patients",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointements_Patients_PatienceId",
                table: "Appointements",
                column: "PatienceId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
