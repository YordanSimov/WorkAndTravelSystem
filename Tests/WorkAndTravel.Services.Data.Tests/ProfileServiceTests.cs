namespace WorkAndTravel.Services.Data.Tests
{
    using System;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using WorkAndTravel.Data;
    using WorkAndTravel.Data.Models;
    using WorkAndTravel.Data.Repositories;
    using WorkAndTravel.Services.Mapping;
    using Xunit;

    public class ProfileServiceTests
    {
        [Fact]

        public async Task GetByIdShouldWorkProperly()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
          .UseInMemoryDatabase(Guid.NewGuid().ToString());
            var repositoryPost = new EfDeletableEntityRepository<WorkPost>(new ApplicationDbContext(options.Options));
            var repositoryUser = new EfDeletableEntityRepository<ApplicationUser>(new ApplicationDbContext(options.Options));

            await repositoryUser.AddAsync(new ApplicationUser() { Id = "1" });
            await repositoryUser.SaveChangesAsync();

            var service = new ProfileService(repositoryUser, repositoryPost);
            AutoMapperConfig.RegisterMappings(typeof(TestUser).Assembly);

            var user = service.GetUserId<TestUser>("1");

            Assert.Equal("1", user.Id);
        }
    }

    public class TestUser : IMapFrom<ApplicationUser>
    {
        public string Id { get; set; }
    }
}
