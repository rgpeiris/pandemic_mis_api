using System.ComponentModel.DataAnnotations;

namespace Pandemic_MIS.Services.PatientManagementAPI.Models
{
    public class Hospital
    {
        [Key]
        public int HospitalId { get; set; }
        [Required]
        public string HospitalName { get; set; }
        [Required]
        public string District { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
