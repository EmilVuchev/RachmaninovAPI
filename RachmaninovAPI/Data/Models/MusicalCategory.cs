using System.ComponentModel.DataAnnotations;

namespace RachmaninovAPI.Data.Models
{
    public class MusicalCategory : BaseModel
    {
        public MusicalCategory()
        {
            this.Compositions = new HashSet<Composition>();
        }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Composition> Compositions { get; set; }
    }
}
