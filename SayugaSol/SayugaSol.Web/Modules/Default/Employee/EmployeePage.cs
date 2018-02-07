


namespace SayugaSol.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/Employee"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.EmployeeRow))]
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/Employee/EmployeeIndex.cshtml");
        }
    }
}