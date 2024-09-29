using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pandemic_MIS.Services.PandemicTestsManagementAPI.Data;
using Pandemic_MIS.Services.PandemicTestsManagementAPI.Models;
using Pandemic_MIS.Services.PandemicTestsManagementAPI.Models.Dto;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Pandemic_MIS.Services.PandemicTestsManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PandemicTestsManagementAPIController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDto _response;
        private IMapper _mapper;

        public PandemicTestsManagementAPIController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new ResponseDto();
        }

        [HttpGet]
        [Route("viral-tests")]
        public ResponseDto GetAllPandemicTests()
        {
            try
            {
                IEnumerable<PandemicTest> objList = _db.PandemicTests.OrderByDescending(x => x.CreatedDate).ToList();
                _response.Result = _mapper.Map<IEnumerable<PandemicTestDto>>(objList); 
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("viral-test/{id:int}")]
        public ResponseDto GetPandemicTestById(int id)
        {
            try
            {
                PandemicTest obj = _db.PandemicTests.First(u => u.PandemicTestId == id);
                _response.Result = _mapper.Map<PandemicTestDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("viral-test/{testType}")]
        public ResponseDto GetPandemicTestByName(string testType)
        {
            try
            {
                IEnumerable<PandemicTest> objList = _db.PandemicTests.Where(u => u.TestType.ToLower().Contains(testType.ToLower()));
                _response.Result = _mapper.Map<IEnumerable<PandemicTestDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPost]
        [Route("viral-test")]
        public ResponseDto PostPandemicTest([FromBody] PandemicTestDto pandemicTestDto)
        {
            try
            {
                PandemicTest obj = _mapper.Map<PandemicTest>(pandemicTestDto);
                _db.PandemicTests.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<PandemicTestDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPut]
        [Route("viral-test")]
        public ResponseDto PutPandemicTest([FromBody] PandemicTestDto pandemicTestDto)
        {
            try
            {
                PandemicTest obj = _mapper.Map<PandemicTest>(pandemicTestDto);
                _db.PandemicTests.Update(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<PandemicTestDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpDelete]
        [Route("viral-test")]
        public ResponseDto DeletePandemicTest(int id)
        {
            try
            {
                PandemicTest obj = _db.PandemicTests.First(u => u.PandemicTestId == id);
                _db.PandemicTests.Remove(obj);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("viral-test-centres")]
        public ResponseDto GetAllTestCentres()
        {
            try
            {
                IEnumerable<TestCentre> objList = _db.TestCentres.OrderByDescending(x => x.CreatedDate).ToList();
                _response.Result = _mapper.Map<IEnumerable<TestCentreDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("viral-test-centre/{id:int}")]
        public ResponseDto GetTestCentreById(int id)
        {
            try
            {
                TestCentre obj = _db.TestCentres.First(u => u.TestCentreId == id);
                _response.Result = _mapper.Map<TestCentreDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("viral-test-centre/{centreName}")]
        public ResponseDto GetTestCentreByName(string centreName)
        {
            try
            {
                IEnumerable<TestCentre> objList = _db.TestCentres.Where(u => u.CentreName.ToLower().Contains(centreName.ToLower()));
                _response.Result = _mapper.Map<IEnumerable<TestCentreDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPost]
        [Route("viral-test-centre")]
        public ResponseDto PostTestCentre([FromBody] TestCentreDto testCentreDto)
        {
            try
            {
                TestCentre obj = _mapper.Map<TestCentre>(testCentreDto);
                _db.TestCentres.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<TestCentreDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPut]
        [Route("viral-test-centre")]
        public ResponseDto PutTestCentre([FromBody] TestCentreDto testCentreDto)
        {
            try
            {
                TestCentre obj = _mapper.Map<TestCentre>(testCentreDto);
                _db.TestCentres.Update(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<TestCentreDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpDelete]
        [Route("viral-test-centre")]
        public ResponseDto DeleteTestCentre(int id)
        {
            try
            {
                TestCentre obj = _db.TestCentres.First(u => u.TestCentreId == id);
                _db.TestCentres.Remove(obj);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("scheduled-viral-test-centres/all")]
        public ResponseDto GetAllScheduledTestCentres()
        {
            try
            {
                var query = from a in _db.ScheduledTestCentres
                            join b in _db.TestCentres
                            on a.TestCentreId equals b.TestCentreId
                            orderby a.CreatedDate descending
                            select new
                            {
                                a.ScheduledTestCentreId,
                                a.TestCentreId,
                                b.CentreName,
                                a.DateScheduled,
                                a.TimeScheduled,
                                a.AvailableCapacity,
                                a.CreatedBy, 
                                a.CreatedDate,
                            };
                _response.Result = query.ToList();
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("scheduled-viral-test-centre/{id:int}")]
        public ResponseDto GetScheduledTestCentreById(int id)
        {
            try
            {
                var query = from a in _db.ScheduledTestCentres
                            join b in _db.TestCentres
                on a.TestCentreId equals b.TestCentreId
                            where a.ScheduledTestCentreId == id
                            select new
                            {
                                a.ScheduledTestCentreId,
                                a.TestCentreId,
                                b.CentreName,
                                a.DateScheduled,
                                a.TimeScheduled,
                                a.AvailableCapacity,
                                a.CreatedBy,
                                a.CreatedDate,
                            };
                _response.Result = query.ToList();
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("scheduled-viral-test-centre/{date}")]
        public ResponseDto GetScheduledTestCentreByDate(DateTime date)
        {
            try
            {
                var query = from a in _db.ScheduledTestCentres
                            join b in _db.TestCentres
                            on a.TestCentreId equals b.TestCentreId
                            where a.DateScheduled.Date == date.Date
                            select new
                            {
                                a.ScheduledTestCentreId,
                                a.TestCentreId,
                                b.CentreName,
                                a.DateScheduled,
                                a.TimeScheduled,
                                a.AvailableCapacity,
                            };
                _response.Result = query.ToList();
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("scheduled-viral-test-centres")]
        public ResponseDto GetScheduledTestCentreByInfo(string district, string city, DateTime date)
        {
            try
            {
                var query = from a in _db.ScheduledTestCentres
                            join b in _db.TestCentres
                            on a.TestCentreId equals b.TestCentreId
                            where a.DateScheduled.Date == date.Date && b.District == district && b.City == city
                            select new
                            {
                                a.ScheduledTestCentreId,
                                a.TestCentreId,
                                b.CentreName,
                                a.DateScheduled,
                                a.TimeScheduled,
                                a.AvailableCapacity,
                            };
                _response.Result = query.ToList();
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPost]
        [Route("scheduled-viral-test-centre")]
        public ResponseDto PostScheduledTestCentre([FromBody] ScheduledTestCentreDto scheduledTestCentreDto)
        {
            try
            {
                ScheduledTestCentre obj = _mapper.Map<ScheduledTestCentre>(scheduledTestCentreDto);
                _db.ScheduledTestCentres.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<ScheduledTestCentreDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPut]
        [Route("scheduled-viral-test-centre")]
        public ResponseDto PutScheduledTestCentre([FromBody] ScheduledTestCentreDto scheduledTestCentreDto)
        {
            try
            {
                ScheduledTestCentre obj = _mapper.Map<ScheduledTestCentre>(scheduledTestCentreDto);
                _db.ScheduledTestCentres.Update(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<ScheduledTestCentreDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpDelete]
        [Route("scheduled-viral-test-centre")]
        public ResponseDto DeleteScheduledTestCentre(int id)
        {
            try
            {
                ScheduledTestCentre obj = _db.ScheduledTestCentres.First(u => u.ScheduledTestCentreId == id);
                _db.ScheduledTestCentres.Remove(obj);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("viral-test-appointments/all")]
        public ResponseDto GetAllTestsAppointments()
        {
            try
            {
                var query = from a in _db.TestsAppointments
                            join b in _db.TestCentres
                            on a.TestCentreId equals b.TestCentreId
                            orderby a.CreatedDate descending
                            select new
                            {
                                a.TestsAppointmentId,
                                a.Name,
                                a.NICNumber,
                                a.Age,
                                a.Gender,
                                a.Address,
                                a.PhoneNumber,
                                a.TestCentreId,
                                b.CentreName,
                                a.DateScheduled,
                                a.TimeScheduled,
                                a.Status,
                                a.CreatedBy,
                                a.CreatedDate,
                            };
                _response.Result = query.ToList();
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("viral-test-appointment/{id:int}")]
        public ResponseDto GetTestsAppointmentById(int id)
        {
            try
            {
                var query = from a in _db.TestsAppointments
                            join b in _db.TestCentres
                on a.TestCentreId equals b.TestCentreId
                            where a.TestsAppointmentId == id
                            select new
                            {
                                a.TestsAppointmentId,
                                a.Name,
                                a.NICNumber,
                                a.Age,
                                a.Gender,
                                a.Address,
                                a.PhoneNumber,
                                a.TestCentreId,
                                b.CentreName,
                                a.DateScheduled,
                                a.TimeScheduled,
                                a.Status,
                                a.CreatedBy,
                                a.CreatedDate,
                            };
                _response.Result = query.ToList();
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("viral-test-appointment/{date}")]
        public ResponseDto GetTestsAppointmentByDate(DateTime date)
        {
            try
            {
                var query = from a in _db.TestsAppointments
                            join b in _db.TestCentres
                            on a.TestCentreId equals b.TestCentreId
                            where a.DateScheduled.Date == date.Date
                            select new
                            {
                                a.TestsAppointmentId,
                                a.Name,
                                a.NICNumber,
                                a.Age,
                                a.Gender,
                                a.Address,
                                a.PhoneNumber,
                                a.TestCentreId,
                                b.CentreName,
                                a.DateScheduled,
                                a.TimeScheduled,
                                a.Status,
                                a.CreatedBy,
                                a.CreatedDate,
                            };
                _response.Result = query.ToList();
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("viral-test-appointments")]
        public ResponseDto GetTestsAppointmentsByInfo(int testCentreId, string createdBy, DateTime date)
        {
            try
            {
                var query = from a in _db.TestsAppointments
                            join b in _db.TestCentres
                            on a.TestCentreId equals b.TestCentreId
                            where a.DateScheduled.Date == date.Date && a.TestCentreId == testCentreId && a.CreatedBy == createdBy
                            select new
                            {
                                a.TestsAppointmentId,
                                a.Name,
                                a.NICNumber,
                                a.Age,
                                a.Gender,
                                a.Address,
                                a.PhoneNumber,
                                a.TestCentreId,
                                b.CentreName,
                                a.DateScheduled,
                                a.TimeScheduled,
                                a.Status,
                                a.CreatedBy,
                                a.CreatedDate,
                            };

                _response.Result = query.ToList();
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("viral-test-appointments/{createdBy}")]
        public ResponseDto GetTestsAppointmentsByCreatedBy(string createdBy)
        {
            try
            {
                var query = from a in _db.TestsAppointments
                            join b in _db.TestCentres
                            on a.TestCentreId equals b.TestCentreId
                            where a.CreatedBy == createdBy && a.Status == "SCHEDULED"
                            select new
                            {
                                a.TestsAppointmentId,
                                a.Name,
                                a.NICNumber,
                                a.Age,
                                a.Gender,
                                a.Address,
                                a.PhoneNumber,
                                a.TestCentreId,
                                b.CentreName,
                                a.DateScheduled,
                                a.TimeScheduled,
                                a.Status,
                                a.CreatedBy,
                                a.CreatedDate,
                            };

                _response.Result = query.ToList();
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPost]
        [Route("viral-test-appointment")]
        public ResponseDto PostTestsAppointment([FromBody] TestsAppointmentDto testsAppointmentDto)
        {
            try
            {
                TestsAppointment obj = _mapper.Map<TestsAppointment>(testsAppointmentDto);
                _db.TestsAppointments.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<TestsAppointmentDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPut]
        [Route("viral-test-appointment")]
        public ResponseDto PutTestsAppointment([FromBody] TestsAppointmentDto testsAppointmentDto)
        {
            try
            {
                TestsAppointment obj = _mapper.Map<TestsAppointment>(testsAppointmentDto);
                _db.TestsAppointments.Update(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<TestsAppointmentDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpDelete]
        [Route("viral-test-appointment")]
        public ResponseDto DeleteTestsAppointment(int id)
        {
            try
            {
                TestsAppointment obj = _db.TestsAppointments.First(u => u.TestsAppointmentId == id);
                _db.TestsAppointments.Remove(obj);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("viral-test-results")]
        public ResponseDto GetAllPandemicTestResults()
        {
            try
            {
                var query = from a in _db.PandemicTestResults
                            join b in _db.TestCentres
                            on a.TestCentreId equals b.TestCentreId
                            orderby a.CreatedDate descending
                            select new
                            {
                                a.PandemicTestResultId,
                                a.Name,
                                a.NICNumber,
                                a.Age,
                                a.Gender,
                                a.Address,
                                a.PhoneNumber,
                                a.District,
                                a.MOHArea,
                                a.GramaNiladhariArea,
                                a.SerialNumber,
                                a.TestCentreId,
                                b.CentreName,
                                a.DateOfPandemicTest,
                                a.TestResult,
                                a.TestingType,
                                a.TestResultSummary,
                                a.Status,
                                a.CreatedBy,
                                a.CreatedDate,
                            };
                _response.Result = query.ToList();
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("viral-test-result/{id:int}")]
        public ResponseDto GetPandemicTestResultById(int id)
        {
            try
            {
                PandemicTestResult obj = _db.PandemicTestResults.First(u => u.PandemicTestResultId == id);
                _response.Result = _mapper.Map<PandemicTestResultDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("viral-test-result/{nic}")]
        public ResponseDto GetPandemicTestResultByNIC(string nic)
        {
            try
            {
                var query = from a in _db.PandemicTestResults
                            join b in _db.TestCentres
                            on a.TestCentreId equals b.TestCentreId
                            where a.NICNumber == nic
                            select new
                            {
                                a.PandemicTestResultId,
                                a.Name,
                                a.NICNumber,
                                a.Age,
                                a.Gender,
                                a.Address,
                                a.PhoneNumber,
                                a.District,
                                a.MOHArea,
                                a.GramaNiladhariArea,
                                a.SerialNumber,
                                a.TestCentreId,
                                b.CentreName,
                                a.DateOfPandemicTest,
                                a.TestingType,
                                a.TestResult,
                                a.TestResultSummary,
                                a.Status,
                            };
                _response.Result = query.ToList();
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPost]
        [Route("viral-test-result")]
        public ResponseDto PostPandemicTestResult([FromBody] PandemicTestResultDto pandemicTestResultDto)
        {
            try
            {
                PandemicTestResult obj = _mapper.Map<PandemicTestResult>(pandemicTestResultDto);
                _db.PandemicTestResults.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<PandemicTestResultDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPut]
        [Route("viral-test-result")]
        public ResponseDto PutPandemicTestResult([FromBody] PandemicTestResultDto pandemicTestResultDto)
        {
            try
            {
                PandemicTestResult obj = _mapper.Map<PandemicTestResult>(pandemicTestResultDto);
                _db.PandemicTestResults.Update(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<PandemicTestResultDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpDelete]
        [Route("viral-test-result")]
        public ResponseDto DeletePandemicTestResult(int id)
        {
            try
            {
                PandemicTestResult obj = _db.PandemicTestResults.First(u => u.PandemicTestResultId == id);
                _db.PandemicTestResults.Remove(obj);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }
    }
}
