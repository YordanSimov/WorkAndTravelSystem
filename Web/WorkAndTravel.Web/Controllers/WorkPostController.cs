namespace WorkAndTravel.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using WorkAndTravel.Data.Models;
    using WorkAndTravel.Services.Data;
    using WorkAndTravel.Web.ViewModels;
    using WorkAndTravel.Web.ViewModels.WorkPosts;

    public class WorkPostController : Controller
    {
        private readonly ICategoriesService categoriesService;
        private readonly ICountriesService countriesService;
        private readonly IWorkPostsService workPostsService;
        private readonly UserManager<ApplicationUser> userManager;

        public WorkPostController(
            ICategoriesService categoriesService,
            ICountriesService countriesService,
            IWorkPostsService workPostsService,
            UserManager<ApplicationUser> userManager)
        {
            this.categoriesService = categoriesService;
            this.countriesService = countriesService;
            this.workPostsService = workPostsService;
            this.userManager = userManager;
        }

        [Authorize]
        public IActionResult Create()
        {
            var viewModel = new CreateWorkPostsInputModel();
            viewModel.CategoryItems = this.categoriesService.GetAllAsKeyValuePairs();
            viewModel.CountryItems = this.countriesService.GetAllAsKeyValuePairs();
            return this.View(viewModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CreateWorkPostsInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.CategoryItems = this.categoriesService.GetAllAsKeyValuePairs();
                input.CountryItems = this.countriesService.GetAllAsKeyValuePairs();
                return this.View(input);
            }

            var user = await this.userManager.GetUserAsync(this.User);
            await this.workPostsService.CreateAsync(input, user.Id);

            // TODO: Redirect to post page
            return this.Redirect("/");
        }

        public IActionResult All(int id = 1)
        {
            if (id <= 0)
            {
                return this.NotFound();
            }

            const int ItemsPerPage = 12;
            var viewModel = new WorkPostsListViewModel
            {
                ItemsPerPage = ItemsPerPage,
                PageNumber = id,
                WorkPostsCount = this.workPostsService.GetCount(),
                WorkPosts = this.workPostsService.GetAll<WorkPostInListViewModel>(id, 12),
            };
            return this.View(viewModel);
        }
    }
}