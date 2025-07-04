using OnlineStoreReviews.Models.DTO;
using OnlineStoreReviews.Models.Entities;

namespace OnlineStoreReviews.Models.Views
{
    public class ProductViewModel
    {
        public required Product Product { get; set; }
        public ReviewDTO? ReviewDTO { get; set; }
    }
}
