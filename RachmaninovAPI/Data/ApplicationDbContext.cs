using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RachmaninovAPI.Data.Models;

namespace RachmaninovAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Article> Articles { get; set; }

        public virtual DbSet<Composition> Compositions { get; set; }

        public virtual DbSet<Letter> Letters { get; set; }

        public virtual DbSet<Memoir> Memoirs { get; set; }

        public virtual DbSet<MusicalCategory> MusicalCategories { get; set; }

        public virtual DbSet<Paragraph> Paragraphs { get; set; }

        public virtual DbSet<Recording> Recordings { get; set; }

        public virtual DbSet<Score> Scores { get; set; }

        public virtual DbSet<MultimediaFile> MultimediaFiles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
