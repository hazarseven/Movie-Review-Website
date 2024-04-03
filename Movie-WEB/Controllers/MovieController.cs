using Microsoft.AspNetCore.Mvc;

namespace Movie_WEB.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
