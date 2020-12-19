namespace WorkAndTravel.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using WorkAndTravel.Data.Common.Repositories;
    using WorkAndTravel.Data.Models;
    using WorkAndTravel.Services.Mapping;

    public class ProfileService : IProfileService
    {
        private readonly IDeletableEntityRepository<ApplicationUser> userRepository;
        private readonly IDeletableEntityRepository<WorkPost> workPostsRepository;

        public ProfileService(
            IDeletableEntityRepository<ApplicationUser> userRepository,
            IDeletableEntityRepository<WorkPost> workPostsRepository)
        {
            this.userRepository = userRepository;
            this.workPostsRepository = workPostsRepository;
        }

        public T GetUserId<T>(string id)
        {
            return this.userRepository
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .To<T>()
                .FirstOrDefault();
        }

        public IEnumerable<T> GetUserAppliedToPosts<T>(string id)
        {
            return this.workPostsRepository
                .All()
                .Where(x => x.AppliedUsersWorkPosts.Any(y => y.ApplicationUserId == id))
                .To<T>().ToList();
        }

        public IEnumerable<T> GetApplicants<T>(string id)
        {
            var collection = new List<IQueryable<WorkPost>>();
            var posts = this.workPostsRepository.All()
                .Where(x => x.AddedByUserId == id);

            foreach (var item in posts)
            {
                var workPost = this.workPostsRepository.All().Where(x => x.AppliedUsersWorkPosts.Any(x => x.WorkPostId == item.Id));
                collection.Add(workPost);
            }

            var result = new List<T>();
            foreach (var c in collection)
            {
                if (c.To<T>().FirstOrDefault() != null)
                {
                    result.Add(c.To<T>().FirstOrDefault());
                }
            }

            return result.ToList();
        }
    }
}
