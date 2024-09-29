namespace Pandemic_MIS.Services.AuthAPI.Models.Dto
{
    public class UserDto
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string CallingName { get; set; }
        public string Gender { get; set; }
        public string Salutation { get; set; }
        public string FullName { get; set; }
        public string NICNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Designation { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastLoginDate { get; set; }       
        public string Role { get; set; }
    }
}
