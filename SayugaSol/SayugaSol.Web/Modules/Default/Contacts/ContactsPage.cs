


namespace SayugaSol.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/Contacts"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.ContactsRow))]
    public class ContactsController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/Contacts/ContactsIndex.cshtml");
        }
    }
}