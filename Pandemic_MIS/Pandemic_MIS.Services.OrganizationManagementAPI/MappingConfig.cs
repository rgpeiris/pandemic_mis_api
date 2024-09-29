using AutoMapper;
using Pandemic_MIS.Services.OrganizationManagementAPI.Models;
using Pandemic_MIS.Services.OrganizationManagementAPI.Models.Dto;

namespace Pandemic_MIS.Services.OrganizationManagementAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<OrganizationDto, Organization>();
                config.CreateMap<Organization, OrganizationDto>();
                config.CreateMap<PandemicContactDto, PandemicContact>();
                config.CreateMap<PandemicContact, PandemicContactDto>();
                config.CreateMap<ComplaintDto, Complaint>();
                config.CreateMap<Complaint, ComplaintDto>();
            });
            return mappingConfig;
        }
    }
}
