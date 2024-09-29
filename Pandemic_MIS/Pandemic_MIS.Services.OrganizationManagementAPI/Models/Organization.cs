using System.ComponentModel.DataAnnotations;

namespace Pandemic_MIS.Services.OrganizationManagementAPI.Models
{
    public class Organization
    {
        [Key]
        public int OrganizationId { get; set; }
        [Required]
        public string OrganizationName { get; set; }
        [Required]
        public string OrganizationType { get; set; }
        [Required]
        public string ContactName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }
        public bool IsActive { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
