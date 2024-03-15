using Microsoft.AspNetCore.Mvc;

namespace mayur_education.Controllers
{
    public class StudentResult : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
