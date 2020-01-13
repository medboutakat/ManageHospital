﻿// <auto-generated />
using System;
using ManageHospitalData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ManageHospitalData.Migrations
{
    [DbContext(typeof(ManageHospitalDBContext))]
    partial class ManageHospitalDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ManageHospitalData.Entities.Appointement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Assurance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CallTimeStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReservationTimeStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.ToTable("Appointements");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.AppointementStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Statuss");
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

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

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

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.Doctor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("DoctorsCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("OperationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Sexe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("contactId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DoctorsCategoryId");

                    b.HasIndex("OperationId");

                    b.HasIndex("contactId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.DoctorsCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Assurance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<Guid?>("contactId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("contactId");

                    b.ToTable("Hospitals");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.HospitalCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HospitalCategories");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MaterialCategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("MaterialStatusId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaterialCategoryId");

                    b.HasIndex("MaterialStatusId");

                    b.HasIndex("RoomId");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.MaterialCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MaterialCategories");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.MaterialStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<int?>("OperationCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.Property<string>("TotalStayNight")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OperationCategoryId");

                    b.HasIndex("RoomId");

                    b.ToTable("Operations");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.OperationCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

            modelBuilder.Entity("ManageHospitalData.Entities.Patience", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Assurance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("contactId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("contactId");

                    b.ToTable("Patiences");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoomCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomCategoryId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.RoomCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoomCategory");
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

            modelBuilder.Entity("ManageHospitalData.Entities.Appointement", b =>
                {
                    b.HasOne("ManageHospitalData.Entities.AppointementStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.Doctor", b =>
                {
                    b.HasOne("ManageHospitalData.Entities.DoctorsCategory", "DoctorsCategory")
                        .WithMany()
                        .HasForeignKey("DoctorsCategoryId");

                    b.HasOne("ManageHospitalData.Entities.Operation", null)
                        .WithMany("Doctors")
                        .HasForeignKey("OperationId");

                    b.HasOne("ManageHospitalData.Entities.Contact", "contact")
                        .WithMany()
                        .HasForeignKey("contactId");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.Hospital", b =>
                {
                    b.HasOne("ManageHospitalData.Entities.HospitalCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("ManageHospitalData.Entities.Contact", "contact")
                        .WithMany()
                        .HasForeignKey("contactId");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.Material", b =>
                {
                    b.HasOne("ManageHospitalData.Entities.MaterialCategory", "MaterialCategory")
                        .WithMany()
                        .HasForeignKey("MaterialCategoryId");

                    b.HasOne("ManageHospitalData.Entities.MaterialStatus", "MaterialStatus")
                        .WithMany()
                        .HasForeignKey("MaterialStatusId");

                    b.HasOne("ManageHospitalData.Entities.Room", null)
                        .WithMany("Materials")
                        .HasForeignKey("RoomId");
                });

            modelBuilder.Entity("ManageHospitalData.Entities.Operation", b =>
                {
                    b.HasOne("ManageHospitalData.Entities.OperationCategory", "OperationCategory")
                        .WithMany()
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

            modelBuilder.Entity("ManageHospitalData.Entities.Patience", b =>
                {
                    b.HasOne("ManageHospitalData.Entities.Contact", "contact")
                        .WithMany()
                        .HasForeignKey("contactId");
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
#pragma warning restore 612, 618
        }
    }
}
