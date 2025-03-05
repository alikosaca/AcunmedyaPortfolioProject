using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaPortfolioProjectt.Controllers
{
	public class StaticController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
