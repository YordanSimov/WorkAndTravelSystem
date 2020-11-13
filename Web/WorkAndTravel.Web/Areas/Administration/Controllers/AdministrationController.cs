namespace WorkAndTravel.Web.Areas.Administration.Controllers
{
    using WorkAndTravel.Common;
    using WorkAndTravel.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
