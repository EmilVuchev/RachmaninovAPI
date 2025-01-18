using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RachmaninovAPI.Data.Models
{
    public class Recording : BaseModel
    {
        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

        public DateTime RecordedOn { get; set; }

        [Required]
        [MaxLength(100)]
        public string Url { get; set; }

        [ForeignKey(nameof(Composition))]
        public int CompositionId { get; set; }

        public virtual Composition Composition { get; set; }
    }
}