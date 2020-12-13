namespace WorkAndTravel.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using WorkAndTravel.Common;
    using WorkAndTravel.Data.Models;

    public class AdministratorSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var usersCount = await dbContext.Users.CountAsync();

            if (usersCount == 0)
            {
                await SeedAdminAsync(dbContext, userManager);
            }
        }

        public async Task SeedAdminAsync(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            var admin = await userManager.FindByNameAsync("Admin");

            var profileImage = await dbContext.ProfilePictures.FirstOrDefaultAsync(x => x.Url == GlobalConstants.DefaultProfilePicturePath);

            if (admin == null)
            {
                var user = new ApplicationUser
                {
                    FirstName = "Admin",
                    LastName = "Admin",
                    UserName = "Admin",
                    Email = "admin@gmail.com",
                    BirthDate = DateTime.Now,
                    ProfilePicture = profileImage,
                    PhoneNumber = null,
                    Ratings = null,
                };

                await userManager.CreateAsync(user, "admin");
                await userManager.AddToRoleAsync(user, GlobalConstants.AdministratorRoleName);
            }
        }
    }
}
