using System.ComponentModel.DataAnnotations;

namespace RachmaninovAPI.Data.Models
{
    public class Memoir : BaseModel
    {
        public Memoir()
        {
            this.Paragraphs = new HashSet<Paragraph>();
        }

        [Required]
        [MaxLength(30)]
        public string Author { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        public DateTime WrittenOn { get; set; }

        public DateTime WrittenIn { get; set; }

        public virtual ICollection<Paragraph> Paragraphs { get; set; }
    }
}
