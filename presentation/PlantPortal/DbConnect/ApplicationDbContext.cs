using Device;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Plant;
using PlantPortal.Models;

namespace PlantPortal.DbConnect
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Temperature> Temperature { get; set; }
        public DbSet<Humidity> Humidity { get; set; }
        public DbSet<Disease> Disease { get; set; }
        public DbSet<Plant.Plant> Plant { get; set; }
        public DbSet<Settings> Settings { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var admin = new IdentityRole("admin");
            admin.NormalizedName = "admin";
            
            var user = new IdentityRole("user");
            user.NormalizedName = "user";

            builder.Entity<IdentityRole>().HasData(admin, user);
        }
    }
}
