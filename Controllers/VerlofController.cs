using Microsoft.AspNetCore.Mvc;

namespace GeoProfs.Controllers
{
    public class VerlofController : Controller
    {
        public IActionResult Verlof()
        {
            return View();
        }
    }
}
