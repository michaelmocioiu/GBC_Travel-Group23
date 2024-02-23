using Microsoft.AspNetCore.Mvc;

namespace GBC_Travel_Group23.Controllers
{
    public class ListingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
