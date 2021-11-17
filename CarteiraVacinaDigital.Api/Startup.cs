using CarteiraVacinaDigital.Model.Contracts;
using CarteiraVacinaDigital.Repository.Context;
using CarteiraVacinaDigital.Repository.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CarteiraVacinaDigital.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("config.json", optional: false, reloadOnChange: true);
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddRouting();
            
            var connectionString = Configuration.GetConnectionString("CarteiraVacinacaoDigital");
            services.AddDbContext<CarteiraVacinaDigitalContext>
                (option => option.UseLazyLoadingProxies().UseMySql
                (connectionString, m => m.MigrationsAssembly("CarteiraVacinaDigital.Repository")));

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IPacientRepository, PacientRepository>();
            services.AddScoped<IVaccineRepository, VaccineRepository>();
            services.AddScoped<ICalenderRepository, CalenderRepository>();
            services.AddScoped<IEmployeeLogRepository, EmployeeLogRepository>();
            services.AddScoped<IPacientVaccineRepository, PacientVaccineRepository>();
            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endPoints => endPoints.MapControllers());

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    //spa.UseAngularCliServer(npmScript: "start");
                    spa.UseProxyToSpaDevelopmentServer("http://localhost:4200/");
                }
            });
        }
    }
}
