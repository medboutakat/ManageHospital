using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ManageHospitalData.Migrations.Scripts
{
    public partial class addresponse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
