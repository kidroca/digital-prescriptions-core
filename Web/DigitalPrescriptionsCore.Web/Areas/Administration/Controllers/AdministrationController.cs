namespace DigitalPrescriptionsCore.Web.Areas.Administration.Controllers
{
    using DigitalPrescriptionsCore.Common;
    using DigitalPrescriptionsCore.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
