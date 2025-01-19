using System.ComponentModel.DataAnnotations;

namespace RachmaninovAPI.Data.Models
{
    public class MultimediaFile : BaseModel
    {
        [Required]
        public string Url { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        public bool IsImage { get; set; }
    }
}
