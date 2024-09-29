using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pandemic_MIS.Services.OrganizationManagementAPI.Data;
using Pandemic_MIS.Services.OrganizationManagementAPI.Models;
using Pandemic_MIS.Services.OrganizationManagementAPI.Models.Dto;
using System.Collections.Generic;

namespace Pandemic_MIS.Services.OrganizationManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationManagementAPIController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDto _response;
        private IMapper _mapper;

        public OrganizationManagementAPIController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new ResponseDto();
        }

        [HttpGet]
        [Route("organizations")]
        public ResponseDto GetAllOrganizations()
        {
            try
            {
                IEnumerable<Organization> objList = _db.Organizations.OrderByDescending(x => x.CreatedDate).ToList();
                _response.Result = _mapper.Map<IEnumerable<OrganizationDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("organization/{id:int}")]
        public ResponseDto GetOrganizationById(int id)
        {
            try
            {
                Organization obj = _db.Organizations.First(u => u.OrganizationId == id);
                _response.Result = _mapper.Map<OrganizationDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("organization/{name}")]
        public ResponseDto GetOrganizationByName(string name)
        {
            try
            {
                Organization obj = _db.Organizations.FirstOrDefault(u => u.OrganizationName.ToLower().Contains(name.ToLower()));
                _response.Result = _mapper.Map<OrganizationDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPost]
        [Route("organization")]
        public ResponseDto PostOrganization([FromBody] OrganizationDto pandemicNewsDto)
        {
            try
            {
                Organization obj = _mapper.Map<Organization>(pandemicNewsDto);
                _db.Organizations.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<OrganizationDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPut]
        [Route("organization")]
        public ResponseDto PutOrganization([FromBody] OrganizationDto pandemicNewsDto)
        {
            try
            {
                Organization obj = _mapper.Map<Organization>(pandemicNewsDto);
                _db.Organizations.Update(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<OrganizationDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpDelete]
        [Route("organization")]
        public ResponseDto DeleteOrganization(int id)
        {
            try
            {
                Organization obj = _db.Organizations.First(u => u.OrganizationId == id);
                _db.Organizations.Remove(obj);
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
        [Route("pandemic-contacts")]
        public ResponseDto GetAllPandemicContacts()
        {
            try
            {
                

                var query = from a in _db.PandemicContacts
                            join b in _db.Organizations
                            on a.OrganizationId equals b.OrganizationId
                            orderby a.CreatedDate descending
                            select new
                            {
                                a.PandemicContactId,
                                a.NicNumber,
                                a.Name, 
                                a.Address,
                                a.PhoneNumber,
                                a.CheckInTime,
                                a.CheckOutTime,
                                a.OrganizationId,
                                b.OrganizationName,
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
        [Route("pandemic-contact/{id:int}")]
        public ResponseDto GetPandemicContactById(int id)
        {
            try
            {
                PandemicContact obj = _db.PandemicContacts.First(u => u.PandemicContactId == id);
                _response.Result = _mapper.Map<PandemicContactDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("pandemic-contact")]
        public ResponseDto GetPandemicContactByOrganizationId(int organizationId)
        {
            try
            {
                var query = from a in _db.PandemicContacts
                            join b in _db.Organizations
                            on a.OrganizationId equals b.OrganizationId
                            where a.OrganizationId == organizationId
                            orderby a.CreatedDate descending
                            select new
                            {
                                a.PandemicContactId,
                                a.NicNumber,
                                a.Name,
                                a.Address,
                                a.PhoneNumber,
                                a.CheckInTime,
                                a.CheckOutTime,
                                a.OrganizationId,
                                b.OrganizationName,
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
        [Route("pandemic-contact/{nicNumber}")]
        public ResponseDto GetPandemicContactByNic(string nicNumber)
        {
            try
            {
                PandemicContact obj = _db.PandemicContacts.FirstOrDefault(u => u.NicNumber == nicNumber);
                _response.Result = _mapper.Map<PandemicContactDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPost]
        [Route("pandemic-contact")]
        public ResponseDto PostPandemicContact([FromBody] PandemicContactDto pandemicContactDto)
        {
            try
            {
                PandemicContact obj = _mapper.Map<PandemicContact>(pandemicContactDto);
                _db.PandemicContacts.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<PandemicContactDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPut]
        [Route("pandemic-contact")]
        public ResponseDto PutPandemicContact([FromBody] PandemicContactDto pandemicContactDto)
        {
            try
            {
                PandemicContact obj = _mapper.Map<PandemicContact>(pandemicContactDto);
                _db.PandemicContacts.Update(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<PandemicContactDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpDelete]
        [Route("pandemic-contact")]
        public ResponseDto DeletePandemicContact(int id)
        {
            try
            {
                PandemicContact obj = _db.PandemicContacts.First(u => u.PandemicContactId == id);
                _db.PandemicContacts.Remove(obj);
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
        [Route("complaints")]
        public ResponseDto GetAllComplaints()
        {
            try
            {
                IEnumerable<Complaint> objList = _db.Complaints.OrderByDescending(x => x.CreatedDate).ToList();
                _response.Result = _mapper.Map<IEnumerable<ComplaintDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPost]
        [Route("complaint")]
        public ResponseDto PostComplaint([FromBody] ComplaintDto complaintDto)
        {
            try
            {
                Complaint obj = _mapper.Map<Complaint>(complaintDto);
                _db.Complaints.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<ComplaintDto>(obj);
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
