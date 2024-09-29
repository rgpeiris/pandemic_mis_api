using System.ComponentModel.DataAnnotations;

namespace Pandemic_MIS.Services.PandemicVaccineManagementAPI.Models
{
    public class ScheduledVaccinationCentre
    {
        [Key]
        public int ScheduledVaccinationCentreId { get; set; }
        [Required]
        public int VaccinationCentreId { get; set; }
        [Required]
        public DateTime DateScheduled { get; set; }
        [Required]
        public string TimeScheduled { get; set; }
        [Required]
        public int AvailableCapacity { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
