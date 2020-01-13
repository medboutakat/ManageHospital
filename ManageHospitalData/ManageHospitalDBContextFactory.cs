using Microsoft.EntityFrameworkCore;

namespace ManageHospitalData
{
    public class ManageHospitalDBContextFactory : DesignTimeDbContextFactoryBase<ManageHospitalDBContext>
    {
        protected override ManageHospitalDBContext CreateNewInstance(DbContextOptions<ManageHospitalDBContext> options)
        {
            return new ManageHospitalDBContext(options);
        }
    }
}
