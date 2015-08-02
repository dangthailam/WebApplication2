using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class CvController : Controller
    {
        // GET: Cv
        public PartialViewResult Create()
        {
            return PartialView();
        }
    }
}