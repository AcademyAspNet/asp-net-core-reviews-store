namespace OnlineStoreReviews.Models.Entities
{
    public class Review
    {
        public required int Id { get; set; }
        public required string Author { get; set; }
        public required string Text { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
