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
    using WorkAndTravel.Web.ViewModels.WorkPosts;
    using Xunit;

    public class WorkPostsServiceTest
    {
        [Fact]

        public async Task GetByCityNameShouldWorkProperly()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
          .UseInMemoryDatabase(Guid.NewGuid().ToString());
            var repositoryPost = new EfDeletableEntityRepository<WorkPost>(new ApplicationDbContext(options.Options));
            var repositoryCity = new EfRepository<City>(new ApplicationDbContext(options.Options));
            var repositoryAddress = new EfDeletableEntityRepository<Address>(new ApplicationDbContext(options.Options));
            var repositoryUser = new EfDeletableEntityRepository<ApplicationUser>(new ApplicationDbContext(options.Options));

            await repositoryPost.AddAsync(new WorkPost { City = new City() { Name = "a" } });
            await repositoryPost.AddAsync(new WorkPost { City = new City() { Name = "b" } });
            await repositoryPost.SaveChangesAsync();

            var service = new WorkPostsService(repositoryPost, repositoryAddress, repositoryCity, null, repositoryUser);
            AutoMapperConfig.RegisterMappings(typeof(MyTestCityName).Assembly);

            var post = service.GetByCityName<MyTestCityName>("a");

            Assert.Equal("a", post.FirstOrDefault().CityName);
        }

        [Fact]

        public async Task GetByIdShouldWorkProperly()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
          .UseInMemoryDatabase(Guid.NewGuid().ToString());
            var repositoryPost = new EfDeletableEntityRepository<WorkPost>(new ApplicationDbContext(options.Options));
            var repositoryCity = new EfRepository<City>(new ApplicationDbContext(options.Options));
            var repositoryAddress = new EfDeletableEntityRepository<Address>(new ApplicationDbContext(options.Options));
            var repositoryUser = new EfDeletableEntityRepository<ApplicationUser>(new ApplicationDbContext(options.Options));

            await repositoryPost.AddAsync(new WorkPost { Id = 1, Title = "abc" });
            await repositoryPost.SaveChangesAsync();

            var service = new WorkPostsService(repositoryPost, repositoryAddress, repositoryCity, null, repositoryUser);
            AutoMapperConfig.RegisterMappings(typeof(MyTestAll).Assembly);

            var post = service.GetById<MyTestAll>(1);

            Assert.Equal(1, post.Id);
        }

        [Fact]

        public async Task DeleteWorkPostAndCountShouldWorkProperlyTest()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
          .UseInMemoryDatabase(Guid.NewGuid().ToString());
            var repositoryPost = new EfDeletableEntityRepository<WorkPost>(new ApplicationDbContext(options.Options));

            await repositoryPost.AddAsync(new WorkPost { Id = 1, Title = "abc" });
            await repositoryPost.SaveChangesAsync();

            var service = new WorkPostsService(repositoryPost, null, null, null, null);
            AutoMapperConfig.RegisterMappings(typeof(MyTestAll).Assembly);

            await service.DeleteAsync(1);
            var posts = service.GetCount();
            var post = repositoryPost.AllWithDeleted().FirstOrDefault();

            Assert.True(post.IsDeleted);
            Assert.Equal(0, posts);
        }

        [Fact]

        public async Task EditWorkPostShouldWorkProperly()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
          .UseInMemoryDatabase(Guid.NewGuid().ToString());
            var repositoryPost = new EfDeletableEntityRepository<WorkPost>(new ApplicationDbContext(options.Options));

            await repositoryPost.AddAsync(new WorkPost { Id = 1, Title = "abc" });
            await repositoryPost.SaveChangesAsync();

            var service = new WorkPostsService(repositoryPost, null, null, null, null);
            AutoMapperConfig.RegisterMappings(typeof(MyTestAll).Assembly);

            await service.EditAsync(1, new EditWorkPostInputModel()
            {
                Title = "new",
            });

            var post = repositoryPost.All().FirstOrDefault();

            Assert.Equal("new", post.Title);
        }

        [Fact]
        public async Task TestGetAll()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString());
            var repositoryPost = new EfDeletableEntityRepository<WorkPost>(new ApplicationDbContext(options.Options));
            var repositoryCity = new EfRepository<City>(new ApplicationDbContext(options.Options));
            var repositoryAddress = new EfDeletableEntityRepository<Address>(new ApplicationDbContext(options.Options));
            var repositoryUser = new EfDeletableEntityRepository<ApplicationUser>(new ApplicationDbContext(options.Options));

            await repositoryPost.AddAsync(new WorkPost { Title = "abc" });
            await repositoryPost.AddAsync(new WorkPost { Title = "abcd" });
            await repositoryPost.AddAsync(new WorkPost { Title = "abcd" });
            await repositoryPost.AddAsync(new WorkPost { Title = "abcd" });
            await repositoryPost.AddAsync(new WorkPost { Title = "abcd" });
            await repositoryPost.AddAsync(new WorkPost { Title = "abcd" });
            await repositoryPost.AddAsync(new WorkPost { Title = "abcd" });
            await repositoryPost.AddAsync(new WorkPost { Title = "abcd" });
            await repositoryPost.AddAsync(new WorkPost { Title = "abcd" });
            await repositoryPost.AddAsync(new WorkPost { Title = "abcd" });
            await repositoryPost.SaveChangesAsync();

            var service = new WorkPostsService(repositoryPost, repositoryAddress, repositoryCity, null, repositoryUser);
            AutoMapperConfig.RegisterMappings(typeof(MyTestAll).Assembly);
            var posts = service.GetAll<MyTestAll>(2);
            Assert.Equal(2, posts.Count());
        }

        [Fact]
        public async Task TestSortByDate()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString());
            var repositoryPost = new EfDeletableEntityRepository<WorkPost>(new ApplicationDbContext(options.Options));
            var repositoryCity = new EfRepository<City>(new ApplicationDbContext(options.Options));
            var repositoryAddress = new EfDeletableEntityRepository<Address>(new ApplicationDbContext(options.Options));
            var repositoryUser = new EfDeletableEntityRepository<ApplicationUser>(new ApplicationDbContext(options.Options));

            await repositoryPost.AddAsync(new WorkPost { Title = "abc" });
            await repositoryPost.AddAsync(new WorkPost { Title = "abcd" });
            await repositoryPost.AddAsync(new WorkPost { Title = "abcde" });
            await repositoryPost.AddAsync(new WorkPost { Title = "abcdf" });
            await repositoryPost.AddAsync(new WorkPost { Title = "abcdg" });
            await repositoryPost.AddAsync(new WorkPost { Title = "abcdh" });
            await repositoryPost.AddAsync(new WorkPost { Title = "abcdi" });
            await repositoryPost.AddAsync(new WorkPost { Title = "abcdj" });
            await repositoryPost.AddAsync(new WorkPost { Title = "abcdk" });
            await repositoryPost.AddAsync(new WorkPost { Title = "abcdl" });
            await repositoryPost.SaveChangesAsync();

            var firstCreated = repositoryPost.All().OrderByDescending(x => x.CreatedOn).FirstOrDefault();

            var service = new WorkPostsService(repositoryPost, repositoryAddress, repositoryCity, null, repositoryUser);
            AutoMapperConfig.RegisterMappings(typeof(MyTestAll).Assembly);

            var posts = service.SortByDate<MyTestAll>(2);
            Assert.Equal(firstCreated.CreatedOn.ToString(), posts.FirstOrDefault().CreatedOn.ToString());
        }

        [Fact]
        public async Task TestSortBySalary()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString());
            var repositoryPost = new EfDeletableEntityRepository<WorkPost>(new ApplicationDbContext(options.Options));
            var repositoryCity = new EfRepository<City>(new ApplicationDbContext(options.Options));
            var repositoryAddress = new EfDeletableEntityRepository<Address>(new ApplicationDbContext(options.Options));
            var repositoryUser = new EfDeletableEntityRepository<ApplicationUser>(new ApplicationDbContext(options.Options));

            await repositoryPost.AddAsync(new WorkPost { Title = "abc" });
            await repositoryPost.AddAsync(new WorkPost { Title = "abcd" });
            await repositoryPost.AddAsync(new WorkPost { Title = "abcde" });
            await repositoryPost.AddAsync(new WorkPost { Title = "abcdf" });
            await repositoryPost.AddAsync(new WorkPost { Title = "abcdg" });
            await repositoryPost.AddAsync(new WorkPost { Title = "abcdh" });
            await repositoryPost.AddAsync(new WorkPost { Title = "abcdi" });
            await repositoryPost.AddAsync(new WorkPost { Title = "abcdj" });
            await repositoryPost.AddAsync(new WorkPost { Title = "abcdk", PaymentPerDay = 10 });
            await repositoryPost.AddAsync(new WorkPost { Title = "abcdl", PaymentPerDay = 11 });

            await repositoryPost.SaveChangesAsync();

            var highestPayment = repositoryPost.All().OrderByDescending(x => x.PaymentPerDay).Skip(8).FirstOrDefault();

            var service = new WorkPostsService(repositoryPost, repositoryAddress, repositoryCity, null, repositoryUser);
            AutoMapperConfig.RegisterMappings(typeof(MyTestAll).Assembly);

            var posts = service.SortBySalary<MyTestAll>(2);
            Assert.Equal(highestPayment.PaymentPerDay, posts.FirstOrDefault().PaymentPerDay);
        }

        [Fact]
        public async Task TestSortByName()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString());
            var repositoryPost = new EfDeletableEntityRepository<WorkPost>(new ApplicationDbContext(options.Options));
            var repositoryCity = new EfRepository<City>(new ApplicationDbContext(options.Options));
            var repositoryAddress = new EfDeletableEntityRepository<Address>(new ApplicationDbContext(options.Options));
            var repositoryUser = new EfDeletableEntityRepository<ApplicationUser>(new ApplicationDbContext(options.Options));

            await repositoryPost.AddAsync(new WorkPost { Title = "a" });
            await repositoryPost.AddAsync(new WorkPost { Title = "b" });
            await repositoryPost.AddAsync(new WorkPost { Title = "c" });
            await repositoryPost.AddAsync(new WorkPost { Title = "d" });
            await repositoryPost.AddAsync(new WorkPost { Title = "e" });
            await repositoryPost.AddAsync(new WorkPost { Title = "f" });
            await repositoryPost.AddAsync(new WorkPost { Title = "g" });
            await repositoryPost.AddAsync(new WorkPost { Title = "h" });
            await repositoryPost.AddAsync(new WorkPost { Title = "i" });
            await repositoryPost.SaveChangesAsync();

            var first = repositoryPost.All().OrderBy(x => x.Title).Skip(8).FirstOrDefault();

            var service = new WorkPostsService(repositoryPost, repositoryAddress, repositoryCity, null, repositoryUser);
            AutoMapperConfig.RegisterMappings(typeof(MyTestAll).Assembly);

            var posts = service.SortByName<MyTestAll>(2);
            Assert.Equal(first.Title, posts.FirstOrDefault().Title);
        }
    }

    public class MyTestAll : IMapFrom<WorkPost>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime CreatedOn { get; set; }

        public int? PaymentPerDay { get; set; }
    }

    public class MyTestCityName : IMapFrom<WorkPost>
    {
        public string CityName { get; set; }
    }
}
