using Microsoft.AspNetCore.Mvc;

namespace mayur_education.Controllers
{
    public class Gallery : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
