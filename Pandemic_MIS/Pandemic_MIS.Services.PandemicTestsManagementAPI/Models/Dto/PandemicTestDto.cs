namespace Pandemic_MIS.Services.PandemicTestsManagementAPI.Models.Dto
{
    public class PandemicTestDto
    {
        public int PandemicTestId { get; set; }
        public string TestType { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
