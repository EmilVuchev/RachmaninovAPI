using System.ComponentModel.DataAnnotations;

namespace RachmaninovAPI.Data.Models
{
    public class Article : BaseModel
    {
        public Article()
        {
            this.Paragraphs = new HashSet<Paragraph>();
        }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(50)]
        public string Author { get; set; }

        public virtual ICollection<Paragraph> Paragraphs { get; set; }
    }
}
