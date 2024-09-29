using AutoMapper;
using Pandemic_MIS.Services.PatientManagementAPI.Models;
using Pandemic_MIS.Services.PatientManagementAPI.Models.Dto;

namespace Pandemic_MIS.Services.PatientManagementAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps() 
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<HealthcareProfessionalDto, HealthcareProfessional>();
                config.CreateMap<HealthcareProfessional, HealthcareProfessionalDto>();
                config.CreateMap<HospitalDto, Hospital>();
                config.CreateMap<Hospital, HospitalDto>();
                config.CreateMap<LocalGovernmentInChargeDto, LocalGovernmentInCharge>();
                config.CreateMap<LocalGovernmentInCharge, LocalGovernmentInChargeDto>();
                config.CreateMap<PandemicPatientDto, PandemicPatient>();
                config.CreateMap<PandemicPatient, PandemicPatientDto>();
                config.CreateMap<PatientMedicalHistoryDto, PatientMedicalHistory>();
                config.CreateMap<PatientMedicalHistory, PatientMedicalHistoryDto>();
            });
            return mappingConfig;
        }
    }
}
