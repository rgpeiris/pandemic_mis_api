using AutoMapper;
using Pandemic_MIS.Services.PandemicTestsManagementAPI.Models;
using Pandemic_MIS.Services.PandemicTestsManagementAPI.Models.Dto;

namespace Pandemic_MIS.Services.PandemicTestsManagementAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<PandemicTestDto, PandemicTest>();
                config.CreateMap<PandemicTest, PandemicTestDto>();
                config.CreateMap<PandemicTestResultDto, PandemicTestResult>();
                config.CreateMap<PandemicTestResult, PandemicTestResultDto>();
                config.CreateMap<ScheduledTestCentreDto, ScheduledTestCentre>();
                config.CreateMap<ScheduledTestCentre, ScheduledTestCentreDto>();
                config.CreateMap<TestCentreDto, TestCentre>();
                config.CreateMap<TestCentre, TestCentreDto>();
                config.CreateMap<TestsAppointmentDto, TestsAppointment>();
                config.CreateMap<TestsAppointment, TestsAppointmentDto>();
            });
            return mappingConfig;
        }
    }
}
