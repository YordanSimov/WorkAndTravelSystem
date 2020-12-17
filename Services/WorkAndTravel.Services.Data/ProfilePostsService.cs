namespace WorkAndTravel.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using WorkAndTravel.Data.Common.Repositories;
    using WorkAndTravel.Data.Models;
    using WorkAndTravel.Services.Mapping;

    public class ProfilePostsService : IProfilePostsService
    {
        private readonly IDeletableEntityRepository<WorkPost> workpostRepository;

        public ProfilePostsService(IDeletableEntityRepository<WorkPost> workpostRepository)
        {
            this.workpostRepository = workpostRepository;
        }

        public IEnumerable<T> GetAll<T>(string id)
        {
            return this.workpostRepository
                .All()
                .Where(x => x.AddedByUserId == id)
                .To<T>()
                .ToList();
        }
    }
}
