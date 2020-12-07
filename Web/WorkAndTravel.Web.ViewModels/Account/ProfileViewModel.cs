namespace WorkAndTravel.Web.ViewModels.Account
{
    using System;
    using System.Collections.Generic;

    using WorkAndTravel.Data.Models;
    using WorkAndTravel.Services.Mapping;

    public class ProfileViewModel : IMapFrom<ApplicationUser>
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string ProfilePictureUrl { get; set; }

        public DateTime BirthDate { get; set; }

        public int Age => DateTime.UtcNow.Year - this.BirthDate.Year;

        public IEnumerable<ProfilePostViewModel> WorkPosts { get; set; }
    }
}
