using Microsoft.AspNetCore.Mvc;

namespace Group_Project.Controllers
{
	public class QuestionController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Create()
		{
			return View();
		}
	}
}
