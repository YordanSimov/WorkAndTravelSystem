namespace WorkAndTravel.Services.Data
{
    using System.Threading.Tasks;

    public interface IRatingsService
    {
        Task SetRatingAsync(int workPostId, string userId, byte value);

        double GetAverageRating(int workPostId);
    }
}
