using System.Web.Mvc;

namespace MusicStore.Controllers
{
    public class StoreController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Browse(string genre)
        {
            return View();
        }

        public ActionResult Details(int ID)
        {
            return View();
        }
    }
}