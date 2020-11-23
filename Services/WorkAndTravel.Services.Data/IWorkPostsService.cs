namespace WorkAndTravel.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using WorkAndTravel.Web.ViewModels;
    using WorkAndTravel.Web.ViewModels.WorkPosts;

    public interface IWorkPostsService
    {
        Task CreateAsync(CreateWorkPostsInputModel input, string userId, string imagePath);

        IEnumerable<T> GetAll<T>(int page, int postsPerPage = 12);

        int GetCount();

        T GetById<T>(int Id);
    }
}
