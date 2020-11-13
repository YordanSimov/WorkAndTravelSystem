namespace WorkAndTravel.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore.Internal;
    using WorkAndTravel.Data.Models;

    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            await dbContext.Categories.AddAsync(new Category { Name = "Volunteering", });
            await dbContext.Categories.AddAsync(new Category { Name = "Working Abroad", });
            await dbContext.Categories.AddAsync(new Category { Name = "Couchsurfing", });

            await dbContext.SaveChangesAsync();
        }
    }
}
