namespace WorkAndTravel.Web.Controllers
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using WorkAndTravel.Data.Models;
    using WorkAndTravel.Services.Data;
    using WorkAndTravel.Web.ViewModels.Account;

    public class AccountController : Controller
    {
        private readonly IProfilePostsService profilePostsService;
        private readonly UserManager<ApplicationUser> userManager;

        public AccountController(IProfilePostsService profilePostsService,
            UserManager<ApplicationUser> userManager)
        {
            this.profilePostsService = profilePostsService;
            this.userManager = userManager;
        }

        public IActionResult Index(string id)
        {
            var userId = this.userManager.GetUserId(this.User);
            if (id == null)
            {
                id = userId;
            }

           // var workPosts = this.profilePostsService.GetAll<ProfilePostViewModel>(id);

            var viewModel = new ProfileViewModel()
            {
                WorkPosts = this.profilePostsService.GetAll<ProfilePostViewModel>(id),
            };

            return this.View(viewModel);
        }
    }
}
