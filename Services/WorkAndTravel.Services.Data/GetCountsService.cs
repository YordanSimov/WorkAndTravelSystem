namespace WorkAndTravel.Services.Data
{
    using System.Linq;

    using WorkAndTravel.Data.Common.Repositories;
    using WorkAndTravel.Data.Models;
    using WorkAndTravel.Web.ViewModels.Home;

    public class GetCountsService : IGetCountsService
    {
        private readonly IDeletableEntityRepository<WorkPost> workpostRepository;
        private readonly IRepository<Country> countriesRepository;
        private readonly IRepository<City> citiesRepository;

        public GetCountsService(
            IDeletableEntityRepository<WorkPost> workpostRepository,
            IRepository<Country> countriesRepository,
            IRepository<City> citiesRepository)
        {
            this.workpostRepository = workpostRepository;
            this.countriesRepository = countriesRepository;
            this.citiesRepository = citiesRepository;
        }

        public int GetCountriesCounts()
        {
            return this.countriesRepository.All().Count();
        }

        public int GetCitiesCounts()
        {
            return this.citiesRepository.All().Count();
        }

        public int GetPostsCounts()
        {
            return this.workpostRepository.All().Count();
        }
    }
}
