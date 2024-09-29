namespace Pandemic_MIS.Services.PatientManagementAPI.Models.Dto
{
    public class HealthcareProfessionalDto
    {
        public int HealthcareProfessionalId { get; set; }
        public string HealthcareProfessionalName { get; set; }
        public string MedicalSpecialty { get; set; }
        public int AssignedHospital { get; set; }
        public string PhoneNumber { get; set; }
        public string AssignedUsername { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
