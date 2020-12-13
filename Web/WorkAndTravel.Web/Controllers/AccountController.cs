namespace WorkAndTravel.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;
    using System.Threading.Tasks;
    using WorkAndTravel.Data.Models;
    using WorkAndTravel.Services.Data;
    using WorkAndTravel.Web.ViewModels.Account;
    using WorkAndTravel.Web.ViewModels.WorkPosts;

    public class AccountController : Controller
    {
        private readonly IProfilePostsService profilePostsService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IProfileService profileService;

        public AccountController(
            IProfilePostsService profilePostsService,
            UserManager<ApplicationUser> userManager,
            IProfileService profileService)
        {
            this.profilePostsService = profilePostsService;
            this.userManager = userManager;
            this.profileService = profileService;
        }

        [Authorize]
        public IActionResult MyPosts(string id)
        {
            var userId = this.userManager.GetUserId(this.User);
            if (id == null)
            {
                id = userId;
            }

            var viewModel = new ProfileViewModel()
            {
                WorkPosts = this.profilePostsService.GetAll<ProfilePostViewModel>(id),
            };

            return this.View(viewModel);
        }

        [Authorize]
        public IActionResult Index(string id)
        {
            var userId = id == null ? this.userManager.GetUserId(this.User) : id;
            var viewModel = this.profileService.GetUserId<ProfileViewModel>(userId);
            return this.View(viewModel);
        }

        [Authorize]

        public IActionResult Applications(string id)
        {
            var userId = id == null ? this.userManager.GetUserId(this.User) : id;
            var viewModel = this.profileService.GetUserAppliedToPosts<PostsListViewModel>(userId);
            return this.View(viewModel);
        }
    }
}
