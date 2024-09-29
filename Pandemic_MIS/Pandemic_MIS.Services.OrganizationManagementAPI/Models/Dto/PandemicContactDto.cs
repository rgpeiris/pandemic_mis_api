namespace Pandemic_MIS.Services.OrganizationManagementAPI.Models.Dto
{
    public class PandemicContactDto
    {
        public int PandemicContactId { get; set; }
        public string NicNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime CheckOutTime { get; set; }
        public int OrganizationId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
