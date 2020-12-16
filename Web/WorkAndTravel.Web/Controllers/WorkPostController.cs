namespace WorkAndTravel.Web.Controllers
{
    using System;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Hosting;
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
        private readonly IWebHostEnvironment environment;

        public WorkPostController(
            ICategoriesService categoriesService,
            ICountriesService countriesService,
            IWorkPostsService workPostsService,
            UserManager<ApplicationUser> userManager,
            IWebHostEnvironment environment)
        {
            this.categoriesService = categoriesService;
            this.countriesService = countriesService;
            this.workPostsService = workPostsService;
            this.userManager = userManager;
            this.environment = environment;
        }

        [Authorize]
        public IActionResult Edit(int id)
        {
            var inputModel = this.workPostsService.GetById<EditWorkPostInputModel>(id);

            inputModel.CategoryItems = this.categoriesService.GetAllAsKeyValuePairs();

            return this.View(inputModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Edit(int id, EditWorkPostInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.CategoryItems = this.categoriesService.GetAllAsKeyValuePairs();
                return this.View(input);
            }

            await this.workPostsService.EditAsync(id, input);

            return this.RedirectToAction(nameof(this.ById), new { id = id });
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

            try
            {
                await this.workPostsService.CreateAsync(input, user.Id, $"{this.environment.WebRootPath}/images");
            }
            catch (Exception ex)
            {
                this.ModelState.AddModelError(string.Empty, ex.Message);
            }

            // TODO: Redirect to post page
            return this.Redirect("/");
        }

        public IActionResult All(int id = 1)
        {
            if (id <= 0)
            {
                return this.NotFound();
            }

            const int ItemsPerPage = 8;
            var viewModel = new WorkPostsListViewModel
            {
                ItemsPerPage = ItemsPerPage,
                PageNumber = id,
                WorkPostsCount = this.workPostsService.GetCount(),
                WorkPosts = this.workPostsService.GetAll<WorkPostInListViewModel>(id, 8),
            };
            return this.View(viewModel);
        }

        public IActionResult SortByDate(int id = 1)
        {
            if (id <= 0)
            {
                return this.NotFound();
            }

            const int ItemsPerPage = 8;
            var viewModel = new WorkPostsListViewModel
            {
                ItemsPerPage = ItemsPerPage,
                PageNumber = id,
                WorkPostsCount = this.workPostsService.GetCount(),
                WorkPosts = this.workPostsService.SortByDate<WorkPostInListViewModel>(id, 8),
            };
            return this.View("All", viewModel);
        }

        public IActionResult SortByName(int id = 1)
        {
            if (id <= 0)
            {
                return this.NotFound();
            }

            const int ItemsPerPage = 8;
            var viewModel = new WorkPostsListViewModel
            {
                ItemsPerPage = ItemsPerPage,
                PageNumber = id,
                WorkPostsCount = this.workPostsService.GetCount(),
                WorkPosts = this.workPostsService.SortByName<WorkPostInListViewModel>(id, 8),
            };
            return this.View("All", viewModel);
        }

        public IActionResult SortBySalary(int id = 1)
        {
            if (id <= 0)
            {
                return this.NotFound();
            }

            const int ItemsPerPage = 8;
            var viewModel = new WorkPostsListViewModel
            {
                ItemsPerPage = ItemsPerPage,
                PageNumber = id,
                WorkPostsCount = this.workPostsService.GetCount(),
                WorkPosts = this.workPostsService.SortBySalary<WorkPostInListViewModel>(id, 8),
            };
            return this.View("All", viewModel);
        }

        public IActionResult ById(int id)
        {
            var workPost = this.workPostsService.GetById<SingleWorkPostViewModel>(id);

            return this.View(workPost);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            await this.workPostsService.DeleteAsync(id);
            return this.RedirectToAction(nameof(this.All));
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Add(int postId, string userId)
        {
            if (userId == null)
            {
                userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            }

            await this.workPostsService.AddAsync(userId, postId);
            this.TempData["Message"] = "You have successfully applied to a post. The creator will contact you via email.";
            return this.Redirect("/Account/Applications");
        }

        public IActionResult Search(string cityName)
        {
            var viewModel = new SearchInListViewModel()
            {
                WorkPosts = this.workPostsService.GetByCityName<SearchViewModel>(cityName),
            };
            return this.View(viewModel);
        }
    }
}
