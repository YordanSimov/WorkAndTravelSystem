namespace WorkAndTravel.Services.Data.Tests
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using WorkAndTravel.Data;
    using WorkAndTravel.Data.Models;
    using WorkAndTravel.Data.Repositories;
    using WorkAndTravel.Services.Mapping;
    using Xunit;

    public class ProfilePostsServiceTest
    {
        [Fact]
        public async Task GetAllByIdShouldWorkProperly()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString());
            var repositoryPost = new EfDeletableEntityRepository<WorkPost>(new ApplicationDbContext(options.Options));

            await repositoryPost.AddAsync(new WorkPost { AddedByUserId = "1" });
            await repositoryPost.SaveChangesAsync();

            var service = new ProfilePostsService(repositoryPost);
            AutoMapperConfig.RegisterMappings(typeof(MyTestProfileAll).Assembly);

            var posts = service.GetAll<MyTestProfileAll>("1");

            Assert.Equal(1, posts.Count());
        }
    }

    public class MyTestProfileAll : IMapFrom<WorkPost>
    {
        public string AddedByUserId { get; set; }
    }
}
