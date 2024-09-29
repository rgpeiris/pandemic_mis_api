using Microsoft.EntityFrameworkCore;
using Pandemic_MIS.Services.OrganizationManagementAPI.Models;
using System.Net;
using System.Numerics;

namespace Pandemic_MIS.Services.OrganizationManagementAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<PandemicContact> PandemicContacts { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Organization>().HasData(new Organization
            {
                OrganizationId = 1,
                OrganizationName = "Organization 1",
                OrganizationType = "Organization Type 1",
                ContactName = "Test 1",
                Email = "Test1@gmail.com",
                PhoneNumber = "0112637483",
                Address = "Test Address 1",
                IsActive = true,
                CreatedBy = "ad_rpeiris",
                CreatedDate = DateTime.Now,
            });

            modelBuilder.Entity<Organization>().HasData(new Organization
            {
                OrganizationId = 2,
                OrganizationName = "Organization 2",
                OrganizationType = "Organization Type 2",
                ContactName = "Test 2",
                Email = "Test2@gmail.com",
                PhoneNumber = "0112637487",
                Address = "Test Address 2",
                IsActive = true,
                CreatedBy = "ad_rpeiris",
                CreatedDate = DateTime.Now,
            });

            modelBuilder.Entity<PandemicContact>().HasData(new PandemicContact
            {
                PandemicContactId = 1,
                NicNumber = "934455522V",
                Name = "Nisha Perera",
                Address = "Colombo",
                PhoneNumber = "0778364772",
                CheckInTime = DateTime.Now,
                CheckOutTime = DateTime.Now,
                OrganizationId = 1,    
                CreatedBy = "ad_rpeiris",
                CreatedDate = DateTime.Now,
            });

            modelBuilder.Entity<Complaint>().HasData(new Complaint
            {
                ComplaintId = 1,
                ComplaintTitle = "Complaint 1",
                ComplaintDescription = "Complaint 1 Description",
                CreatedBy = "au_nipunsala",
                CreatedDate = DateTime.Now,
            });
        }
    }
}
