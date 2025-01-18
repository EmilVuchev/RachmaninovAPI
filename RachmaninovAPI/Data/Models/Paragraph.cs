using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RachmaninovAPI.Data.Models
{
    public class Paragraph : BaseModel
    {
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Content { get; set; }

        public bool IsPoem { get; set; }

        public int Order { get; set; }

        [ForeignKey(nameof(Memoir))]
        public int? MemoirId { get; set; }

        public virtual Memoir Memoir { get; set; }

        [ForeignKey(nameof(Article))]
        public int? ArticleId { get; set; }

        public virtual Article Article { get; set; }

        //Image
    }
}