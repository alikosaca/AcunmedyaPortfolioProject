using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaPortfolioProjectt.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PartialHead()
        {
            return PartialView();
        }
        public IActionResult PartialMenu()
        {
            return PartialView();
        }
        public IActionResult PartialScript()
        {
            return PartialView();
        }
    }
}
