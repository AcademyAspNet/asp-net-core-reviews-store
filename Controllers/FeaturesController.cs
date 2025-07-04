using Microsoft.AspNetCore.Mvc;
using OnlineStoreReviews.Models.Views;

namespace OnlineStoreReviews.Controllers
{
    public class FeaturesController : Controller
    {
        public IActionResult Index()
        {
            FeaturesViewModel model = new FeaturesViewModel();
            return View(model);
        }

        public IActionResult ProcessRequest(FeaturesViewModel model)
        {
            return Content($"First name: {model.FirstName} / Last name: {model.LastName}");
        }
    }
}
