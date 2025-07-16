using OnlineStoreReviews.Models.Entities;

namespace OnlineStoreReviews.Services.Implementations
{
    public class CartService : ICartService
    {
        private readonly Cart _sharedCart;

        public CartService()
        {
            _sharedCart = new Cart()
            {
                Id = 1
            };
        }

        public Cart GetCart()
        {
            return _sharedCart;
        }
    }
}
