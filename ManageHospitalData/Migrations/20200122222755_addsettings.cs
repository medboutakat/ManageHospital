using Microsoft.EntityFrameworkCore.Migrations;

namespace ManageHospitalData.Migrations
{
    public partial class addsettings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hospitals_HospitalCategories_CategoryId",
                table: "Hospitals");

            migrationBuilder.DropForeignKey(
                name: "FK_Hospitals_Contacts_contactId",
                table: "Hospitals");

            migrationBuilder.DropColumn(
                name: "Assurance",
                table: "Hospitals");

            migrationBuilder.RenameColumn(
                name: "contactId",
                table: "Hospitals",
                newName: "ContactId");

            migrationBuilder.RenameIndex(
                name: "IX_Hospitals_contactId",
                table: "Hospitals",
                newName: "IX_Hospitals_ContactId");

            migrationBuilder.AlterColumn<int>(
                name: "ContactId",
                table: "Hospitals",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Hospitals",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CountryHealthId",
                table: "Hospitals",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "History",
                table: "Hospitals",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Hospitals",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Remark",
                table: "Hospitals",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Hospitals_HospitalCategories_CategoryId",
                table: "Hospitals",
                column: "CategoryId",
                principalTable: "HospitalCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hospitals_Contacts_ContactId",
                table: "Hospitals",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hospitals_HospitalCategories_CategoryId",
                table: "Hospitals");

            migrationBuilder.DropForeignKey(
                name: "FK_Hospitals_Contacts_ContactId",
                table: "Hospitals");

            migrationBuilder.DropColumn(
                name: "CountryHealthId",
                table: "Hospitals");

            migrationBuilder.DropColumn(
                name: "History",
                table: "Hospitals");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Hospitals");

            migrationBuilder.DropColumn(
                name: "Remark",
                table: "Hospitals");

            migrationBuilder.RenameColumn(
                name: "ContactId",
                table: "Hospitals",
                newName: "contactId");

            migrationBuilder.RenameIndex(
                name: "IX_Hospitals_ContactId",
                table: "Hospitals",
                newName: "IX_Hospitals_contactId");

            migrationBuilder.AlterColumn<int>(
                name: "contactId",
                table: "Hospitals",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Hospitals",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Assurance",
                table: "Hospitals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Hospitals_HospitalCategories_CategoryId",
                table: "Hospitals",
                column: "CategoryId",
                principalTable: "HospitalCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hospitals_Contacts_contactId",
                table: "Hospitals",
                column: "contactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
