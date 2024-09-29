using AutoMapper;
using Pandemic_MIS.Services.PandemicVaccineManagementAPI.Models;
using Pandemic_MIS.Services.PandemicVaccineManagementAPI.Models.Dto;

namespace Pandemic_MIS.Services.PandemicVaccineManagementAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<PandemicVaccinationDto, PandemicVaccination>();
                config.CreateMap<PandemicVaccination, PandemicVaccinationDto>();
                config.CreateMap<PandemicVaccineDto, PandemicVaccine>();
                config.CreateMap<PandemicVaccine, PandemicVaccineDto>();
                config.CreateMap<ScheduledVaccinationCentreDto, ScheduledVaccinationCentre>();
                config.CreateMap<ScheduledVaccinationCentre, ScheduledVaccinationCentreDto>();
                config.CreateMap<VaccinationCentreDto, VaccinationCentre>();
                config.CreateMap<VaccinationCentre, VaccinationCentreDto>();
                config.CreateMap<VaccineAppointmentDto, VaccineAppointment>();
                config.CreateMap<VaccineAppointment, VaccineAppointmentDto>();
            });
            return mappingConfig;
        }
    }
}
