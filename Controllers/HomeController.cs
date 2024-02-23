using Microsoft.AspNetCore.Mvc;

namespace GBC_Travel_Group23.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
