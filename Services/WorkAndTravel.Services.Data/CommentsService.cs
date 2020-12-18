namespace WorkAndTravel.Services.Data
{
    using System.Linq;
    using System.Threading.Tasks;

    using WorkAndTravel.Data.Common.Repositories;
    using WorkAndTravel.Data.Models;

    public class CommentsService : ICommentsService
    {
        private readonly IDeletableEntityRepository<Comment> commentsRepository;

        public CommentsService(IDeletableEntityRepository<Comment> commentsRepository)
        {
            this.commentsRepository = commentsRepository;
        }

        public async Task Create(int workPostId, string userId, string content, int? parentId = null)
        {
            var comment = new Comment
            {
                Content = content,
                ParentId = parentId,
                WorkPostId = workPostId,
                UserId = userId,
            };

            await this.commentsRepository.AddAsync(comment);
            await this.commentsRepository.SaveChangesAsync();
        }

        public bool IsInPostId(int commentId, int postId)
        {
            var commentPostId = this.commentsRepository
                .All()
                .Where(x => x.Id == commentId)
                .Select(x => x.WorkPostId)
                .FirstOrDefault();

            return commentPostId == postId;
        }
    }
}
