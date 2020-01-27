using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ManageHospitalData.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppointementStatuss",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointementStatuss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Phone1 = table.Column<string>(nullable: true),
                    Phone2 = table.Column<string>(nullable: true),
                    WhatsApp = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Adress1 = table.Column<string>(nullable: true),
                    Adress2 = table.Column<string>(nullable: true),
                    Other = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DoctorCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    File = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HospitalCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaterialCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaterialStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Decription = table.Column<string>(nullable: true),
                    AnalyzeResult = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Assutance",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Sexe = table.Column<string>(nullable: true),
                    ContactId = table.Column<Guid>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    IdentityNo = table.Column<string>(nullable: true),
                    Assurance = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assutance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assutance_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Sexe = table.Column<string>(nullable: true),
                    ContactId = table.Column<Guid>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    IdentityNo = table.Column<string>(nullable: true),
                    Assurance = table.Column<string>(nullable: true)
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

            migrationBuilder.CreateTable(
                name: "Assurances",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    DocumentsId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assurances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assurances_Documents_DocumentsId",
                        column: x => x.DocumentsId,
                        principalTable: "Documents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Hospitals",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CountryHealthId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    History = table.Column<string>(nullable: true),
                    HospitalCategoryId = table.Column<Guid>(nullable: false),
                    ContactId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hospitals_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hospitals_HospitalCategories_HospitalCategoryId",
                        column: x => x.HospitalCategoryId,
                        principalTable: "HospitalCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Sexe = table.Column<string>(nullable: true),
                    ContactId = table.Column<Guid>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Token = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    RoomNumber = table.Column<int>(nullable: false),
                    RoomCategoryId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomCategories_RoomCategoryId",
                        column: x => x.RoomCategoryId,
                        principalTable: "RoomCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TestResults",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DatePublish = table.Column<DateTime>(nullable: false),
                    DocumentsId = table.Column<Guid>(nullable: true),
                    TestId = table.Column<Guid>(nullable: true),
                    SentTo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestResults_Documents_DocumentsId",
                        column: x => x.DocumentsId,
                        principalTable: "Documents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TestResults_Tests_TestId",
                        column: x => x.TestId,
                        principalTable: "Tests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Appointements",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IdentityNo = table.Column<string>(nullable: true),
                    Assurance = table.Column<string>(nullable: true),
                    CallTimeStamp = table.Column<string>(nullable: true),
                    ReservationTimeStamp = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    StatusId = table.Column<Guid>(nullable: true),
                    PatienceId = table.Column<Guid>(nullable: true),
                    AssutanceId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointements_Assutance_AssutanceId",
                        column: x => x.AssutanceId,
                        principalTable: "Assutance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointements_Patients_PatienceId",
                        column: x => x.PatienceId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointements_AppointementStatuss_StatusId",
                        column: x => x.StatusId,
                        principalTable: "AppointementStatuss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    MaterialStatusId = table.Column<Guid>(nullable: true),
                    MaterialCategoryId = table.Column<Guid>(nullable: true),
                    RoomId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Materials_MaterialCategories_MaterialCategoryId",
                        column: x => x.MaterialCategoryId,
                        principalTable: "MaterialCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Materials_MaterialStatuses_MaterialStatusId",
                        column: x => x.MaterialStatusId,
                        principalTable: "MaterialStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Materials_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Operations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Price = table.Column<string>(nullable: true),
                    TotalStayNight = table.Column<string>(nullable: true),
                    OperationCategoryId = table.Column<Guid>(nullable: true),
                    RoomId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Operations_OperationCategories_OperationCategoryId",
                        column: x => x.OperationCategoryId,
                        principalTable: "OperationCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Operations_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Sexe = table.Column<string>(nullable: true),
                    ContactId = table.Column<Guid>(nullable: true),
                    DoctorCategoryId = table.Column<Guid>(nullable: true),
                    OperationId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Doctors_DoctorCategories_DoctorCategoryId",
                        column: x => x.DoctorCategoryId,
                        principalTable: "DoctorCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Doctors_Operations_OperationId",
                        column: x => x.OperationId,
                        principalTable: "Operations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OperationResults",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DatePublish = table.Column<DateTime>(nullable: false),
                    DocumentsId = table.Column<Guid>(nullable: true),
                    TestId = table.Column<Guid>(nullable: true),
                    SentTo = table.Column<string>(nullable: true),
                    DoctorsId = table.Column<Guid>(nullable: true),
                    PatienceState = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperationResults_Doctors_DoctorsId",
                        column: x => x.DoctorsId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OperationResults_Documents_DocumentsId",
                        column: x => x.DocumentsId,
                        principalTable: "Documents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OperationResults_Tests_TestId",
                        column: x => x.TestId,
                        principalTable: "Tests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "Remark" },
                values: new object[,]
                {
                    { new Guid("252161ac-17da-453e-894c-b993c0d21925"), "Admin", "Administrator" },
                    { new Guid("18b521ab-8ca5-4c7d-8110-9aabd3a445cf"), "Patient", "Patient" },
                    { new Guid("4b689146-61c9-477b-9a76-ae976ed36691"), "Assusstance", "Assusstance" },
                    { new Guid("9432d219-f4d8-4b48-adf6-66ae6a64217b"), "Doctor", "Doctor" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointements_AssutanceId",
                table: "Appointements",
                column: "AssutanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointements_PatienceId",
                table: "Appointements",
                column: "PatienceId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointements_StatusId",
                table: "Appointements",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Assurances_DocumentsId",
                table: "Assurances",
                column: "DocumentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Assutance_ContactId",
                table: "Assutance",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_ContactId",
                table: "Doctors",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_DoctorCategoryId",
                table: "Doctors",
                column: "DoctorCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_OperationId",
                table: "Doctors",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitals_ContactId",
                table: "Hospitals",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitals_HospitalCategoryId",
                table: "Hospitals",
                column: "HospitalCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_MaterialCategoryId",
                table: "Materials",
                column: "MaterialCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_MaterialStatusId",
                table: "Materials",
                column: "MaterialStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_RoomId",
                table: "Materials",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationResults_DoctorsId",
                table: "OperationResults",
                column: "DoctorsId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationResults_DocumentsId",
                table: "OperationResults",
                column: "DocumentsId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationResults_TestId",
                table: "OperationResults",
                column: "TestId");

            migrationBuilder.CreateIndex(
                name: "IX_Operations_OperationCategoryId",
                table: "Operations",
                column: "OperationCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Operations_RoomId",
                table: "Operations",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_ContactId",
                table: "Patients",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomCategoryId",
                table: "Rooms",
                column: "RoomCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TestResults_DocumentsId",
                table: "TestResults",
                column: "DocumentsId");

            migrationBuilder.CreateIndex(
                name: "IX_TestResults_TestId",
                table: "TestResults",
                column: "TestId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ContactId",
                table: "Users",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointements");

            migrationBuilder.DropTable(
                name: "Assurances");

            migrationBuilder.DropTable(
                name: "Hospitals");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "OperationResults");

            migrationBuilder.DropTable(
                name: "TestResults");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Assutance");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "AppointementStatuss");

            migrationBuilder.DropTable(
                name: "HospitalCategories");

            migrationBuilder.DropTable(
                name: "MaterialCategories");

            migrationBuilder.DropTable(
                name: "MaterialStatuses");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "DoctorCategories");

            migrationBuilder.DropTable(
                name: "Operations");

            migrationBuilder.DropTable(
                name: "OperationCategories");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "RoomCategories");
        }
    }
}
