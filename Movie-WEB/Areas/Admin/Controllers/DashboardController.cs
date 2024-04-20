using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Movie_WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "editor")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
