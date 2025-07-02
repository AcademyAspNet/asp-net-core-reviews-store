using Microsoft.AspNetCore.Mvc;
using OnlineStoreReviews.Models.Entities;
using OnlineStoreReviews.Services;

namespace OnlineStoreReviews.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            List<Product> products = _productService.GetProducts();
            return View(products);
        }

        public IActionResult GetById([FromRoute] int? id)
        {
            if (id is null)
                return RedirectToAction("Index");

            Product? product = _productService.GetProductById((int) id);

            if (id is null)
                return RedirectToAction("Index");

            return View(product);
        }
    }
}
