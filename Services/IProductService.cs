using OnlineStoreReviews.Models.Entities;

namespace OnlineStoreReviews.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product? GetProductById(int id);
    }
}
