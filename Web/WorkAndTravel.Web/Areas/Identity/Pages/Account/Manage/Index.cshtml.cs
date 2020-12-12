namespace WorkAndTravel.Web.Areas.Identity.Pages.Account.Manage
{
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    using CloudinaryDotNet;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using WorkAndTravel.Data.Common.Repositories;
    using WorkAndTravel.Data.Models;
    using WorkAndTravel.Web.Cloudinary;

    public partial class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly Cloudinary cloudinary;
        private readonly IDeletableEntityRepository<ApplicationUser> usersRepository;
        private readonly IDeletableEntityRepository<ProfilePicture> picturesRepository;

        public IndexModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            Cloudinary cloudinary,
            IDeletableEntityRepository<ApplicationUser> usersRepository,
            IDeletableEntityRepository<ProfilePicture> picturesRepository)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.cloudinary = cloudinary;
            this.usersRepository = usersRepository;
            this.picturesRepository = picturesRepository;
        }

        //  public string Email { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Display(Name = "Username")]
            public string Username { get; set; }

            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }

            [Display(Name = "Change profile picture")]
            public IFormFile ProfilePicture { get; set; }

            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [Display(Name = "Last Name")]
            public string LastName { get; set; }
        }

        private async Task LoadAsync(ApplicationUser user)
        {
            var email = await this.userManager.GetEmailAsync(user);
            var phoneNumber = await this.userManager.GetPhoneNumberAsync(user);
            var applicationUser = await this.userManager.GetUserAsync(this.User);

            this.Input = new InputModel
            {
                FirstName = applicationUser.FirstName,
                LastName = applicationUser.LastName,
                Username = applicationUser.UserName,
                Email = email,
                PhoneNumber = phoneNumber,
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await this.userManager.GetUserAsync(this.User);
            if (user == null)
            {
                return this.NotFound($"Unable to load user with ID '{this.userManager.GetUserId(this.User)}'.");
            }

            await this.LoadAsync(user);
            return this.Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await this.userManager.GetUserAsync(this.User);
            var userInRepo = this.usersRepository.All().Where(x => x.Id == user.Id).FirstOrDefault();
            var userPicture = this.picturesRepository.All().Where(x => x.UserId == userInRepo.Id).FirstOrDefault();
            if (user == null)
            {
                return this.NotFound($"Unable to load user with ID '{this.userManager.GetUserId(this.User)}'.");
            }

            if (!this.ModelState.IsValid)
            {
                await this.LoadAsync(user);
                return this.Page();
            }

            var phoneNumber = await this.userManager.GetPhoneNumberAsync(user);
            if (this.Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await this.userManager.SetPhoneNumberAsync(user, this.Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    this.StatusMessage = "Unexpected error when trying to set phone number.";
                    return this.RedirectToPage();
                }
            }

            if (this.Input.FirstName != user.FirstName)
            {
                user.FirstName = this.Input.FirstName;
                userInRepo.FirstName = this.Input.FirstName;
            }

            if (this.Input.LastName != user.LastName)
            {
                user.LastName = this.Input.LastName;
                userInRepo.LastName = this.Input.LastName;
            }

            if (this.Input.Email != user.Email)
            {
                var usersEmails = this.usersRepository.All().Any(x => x.Email == this.Input.Email);
                if (usersEmails)
                {
                    this.StatusMessage = "This email is already taken.";
                    return this.Page();
                }

                user.NormalizedEmail = this.Input.Email.ToUpper();
                userInRepo.NormalizedEmail = this.Input.Email.ToUpper();
                user.Email = this.Input.Email;
                userInRepo.Email = this.Input.Email;
            }

            if (this.Input.Username != user.UserName)
            {
                var usersUsernames = this.usersRepository.All().Any(x => x.UserName == this.Input.Username);

                if (usersUsernames)
                {
                    this.StatusMessage = "This username is already taken.";
                    return this.Page();
                }

                user.NormalizedUserName = this.Input.Username.ToUpper();
                user.UserName = this.Input.Username;
                userInRepo.NormalizedUserName = this.Input.Username.ToUpper();
                userInRepo.UserName = this.Input.Username;
            }

            if (this.Input.ProfilePicture != null)
            {
                var resultUrl = await Cloud.UploadAsync(this.cloudinary, this.Input.ProfilePicture);
                user.ProfilePicture.Url = resultUrl;
                userPicture.Url = resultUrl;
                await this.picturesRepository.SaveChangesAsync();
            }

            await this.signInManager.RefreshSignInAsync(user);
            await this.usersRepository.SaveChangesAsync();

            this.StatusMessage = "Your profile has been updated";
            return this.RedirectToPage();
        }
    }
}
