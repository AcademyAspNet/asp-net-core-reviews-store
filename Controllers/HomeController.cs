using Microsoft.AspNetCore.Mvc;

namespace OnlineStoreReviews.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
