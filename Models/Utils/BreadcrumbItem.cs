namespace OnlineStoreReviews.Models.Utils
{
    public record BreadcrumbItem(
        string Text,
        string ControllerName,
        string ActionName
    );
}
