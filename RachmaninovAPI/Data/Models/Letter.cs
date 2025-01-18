using System.ComponentModel.DataAnnotations;

namespace RachmaninovAPI.Data.Models
{
    public class Letter : BaseModel
    {
        public Letter()
        {
            this.Paragraphs = new HashSet<Paragraph>();
        }

        [Required]
        [MaxLength(50)]
        public string To { get; set; }

        public DateTime WrittenOn { get; set; }

        [MaxLength(30)]
        public string WrittenIn { get; set; }

        public virtual ICollection<Paragraph> Paragraphs { get; set; }
    }
}
