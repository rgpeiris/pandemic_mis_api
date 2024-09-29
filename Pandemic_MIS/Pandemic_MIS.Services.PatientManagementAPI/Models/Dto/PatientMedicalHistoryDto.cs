namespace Pandemic_MIS.Services.PatientManagementAPI.Models.Dto
{
    public class PatientMedicalHistoryDto
    {
        public int PatientMedicalHistoryId { get; set; }
        public int PatientId { get; set; }
        public DateTime ExaminedDate { get; set; }
        public string ExaminedBy { get; set; }
        public string DiagnosisSummary { get; set; }
        public string Treatments { get; set; }
        public string? Remarks { get; set; }
    }
}
