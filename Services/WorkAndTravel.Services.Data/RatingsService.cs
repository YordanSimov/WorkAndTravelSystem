namespace WorkAndTravel.Services.Data
{
    using System.Linq;
    using System.Threading.Tasks;

    using WorkAndTravel.Data.Common.Repositories;
    using WorkAndTravel.Data.Models;

    public class RatingsService : IRatingsService
    {
        private readonly IRepository<Rating> ratingsRepository;

        public RatingsService(IRepository<Rating> ratingsRepository)
        {
            this.ratingsRepository = ratingsRepository;
        }

        public double GetAverageRating(int workPostId)
        {
           return this.ratingsRepository
                .All()
                .Where(x => x.WorkPostId == workPostId)
                .Average(x => x.Value);
        }

        public async Task SetRatingAsync(int workPostId, string userId, byte value)
        {
            var rating = this.ratingsRepository.All()
                .FirstOrDefault(x => x.WorkPostId == workPostId && x.AddedByUserId == userId);

            if (rating == null)
            {
                rating = new Rating
                {
                    AddedByUserId = userId,
                    WorkPostId = workPostId,
                };

                await this.ratingsRepository.AddAsync(rating);
            }

            rating.Value = value;
            await this.ratingsRepository.SaveChangesAsync();
        }
    }
}
