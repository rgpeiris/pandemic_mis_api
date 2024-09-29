namespace Pandemic_MIS.Services.PandemicTestsManagementAPI.Models.Dto
{
    public class PandemicTestResultDto
    {
        public int PandemicTestResultId { get; set; }
        public string Name { get; set; }
        public string NICNumber { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string District { get; set; }
        public string MOHArea { get; set; }
        public string GramaNiladhariArea { get; set; }
        public int SerialNumber { get; set; }
        public int TestCentreId { get; set; }
        public DateTime DateOfPandemicTest { get; set; }
        public string TestingType { get; set; }
        public string TestResult { get; set; }
        public string TestResultSummary { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
