using AutoMapper;
using Pandemic_MIS.Services.PandemicNewsAPI.Models;
using Pandemic_MIS.Services.PandemicNewsAPI.Models.Dto;

namespace Pandemic_MIS.Services.PandemicNewsAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps() 
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<PandemicNewsDto, PandemicNews>();
                config.CreateMap<PandemicNews, PandemicNewsDto>();
            });
            return mappingConfig;
        }
    }
}
