using Microsoft.AspNetCore.Identity;

namespace Pandemic_MIS.Services.AuthAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string CallingName { get; set; }
        public string Gender { get; set; }
        public string Salutation { get; set; }
        public string FullName { get; set; }
        public string NICNumber { get; set; }
        public string Address { get; set; }
        public string Designation { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
