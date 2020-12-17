namespace WorkAndTravel.Web.Controllers
{
    using System.Diagnostics;

    using Microsoft.AspNetCore.Mvc;
    using WorkAndTravel.Services.Data;
    using WorkAndTravel.Web.ViewModels;
    using WorkAndTravel.Web.ViewModels.Home;

    public class HomeController : BaseController
    {
        private readonly IWorkPostsService workPostsService;
        private readonly IGetCountsService getCountsService;

        public HomeController(
            IWorkPostsService workPostsService,
            IGetCountsService getCountsService)
        {
            this.workPostsService = workPostsService;
            this.getCountsService = getCountsService;
        }

        public IActionResult Index()
        {
            var viewModel = new WorkPostsForIndexViewModel()
            {
                CitiesCount = this.getCountsService.GetCitiesCounts(),
                CountriesCount = this.getCountsService.GetCountriesCounts(),
                WorkPostsCount = this.getCountsService.GetPostsCounts(),
                WorkPosts = this.workPostsService.GetTopThreePosts<IndexViewModel>(),
            };

            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
