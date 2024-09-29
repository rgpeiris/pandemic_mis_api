namespace Pandemic_MIS.Services.PatientManagementAPI.Models.Dto
{
    public class LocalGovernmentInChargeDto
    {
        public int LocalGovernmentInChargeId { get; set; }
        public string LocalGovernmentInChargeName { get; set; }
        public string Designation { get; set; }
        public string AssignedDistrict { get; set; }
        public string PhoneNumber { get; set; }
        public string AssignedUsername { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
