namespace WorkAndTravel.Services.Data
{
    using CloudinaryDotNet;
    using System.Linq;
    using System.Threading.Tasks;
    using WorkAndTravel.Data.Common.Repositories;
    using WorkAndTravel.Data.Models;
    using WorkAndTravel.Services.Mapping;
    using WorkAndTravel.Web.Cloudinary;
    using WorkAndTravel.Web.ViewModels.Account;

    public class ProfileService : IProfileService
    {
        private readonly IDeletableEntityRepository<ApplicationUser> userRepository;
        private readonly Cloudinary cloudinary;
        private readonly IDeletableEntityRepository<ProfilePicture> picturesRepository;

        public ProfileService(
            IDeletableEntityRepository<ApplicationUser> userRepository,
            Cloudinary cloudinary,
            IDeletableEntityRepository<ProfilePicture> picturesRepository)
        {
            this.userRepository = userRepository;
            this.cloudinary = cloudinary;
            this.picturesRepository = picturesRepository;
        }

        public T GetUserId<T>(string id)
        {
            return this.userRepository.AllAsNoTracking().Where(x => x.Id == id).To<T>().FirstOrDefault();
        }

        public async Task EditAsync(string id, EditProfileViewModel input)
        {
            var user = this.userRepository.All().Where(x => x.Id == id).FirstOrDefault();
            var userPicture = this.picturesRepository.All().Where(x => x.UserId == user.Id).FirstOrDefault();

            var resultUrl = await Cloud.UploadAsync(this.cloudinary, input.ProfilePicture);
            userPicture.Url = resultUrl;

            user.Email = input.Email;
            user.UserName = input.Username;
            user.FirstName = input.FirstName;
            user.LastName = input.LastName;

            await this.userRepository.SaveChangesAsync();
            await this.picturesRepository.SaveChangesAsync();
        }
    }
}
