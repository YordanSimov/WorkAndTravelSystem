namespace WorkAndTravel.Web.Controllers
{
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using WorkAndTravel.Services.Data;
    using WorkAndTravel.Web.ViewModels.Ratings;

    [ApiController]
    [Route("api/[controller]")]
    public class RatingsController : BaseController
    {
        private readonly IRatingsService ratingsService;

        public RatingsController(IRatingsService ratingsService)
        {
            this.ratingsService = ratingsService;
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<PostRatingViewModel>> Post(PostRatingInputModel input)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            await this.ratingsService.SetRatingAsync(input.WorkPostId, userId, input.Value);
            var averageRatings = this.ratingsService.GetAverageRating(input.WorkPostId);
            return new PostRatingViewModel { AverageRating = averageRatings };
        }
    }
}
