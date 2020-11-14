namespace WorkAndTravel.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using WorkAndTravel.Services.Data;
    using WorkAndTravel.Web.ViewModels;

    public class WorkPostController : Controller
    {
        private readonly ICategoriesService categoriesService;
        private readonly ICountriesService countriesService;
        private readonly IWorkPostsService workPostsService;

        public WorkPostController(
            ICategoriesService categoriesService,
            ICountriesService countriesService,
            IWorkPostsService workPostsService)
        {
            this.categoriesService = categoriesService;
            this.countriesService = countriesService;
            this.workPostsService = workPostsService;
        }

        public IActionResult Create()
        {
            var viewModel = new CreateWorkPostsInputModel();
            viewModel.CategoryItems = this.categoriesService.GetAllAsKeyValuePairs();
            viewModel.CountryItems = this.countriesService.GetAllAsKeyValuePairs();
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateWorkPostsInputModel input)
        {

            if (!this.ModelState.IsValid)
            {
                input.CategoryItems = this.categoriesService.GetAllAsKeyValuePairs();
                input.CountryItems = this.countriesService.GetAllAsKeyValuePairs();
                return this.View(input);
            }

            await this.workPostsService.CreateAsync(input);

            // TODO: Redirect to post page
            return this.Redirect("/");
        }
    }
}