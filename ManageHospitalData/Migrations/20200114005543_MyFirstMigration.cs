using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ManageHospitalData.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppointementStatuss",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    table.PrimaryKey("PK_Assutance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assutance_Contacts_contactId",
                        column: x => x.contactId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Patiences",
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
                    table.PrimaryKey("PK_Patiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patiences_Contacts_contactId",
                        column: x => x.contactId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Assurances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Assurance = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: true),
                    contactId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hospitals_HospitalCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "HospitalCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Hospitals_Contacts_contactId",
                        column: x => x.contactId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    RoomNumber = table.Column<int>(nullable: false),
                    RoomCategoryId = table.Column<int>(nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentityNo = table.Column<string>(nullable: true),
                    Assurance = table.Column<string>(nullable: true),
                    CallTimeStamp = table.Column<string>(nullable: true),
                    ReservationTimeStamp = table.Column<string>(nullable: true),
                    StatusId = table.Column<int>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    PatienceId = table.Column<int>(nullable: true),
                    AssutanceId = table.Column<int>(nullable: true)
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
                        name: "FK_Appointements_Patiences_PatienceId",
                        column: x => x.PatienceId,
                        principalTable: "Patiences",
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    MaterialStatusId = table.Column<int>(nullable: true),
                    MaterialCategoryId = table.Column<int>(nullable: true),
                    RoomId = table.Column<int>(nullable: true)
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
                    OperationCategoryId = table.Column<int>(nullable: true),
                    RoomId = table.Column<int>(nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Sexe = table.Column<string>(nullable: true),
                    contactId = table.Column<int>(nullable: true),
                    DoctorCategoryId = table.Column<int>(nullable: true),
                    OperationId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
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
                    table.ForeignKey(
                        name: "FK_Doctors_Contacts_contactId",
                        column: x => x.contactId,
                        principalTable: "Contacts",
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
                    DoctorsId = table.Column<int>(nullable: true),
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
                name: "IX_Assutance_contactId",
                table: "Assutance",
                column: "contactId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_DoctorCategoryId",
                table: "Doctors",
                column: "DoctorCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_OperationId",
                table: "Doctors",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_contactId",
                table: "Doctors",
                column: "contactId");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitals_CategoryId",
                table: "Hospitals",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitals_contactId",
                table: "Hospitals",
                column: "contactId");

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
                name: "IX_Patiences_contactId",
                table: "Patiences",
                column: "contactId");

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
                name: "Assutance");

            migrationBuilder.DropTable(
                name: "Patiences");

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
                name: "DoctorCategories");

            migrationBuilder.DropTable(
                name: "Operations");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "OperationCategories");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "RoomCategories");
        }
    }
}
