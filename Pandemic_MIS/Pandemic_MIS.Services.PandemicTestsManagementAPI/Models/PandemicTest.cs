using System.ComponentModel.DataAnnotations;

namespace Pandemic_MIS.Services.PandemicTestsManagementAPI.Models
{
    public class PandemicTest
    {
        [Key]
        public int PandemicTestId { get; set; }
        [Required]
        public string TestType { get; set; }
        public string Description { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
