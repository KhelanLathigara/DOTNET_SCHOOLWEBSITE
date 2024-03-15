using Microsoft.AspNetCore.Mvc;

namespace mayur_education.Controllers
{
    public class Contact : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
