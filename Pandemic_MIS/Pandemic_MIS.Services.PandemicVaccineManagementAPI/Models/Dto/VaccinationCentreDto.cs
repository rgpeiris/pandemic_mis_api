namespace Pandemic_MIS.Services.PandemicVaccineManagementAPI.Models.Dto
{
    public class VaccinationCentreDto
    {
        public int VaccinationCentreId { get; set; }
        public string CentreName { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
