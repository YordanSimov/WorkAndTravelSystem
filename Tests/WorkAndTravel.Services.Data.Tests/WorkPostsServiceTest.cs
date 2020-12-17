namespace WorkAndTravel.Services.Data.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Moq;
    using WorkAndTravel.Data;
    using WorkAndTravel.Data.Common.Repositories;
    using WorkAndTravel.Data.Models;
    using WorkAndTravel.Services.Mapping;
    using WorkAndTravel.Web.ViewModels;
    using WorkAndTravel.Web.ViewModels.WorkPosts;
    using Xunit;

    public class WorkPostsServiceTest
    {
        private IList<ApplicationUser> users;
        private IList<Address> addresses;
        private IList<City> cities;
        private IList<WorkPost> workPosts;
        private WorkPostsService service;

        public WorkPostsServiceTest()
        {
            AutoMapperConfig.RegisterMappings(typeof(ErrorViewModel).GetTypeInfo().Assembly);
            AutoMapperConfig.RegisterMappings(Assembly.Load("WorkAndTravel.Services.Data.Tests"));

            this.users = new List<ApplicationUser>();
            this.addresses = new List<Address>();
            this.cities = new List<City>();
            this.workPosts = new List<WorkPost>();

            var mockUsersRepo = new Mock<IDeletableEntityRepository<ApplicationUser>>();
            //  mockUsersRepo.Setup(x => x.All()).Returns(this.users.AsQueryable());

            var mockAddressesRepo = new Mock<IDeletableEntityRepository<Address>>();
            mockAddressesRepo.Setup(x => x.All()).Returns(this.addresses.AsQueryable());

            var mockCitiesRepo = new Mock<IRepository<City>>();
            mockCitiesRepo.Setup(x => x.All()).Returns(this.cities.AsQueryable());

            var mockWorkPostsRepoDefault = new Mock<IDeletableEntityRepository<WorkPost>>();
            mockWorkPostsRepoDefault.Setup(x => x.AllAsNoTracking()).Returns(this.workPosts.AsQueryable());

            this.service = new WorkPostsService(mockWorkPostsRepoDefault.Object, mockAddressesRepo.Object, mockCitiesRepo.Object, null, mockUsersRepo.Object);
        }

        [Fact]

        public async Task DeleteWorkPostTest()
        {
            var mockWorkPostsRepo = new Mock<IDeletableEntityRepository<WorkPost>>();
            mockWorkPostsRepo.Setup(x => x.Delete(It.IsAny<WorkPost>())).Callback(
              (WorkPost workPost) => this.workPosts.Remove(workPost));

            await this.service.DeleteAsync(1);

            Assert.Equal(0, this.workPosts.Count);
        }

        [Fact]

        public void CreatePostShouldWorkProperly()
        {
            this.workPosts.Add(new WorkPost { Title = "input" });
            var mockWorkPostsRepo = new Mock<IDeletableEntityRepository<WorkPost>>();
            mockWorkPostsRepo.Setup(x => x.AddAsync(It.IsAny<WorkPost>())).Callback((WorkPost workPost) => this.workPosts.Add(workPost));

            var input = new CreateWorkPostsInputModel()
            {
                Title = "input",
            };
            var post = this.service.CreateAsync(input, "1");

            Assert.Equal("input", this.workPosts.First().Title);
        }
    }
}
