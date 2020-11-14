namespace WorkAndTravel.Services.Data
{
    using System.Threading.Tasks;

    using WorkAndTravel.Web.ViewModels;

    public interface IWorkPostsService
    {
        Task CreateAsync(CreateWorkPostsInputModel input);
    }
}
