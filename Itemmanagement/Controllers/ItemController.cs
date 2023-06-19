using Microsoft.AspNetCore.Mvc;

namespace Itemmanagement.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
