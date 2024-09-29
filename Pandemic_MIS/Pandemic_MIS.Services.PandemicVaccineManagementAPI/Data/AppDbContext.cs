using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Pandemic_MIS.Services.PandemicVaccineManagementAPI.Models;
using System.Net;
using System.Numerics;
using System.Reflection;

namespace Pandemic_MIS.Services.PandemicVaccineManagementAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<PandemicVaccination> PandemicVaccinations { get; set; }
        public DbSet<PandemicVaccine> PandemicVaccines { get; set; }
        public DbSet<ScheduledVaccinationCentre> ScheduledVaccinationCentres { get; set; }
        public DbSet<VaccinationCentre> VaccinationCentres { get; set; }
        public DbSet<VaccineAppointment> VaccineAppointments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PandemicVaccine>().HasData(new PandemicVaccine
            {
                VaccineId = 1,
                VaccineName = "Sinopharm",
                Dose = "1st Dose",
                NextDose = 3,
                CreatedBy = "hp_anushka",
                CreatedDate = DateTime.Now,
            });

            modelBuilder.Entity<PandemicVaccine>().HasData(new PandemicVaccine
            {
                VaccineId = 2,
                VaccineName = "Pfizer",
                Dose = "1st Dose",
                NextDose = 3,
                CreatedBy = "hp_anushka",
                CreatedDate = DateTime.Now,
            });

            modelBuilder.Entity<VaccinationCentre>().HasData(new VaccinationCentre
            {
                VaccinationCentreId = 1,
                CentreName = "MOH Office Piliyandala",
                District = "Colombo",
                City = "Piliyandala",
                Address = "RW99+J9X, Makuluduwa Rd, Piliyandala",
                PhoneNumber = "0112 708 553",
                Latitude = 6.801803,
                Longitude = 79.922684,
                IsActive = true,
                CreatedBy = "hp_anushka",
                CreatedDate = DateTime.Now,
            });

            modelBuilder.Entity<ScheduledVaccinationCentre>().HasData(new ScheduledVaccinationCentre
            {
                ScheduledVaccinationCentreId = 1,
                VaccinationCentreId = 1,
                DateScheduled = DateTime.Now,
                TimeScheduled = "Forenoon",
                AvailableCapacity = 500,
                CreatedBy = "hp_anushka",
                CreatedDate = DateTime.Now,
            });

            modelBuilder.Entity<VaccineAppointment>().HasData(new VaccineAppointment
            {
                VaccineAppointmentId = 1,
                Name = "Janvi Fernando",
                NICNumber = "917283783V",
                Age = 32,
                BirthYear = 1991,
                Gender = "Female",
                Address = "538/7 Aluthmawatha Road, Colombo",
                PhoneNumber = "772523191",
                IsRequiredReports = false,
                VaccinationCentreId = 1,
                DateScheduled = DateTime.Now,
                TimeScheduled = "Forenoon",
                Status = "SCHEDULED",
                CreatedBy = "au_uthpala", 
                CreatedDate = DateTime.Now,
            });

            modelBuilder.Entity<PandemicVaccination>().HasData(new PandemicVaccination
            {
                PandemicVaccinationId = 1,
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
                VaccineName = "Sinopharm",
                VaccineDose = "1st Dose",
                VaccinationCentreId = 1,
                DateOfVaccination = DateTime.Now,
                NextAppointmentDate = DateTime.Now.AddDays(90),
                CreatedBy = "hp_anushka",
                CreatedDate = DateTime.Now,
            });
        }
    }
}
