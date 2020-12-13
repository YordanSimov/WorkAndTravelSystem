namespace WorkAndTravel.Web.Areas.Administration.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;
    using WorkAndTravel.Data;
    using WorkAndTravel.Data.Common.Repositories;
    using WorkAndTravel.Data.Models;

    [Area("Administration")]
    public class WorkPostsController : AdministrationController
    {
        private readonly IDeletableEntityRepository<WorkPost> workPostsRepository;

        public WorkPostsController(IDeletableEntityRepository<WorkPost> workPostsRepository)
        {
            this.workPostsRepository = workPostsRepository;
        }

        // GET: Administration/WorkPosts
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = this.workPostsRepository.AllWithDeleted().Include(w => w.AddedByUser).Include(w => w.Address).Include(w => w.Category).Include(w => w.City).Include(w => w.Country);
            return this.View(await applicationDbContext.ToListAsync());
        }

        // GET: Administration/WorkPosts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var workPost = await this.workPostsRepository.All()
                .Include(w => w.AddedByUser)
                .Include(w => w.Address)
                .Include(w => w.Category)
                .Include(w => w.City)
                .Include(w => w.Country)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (workPost == null)
            {
                return this.NotFound();
            }

            return this.View(workPost);
        }

        // GET: Administration/WorkPosts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var workPost = await this.workPostsRepository.All()
                .Include(w => w.AddedByUser)
                .Include(w => w.Address)
                .Include(w => w.Category)
                .Include(w => w.City)
                .Include(w => w.Country)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (workPost == null)
            {
                return this.NotFound();
            }

            return this.View(workPost);
        }

        // POST: Administration/WorkPosts/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var workPost = this.workPostsRepository.All().FirstOrDefault(x => x.Id == id);
            this.workPostsRepository.Delete(workPost);
            await this.workPostsRepository.SaveChangesAsync();
            return this.RedirectToAction(nameof(this.Index));
        }

        private bool WorkPostExists(int id)
        {
            return this.workPostsRepository.All().Any(e => e.Id == id);
        }
    }
}
