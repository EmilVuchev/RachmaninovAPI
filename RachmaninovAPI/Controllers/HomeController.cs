using Microsoft.AspNetCore.Mvc;

namespace RachmaninovAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        public HomeController()
        {
        }

        /// <summary>
        /// Gets home page data.
        /// </summary>
        /// <returns>Some data.</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Index()
        {
            return this.Ok();
        }
    }
}
