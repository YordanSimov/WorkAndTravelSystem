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
            var post = this.workPostsRepository.All()
                .Where(x => x.AddedByUserId == id)
                .First();

            return this.workPostsRepository.All()
                .Where(x => x.AppliedUsersWorkPosts
                .Any(y => y.WorkPostId == post.Id)).To<T>().ToList();
        }
    }
}
