namespace Pandemic_MIS.Services.PandemicVaccineManagementAPI.Models.Dto
{
    public class ScheduledVaccinationCentreDto
    {
        public int ScheduledVaccinationCentreId { get; set; }
        public int VaccinationCentreId { get; set; }
        public DateTime DateScheduled { get; set; }
        public string TimeScheduled { get; set; }
        public int AvailableCapacity { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
