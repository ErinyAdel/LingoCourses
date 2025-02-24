using Microsoft.AspNetCore.Mvc;

namespace LingoCourses.Controllers
{
	public class ReviewsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
