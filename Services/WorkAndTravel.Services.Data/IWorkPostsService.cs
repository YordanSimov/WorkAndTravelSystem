namespace WorkAndTravel.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using WorkAndTravel.Web.ViewModels;
    using WorkAndTravel.Web.ViewModels.WorkPosts;

    public interface IWorkPostsService
    {
        int GetCount();

        T GetById<T>(int id);

        Task CreateAsync(CreateWorkPostsInputModel input, string userId);

        Task AddAsync(string userId, int postId);

        Task EditAsync(int id, EditWorkPostInputModel input);

        Task DeleteAsync(int id);

        IEnumerable<T> GetByCityName<T>(string cityName);

        IEnumerable<T> GetTopThreePosts<T>();

        IEnumerable<T> GetAll<T>(int page, int postsPerPage = 8);

        IEnumerable<T> SortByDate<T>(int page, int postsPerPage = 8);

        IEnumerable<T> SortByName<T>(int page, int postsPerPage = 8);

        IEnumerable<T> SortBySalary<T>(int page, int postsPerPage = 8);
    }
}
