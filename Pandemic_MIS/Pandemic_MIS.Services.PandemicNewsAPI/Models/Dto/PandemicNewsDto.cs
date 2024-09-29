namespace Pandemic_MIS.Services.PandemicNewsAPI.Models.Dto
{
    public class PandemicNewsDto
    {
        public int NewsId { get; set; }
        public string Title { get; set; } 
        public string Description { get; set; } 
        public int Priority { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
