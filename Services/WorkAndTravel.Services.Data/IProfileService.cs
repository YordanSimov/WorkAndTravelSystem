namespace WorkAndTravel.Services.Data
{
    using System.Threading.Tasks;

    using WorkAndTravel.Web.ViewModels.Account;

    public interface IProfileService
    {
        T GetUserId<T>(string id);

        Task EditAsync(string id, EditProfileViewModel input);
    }
}
