using Microsoft.AspNetCore.Mvc;

namespace aspAngu.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
