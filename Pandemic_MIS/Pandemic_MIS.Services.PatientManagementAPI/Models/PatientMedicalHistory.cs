using System.ComponentModel.DataAnnotations;

namespace Pandemic_MIS.Services.PatientManagementAPI.Models
{
    public class PatientMedicalHistory
    {
        [Key]
        public int PatientMedicalHistoryId { get; set; }
        [Required]
        public int PatientId { get; set; }
        [Required]
        public DateTime ExaminedDate { get; set; }
        [Required]
        public string ExaminedBy { get; set; }
        [Required]
        public string DiagnosisSummary { get; set; }
        [Required]
        public string Treatments { get; set; }
        public string? Remarks { get; set; }
    }
}
