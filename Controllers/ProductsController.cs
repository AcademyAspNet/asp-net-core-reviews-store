using Microsoft.AspNetCore.Mvc;
using OnlineStoreReviews.Models.Entities;
using OnlineStoreReviews.Models.Utils;
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

            ViewBag.Breadcrumb = new List<BreadcrumbItem>()
            {
                new BreadcrumbItem("Список товаров", "Products", "Index")
            };

            return View(products);
        }

        public IActionResult GetById([FromRoute] int? id)
        {
            if (id is null)
                return RedirectToAction("Index");

            Product? product = _productService.GetProductById((int) id);

            if (product is null)
                return RedirectToAction("Index");

            ViewBag.Breadcrumb = new List<BreadcrumbItem>()
            {
                new BreadcrumbItem("Список товаров", "Products", "Index"),
                new BreadcrumbItem(product.Name, "Products", "GetById")
            };

            return View(product);
        }
    }
}
