using OnlineStoreReviews.Models.Entities;

namespace OnlineStoreReviews.Services.Implementations
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product() { Id = 1, Name = "Молоко", Description = "Просто описание молока.", Price = 100 },
                new Product() { Id = 2, Name = "Хлеб", Description = "Просто описание хлеба.", Price = 25 },
                new Product() { Id = 3, Name = "Помидоры", Price = 30 },
                new Product() { Id = 4, Name = "Огурцы", Price = 27 },
            };
        }

        public Product? GetProductById(int id)
        {
            foreach (Product product in GetProducts())
            {
                if (product.Id == id)
                    return product;
            }

            return null;
        }
    }
}
