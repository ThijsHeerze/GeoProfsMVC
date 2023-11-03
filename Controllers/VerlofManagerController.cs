using Microsoft.AspNetCore.Mvc;

namespace GeoProfs.Controllers
{

    public class VerlofManagerController : Controller
    {
        public IActionResult VerlofManager()
        {
            return View();
        }
    }
}