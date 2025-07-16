using Microsoft.AspNetCore.Mvc;
using OnlineStoreReviews.Models.DTO;
using OnlineStoreReviews.Models.Entities;
using OnlineStoreReviews.Models.Utils;
using OnlineStoreReviews.Models.Views;
using OnlineStoreReviews.Services;

namespace OnlineStoreReviews.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICartService _cartService;

        public ProductsController(IProductService productService, ICartService cartService)
        {
            _productService = productService;
            _cartService = cartService;
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

            ProductViewModel model = new ProductViewModel()
            {
                Product = product,
                ReviewDTO = new ReviewDTO()
            };

            ViewBag.Breadcrumb = new List<BreadcrumbItem>()
            {
                new BreadcrumbItem("Список товаров", "Products", "Index"),
                new BreadcrumbItem(product.Name, "Products", "GetById")
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult AddProductReview([FromForm(Name = "ProductId")] int? id, [FromForm] ReviewDTO reviewDto)
        {
            if (id is null)
                return RedirectToAction("Index");

            Product? product = _productService.GetProductById((int) id);

            if (product is null)
                return RedirectToAction("Index");

            ProductViewModel model = new ProductViewModel()
            {
                Product = product,
                ReviewDTO = new ReviewDTO()
            };

            ViewBag.Breadcrumb = new List<BreadcrumbItem>()
            {
                new BreadcrumbItem("Список товаров", "Products", "Index"),
                new BreadcrumbItem(product.Name, "Products", "AddProductReview")
            };

            if (!ModelState.IsValid)
                return View("~/Views/Products/GetById.cshtml", model);

            return Content($"Author: {reviewDto.Author} / Text: {reviewDto.Text}");
        }

        [HttpGet]
        public IActionResult AddToCart([FromRoute] int? id)
        {
            if (id is null)
                return RedirectToAction("Index");

            Product? product = _productService.GetProductById((int) id);

            if (product is null)
                return RedirectToAction("Index");

            Cart cart = _cartService.GetCart();
            cart.AddItem(product);

            return RedirectToAction("GetById", new { id = id });
        }
    }
}
