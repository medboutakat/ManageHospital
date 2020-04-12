using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ManageHospitalData.Migrations.Scripts
{
    public partial class updateInvocie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20d2b005-1306-428e-8f87-22c31708ea71"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("95ef201f-64d2-4f47-b67b-77b3267c585e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c809e47d-40df-4caf-b7cd-43dbcec712a7"));

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalAmont",
                table: "Invoices",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "Remark" },
                values: new object[] { new Guid("af9efd7d-f283-4e18-98f5-f1397c1848c9"), "Patient", "Patient" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "Remark" },
                values: new object[] { new Guid("2e902387-3acf-43c9-a134-ff754abe895b"), "Assusstance", "Assusstance" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "Remark" },
                values: new object[] { new Guid("14c3a12f-0dcb-4471-9a4c-fc272db73f49"), "Doctor", "Doctor" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("14c3a12f-0dcb-4471-9a4c-fc272db73f49"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2e902387-3acf-43c9-a134-ff754abe895b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("af9efd7d-f283-4e18-98f5-f1397c1848c9"));

            migrationBuilder.AlterColumn<double>(
                name: "TotalAmont",
                table: "Invoices",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "Remark" },
                values: new object[] { new Guid("95ef201f-64d2-4f47-b67b-77b3267c585e"), "Patient", "Patient" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "Remark" },
                values: new object[] { new Guid("c809e47d-40df-4caf-b7cd-43dbcec712a7"), "Assusstance", "Assusstance" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "Remark" },
                values: new object[] { new Guid("20d2b005-1306-428e-8f87-22c31708ea71"), "Doctor", "Doctor" });
        }
    }
}
