using System.ComponentModel.DataAnnotations;

namespace Pandemic_MIS.Services.PandemicNewsAPI.Models
{
    public class PandemicNews
    {
        [Key]
        public int NewsId { get; set; }
        [Required]
        public string Title { get; set; } 
        [Required]
        public string Description { get; set; }
        [Required]
        public int Priority { get; set; }
        public bool IsActive { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
