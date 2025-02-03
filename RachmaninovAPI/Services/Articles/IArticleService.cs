using RachmaninovAPI.Models.Articles;

namespace RachmaninovAPI.Services.Articles
{
    public interface IArticleService
    {
        Task<bool> AddArticle();

        Task<IList<ArticleViewModel>> GetArticlesList();
    }
}
