namespace Pandemic_MIS.Services.PandemicVaccineManagementAPI.Models.Dto
{
    public class PandemicVaccinationDto
    {
        public int PandemicVaccinationId { get; set; }
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
        public string VaccineName { get; set; }
        public string VaccineDose { get; set; }
        public int VaccinationCentreId { get; set; }
        public DateTime DateOfVaccination { get; set; }
        public DateTime NextAppointmentDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
