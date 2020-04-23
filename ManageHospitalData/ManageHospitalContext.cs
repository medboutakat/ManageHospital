using ManageHospitalData.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace ManageHospitalData
{
    public class ManageHospitalDBContext : DbContext, IManageHospitalDBContext
    {
        public ManageHospitalDBContext(DbContextOptions<ManageHospitalDBContext> options) : base(options)
        {

        }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Appointement> Appointements { get; set; }
        public DbSet<AppointementStatus> AppointementStatuss { get; set; }


        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorCategory> DoctorCategories { get; set; }

        public DbSet<Material> Materials { get; set; }
        public DbSet<MaterialStatus> MaterialStatuses { get; set; }
        public DbSet<MaterialCategory> MaterialCategories { get; set; }

        public DbSet<Operation> Operations { get; set; }
        public DbSet<DoctorOperation> DoctorOperations { get; set; }
        public DbSet<OperationResult> OperationResults { get; set; }
        public DbSet<OperationCategory> OperationCategories { get; set; }

        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<HospitalCategory> HospitalCategories { get; set; }

        public DbSet<Test> Tests { get; set; }
        public DbSet<TestResult> TestResults { get; set; }

        public DbSet<Documents> Documents { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomCategory> RoomCategories { get; set; }

        public DbSet<Ansurance> Assurances { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public DbSet<City> Cities { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }

        public DbSet<Settings> Settings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ManageHospitalDBContext).Assembly);

            modelBuilder.Entity<Role>().HasData(
                new Role { Id = StaticObject.AdminId, Name = "Admin", Remark = "Administrator" }
            );

            modelBuilder.Entity<Role>().HasData(
                          new Role { Id = Guid.NewGuid(), Name = "Patient", Remark = "Patient" }
            );

            modelBuilder.Entity<Role>().HasData(
               new Role { Id = Guid.NewGuid(), Name = "Assusstance", Remark = "Assusstance" }
            );

            modelBuilder.Entity<Role>().HasData(
            new Role { Id = Guid.NewGuid(), Name = "Doctor", Remark = "Doctor" }
            );


        }
    }
}
