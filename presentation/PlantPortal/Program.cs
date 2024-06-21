using Microsoft.EntityFrameworkCore;
using Plant;
using Plant.PostgreSQL;
using Device;
using Device.PostgreSQL;
using PlantPortal.DbConnect;
using Microsoft.AspNetCore.Identity;
using PlantPortal.Models;

namespace PlantPortal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<ApplicationDbContext>(option =>
            {
                var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
                option.UseNpgsql(connectionString);
            });

            builder.Services.
                AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false).
                AddRoles<IdentityRole>().
                AddEntityFrameworkStores<ApplicationDbContext>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddSingleton<IPlantRepository, PlantRepository>();
            builder.Services.AddSingleton<PlantService>();            
            builder.Services.AddSingleton<IDiseaseRepository, DiseaseRepository>();
            builder.Services.AddSingleton<DiseaseService>();            
            builder.Services.AddSingleton<IHumidityRepository, HumidityRepository>();
            builder.Services.AddSingleton<HumidityService>();
            builder.Services.AddSingleton<ITemperatureRepository, TemperatureRepository>();
            builder.Services.AddSingleton<TemperatureService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            //app.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller=Home}/{action=Index}/{id?}");

            app.UseEndpoints(endpoints => {
                endpoints.MapRazorPages();
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllers();
            });

            //app.MapRazorPages();

            app.Run();
        }
    }
}
