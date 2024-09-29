namespace Pandemic_MIS.Services.PatientManagementAPI.Models.Dto
{
    public class HospitalDto
    {
        public int HospitalId { get; set; }
        public string HospitalName { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
