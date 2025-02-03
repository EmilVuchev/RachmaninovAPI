using System.ComponentModel.DataAnnotations;

namespace RachmaninovAPI.Data.Models
{
    public class Score : BaseModel
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(100)]
        public string Edition { get; set; }

        [Required]
        public string Url { get; set; }

        public virtual Composition Composition { get; set; }
    }
}