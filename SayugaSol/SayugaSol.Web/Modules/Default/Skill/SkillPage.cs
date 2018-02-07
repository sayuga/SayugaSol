namespace SayugaSol.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;    

    [RoutePrefix("Default/Skill"), Route("{action=index}")]    
    public class SkillController : Controller
    {
        [PageAuthorize(typeof(Entities.SkillRow))]
        public ActionResult Index()
        {
            return View("~/Modules/Default/Skill/SkillIndex.cshtml");
        }
    }
}