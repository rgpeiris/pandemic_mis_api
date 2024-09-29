namespace Pandemic_MIS.Services.PatientManagementAPI.Models.Dto
{
    public class PandemicPatientDto
    {
        public int PatientId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime ConfirmedDate { get; set; }
        public string NICNumber { get; set; }
        public string? PassportNumber { get; set; }
        public string PatientName { get; set; }
        public string DateOfBirth { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string District { get; set; }
        public string DSDivision { get; set; }
        public string MOHArea { get; set; }
        public string GramaNiladhariArea { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool ForeignEntrant { get; set; }
        public string? CriticalMedicalInformation { get; set; }
        public string? OtherMedicalNotes { get; set; }
        public string MedicalReportingAgency { get; set; }
        public string ReportedHealthCenter { get; set; }
        public string GuardianName { get; set; }
        public string GuardianNICNumber { get; set; }
        public string GuardianAddress { get; set; }
        public string GuardianPhoneNumber { get; set; }
        public string GuardianAssignedUsername { get; set; }
        public string GuardianRelationship { get; set; }
        public string LocalGovernmentInCharge { get; set; }
        public string? SeverityUponDiagnosis { get; set; }
        public string? RecommendedTreatmentType { get; set; }
        public int? HospitalId { get; set; }
        public string? WardNumber { get; set; }
        public string? BedNumber { get; set; }
        public string? HospitalAdmissionNo { get; set; }
        public DateTime? DateOfHospitalization { get; set; }
        public string HealthcareProfessionalInCharge { get; set; }
        public DateTime? FirstNegativeConfirmationDate { get; set; }
        public DateTime? SecondNegativeConfirmationDate { get; set; }
        public DateTime? DateOfRecovery { get; set; }
        public DateTime? DateOfDeath { get; set; }
        public string? ReleaseInfoCertifiedBy { get; set; }
        public string? ReleaseInfoRemarks { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
