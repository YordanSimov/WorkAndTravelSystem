namespace WorkAndTravel.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using WorkAndTravel.Services.Data;
    using WorkAndTravel.Web.ViewModels;

    public class WorkPostController : Controller
    {
        private readonly ICategoriesService categoriesService;
        private readonly ICountriesService countriesService;

        public WorkPostController(ICategoriesService categoriesService,ICountriesService countriesService)
        {
            this.categoriesService = categoriesService;
            this.countriesService = countriesService;
        }

        public IActionResult Create()
        {
            var viewModel = new CreateWorkPostsInputModel();
            viewModel.CategoryItems = this.categoriesService.GetAllAsKeyValuePairs();
            viewModel.CountryItems = this.countriesService.GetAllAsKeyValuePairs();
            return this.View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(CreateWorkPostsInputModel input)
        {

            if (!this.ModelState.IsValid)
            {
                input.CategoryItems = this.categoriesService.GetAllAsKeyValuePairs();
                input.CountryItems = this.countriesService.GetAllAsKeyValuePairs();
                return this.View(input);
            }

            // TODO: Redirect to post page
            return this.Redirect("/");
        }
    }
}