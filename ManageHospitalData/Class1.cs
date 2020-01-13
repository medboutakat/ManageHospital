using ManageHospitalData.Entities;
using Microsoft.EntityFrameworkCore; 

namespace ManageHospitalData
{
    public class ManageHospitalContext : DbContext
    {
        public DbSet<Patience> Patiences { get; set; }
        public DbSet<Appointement> Appointements { get; set; }
        public DbSet<AppointementStatus> Statuss { get; set; }
        public DbSet<HospitalCategory> Categorys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ManageHospitalContext).Assembly);
        }
    }
}
