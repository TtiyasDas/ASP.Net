using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TimeSheet.DAL.Data;
using TimeSheet.DAL.Repository.AdminRepo;
using TimeSheet.DAL.Repository.EmployeeRepo;
using TimeSheet.DAL.Repository.ManagerRepo;
using TimeSheet.BAL.Services;


namespace TimeSheetApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Th is method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionStr = Configuration.GetConnectionString("SqlConnection");
            services.AddDbContext<TimeSheetDbContext>(options => options.UseSqlServer(connectionStr));
            services.AddControllersWithViews();
            services.AddTransient<IAdminRepository, AdminRepository>();
            services.AddTransient<AdminServices, AdminServices>();

            services.AddTransient<IManagerRepository, ManagerRepository>();
            services.AddTransient<ManagerServices, ManagerServices>();

            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<EmployeeServices, EmployeeServices>();
        } 

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
 