using System.ComponentModel.DataAnnotations;

namespace Pandemic_MIS.Services.PandemicVaccineManagementAPI.Models
{
    public class PandemicVaccine
    {
        [Key]
        public int VaccineId { get; set; }
        [Required]
        public string VaccineName { get; set; }
        [Required]
        public string Dose { get; set; }
        [Required]
        public int NextDose { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
