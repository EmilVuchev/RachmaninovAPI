using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RachmaninovAPI.Data.Models
{
    public class Composition : BaseModel
    {
        public Composition()
        {
            this.Scores = new HashSet<Score>();
            this.Recordings = new HashSet<Recording>();
        }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

        public int? OpusNumber { get; set; }

        public DateTime WrittenOn { get; set; }

        [ForeignKey(nameof(MusicalCategory))]
        public int MusicalCategoryId { get; set; }

        public virtual MusicalCategory MusicalCategory { get; set; }

        public virtual ICollection<Score> Scores { get; set; }

        public virtual ICollection<Recording> Recordings { get; set; }
    }
}
