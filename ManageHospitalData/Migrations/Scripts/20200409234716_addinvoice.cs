using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ManageHospitalData.Migrations.Scripts
{
    public partial class addinvoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoctorOperation_Doctors_DoctorId",
                table: "DoctorOperation");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorOperation_Operations_OperationId",
                table: "DoctorOperation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DoctorOperation",
                table: "DoctorOperation");

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

            migrationBuilder.RenameTable(
                name: "DoctorOperation",
                newName: "DoctorOperations");

            migrationBuilder.RenameIndex(
                name: "IX_DoctorOperation_OperationId",
                table: "DoctorOperations",
                newName: "IX_DoctorOperations_OperationId");

            migrationBuilder.RenameIndex(
                name: "IX_DoctorOperation_DoctorId",
                table: "DoctorOperations",
                newName: "IX_DoctorOperations_DoctorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoctorOperations",
                table: "DoctorOperations",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    TotalAmont = table.Column<double>(nullable: false),
                    Expedition = table.Column<decimal>(nullable: false),
                    Livraison = table.Column<decimal>(nullable: false),
                    Remise = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Product = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Qte = table.Column<decimal>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Tax = table.Column<decimal>(nullable: false),
                    Total = table.Column<decimal>(nullable: false),
                    InvoiceId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceDetails_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetails_InvoiceId",
                table: "InvoiceDetails",
                column: "InvoiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorOperations_Doctors_DoctorId",
                table: "DoctorOperations",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorOperations_Operations_OperationId",
                table: "DoctorOperations",
                column: "OperationId",
                principalTable: "Operations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoctorOperations_Doctors_DoctorId",
                table: "DoctorOperations");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorOperations_Operations_OperationId",
                table: "DoctorOperations");

            migrationBuilder.DropTable(
                name: "InvoiceDetails");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DoctorOperations",
                table: "DoctorOperations");

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

            migrationBuilder.RenameTable(
                name: "DoctorOperations",
                newName: "DoctorOperation");

            migrationBuilder.RenameIndex(
                name: "IX_DoctorOperations_OperationId",
                table: "DoctorOperation",
                newName: "IX_DoctorOperation_OperationId");

            migrationBuilder.RenameIndex(
                name: "IX_DoctorOperations_DoctorId",
                table: "DoctorOperation",
                newName: "IX_DoctorOperation_DoctorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoctorOperation",
                table: "DoctorOperation",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorOperation_Doctors_DoctorId",
                table: "DoctorOperation",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorOperation_Operations_OperationId",
                table: "DoctorOperation",
                column: "OperationId",
                principalTable: "Operations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
