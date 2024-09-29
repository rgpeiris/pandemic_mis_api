namespace Pandemic_MIS.Services.OrganizationManagementAPI.Models.Dto
{
    public class ComplaintDto
    {
        public int ComplaintId { get; set; }
        public string ComplaintTitle { get; set; }
        public string ComplaintDescription { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
