using Microsoft.AspNetCore.Mvc;

namespace CV_Webbutveckling.Controllers
{
    public class AboutMeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Education()
        {
            return View();
        }

        public IActionResult Experience()
        {
            return View();
        }

    }
}
