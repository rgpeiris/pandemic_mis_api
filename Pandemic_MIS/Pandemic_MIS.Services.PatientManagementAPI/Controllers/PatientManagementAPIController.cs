using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pandemic_MIS.Services.PatientManagementAPI.Data;
using Pandemic_MIS.Services.PatientManagementAPI.Models;
using Pandemic_MIS.Services.PatientManagementAPI.Models.Dto;
using System;

namespace Pandemic_MIS.Services.PatientManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientManagementAPIController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDto _response;
        private IMapper _mapper;

        public PatientManagementAPIController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new ResponseDto();
        }

        [HttpGet]
        [Route("healthcare-professionals")]
        public ResponseDto GetAllHealthcareProfessionals()
        {
            try
            {
                var query = from a in _db.HealthcareProfessionals
                            join b in _db.Hospitals
                            on a.AssignedHospital equals b.HospitalId
                            orderby a.CreatedDate descending
                            select new
                            {
                                a.HealthcareProfessionalId,
                                a.HealthcareProfessionalName,
                                a.MedicalSpecialty,
                                a.AssignedHospital,
                                a.PhoneNumber,
                                a.AssignedUsername,
                                b.HospitalName,
                                a.IsActive,
                                a.CreatedBy,
                                a.CreatedDate
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
        [Route("healthcare-professional/{id:int}")]
        public ResponseDto GetHealthcareProfessionalById(int id)
        {
            try
            {
                HealthcareProfessional obj = _db.HealthcareProfessionals.First(u => u.HealthcareProfessionalId == id);
                _response.Result = _mapper.Map<HealthcareProfessionalDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("healthcare-professional/{name}")]
        public ResponseDto GetHealthcareProfessionalByName(string name)
        {
            try
            {
                IEnumerable<HealthcareProfessional> objList = _db.HealthcareProfessionals.Where(u => u.HealthcareProfessionalName.ToLower().Contains(name.ToLower()));
                _response.Result = _mapper.Map<IEnumerable<HealthcareProfessionalDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPost]
        [Route("healthcare-professional")]
        public ResponseDto PostHealthcareProfessional([FromBody] HealthcareProfessionalDto healthcareProfessionalDto)
        {
            try
            {
                HealthcareProfessional obj = _mapper.Map<HealthcareProfessional>(healthcareProfessionalDto);
                _db.HealthcareProfessionals.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<HealthcareProfessionalDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPut]
        [Route("healthcare-professional")]
        public ResponseDto PutHealthcareProfessional([FromBody] HealthcareProfessionalDto healthcareProfessionalDto)
        {
            try
            {
                HealthcareProfessional obj = _mapper.Map<HealthcareProfessional>(healthcareProfessionalDto);
                _db.HealthcareProfessionals.Update(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<HealthcareProfessionalDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpDelete]
        [Route("healthcare-professional")]
        public ResponseDto DeleteHealthcareProfessional(int id)
        {
            try
            {
                HealthcareProfessional obj = _db.HealthcareProfessionals.First(u => u.HealthcareProfessionalId == id);
                _db.HealthcareProfessionals.Remove(obj);
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
        [Route("hospitals")]
        public ResponseDto GetAllHospitals()
        {
            try
            {
                IEnumerable<Hospital> objList = _db.Hospitals.OrderByDescending(x => x.CreatedDate).ToList();
                _response.Result = _mapper.Map<IEnumerable<HospitalDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("hospital/{id:int}")]
        public ResponseDto GetHospitalById(int id)
        {
            try
            {
                Hospital obj = _db.Hospitals.First(u => u.HospitalId == id);
                _response.Result = _mapper.Map<HospitalDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("hospital/{name}")]
        public ResponseDto GetHospitalByName(string name)
        {
            try
            {
                IEnumerable<Hospital> objList = _db.Hospitals.Where(u => u.HospitalName.ToLower().Contains(name.ToLower()));
                _response.Result = _mapper.Map<IEnumerable<HospitalDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPost]
        [Route("hospital")]
        public ResponseDto PostHospital([FromBody] HospitalDto hospitalDto)
        {
            try
            {
                Hospital obj = _mapper.Map<Hospital>(hospitalDto);
                _db.Hospitals.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<HospitalDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPut]
        [Route("hospital")]
        public ResponseDto PutHospital([FromBody] HospitalDto hospitalDto)
        {
            try
            {
                Hospital obj = _mapper.Map<Hospital>(hospitalDto);
                _db.Hospitals.Update(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<HospitalDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpDelete]
        [Route("hospital")]
        public ResponseDto DeleteHospital(int id)
        {
            try
            {
                Hospital obj = _db.Hospitals.First(u => u.HospitalId == id);
                _db.Hospitals.Remove(obj);
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
        [Route("local-government-in-chargers")]
        public ResponseDto GetAllLocalGovernmentInCharge()
        {
            try
            {
                IEnumerable<LocalGovernmentInCharge> objList = _db.LocalGovernmentInCharge.OrderByDescending(x => x.CreatedDate).ToList();
                _response.Result = _mapper.Map<IEnumerable<LocalGovernmentInChargeDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("local-government-in-charge/{id:int}")]
        public ResponseDto GetLocalGovernmentInChargeById(int id)
        {
            try
            {
                LocalGovernmentInCharge obj = _db.LocalGovernmentInCharge.First(u => u.LocalGovernmentInChargeId == id);
                _response.Result = _mapper.Map<LocalGovernmentInChargeDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("local-government-in-charge/{name}")]
        public ResponseDto GetLocalGovernmentInChargeByName(string name)
        {
            try
            {
                IEnumerable<LocalGovernmentInCharge> objList = _db.LocalGovernmentInCharge.Where(u => u.LocalGovernmentInChargeName.ToLower().Contains(name.ToLower()));
                _response.Result = _mapper.Map<IEnumerable<LocalGovernmentInChargeDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPost]
        [Route("local-government-in-charge")]
        public ResponseDto PostLocalGovernmentInCharge([FromBody] LocalGovernmentInChargeDto localGovernmentInChargeDto)
        {
            try
            {
                LocalGovernmentInCharge obj = _mapper.Map<LocalGovernmentInCharge>(localGovernmentInChargeDto);
                _db.LocalGovernmentInCharge.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<LocalGovernmentInChargeDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPut]
        [Route("local-government-in-charge")]
        public ResponseDto PutLocalGovernmentInCharge([FromBody] LocalGovernmentInChargeDto localGovernmentInChargeDto)
        {
            try
            {
                LocalGovernmentInCharge obj = _mapper.Map<LocalGovernmentInCharge>(localGovernmentInChargeDto);
                _db.LocalGovernmentInCharge.Update(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<LocalGovernmentInChargeDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpDelete]
        [Route("local-government-in-charge")]
        public ResponseDto DeleteLocalGovernmentInCharge(int id)
        {
            try
            {
                LocalGovernmentInCharge obj = _db.LocalGovernmentInCharge.First(u => u.LocalGovernmentInChargeId == id);
                _db.LocalGovernmentInCharge.Remove(obj);
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
        [Route("pandemic-patients")]
        public ResponseDto GetAllPandemicPatients()
        {
            try
            {
                IEnumerable<PandemicPatient> objList = _db.PandemicPatients.ToList();
                _response.Result = _mapper.Map<IEnumerable<PandemicPatientDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("pandemic-patients-overall-stats")]
        public ResponseDto GetPandemicPatientsOverallStats()
        {
            try
            {
                var query = from a in _db.PandemicPatients
                            group a by new
                            {
                                a.Status                               
                            } into pat
                            select new
                            {
                                pat.Key.Status,
                                Count = pat.Count()
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
        [Route("pandemic-patients-monthly-confirmed-stats")]
        public ResponseDto GetPandemicPatientsMonthlyConfirmedStats()
        {
            try
            {
                var query = from a in _db.PandemicPatients 
                            where a.ConfirmedDate.Year == 2024
                            group a by new
                            {
                                a.ConfirmedDate.Month
                            } into pat
                            select new
                            {
                                pat.Key.Month,
                                Count = pat.Count()
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
        [Route("pandemic-patient/{id:int}")]
        public ResponseDto GetPatientById(int id)
        {
            try
            {
                PandemicPatient obj = _db.PandemicPatients.First(u => u.PatientId == id);
                _response.Result = _mapper.Map<PandemicPatientDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("pandemic-patient/{name}")]
        public ResponseDto GetPatientByName(string name)
        {
            try
            {
                IEnumerable<PandemicPatient> objList = _db.PandemicPatients.Where(u => u.PatientName.ToLower().Contains(name.ToLower()));
                _response.Result = _mapper.Map<IEnumerable<PandemicPatientDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("pandemic-patient-by-guardian")]
        public ResponseDto GetPatientByGuardian(string username)
        {
            try
            {
                var query = from a in _db.PandemicPatients
                            join b in _db.HealthcareProfessionals
                            on a.HealthcareProfessionalInCharge equals b.AssignedUsername
                            where a.GuardianAssignedUsername == username && (a.Status == "Registration Completed" || a.Status == "Home Quarantined" || a.Status == "Hospitalized" || a.Status == "Approval Pending")
                            orderby a.CreatedDate descending
                            select new
                            {
                                a.PatientId,
                                a.PatientName,
                                a.NICNumber,
                                a.ConfirmedDate,
                                b.PhoneNumber,
                                b.HealthcareProfessionalName,                                
                                a.Status,
                                a.CreatedBy,
                                a.CreatedDate
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
        [Route("pandemic-patients/{governmentInCharge}")]
        public ResponseDto GetPatientByLocalInCharge(string governmentInCharge)
        {
            try
            {
                IEnumerable<PandemicPatient> objList = _db.PandemicPatients.Where(u => u.LocalGovernmentInCharge == governmentInCharge && u.Status == "Approval Pending");
                _response.Result = _mapper.Map<IEnumerable<PandemicPatientDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("pandemic-patients-by-healthcare-professional")]
        public ResponseDto GetPatientByHealthcareProfessional(string healthcareProfessional)
        {
            try
            {
                IEnumerable<PandemicPatient> objList = _db.PandemicPatients.Where(u => u.HealthcareProfessionalInCharge == healthcareProfessional);
                _response.Result = _mapper.Map<IEnumerable<PandemicPatientDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPost]
        [Route("pandemic-patient")]
        public ResponseDto PostPatient([FromBody] PandemicPatientDto pandemicPatientDto)
        {
            try
            {
                PandemicPatient obj = _mapper.Map<PandemicPatient>(pandemicPatientDto);
                _db.PandemicPatients.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<PandemicPatientDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPut]
        [Route("pandemic-patient")]
        public ResponseDto PutPatient([FromBody] PandemicPatientDto pandemicPatientDto)
        {
            try
            {
                PandemicPatient obj = _mapper.Map<PandemicPatient>(pandemicPatientDto);
                _db.PandemicPatients.Update(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<PandemicPatientDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpDelete]
        [Route("pandemic-patient")]
        public ResponseDto DeletePatient(int id)
        {
            try
            {
                PandemicPatient obj = _db.PandemicPatients.First(u => u.PatientId == id);
                _db.PandemicPatients.Remove(obj);
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
        [Route("patient-medical-histories")]
        public ResponseDto GetAllPatientMedicalHistories()
        {
            try
            {
                IEnumerable<PatientMedicalHistory> objList = _db.PatientMedicalHistories.ToList();
                _response.Result = _mapper.Map<IEnumerable<PatientMedicalHistoryDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("patient-medical-history/{patientId}")]
        public ResponseDto GetPatientMedicalHistoryById(int patientId)
        {
            try
            {
                //IEnumerable<PatientMedicalHistory> objList = _db.PatientMedicalHistories.Where(u => u.PatientId.Equals(patientId));
                //_response.Result = _mapper.Map<IEnumerable<PatientMedicalHistoryDto>>(objList);

                var query = from a in _db.PatientMedicalHistories
                            join b in _db.HealthcareProfessionals
                            on a.ExaminedBy equals b.AssignedUsername
                            where a.PatientId == patientId
                            orderby a.ExaminedDate descending
                            select new
                            {
                                a.PatientMedicalHistoryId,
                                a.PatientId,
                                a.ExaminedDate,
                                a.ExaminedBy,
                                a.DiagnosisSummary,
                                a.Treatments,
                                b.HealthcareProfessionalName,
                                a.Remarks,
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
        [Route("patient-medical-history")]
        public ResponseDto PostPatientMedicalHistory([FromBody] PatientMedicalHistoryDto patientMedicalHistoryDto)
        {
            try
            {
                PatientMedicalHistory obj = _mapper.Map<PatientMedicalHistory>(patientMedicalHistoryDto);
                _db.PatientMedicalHistories.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<PatientMedicalHistoryDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPut]
        [Route("patient-medical-history")]
        public ResponseDto PutPatientMedicalHistory([FromBody] PatientMedicalHistoryDto patientMedicalHistoryDto)
        {
            try
            {
                PatientMedicalHistory obj = _mapper.Map<PatientMedicalHistory>(patientMedicalHistoryDto);
                _db.PatientMedicalHistories.Update(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<PatientMedicalHistoryDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpDelete]
        [Route("patient-medical-history")]
        public ResponseDto DeletePatientMedicalHistory(int id)
        {
            try
            {
                PatientMedicalHistory obj = _db.PatientMedicalHistories.First(u => u.PatientMedicalHistoryId == id);
                _db.PatientMedicalHistories.Remove(obj);
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
