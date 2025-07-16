namespace OnlineStoreReviews.Models.Entities
{
    public class Cart
    {
        public required int Id { get; set; }
        public List<CartItem> Items { get; set; } = new List<CartItem>();

        public void AddItem(Product product, int amount = 1)
        {
            foreach (CartItem item in Items)
            {
                if (item.ProductId == product.Id)
                {
                    item.Amount += amount;
                    return;
                }
            }

            CartItem newItem = new CartItem()
            {
                ProductId = product.Id,
                Amount = amount
            };

            Items.Add(newItem);
        }
    }
}
