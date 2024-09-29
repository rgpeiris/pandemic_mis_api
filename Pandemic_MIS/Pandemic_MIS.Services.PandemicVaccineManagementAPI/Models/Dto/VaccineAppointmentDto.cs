namespace Pandemic_MIS.Services.PandemicVaccineManagementAPI.Models.Dto
{
    public class VaccineAppointmentDto
    {
        public int VaccineAppointmentId { get; set; }
        public string Name { get; set; }
        public string NICNumber { get; set; }
        public int Age { get; set; }
        public int BirthYear { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsRequiredReports { get; set; }
        public int VaccinationCentreId { get; set; }
        public DateTime DateScheduled { get; set; }
        public string TimeScheduled { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
