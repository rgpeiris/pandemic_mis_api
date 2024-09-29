using System.ComponentModel.DataAnnotations;

namespace Pandemic_MIS.Services.PandemicTestsManagementAPI.Models
{
    public class ScheduledTestCentre
    {
        [Key]
        public int ScheduledTestCentreId { get; set; }
        [Required]
        public int TestCentreId { get; set; }
        [Required]
        public DateTime DateScheduled { get; set; }
        [Required]
        public string TimeScheduled { get; set; }
        [Required]
        public int AvailableCapacity { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
