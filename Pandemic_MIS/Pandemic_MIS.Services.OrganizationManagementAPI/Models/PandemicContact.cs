using System.ComponentModel.DataAnnotations;

namespace Pandemic_MIS.Services.OrganizationManagementAPI.Models
{
    public class PandemicContact
    {
        [Key]
        public int PandemicContactId { get; set; }
        [Required]
        public string NicNumber { get; set; }
        [Required]
        public string Name { get; set;}
        [Required]
        public string Address { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public DateTime CheckInTime { get; set; }
        [Required]
        public DateTime CheckOutTime { get; set; }
        [Required]
        public int OrganizationId { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
