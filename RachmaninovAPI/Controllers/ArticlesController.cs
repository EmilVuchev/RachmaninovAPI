using Microsoft.AspNetCore.Mvc;
using RachmaninovAPI.Models.Articles;
using RachmaninovAPI.Services.Articles;

namespace RachmaninovAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleService articleService;

        public ArticlesController(IArticleService articleService)
        {
            this.articleService = articleService;
        }

        [HttpGet(Name = nameof(GetArticlesList))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IList<ArticleViewModel>>> GetArticlesList()
        {
            var articlesList = await this.articleService.GetArticlesList();

            if (articlesList.Count == 0)
                return this.NotFound("There is no articles!");

            return this.Ok(articlesList);
        }

        [HttpPost(Name = nameof(AddArticle))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<bool>> AddArticle()
        {
            var isAdded = await this.articleService.AddArticle();

            if (!isAdded)
                return this.BadRequest();

            return this.Ok(isAdded);
        }
    }
}
