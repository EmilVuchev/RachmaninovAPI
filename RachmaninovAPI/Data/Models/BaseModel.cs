using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace RachmaninovAPI.Data.Models
{
    public class BaseModel
    {
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        //[ForeignKey(nameof(CreatedBy))]
        //public string CreatedById { get; set; }

        //public IdentityUser CreatedBy { get; set; }

        //[ForeignKey(nameof(UpdatedBy))]
        //public string? UpdatedById { get; set; }

        //public IdentityUser UpdatedBy { get; set; }
    }
}
