using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ManageHospitalData.Migrations.Scripts
{
    public partial class doctorOeration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Operations_OperationId",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_OperationId",
                table: "Doctors");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("032247f2-b429-4d58-acb5-e72a6296dd79"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3381a03c-8c28-40bb-a56b-7b928a57afc9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ffe08933-a2d9-4f9b-899e-1ad2d3357a70"));

            migrationBuilder.DropColumn(
                name: "OperationId",
                table: "Doctors");

            migrationBuilder.CreateTable(
                name: "DoctorOperation",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DoctorId = table.Column<Guid>(nullable: true),
                    OperationId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorOperation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoctorOperation_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DoctorOperation_Operations_OperationId",
                        column: x => x.OperationId,
                        principalTable: "Operations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "Remark" },
                values: new object[] { new Guid("16579d27-c0c2-4171-b773-bf90e91dc7d6"), "Patient", "Patient" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "Remark" },
                values: new object[] { new Guid("73766854-1664-4fc9-873f-e7dd1a3ec7da"), "Assusstance", "Assusstance" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "Remark" },
                values: new object[] { new Guid("f294aa5a-3573-431c-9f9c-f5cd118fa327"), "Doctor", "Doctor" });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorOperation_DoctorId",
                table: "DoctorOperation",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorOperation_OperationId",
                table: "DoctorOperation",
                column: "OperationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorOperation");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("16579d27-c0c2-4171-b773-bf90e91dc7d6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("73766854-1664-4fc9-873f-e7dd1a3ec7da"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f294aa5a-3573-431c-9f9c-f5cd118fa327"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                table: "Doctors",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "Remark" },
                values: new object[] { new Guid("ffe08933-a2d9-4f9b-899e-1ad2d3357a70"), "Patient", "Patient" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "Remark" },
                values: new object[] { new Guid("3381a03c-8c28-40bb-a56b-7b928a57afc9"), "Assusstance", "Assusstance" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "Remark" },
                values: new object[] { new Guid("032247f2-b429-4d58-acb5-e72a6296dd79"), "Doctor", "Doctor" });

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_OperationId",
                table: "Doctors",
                column: "OperationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Operations_OperationId",
                table: "Doctors",
                column: "OperationId",
                principalTable: "Operations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
