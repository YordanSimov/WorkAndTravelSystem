namespace WorkAndTravel.Services.Data
{
    using System.Linq;
    using System.Threading.Tasks;

    using CloudinaryDotNet;
    using WorkAndTravel.Data.Common.Repositories;
    using WorkAndTravel.Data.Models;
    using WorkAndTravel.Services.Mapping;
    using WorkAndTravel.Web.Cloudinary;
    using WorkAndTravel.Web.ViewModels.Account;

    public class ProfileService : IProfileService
    {
        private readonly IDeletableEntityRepository<ApplicationUser> userRepository;

        public ProfileService(
            IDeletableEntityRepository<ApplicationUser> userRepository)
        {
            this.userRepository = userRepository;
        }

        public T GetUserId<T>(string id)
        {
            return this.userRepository.AllAsNoTracking().Where(x => x.Id == id).To<T>().FirstOrDefault();
        }
    }
}
