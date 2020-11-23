﻿namespace WorkAndTravel.Web.Controllers
{
    using System;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.ModelBinding;
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
