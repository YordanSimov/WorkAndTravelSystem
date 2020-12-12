namespace WorkAndTravel.Web.ViewModels.Account
{
    using AutoMapper;
    using Microsoft.AspNetCore.Http;
    using WorkAndTravel.Data.Models;
    using WorkAndTravel.Services.Mapping;

    public class EditProfileViewModel : IMapFrom<ApplicationUser>, IHaveCustomMappings
    {
        public string Id { get; set; }

        public string Username { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string ProfilePictureUrl { get; set; }

        public IFormFile ProfilePicture { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<ApplicationUser, EditProfileViewModel>()
                .ForMember(x => x.ProfilePicture, opt => opt.Ignore());
        }
    }
}
