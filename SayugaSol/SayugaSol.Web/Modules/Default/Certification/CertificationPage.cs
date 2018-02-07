


namespace SayugaSol.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/Certification"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.CertificationRow))]
    public class CertificationController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/Certification/CertificationIndex.cshtml");
        }
    }
}