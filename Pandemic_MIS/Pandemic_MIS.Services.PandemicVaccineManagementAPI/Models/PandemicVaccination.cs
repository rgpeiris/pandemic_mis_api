using System.ComponentModel.DataAnnotations;

namespace Pandemic_MIS.Services.PandemicVaccineManagementAPI.Models
{
    public class PandemicVaccination
    {
        [Key]
        public int PandemicVaccinationId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string NICNumber { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string District { get; set; }
        [Required]
        public string MOHArea { get; set; }
        [Required]
        public string GramaNiladhariArea { get; set; }
        [Required]
        public int SerialNumber { get; set; }
        [Required]
        public string VaccineName { get; set; }
        [Required]
        public string VaccineDose { get; set; }
        [Required]
        public int VaccinationCentreId { get; set; }
        [Required]
        public DateTime DateOfVaccination { get; set; }
        [Required]
        public DateTime NextAppointmentDate { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
