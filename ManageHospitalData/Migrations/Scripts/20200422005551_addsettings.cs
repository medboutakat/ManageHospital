using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ManageHospitalData.Migrations.Scripts
{
    public partial class addsettings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetails_Invoices_InvoiceId",
                table: "InvoiceDetails");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "InvoiceId",
                table: "InvoiceDetails",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CovePath",
                table: "Hospitals",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PictureProfilePath",
                table: "Hospitals",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Group = table.Column<string>(nullable: true),
                    Key = table.Column<string>(nullable: true),
                    Display = table.Column<string>(nullable: true),
                    ParseType = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "Remark" },
                values: new object[] { new Guid("aee933a3-cfd7-4a57-9fcd-c979862feafe"), "Patient", "Patient" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "Remark" },
                values: new object[] { new Guid("05e31779-040b-4fbc-8c8a-a7dfbdd34d57"), "Assusstance", "Assusstance" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "Remark" },
                values: new object[] { new Guid("cec4cd20-4a76-41d5-8990-c62a3ca4fbe3"), "Doctor", "Doctor" });

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetails_Invoices_InvoiceId",
                table: "InvoiceDetails",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetails_Invoices_InvoiceId",
                table: "InvoiceDetails");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("05e31779-040b-4fbc-8c8a-a7dfbdd34d57"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("aee933a3-cfd7-4a57-9fcd-c979862feafe"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("cec4cd20-4a76-41d5-8990-c62a3ca4fbe3"));

            migrationBuilder.DropColumn(
                name: "CovePath",
                table: "Hospitals");

            migrationBuilder.DropColumn(
                name: "PictureProfilePath",
                table: "Hospitals");

            migrationBuilder.AlterColumn<Guid>(
                name: "InvoiceId",
                table: "InvoiceDetails",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

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

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetails_Invoices_InvoiceId",
                table: "InvoiceDetails",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
