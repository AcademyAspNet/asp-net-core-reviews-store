using Microsoft.AspNetCore.Mvc;
using OnlineStoreReviews.Models.Entities;
using OnlineStoreReviews.Services;

namespace OnlineStoreReviews.Controllers
{
    public class CartController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
