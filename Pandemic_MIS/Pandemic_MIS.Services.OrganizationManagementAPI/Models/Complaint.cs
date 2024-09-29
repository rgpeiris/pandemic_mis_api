using System.ComponentModel.DataAnnotations;

namespace Pandemic_MIS.Services.OrganizationManagementAPI.Models
{
    public class Complaint
    {
        [Key]
        public int ComplaintId { get; set; }
        [Required]
        public string ComplaintTitle { get; set; }
        [Required]
        public string ComplaintDescription { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
