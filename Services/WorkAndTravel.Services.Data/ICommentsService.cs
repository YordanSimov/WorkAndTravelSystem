namespace WorkAndTravel.Services.Data
{
    using System.Threading.Tasks;

    public interface ICommentsService
    {
        Task Create(int workPostId, string userId, string content, int? parentId = null);

        bool IsInPostId(int commentId, int postId);
    }
}
