using Microsoft.AspNetCore.Mvc;

namespace GBC_Travel_Group23.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            System.Console.WriteLine("aa");
            return View();
        }
    }
}
