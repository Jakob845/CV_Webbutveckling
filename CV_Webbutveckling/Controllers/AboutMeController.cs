using Microsoft.AspNetCore.Mvc;

namespace CV_Webbutveckling.Controllers
{
    public class AboutMeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
