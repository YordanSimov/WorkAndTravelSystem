namespace WorkAndTravel.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using WorkAndTravel.Services.Messaging;
    using WorkAndTravel.Web.ViewModels;

    using static WorkAndTravel.Common.GlobalConstants;

    public class ContactUsController : Controller
    {
        private readonly IEmailSender emailSender;

        public ContactUsController(
                   IEmailSender emailSender)
        {
            this.emailSender = emailSender;
        }

        public IActionResult Index()
        {
            var viewModel = new ContactUsInputModel();
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(ContactUsInputModel model)
        {
            if (this.ModelState.IsValid)
            {
                var email = model.Email;
                var name = model.Name;
                var subject = model.Subject;
                var content = model.Message;

                await this.emailSender.SendEmailAsync(email, name, AdminEmail, subject, content, null);

                this.TempData["Message"] = "Email sent successfully.";
                return this.Redirect("/");
            }

            return this.View(model);
        }
    }
}
