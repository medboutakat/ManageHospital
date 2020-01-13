using ManageHospitalData.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace ManageHospitalData
{
    internal interface IManageHospitalDBContext
    {

        public DbSet<Patience> Patiences { get; set; }

        public DbSet<Appointement> Appointements { get; set; }
        public DbSet<AppointementStatus> Statuss { get; set; }


        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorsCategory> DoctorCategories { get; set; }

        public DbSet<Material> Materials { get; set; }
        public DbSet<MaterialStatus> MaterialStatuses { get; set; }
        public DbSet<MaterialCategory> MaterialCategories { get; set; }

        public DbSet<Operation> Operations { get; set; }
        public DbSet<OperationResult> OperationResults { get; set; }
        public DbSet<OperationCategory> OperationCategories { get; set; }

        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<HospitalCategory> HospitalCategories { get; set; }

        public DbSet<Test> Tests { get; set; }
        public DbSet<TestResult> TestResults { get; set; }

        public DbSet<Documents> Documents { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Room> Rooms { get; set; }


        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}