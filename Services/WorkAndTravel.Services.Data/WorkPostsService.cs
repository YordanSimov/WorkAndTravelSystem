namespace WorkAndTravel.Services.Data
{
    using System.Linq;
    using System.Threading.Tasks;

    using WorkAndTravel.Data.Common.Repositories;
    using WorkAndTravel.Data.Models;
    using WorkAndTravel.Web.ViewModels;

    public class WorkPostsService : IWorkPostsService
    {
        private readonly IDeletableEntityRepository<WorkPost> workPostRepository;
        private readonly IRepository<Address> addressRepository;
        private readonly IRepository<City> cityRepository;

        public WorkPostsService(
            IDeletableEntityRepository<WorkPost> workPostRepository,
            IRepository<Address> addressRepository,
            IRepository<City> cityRepository)
        {
            this.workPostRepository = workPostRepository;
            this.addressRepository = addressRepository;
            this.cityRepository = cityRepository;
        }

        public async Task CreateAsync(CreateWorkPostsInputModel input)
        {
            var city = this.cityRepository.All().FirstOrDefault(x => x.Name == input.City);
            if (city == null)
            {
                city = new City { Name = input.City, CountryId = input.CountryId };
            }

            var address = this.addressRepository.All().FirstOrDefault(x => x.Name == input.Address);
            if (address == null)
            {
                address = new Address { Name = input.Address, City = city };
            }

            var workPost = new WorkPost()
            {
                Title = input.Title,
                Description = input.Description,
                Requirement = input.Requirement,
                CountryId = input.CountryId,
                Address = address,
                City = city,
                PaymentPerDay = input.PaymentPerDay,
                WorkLengthDescription = input.WorkLengthDescription,
                CategoryId = input.CategoryId,
            };

            await this.workPostRepository.AddAsync(workPost);
            await this.workPostRepository.SaveChangesAsync();
        }
    }
}
