using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkAndTravel.Data.Common.Repositories;
using WorkAndTravel.Data.Models;
using WorkAndTravel.Web.ViewModels.Home;

namespace WorkAndTravel.Services.Data
{
    public class GetCountsService : IGetCountsService
    {
        private readonly IDeletableEntityRepository<WorkPost> workpostRepository;
        private readonly IRepository<Category> categoriesRepository;
        private readonly IRepository<Country> countriesRepository;
        private readonly IRepository<City> citiesRepository;

        public GetCountsService(
            IDeletableEntityRepository<WorkPost> workpostRepository,
            IRepository<Category> categoriesRepository,
            IRepository<Country> countriesRepository,
            IRepository<City> citiesRepository)
        {
            this.workpostRepository = workpostRepository;
            this.categoriesRepository = categoriesRepository;
            this.countriesRepository = countriesRepository;
            this.citiesRepository = citiesRepository;
        }

        public IndexViewModel GetCounts()
        {
            var data = new IndexViewModel()
            {
                CategoriesCount = this.categoriesRepository.All().Count(),
                WorkPostsCount = this.workpostRepository.All().Count(),
                CountriesCount = this.countriesRepository.All().Count(),
                CitiesCount = this.citiesRepository.All().Count(),
            };

            return data;
        }
    }
}
