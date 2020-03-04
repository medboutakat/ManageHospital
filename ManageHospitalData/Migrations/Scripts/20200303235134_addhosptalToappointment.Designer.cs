﻿// <auto-generated />
using System;
using ManageHospitalData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ManageHospitalData.Migrations.Scripts
{
    [DbContext(typeof(ManageHospitalDBContext))]
    [Migration("20200303235134_addhosptalToappointment")]
    partial class addhosptalToappointment
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ManageHospitalData.Entities.Ansurance", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DocumentsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DocumentsId");

                    b.ToTable("Assurances");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.Appointement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Assurance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("AssutanceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CallTimeStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("HospitalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("IdentityNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PatienceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ReservationTimeStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("StatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AssutanceId");

                    b.HasIndex("HospitalId");

                    b.HasIndex("PatienceId");

                    b.HasIndex("StatusId");

                    b.ToTable("Appointements");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.AppointementStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppointementStatuss");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.Assutance", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Assurance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ContactId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexe")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.ToTable("Assutance");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RegionId")
                        .HasColumnType("int");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adress1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adress2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Other")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhatsApp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.Doctor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ContactId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DoctorCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("OperationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Sexe")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.HasIndex("DoctorCategoryId");

                    b.HasIndex("OperationId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.DoctorCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DoctorCategories");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.Documents", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("File")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.Hospital", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ContactId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CountryHealthId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("History")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("HospitalCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.HasIndex("HospitalCategoryId");

                    b.ToTable("Hospitals");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.HospitalCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HospitalCategories");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.Material", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MaterialCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MaterialStatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RoomId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("MaterialCategoryId");

                    b.HasIndex("MaterialStatusId");

                    b.HasIndex("RoomId");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.MaterialCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MaterialCategories");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.MaterialStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MaterialStatuses");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.Operation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("OperationCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RoomId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TotalStayNight")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OperationCategoryId");

                    b.HasIndex("RoomId");

                    b.ToTable("Operations");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.OperationCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OperationCategories");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.OperationResult", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DatePublish")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DoctorsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DocumentsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PatienceState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SentTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TestId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DoctorsId");

                    b.HasIndex("DocumentsId");

                    b.HasIndex("TestId");

                    b.ToTable("OperationResults");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("252161ac-17da-453e-894c-b993c0d21925"),
                            Name = "Admin",
                            Remark = "Administrator"
                        },
                        new
                        {
                            Id = new Guid("6ca12e73-c65c-428a-a4c5-ce1d9ef2f79f"),
                            Name = "Patient",
                            Remark = "Patient"
                        },
                        new
                        {
                            Id = new Guid("c70f31f2-5791-4729-9d2a-f2a3db47b6f1"),
                            Name = "Assusstance",
                            Remark = "Assusstance"
                        },
                        new
                        {
                            Id = new Guid("7a23f6a1-7a76-410b-b2c7-cf6f90419e29"),
                            Name = "Doctor",
                            Remark = "Doctor"
                        });
                });

            modelBuilder.Entity("ManageHospitalData.Entities.Room", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RoomCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomCategoryId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.RoomCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoomCategories");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.Test", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AnalyzeResult")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Decription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.TestResult", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DatePublish")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DocumentsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SentTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TestId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DocumentsId");

                    b.HasIndex("TestId");

                    b.ToTable("TestResults");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ContactId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Sexe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.Patient", b =>
                {
                    b.HasBaseType("ManageHospitalData.Entities.User");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Assurance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Patient");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.Ansurance", b =>
                {
                    b.HasOne("ManageHospitalData.Entities.Documents", "Documents")
                        .WithMany()
                        .HasForeignKey("DocumentsId");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.Appointement", b =>
                {
                    b.HasOne("ManageHospitalData.Entities.Assutance", "Assutance")
                        .WithMany()
                        .HasForeignKey("AssutanceId");

                    b.HasOne("ManageHospitalData.Entities.Hospital", "Hospital")
                        .WithMany()
                        .HasForeignKey("HospitalId");

                    b.HasOne("ManageHospitalData.Entities.Patient", "Patience")
                        .WithMany()
                        .HasForeignKey("PatienceId");

                    b.HasOne("ManageHospitalData.Entities.AppointementStatus", "Status")
                        .WithMany("Appointements")
                        .HasForeignKey("StatusId");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.Assutance", b =>
                {
                    b.HasOne("ManageHospitalData.Entities.Contact", "contact")
                        .WithMany()
                        .HasForeignKey("ContactId");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.City", b =>
                {
                    b.HasOne("ManageHospitalData.Entities.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.Contact", b =>
                {
                    b.HasOne("ManageHospitalData.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.Doctor", b =>
                {
                    b.HasOne("ManageHospitalData.Entities.Contact", "contact")
                        .WithMany()
                        .HasForeignKey("ContactId");

                    b.HasOne("ManageHospitalData.Entities.DoctorCategory", "DoctorCategory")
                        .WithMany("Doctors")
                        .HasForeignKey("DoctorCategoryId");

                    b.HasOne("ManageHospitalData.Entities.Operation", null)
                        .WithMany("Doctors")
                        .HasForeignKey("OperationId");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.Hospital", b =>
                {
                    b.HasOne("ManageHospitalData.Entities.Contact", "Contact")
                        .WithMany()
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ManageHospitalData.Entities.HospitalCategory", "HospitalCategory")
                        .WithMany("Hospitals")
                        .HasForeignKey("HospitalCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ManageHospitalData.Entities.Material", b =>
                {
                    b.HasOne("ManageHospitalData.Entities.MaterialCategory", "MaterialCategory")
                        .WithMany("Hospitals")
                        .HasForeignKey("MaterialCategoryId");

                    b.HasOne("ManageHospitalData.Entities.MaterialStatus", "MaterialStatus")
                        .WithMany("Materials")
                        .HasForeignKey("MaterialStatusId");

                    b.HasOne("ManageHospitalData.Entities.Room", null)
                        .WithMany("Materials")
                        .HasForeignKey("RoomId");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.Operation", b =>
                {
                    b.HasOne("ManageHospitalData.Entities.OperationCategory", "OperationCategory")
                        .WithMany("Operations")
                        .HasForeignKey("OperationCategoryId");

                    b.HasOne("ManageHospitalData.Entities.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.OperationResult", b =>
                {
                    b.HasOne("ManageHospitalData.Entities.Doctor", "Doctors")
                        .WithMany()
                        .HasForeignKey("DoctorsId");

                    b.HasOne("ManageHospitalData.Entities.Documents", "Documents")
                        .WithMany()
                        .HasForeignKey("DocumentsId");

                    b.HasOne("ManageHospitalData.Entities.Test", "Test")
                        .WithMany()
                        .HasForeignKey("TestId");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.Room", b =>
                {
                    b.HasOne("ManageHospitalData.Entities.RoomCategory", "RoomCategory")
                        .WithMany()
                        .HasForeignKey("RoomCategoryId");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.TestResult", b =>
                {
                    b.HasOne("ManageHospitalData.Entities.Documents", "Documents")
                        .WithMany()
                        .HasForeignKey("DocumentsId");

                    b.HasOne("ManageHospitalData.Entities.Test", "Test")
                        .WithMany()
                        .HasForeignKey("TestId");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.User", b =>
                {
                    b.HasOne("ManageHospitalData.Entities.Contact", "contact")
                        .WithMany()
                        .HasForeignKey("ContactId");

                    b.HasOne("ManageHospitalData.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
