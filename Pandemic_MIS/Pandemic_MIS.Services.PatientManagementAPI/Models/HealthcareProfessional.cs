using System.ComponentModel.DataAnnotations;

namespace Pandemic_MIS.Services.PatientManagementAPI.Models
{
    public class HealthcareProfessional
    {
        [Key]
        public int HealthcareProfessionalId { get; set; }
        [Required]
        public string HealthcareProfessionalName { get; set; }
        [Required]
        public string MedicalSpecialty { get; set; }
        [Required]
        public int AssignedHospital { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string AssignedUsername { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
