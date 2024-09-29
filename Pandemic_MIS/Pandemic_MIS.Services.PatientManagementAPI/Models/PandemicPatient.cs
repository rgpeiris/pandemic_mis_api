using System.ComponentModel.DataAnnotations;

namespace Pandemic_MIS.Services.PatientManagementAPI.Models
{
    public class PandemicPatient
    {
        [Key]
        public int PatientId { get; set; }
        [Required]
        public DateTime RegistrationDate { get; set; }
        [Required]
        public DateTime ConfirmedDate { get; set; }
        public string NICNumber { get; set; }
        public string? PassportNumber { get; set; }
        [Required]
        public string PatientName { get; set; }
        [Required]
        public string DateOfBirth { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string District { get; set; }
        [Required]
        public string DSDivision { get; set; }
        [Required]
        public string MOHArea { get; set; }
        [Required]
        public string GramaNiladhariArea { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public bool ForeignEntrant { get; set; }
        public string? CriticalMedicalInformation { get; set; }
        public string? OtherMedicalNotes { get; set; }
        [Required]
        public string MedicalReportingAgency { get; set; }
        [Required]
        public string ReportedHealthCenter { get; set; }
        [Required]
        public string GuardianName { get; set; }
        [Required]
        public string GuardianNICNumber { get; set; }
        [Required]
        public string GuardianAddress { get; set; }
        [Required]
        public string GuardianPhoneNumber { get; set; }
        public string GuardianAssignedUsername { get; set; }
        [Required]
        public string GuardianRelationship { get; set; }
        [Required]
        public string LocalGovernmentInCharge { get; set; }
        public string? SeverityUponDiagnosis { get; set; }
        public string? RecommendedTreatmentType { get; set; }
        public int? HospitalId { get; set; }
        public string? WardNumber { get; set; }
        public string? BedNumber { get; set; }
        public string? HospitalAdmissionNo { get; set; }
        public DateTime? DateOfHospitalization { get; set; }
        [Required]
        public string HealthcareProfessionalInCharge { get; set; }
        public DateTime? FirstNegativeConfirmationDate { get; set; }
        public DateTime? SecondNegativeConfirmationDate { get; set; }
        public DateTime? DateOfRecovery { get; set; }
        public DateTime? DateOfDeath { get; set; }
        public string? ReleaseInfoCertifiedBy { get; set; }
        public string? ReleaseInfoRemarks { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public string CreatedBy { get; set; }
    }
}
