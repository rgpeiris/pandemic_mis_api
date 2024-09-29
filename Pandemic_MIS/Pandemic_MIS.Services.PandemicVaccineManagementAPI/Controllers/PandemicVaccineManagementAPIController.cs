using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Pandemic_MIS.Services.PandemicVaccineManagementAPI.Data;
using Pandemic_MIS.Services.PandemicVaccineManagementAPI.Models;
using Pandemic_MIS.Services.PandemicVaccineManagementAPI.Models.Dto;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Pandemic_MIS.Services.PandemicVaccineManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PandemicVaccineManagementAPIController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDto _response;
        private IMapper _mapper;

        public PandemicVaccineManagementAPIController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new ResponseDto();
        }

        [HttpGet]
        [Route("vaccines")]
        public ResponseDto GetAllPandemicVaccines() 
        {
            try 
            {
                IEnumerable<PandemicVaccine> objList = _db.PandemicVaccines.OrderByDescending(x => x.CreatedDate).ToList();
                _response.Result = _mapper.Map<IEnumerable<PandemicVaccineDto>>(objList); 
            }
            catch (Exception ex) 
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("vaccine/{vaccineId:int}")]
        public ResponseDto GetPandemicVaccineById(int vaccineId)
        {
            try
            {
                PandemicVaccine obj = _db.PandemicVaccines.First(u => u.VaccineId == vaccineId);
                _response.Result = _mapper.Map<PandemicVaccineDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("vaccine/{vaccineName}")]
        public ResponseDto GetPandemicVaccineByName(string vaccineName)
        {
            try
            {
                IEnumerable<PandemicVaccine> objList = _db.PandemicVaccines.Where(u => u.VaccineName.ToLower().Contains(vaccineName.ToLower()));
                _response.Result = _mapper.Map<IEnumerable<PandemicVaccineDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPost]
        [Route("vaccine")]
        public ResponseDto PostPandemicVaccine([FromBody] PandemicVaccineDto pandemicVaccineDto)
        {
            try
            {
                PandemicVaccine obj = _mapper.Map<PandemicVaccine>(pandemicVaccineDto);
                _db.PandemicVaccines.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<PandemicVaccineDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPut]
        [Route("vaccine")]
        public ResponseDto PutPandemicVaccine([FromBody] PandemicVaccineDto pandemicVaccineDto)
        {
            try
            {
                PandemicVaccine obj = _mapper.Map<PandemicVaccine>(pandemicVaccineDto);
                _db.PandemicVaccines.Update(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<PandemicVaccineDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpDelete]
        [Route("vaccine")]
        public ResponseDto DeletePandemicVaccine(int id)
        {
            try
            {
                PandemicVaccine obj = _db.PandemicVaccines.First(u => u.VaccineId == id);
                _db.PandemicVaccines.Remove(obj);
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
        [Route("vaccination-centres")]
        public ResponseDto GetAllVaccinationCentres()
        {
            try
            {
                IEnumerable<VaccinationCentre> objList = _db.VaccinationCentres.OrderByDescending(x => x.CreatedDate).ToList();
                _response.Result = _mapper.Map<IEnumerable<VaccinationCentreDto>>(objList); 
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("vaccination-centre/{id:int}")]
        public ResponseDto GetVaccinationCentreById(int id)
        {
            try
            {
                VaccinationCentre obj = _db.VaccinationCentres.First(u => u.VaccinationCentreId == id);
                _response.Result = _mapper.Map<VaccinationCentreDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("vaccination-centre/{centreName}")]
        public ResponseDto GetVaccinationCentreByName(string centreName)
        {
            try
            {
                IEnumerable<VaccinationCentre> objList = _db.VaccinationCentres.Where(u => u.CentreName.ToLower().Contains(centreName.ToLower()));
                _response.Result = _mapper.Map<IEnumerable<VaccinationCentreDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPost]
        [Route("vaccination-centre")]
        public ResponseDto PostVaccinationCentre([FromBody] VaccinationCentreDto vaccinationCentreDto)
        {
            try
            {
                VaccinationCentre obj = _mapper.Map<VaccinationCentre>(vaccinationCentreDto);
                _db.VaccinationCentres.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<VaccinationCentreDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPut]
        [Route("vaccination-centre")]
        public ResponseDto PutVaccinationCentre([FromBody] VaccinationCentreDto vaccinationCentreDto)
        {
            try
            {
                VaccinationCentre obj = _mapper.Map<VaccinationCentre>(vaccinationCentreDto);
                _db.VaccinationCentres.Update(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<VaccinationCentreDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpDelete]
        [Route("vaccination-centre")]
        public ResponseDto DeleteVaccinationCentre(int id)
        {
            try
            {
                VaccinationCentre obj = _db.VaccinationCentres.First(u => u.VaccinationCentreId == id);
                _db.VaccinationCentres.Remove(obj);
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
        [Route("scheduled-vaccination-centres/all")]
        public ResponseDto GetAllScheduledVaccinationCentres()
        {
            try
            {
                var query = from a in _db.ScheduledVaccinationCentres
                            join b in _db.VaccinationCentres
                            on a.VaccinationCentreId equals b.VaccinationCentreId
                            orderby a.CreatedDate descending
                            select new
                            {
                                a.ScheduledVaccinationCentreId,
                                a.VaccinationCentreId,
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
        [Route("scheduled-vaccination-centre/{id:int}")]
        public ResponseDto GetScheduledVaccinationCentreById(int id)
        {
            try
            {
                var query = from a in _db.ScheduledVaccinationCentres
                            join b in _db.VaccinationCentres
                on a.VaccinationCentreId equals b.VaccinationCentreId
                            where a.ScheduledVaccinationCentreId == id
                            select new
                            {
                                a.ScheduledVaccinationCentreId,
                                a.VaccinationCentreId,
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
        [Route("scheduled-vaccination-centre/{date}")]
        public ResponseDto GetScheduledVaccinationCentreByDate(DateTime date)
        {
            try
            {
                var query = from a in _db.ScheduledVaccinationCentres
                            join b in _db.VaccinationCentres
                on a.VaccinationCentreId equals b.VaccinationCentreId
                            where a.DateScheduled.Date == date.Date
                            select new
                            {
                                a.ScheduledVaccinationCentreId,
                                a.VaccinationCentreId,
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
        [Route("scheduled-vaccination-centres")]
        public ResponseDto GetScheduledVaccinationCentreByInfo(string district, string city, DateTime date)
        {
            try
            {
                var query = from a in _db.ScheduledVaccinationCentres
                            join b in _db.VaccinationCentres
                on a.VaccinationCentreId equals b.VaccinationCentreId
                            where a.DateScheduled.Date == date.Date && b.District == district && b.City == city
                            select new
                            {
                                a.ScheduledVaccinationCentreId,
                                a.VaccinationCentreId,
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
        [Route("scheduled-vaccination-centre")]
        public ResponseDto PostScheduledVaccinationCentre([FromBody] ScheduledVaccinationCentreDto scheduledVaccinationCentreDto)
        {
            try
            {
                ScheduledVaccinationCentre obj = _mapper.Map<ScheduledVaccinationCentre>(scheduledVaccinationCentreDto);
                _db.ScheduledVaccinationCentres.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<ScheduledVaccinationCentreDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPut]
        [Route("scheduled-vaccination-centre")]
        public ResponseDto PutScheduledVaccinationCentre([FromBody] ScheduledVaccinationCentreDto scheduledVaccinationCentreDto)
        {
            try
            {
                ScheduledVaccinationCentre obj = _mapper.Map<ScheduledVaccinationCentre>(scheduledVaccinationCentreDto);
                _db.ScheduledVaccinationCentres.Update(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<ScheduledVaccinationCentreDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpDelete]
        [Route("scheduled-vaccination-centre")]
        public ResponseDto DeleteScheduledVaccinationCentre(int id)
        {
            try
            {
                ScheduledVaccinationCentre obj = _db.ScheduledVaccinationCentres.First(u => u.ScheduledVaccinationCentreId == id);
                _db.ScheduledVaccinationCentres.Remove(obj);
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
        [Route("vaccination-appointments/all")]
        public ResponseDto GetAllVaccineAppointments()
        {
            try
            {
                var query = from a in _db.VaccineAppointments
                            join b in _db.VaccinationCentres
                            on a.VaccinationCentreId equals b.VaccinationCentreId
                            orderby a.CreatedDate descending
                            select new
                            {
                                a.VaccineAppointmentId,
                                a.Name,
                                a.NICNumber,
                                a.Age,
                                a.Gender,
                                a.Address,
                                a.PhoneNumber,
                                a.IsRequiredReports,
                                a.VaccinationCentreId,                               
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
        [Route("vaccination-appointment/{id:int}")]
        public ResponseDto GetVaccineAppointmentById(int id)
        {
            try
            {
                var query = from a in _db.VaccineAppointments
                            join b in _db.VaccinationCentres
                            on a.VaccinationCentreId equals b.VaccinationCentreId
                            where a.VaccineAppointmentId == id
                            select new
                            {
                                a.VaccineAppointmentId,
                                a.Name,
                                a.NICNumber,
                                a.Age,
                                a.Gender,
                                a.Address,
                                a.PhoneNumber,
                                a.IsRequiredReports,
                                a.VaccinationCentreId,
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
        [Route("vaccination-appointment/{date}")]
        public ResponseDto GetVaccineAppointmentByDate(DateTime date)
        {
            try
            {
                var query = from a in _db.VaccineAppointments
                            join b in _db.VaccinationCentres
                            on a.VaccinationCentreId equals b.VaccinationCentreId
                            where a.DateScheduled.Date == date.Date
                            select new
                            {
                                a.VaccineAppointmentId,
                                a.Name,
                                a.NICNumber,
                                a.Age,
                                a.Gender,
                                a.Address,
                                a.PhoneNumber,
                                a.IsRequiredReports,
                                a.VaccinationCentreId,
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
        [Route("vaccination-appointments")]
        public ResponseDto GetVaccineAppointmentsByInfo(int vaccinationCentreId, string createdBy, DateTime date)
        {
            try
            {
                var query = from a in _db.VaccineAppointments
                            join b in _db.VaccinationCentres
                            on a.VaccinationCentreId equals b.VaccinationCentreId
                            where a.DateScheduled.Date == date.Date && a.VaccinationCentreId == vaccinationCentreId && a.CreatedBy == createdBy
                            select new
                            {
                                a.VaccineAppointmentId,
                                a.Name,
                                a.NICNumber,
                                a.Age,
                                a.Gender,
                                a.Address,
                                a.PhoneNumber,
                                a.IsRequiredReports,
                                a.VaccinationCentreId,
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
        [Route("vaccination-appointments/{createdBy}")]
        public ResponseDto GetVaccineAppointmentsByCreatedBy(string createdBy)
        {
            try
            {
                var query = from a in _db.VaccineAppointments
                            join b in _db.VaccinationCentres
                            on a.VaccinationCentreId equals b.VaccinationCentreId
                            where a.CreatedBy == createdBy && a.Status == "SCHEDULED"
                            select new
                            {
                                a.VaccineAppointmentId,
                                a.Name,
                                a.NICNumber,
                                a.Age,
                                a.Gender,
                                a.Address,
                                a.PhoneNumber,
                                a.IsRequiredReports,
                                a.VaccinationCentreId,
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
        [Route("vaccination-appointment")]
        public ResponseDto PostVaccineAppointment([FromBody] VaccineAppointmentDto vaccineAppointmentDto)
        {
            try
            {
                VaccineAppointment obj = _mapper.Map<VaccineAppointment>(vaccineAppointmentDto);
                _db.VaccineAppointments.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<VaccineAppointmentDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPut]
        [Route("vaccination-appointment")]
        public ResponseDto PutVaccineAppointment([FromBody] VaccineAppointmentDto vaccineAppointmentDto)
        {
            try
            {
                VaccineAppointment obj = _mapper.Map<VaccineAppointment>(vaccineAppointmentDto);
                _db.VaccineAppointments.Update(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<VaccineAppointmentDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpDelete]
        [Route("vaccination-appointment")]
        public ResponseDto DeleteVaccineAppointment(int id)
        {
            try
            {
                VaccineAppointment obj = _db.VaccineAppointments.First(u => u.VaccineAppointmentId == id);
                _db.VaccineAppointments.Remove(obj);
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
        [Route("vaccinations")]
        public ResponseDto GetAllPandemicVaccinations()
        {
            try
            {
                var query = from a in _db.PandemicVaccinations
                            join b in _db.VaccinationCentres
                            on a.VaccinationCentreId equals b.VaccinationCentreId
                            orderby a.CreatedDate descending
                            select new
                            {
                                a.PandemicVaccinationId,
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
                                a.VaccineName,
                                a.VaccineDose,                             
                                a.VaccinationCentreId,
                                b.CentreName,
                                a.DateOfVaccination,
                                a.NextAppointmentDate,
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
        [Route("vaccination/{id:int}")]
        public ResponseDto GetPandemicVaccinationById(int id)
        {
            try
            {
                PandemicVaccination obj = _db.PandemicVaccinations.First(u => u.PandemicVaccinationId == id);
                _response.Result = _mapper.Map<PandemicVaccinationDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("vaccination/{nic}")]
        public ResponseDto GetPandemicVaccinationByNIC(string nic)
        {
            try
            {
                var query = from a in _db.PandemicVaccinations
                            join b in _db.VaccinationCentres
                            on a.VaccinationCentreId equals b.VaccinationCentreId
                            where a.NICNumber == nic
                            orderby a.CreatedDate
                            select new
                            {
                                a.PandemicVaccinationId,
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
                                a.VaccineName,
                                a.VaccineDose,
                                a.VaccinationCentreId,
                                b.CentreName,
                                a.DateOfVaccination,
                                a.NextAppointmentDate,
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
        [Route("vaccination")]
        public ResponseDto PostPandemicVaccination([FromBody] PandemicVaccinationDto pandemicVaccinationDto)
        {
            try
            {
                PandemicVaccination obj = _mapper.Map<PandemicVaccination>(pandemicVaccinationDto);
                _db.PandemicVaccinations.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<PandemicVaccinationDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPut]
        [Route("vaccination")]
        public ResponseDto PutPandemicVaccination([FromBody] PandemicVaccinationDto pandemicVaccinationDto)
        {
            try
            {
                PandemicVaccination obj = _mapper.Map<PandemicVaccination>(pandemicVaccinationDto);
                _db.PandemicVaccinations.Update(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<PandemicVaccinationDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpDelete]
        [Route("vaccination")]
        public ResponseDto DeletePandemicVaccination(int id)
        {
            try
            {
                PandemicVaccination obj = _db.PandemicVaccinations.First(u => u.PandemicVaccinationId == id);
                _db.PandemicVaccinations.Remove(obj);
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
