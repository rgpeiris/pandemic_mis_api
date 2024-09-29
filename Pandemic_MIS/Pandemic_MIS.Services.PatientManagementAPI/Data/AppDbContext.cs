using Microsoft.EntityFrameworkCore;
using Pandemic_MIS.Services.PatientManagementAPI.Models;

namespace Pandemic_MIS.Services.PatientManagementAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<HealthcareProfessional> HealthcareProfessionals { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<LocalGovernmentInCharge> LocalGovernmentInCharge { get; set; }
        public DbSet<PandemicPatient> PandemicPatients { get; set; }
        public DbSet<PatientMedicalHistory> PatientMedicalHistories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<HealthcareProfessional>().HasData(new HealthcareProfessional
            {
                HealthcareProfessionalId = 1,
                HealthcareProfessionalName = "Prof. Anura Weerasinghe",
                MedicalSpecialty = "Physician",
                AssignedHospital = 1,
                PhoneNumber = "(+94) 11 541 0000",
                AssignedUsername = "hp_aweerasinghe",
                IsActive = true,
                CreatedBy = "ad_rpeiris",
                CreatedDate = DateTime.Now
            });

            modelBuilder.Entity<Hospital>().HasData(new Hospital
            {
                HospitalId = 1,
                HospitalName = "National Hospital of SriLanka",
                District = "Colombo",
                City = "Colombo",
                Address = "WV99+FHX, Colombo 00700",
                PhoneNumber = "(+94) 11 269 1111",             
                IsActive = true,
                CreatedBy = "ad_rpeiris",
                CreatedDate = DateTime.Now
            });

            modelBuilder.Entity<LocalGovernmentInCharge>().HasData(new LocalGovernmentInCharge
            {
                LocalGovernmentInChargeId = 1,
                LocalGovernmentInChargeName = "Prof. Thisara Gamage",
                Designation = "Physician",
                AssignedDistrict = "Colombo",
                PhoneNumber = "(+94) 11 269 1155",
                AssignedUsername = "gic_tgamage",
                IsActive = true,
                CreatedBy = "ad_rpeiris",
                CreatedDate = DateTime.Now
            });

            modelBuilder.Entity<PandemicPatient>().HasData(new PandemicPatient
            {
                PatientId = 1,
                RegistrationDate = DateTime.Now,
                ConfirmedDate = DateTime.Now,
                NICNumber = "912837882V",
                PassportNumber = null,
                PatientName = "Ashen De Silva",
                DateOfBirth = "1991-January-2",
                Age = 32,
                Gender = "Male",
                District = "Colombo",
                DSDivision = "Colombo",
                MOHArea = "Colombo",
                GramaNiladhariArea = "GramaNiladhariArea",
                Address = "Colombo",
                PhoneNumber = "0772601155",
                ForeignEntrant = false,
                CriticalMedicalInformation = null,
                OtherMedicalNotes = null,
                MedicalReportingAgency = "Medical Reporting Agency 1",
                ReportedHealthCenter = "Reported Health Center 1",
                GuardianName = "Gamini De Silva",
                GuardianNICNumber = "757237777V",
                GuardianAddress = "Colombo",
                GuardianPhoneNumber = "0772607755",
                GuardianAssignedUsername = "gp_gdesilva",
                GuardianRelationship = "Father",
                LocalGovernmentInCharge = "chp_tgamage",
                SeverityUponDiagnosis = null,
                RecommendedTreatmentType = null,
                HospitalId = null,
                WardNumber = null,
                BedNumber = null,
                HospitalAdmissionNo = null,
                DateOfHospitalization = null,
                HealthcareProfessionalInCharge = "hp_aweerasinghe",
                FirstNegativeConfirmationDate = null,
                SecondNegativeConfirmationDate = null,
                DateOfRecovery = null,
                DateOfDeath = null,
                ReleaseInfoCertifiedBy = null,
                ReleaseInfoRemarks = null,
                Status = "Registration Completed",
                CreatedDate = DateTime.Now,
                CreatedBy = "ad_rpeiris"
            });

            modelBuilder.Entity<PatientMedicalHistory>().HasData(new PatientMedicalHistory
            {
                PatientMedicalHistoryId = 1,
                PatientId = 1,
                ExaminedDate = DateTime.Now,
                ExaminedBy = "hp_aweerasinghe",
                DiagnosisSummary = "Diagnosis summary",
                Treatments = "Treatments",
                Remarks = "Remarks",
            });
        }
    }
}
