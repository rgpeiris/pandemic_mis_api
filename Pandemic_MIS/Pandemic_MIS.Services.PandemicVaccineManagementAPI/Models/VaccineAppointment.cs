using System.ComponentModel.DataAnnotations;

namespace Pandemic_MIS.Services.PandemicVaccineManagementAPI.Models
{
    public class VaccineAppointment
    {
        [Key]
        public int VaccineAppointmentId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string NICNumber { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int BirthYear { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public bool IsRequiredReports { get; set; }
        [Required]
        public int VaccinationCentreId { get; set; }
        [Required]
        public DateTime DateScheduled { get; set; }
        [Required]
        public string TimeScheduled { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
