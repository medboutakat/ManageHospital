using System.Text;  
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http; 
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection; 
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models; 
using ManageHospitalData;

namespace WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContext<ManageHospitalDBContext>(options =>
             options.UseSqlServer(Configuration["Data:ConnectionStrings:DefaultConnection"]
            ));
             
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder//.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .WithOrigins("http://localhost:4200")
                    .AllowCredentials());
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "GM-Soft Service", Version = "v1", Description = "Api" });
            });

            services.AddLogging(config =>
            {
                config.AddDebug();
                config.AddConsole();
                //etc
            });

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddSignalR();


            string securityKey = "this_is_our_supper_long_security_key_for_token_valIdation_project_2018_09_07$smesk.in";
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));


            //services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            //    .AddJwtBearer(options =>
            //    {
                    //options.TokenValIdationParameters = new TokenValIdationParameters
                    //{
                    //    //what to valIdate
                    //    ValIdateIssuer = false,
                    //    ValIdateAudience = false,
                    //    ValIdateIssuerSigningKey = true,
                    //    //setup valIdate data
                    //    // ValIdIssuer = "smesk.in",
                    //    // ValIdAudience = "readers",
                    //    IssuerSigningKey = symmetricSecurityKey
                    //};
                //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            app.UseDeveloperExceptionPage();

            
            app.UseHttpsRedirection();

            app.UseCors("CorsPolicy");

            app.UseRouting();
             
            app.UseAuthorization();

            // Enable mIddleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();
            // Enable mIddleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


        }
    }
}
