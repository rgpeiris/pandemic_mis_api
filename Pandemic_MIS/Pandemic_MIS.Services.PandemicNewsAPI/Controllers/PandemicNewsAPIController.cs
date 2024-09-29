using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using Pandemic_MIS.Services.PandemicNewsAPI.Data;
using Pandemic_MIS.Services.PandemicNewsAPI.Models;
using Pandemic_MIS.Services.PandemicNewsAPI.Models.Dto;

namespace Pandemic_MIS.Services.PandemicNewsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PandemicNewsAPIController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDto _response; 
        private IMapper _mapper;

        public PandemicNewsAPIController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new ResponseDto();
        }

        [HttpGet]
        [Route("pandemic-news")]
        public ResponseDto GetAllPandemicNews()
        {
            try 
            { 
                IEnumerable<PandemicNews> objList = _db.PandemicNews.OrderByDescending(x => x.CreatedDate).ToList();
                _response.Result = _mapper.Map<IEnumerable<PandemicNewsDto>>(objList);
            }
            catch (Exception ex) 
            { 
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("pandemic-news/public")]
        public ResponseDto GetAllPublicPandemicNews()
        {
            try
            {
                IEnumerable<PandemicNews> objList = _db.PandemicNews.OrderBy(x => x.Priority).ToList();
                _response.Result = _mapper.Map<IEnumerable<PandemicNewsDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("pandemic-news/{id:int}")]
        public ResponseDto GetPandemicNewsById(int id)
        {
            try
            {
                PandemicNews obj = _db.PandemicNews.First(u => u.NewsId == id);
                _response.Result = _mapper.Map<PandemicNewsDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("pandemic-news/{title}")]
        public ResponseDto GetPandemicNewsByTitle(string title)
        {
            try
            {
                PandemicNews obj = _db.PandemicNews.FirstOrDefault(u => u.Title.ToLower().Contains(title.ToLower()));
                _response.Result = _mapper.Map<PandemicNewsDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPost]
        [Route("pandemic-news")]
        public ResponseDto PostPandemicNews([FromBody] PandemicNewsDto pandemicNewsDto)
        {
            try
            {
                PandemicNews obj = _mapper.Map<PandemicNews>(pandemicNewsDto);
                _db.PandemicNews.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<PandemicNewsDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPut]
        [Route("pandemic-news")]
        public ResponseDto PutPandemicNews([FromBody] PandemicNewsDto pandemicNewsDto)
        {
            try
            {
                PandemicNews obj = _mapper.Map<PandemicNews>(pandemicNewsDto);
                _db.PandemicNews.Update(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<PandemicNewsDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpDelete]
        [Route("pandemic-news")]
        public ResponseDto DeletePandemicNews(int id)
        {
            try
            {
                PandemicNews obj = _db.PandemicNews.First(u => u.NewsId == id);
                _db.PandemicNews.Remove(obj);
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
        [Route("pandemic-news-report")]
        public List<PandemicNews> GetAllPandemicNewsReport()
        {  
            var query = from a in _db.PandemicNews
                        select new
                        {
                            a.NewsId,
                            a.Title,
                            a.Description,
                            a.Priority,
                            a.IsActive,
                            a.CreatedBy,
                            a.CreatedDate
                        };
            List<PandemicNews> testList = new List<PandemicNews>();

            foreach (var item in query)
            {
                var element = new PandemicNews();
                element.NewsId = item.NewsId;
                element.Title = item.Title;
                element.Description = item.Description;
                element.Priority = item.Priority;
                element.IsActive = item.IsActive;
                element.CreatedBy = item.CreatedBy;
                element.CreatedDate = item.CreatedDate;
                testList.Add(element);
            }

            return testList;
        }

        [HttpGet]
        [Route("generate-report")]
        public async Task<ActionResult> GenerateExcel()
        {
            string filePathName = Path.Combine(Directory.GetCurrentDirectory(), "Upload\\reports", "PandemicNewsReport"+DateTime.Now.Ticks.ToString()+".xls");

            List<PandemicNews> res = GetAllPandemicNewsReport();

            string htmlstring = "<table><thead><tr>";
            htmlstring += "<th>News ID<th>";
            htmlstring += "<th>Title</th>";
            htmlstring += "<th>Description</th>";
            htmlstring += "<th>Priority</th>";
            htmlstring += "<th>Status</th>";
            htmlstring += "<th>Created By</th>";
            htmlstring += "<th>Created Date</th>";
            htmlstring += "</tr></thead> <tbody>";

            foreach (PandemicNews obj in res)
            {
                htmlstring += "<tr><td> " + obj.NewsId + " </td> ";
                htmlstring += "<td> " + obj.Title + " </td> ";
                htmlstring += "<td> " + obj.Description + " </td> ";
                htmlstring += "<td> " + obj.Priority + " </td> ";
                htmlstring += "<td> " + obj.IsActive + " </td> ";
                htmlstring += "<td> " + obj.CreatedBy + " </td> ";
                htmlstring += "<td> " + obj.CreatedDate + " </td></tr> ";
            }

            htmlstring += "</tbody></table>";

            System.IO.File.AppendAllText(filePathName, htmlstring);

            var provider = new FileExtensionContentTypeProvider();
            if(!provider.TryGetContentType(filePathName, out var contentType))
            {
                contentType = "application/octet-stream";
            }

            var bytes = await System.IO.File.ReadAllBytesAsync(filePathName);
            return File(bytes, contentType, Path.GetFileName(filePathName));
        }
    }
}
