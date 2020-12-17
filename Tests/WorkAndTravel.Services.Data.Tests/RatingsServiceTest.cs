namespace WorkAndTravel.Services.Data.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Moq;
    using WorkAndTravel.Data.Common.Repositories;
    using WorkAndTravel.Data.Models;
    using Xunit;

    public class RatingsServiceTest
    {
        [Fact]
        public async Task WhenUserVotes2TimesOnly1VoteShouldBeCounted()
        {
            var list = new List<Rating>();
            var mockRepo = new Mock<IRepository<Rating>>();
            mockRepo.Setup(x => x.All()).Returns(list.AsQueryable());
            mockRepo.Setup(x => x.AddAsync(It.IsAny<Rating>())).Callback(
                (Rating rating) => list.Add(rating));
            var service = new RatingsService(mockRepo.Object);

            await service.SetRatingAsync(1, "1", 1);
            await service.SetRatingAsync(1, "1", 5);
            await service.SetRatingAsync(1, "1", 5);
            await service.SetRatingAsync(1, "1", 5);
            await service.SetRatingAsync(1, "1", 5);

            Assert.Equal(1, list.Count);
            Assert.Equal(5, list.First().Value);
        }

        [Fact]
        public async Task When2UsersVoteForTheSameRecipeTheAverageVoteShouldBeCorrect()
        {
            var list = new List<Rating>();
            var mockRepo = new Mock<IRepository<Rating>>();
            mockRepo.Setup(x => x.All()).Returns(list.AsQueryable());
            mockRepo.Setup(x => x.AddAsync(It.IsAny<Rating>())).Callback(
                (Rating rating) => list.Add(rating));
            var service = new RatingsService(mockRepo.Object);

            await service.SetRatingAsync(2, "Niki", 5);
            await service.SetRatingAsync(2, "Pesho", 1);
            await service.SetRatingAsync(2, "Niki", 2);

            mockRepo.Verify(x => x.AddAsync(It.IsAny<Rating>()), Times.Exactly(2));

            Assert.Equal(2, list.Count);
            Assert.Equal(1.5, service.GetAverageRating(2));
        }
    }
}
