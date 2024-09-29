using System.ComponentModel.DataAnnotations;

namespace Pandemic_MIS.Services.PatientManagementAPI.Models
{
    public class LocalGovernmentInCharge
    {
        [Key]
        public int LocalGovernmentInChargeId { get; set; }
        [Required]
        public string LocalGovernmentInChargeName { get; set; }
        [Required]
        public string Designation { get; set; }
        [Required]
        public string AssignedDistrict { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string AssignedUsername { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
