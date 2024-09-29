namespace Pandemic_MIS.Services.PandemicVaccineManagementAPI.Models.Dto
{
    public class PandemicVaccineDto
    {
        public int VaccineId { get; set; }
        public string VaccineName { get; set; }
        public string Dose { get; set; }
        public int NextDose { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
