using System.ComponentModel.DataAnnotations;

namespace Pandemic_MIS.Services.PandemicTestsManagementAPI.Models
{
    public class PandemicTestResult
    {
        [Key]
        public int PandemicTestResultId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string NICNumber { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string District { get; set; }
        [Required]
        public string MOHArea { get; set; }
        [Required]
        public string GramaNiladhariArea { get; set; }
        [Required]
        public int SerialNumber { get; set; }
        [Required]
        public int TestCentreId { get; set; }
        [Required]
        public DateTime DateOfPandemicTest { get; set; }
        [Required]
        public string TestingType { get; set; }
        [Required]
        public string TestResult { get; set; }
        [Required]
        public string TestResultSummary { get; set; }
        public string Status { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
