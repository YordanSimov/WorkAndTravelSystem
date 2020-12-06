namespace WorkAndTravel.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using WorkAndTravel.Data.Models;
    using WorkAndTravel.Services.Data;
    using WorkAndTravel.Web.ViewModels.Comment;

    public class CommentsController : Controller
    {
        private readonly ICommentsService commentsService;
        private readonly UserManager<ApplicationUser> userManager;

        public CommentsController(
            ICommentsService commentsService,
            UserManager<ApplicationUser> userManager)
        {
            this.commentsService = commentsService;
            this.userManager = userManager;
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CreateCommentInputModel input)
        {
            int? parentId = input.ParentId == 0 ? null : input.ParentId;

            if (parentId.HasValue)
            {
                if (!this.commentsService.IsInPostId(parentId.Value, input.WorkPostId))
                {
                    return this.BadRequest();
                }
            }

       // TODO: da se proveri za id - to ot html da ne se smeni
            var userId = this.userManager.GetUserId(this.User);
            await this.commentsService.Create(input.WorkPostId, userId, input.Content, parentId);

            return this.RedirectToAction("ById", "WorkPost", new { id = input.WorkPostId });
        }
    }
}
