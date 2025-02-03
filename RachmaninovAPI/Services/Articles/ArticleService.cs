using Microsoft.EntityFrameworkCore;
using RachmaninovAPI.Data;
using RachmaninovAPI.Data.Models;
using RachmaninovAPI.Models.Articles;
using RachmaninovAPI.Extensions;

namespace RachmaninovAPI.Services.Articles
{
    public class ArticleService : IArticleService
    {
        private readonly ApplicationDbContext dbContext;

        public ArticleService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<bool> AddArticle()
        {
            //var article = new Article()
            //{
            //    Author = "Test",
            //    Title = "Test1",
            //    Paragraphs = new List<Paragraph> { new Paragraph { Order = 1, Content = "Tests111", Title = "Test Paragraph Title"} },
            //};

            //await this.dbContext.AddAsync(article);
            //await this.dbContext.SaveChangesAsync();

            //var articlesViewModels = await GetArticlesList();
            //foreach (var articleViewModel in articlesViewModels)
            //{
            //    var asd = articleViewModel.To<Article>();
            //}

            return true;
        }

        public async Task<IList<ArticleViewModel>> GetArticlesList()
            => await dbContext.Articles.To<ArticleViewModel>().ToListAsync();
    }
}
