namespace WorkAndTravel.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using WorkAndTravel.Data.Common.Repositories;
    using WorkAndTravel.Data.Models;

    public class CountriesService : ICountriesService
    {
        private readonly IRepository<Country> countryRepository;

        public CountriesService(IRepository<Country> countryRepository)
        {
            this.countryRepository = countryRepository;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs()
        {
            return this.countryRepository.AllAsNoTracking().Select(x => new
            {
                x.Id,
                x.Name,
            }).ToList().Select(x => new KeyValuePair<string, string>(x.Id.ToString(), x.Name));
        }
    }
}
