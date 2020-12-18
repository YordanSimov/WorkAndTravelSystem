namespace WorkAndTravel.Services.Data.Tests
{
    using System;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using WorkAndTravel.Data;
    using WorkAndTravel.Data.Models;
    using WorkAndTravel.Data.Repositories;
    using Xunit;

    public class GetCountsServiceTests
    {
        [Fact]
        public async Task GetCountsShouldWorkProperly()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString());
            var repositoryPost = new EfDeletableEntityRepository<WorkPost>(new ApplicationDbContext(options.Options));
            var repositoryCity = new EfRepository<City>(new ApplicationDbContext(options.Options));
            var repositoryCountry = new EfRepository<Country>(new ApplicationDbContext(options.Options));

            await repositoryPost.AddAsync(new WorkPost
            {
                Id = 1,
                Country = new Country { Name = "country" },
                City = new City { Name = "city" },
            });
            await repositoryPost.SaveChangesAsync();

            var service = new GetCountsService(repositoryPost, repositoryCountry, repositoryCity);

            var countPosts = service.GetPostsCounts();
            var countCities = service.GetCitiesCounts();
            var countCountries = service.GetCountriesCounts();

            Assert.Equal(1, countPosts);
            Assert.Equal(1, countCities);
            Assert.Equal(1, countCountries);
        }
    }
}
