using Microsoft.AspNetCore.Mvc;

namespace Group_Project.Controllers
{
	public class QuestionController : Controller
	{


        private readonly IWebHostEnvironment _env;
            public QuestionController(IWebHostEnvironment env)
            {
            _env = env;
            }

        public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public ActionResult UploadImage(List<FormFile> files)
		{
			var filePath = "";
			foreach(IFormFile photo in Request.Form.Files)
			{
				string serverMapPath = Path.Combine(_env.WebRootPath , "Image", photo.FileName);
				using (var stream = new FileStream( serverMapPath, FileMode.Create))
				{
					photo.CopyTo(stream);
				}
				filePath = "https://localhost:44367/" + "Image/" + photo.FileName;
			}
			return Json(new { url = filePath});
		}
		public IActionResult Create()
		{
			return View();
		}
	}
}
