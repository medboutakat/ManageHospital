 using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection; 

namespace ManageHospitalData
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ManageHospitalDBContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("SysManageDatabase")));

            services.AddScoped<IManageHospitalDBContext>(provider => provider.GetService<ManageHospitalDBContext>());

            return services;
        }
    }
}
