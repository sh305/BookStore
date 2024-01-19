using Microsoft.AspNetCore.Mvc;

namespace BookStore_Application.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
