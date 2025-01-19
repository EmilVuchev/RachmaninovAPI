using RachmaninovAPI.Data.Models;
using RachmaninovAPI.Models.Base;

namespace RachmaninovAPI.Models.Articles
{
    public class ArticleViewModel : IMapFrom<Article>, IMapTo<Article>
    {
        public int Id { get; set; }

        public string Title { get; set; }
    }
}
