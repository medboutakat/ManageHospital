using Microsoft.EntityFrameworkCore.Migrations;

namespace ManageHospitalData.Migrations
{
    public partial class patient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointements_Patiences_PatienceId",
                table: "Appointements");

            migrationBuilder.DropTable(
                name: "Patiences");

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Sexe = table.Column<string>(nullable: true),
                    contactId = table.Column<int>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    IdentityNo = table.Column<string>(nullable: true),
                    Assurance = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_Contacts_contactId",
                        column: x => x.contactId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_contactId",
                table: "Patients",
                column: "contactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointements_Patients_PatienceId",
                table: "Appointements",
                column: "PatienceId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointements_Patients_PatienceId",
                table: "Appointements");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.CreateTable(
                name: "Patiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Assurance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentityNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sexe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patiences_Contacts_contactId",
                        column: x => x.contactId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patiences_contactId",
                table: "Patiences",
                column: "contactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointements_Patiences_PatienceId",
                table: "Appointements",
                column: "PatienceId",
                principalTable: "Patiences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
