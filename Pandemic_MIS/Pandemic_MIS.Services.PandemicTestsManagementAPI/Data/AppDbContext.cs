using Microsoft.EntityFrameworkCore;
using Pandemic_MIS.Services.PandemicTestsManagementAPI.Models;
using System.Net.NetworkInformation;

namespace Pandemic_MIS.Services.PandemicTestsManagementAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<PandemicTest> PandemicTests { get; set; }
        public DbSet<PandemicTestResult> PandemicTestResults { get; set; }
        public DbSet<ScheduledTestCentre> ScheduledTestCentres { get; set; }
        public DbSet<TestCentre> TestCentres { get; set; }
        public DbSet<TestsAppointment> TestsAppointments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PandemicTest>().HasData(new PandemicTest
            {
                PandemicTestId = 1,
                TestType = "Molecular (PCR)",
                Description = "Detects genetic material of a virus.",
                CreatedBy = "hp_anushka",
                CreatedDate = DateTime.Now,
            });

            modelBuilder.Entity<PandemicTest>().HasData(new PandemicTest
            {
                PandemicTestId = 2,
                TestType = "Antigen",
                Description = "Detects proteins found on a virus.",
                CreatedBy = "hp_anushka",
                CreatedDate = DateTime.Now,
            });

            modelBuilder.Entity<TestCentre>().HasData(new TestCentre
            {
                TestCentreId = 1,
                CentreName = "MOH Office Piliyandala",
                District = "Colombo",
                City = "Piliyandala",
                Address = "RW99+J9X, Makuluduwa Rd, Piliyandala",
                PhoneNumber = "0112708553",
                Latitude = 6.801803,
                Longitude = 79.922684,
                IsActive = true,
                CreatedBy = "hp_anushka",
                CreatedDate = DateTime.Now,
            });

            modelBuilder.Entity<ScheduledTestCentre>().HasData(new ScheduledTestCentre
            {
                ScheduledTestCentreId = 1,
                TestCentreId = 1,
                DateScheduled = DateTime.Now,
                TimeScheduled = "Forenoon",
                AvailableCapacity = 300,
                CreatedBy = "hp_anushka",
                CreatedDate = DateTime.Now,
            });

            modelBuilder.Entity<TestsAppointment>().HasData(new TestsAppointment
            {
                TestsAppointmentId = 1,
                Name = "Janvi Fernando",
                NICNumber = "917283783V",
                Age = 32,
                Gender = "Female",
                Address = "538/7 Aluthmawatha Road, Colombo",
                PhoneNumber = "772523191",
                TestCentreId = 1,
                DateScheduled = DateTime.Now,
                TimeScheduled = "Forenoon",
                Status = "SCHEDULED",
                CreatedBy = "au_uthpala",
                CreatedDate = DateTime.Now,
            });

            modelBuilder.Entity<PandemicTestResult>().HasData(new PandemicTestResult
            {
                PandemicTestResultId = 1,
                Name = "Janvi Fernando",
                NICNumber = "917283783V",
                Age = 32,
                Gender = "Female",
                Address = "538/7 Aluthmawatha Road, Piliyandala",
                PhoneNumber = "772523191",
                District = "Colombo",
                MOHArea = "MOH Office Piliyandala",
                GramaNiladhariArea = "Grama Niladhari Area Piliyandala",
                SerialNumber = 1,
                TestCentreId = 1,
                DateOfPandemicTest = DateTime.Now,
                TestingType = "Molecular (PCR)",
                TestResult = "Positive",
                TestResultSummary = "Positive",
                Status = "ISOLATION",
                CreatedBy = "hp_anushka",
                CreatedDate = DateTime.Now,
            });
        }
    }
}
