namespace Pandemic_MIS.Services.PandemicTestsManagementAPI.Models.Dto
{
    public class ScheduledTestCentreDto
    {
        public int ScheduledTestCentreId { get; set; }
        public int TestCentreId { get; set; }
        public DateTime DateScheduled { get; set; }
        public string TimeScheduled { get; set; }
        public int AvailableCapacity { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
