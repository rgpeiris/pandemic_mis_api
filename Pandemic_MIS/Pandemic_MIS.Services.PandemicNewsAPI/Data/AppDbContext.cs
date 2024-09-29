using Microsoft.EntityFrameworkCore;
using Pandemic_MIS.Services.PandemicNewsAPI.Models;

namespace Pandemic_MIS.Services.PandemicNewsAPI.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<PandemicNews> PandemicNews { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PandemicNews>().HasData(new PandemicNews
            {
                NewsId = 1,
                Title = "Let's Stay Safe",
                Description = "Let's Stay Safe",
                Priority = 1,
                IsActive = true,
                CreatedBy = "ad_rpeiris",
                CreatedDate = DateTime.Now,
            });

            modelBuilder.Entity<PandemicNews>().HasData(new PandemicNews
            {
                NewsId = 2,
                Title = "Know about COVID-19 Vaccine",
                Description = "Know about COVID-19 Vaccine",
                Priority = 2,
                IsActive = true,
                CreatedBy = "ad_rpeiris",
                CreatedDate = DateTime.Now,
            });
        }
    }
}
