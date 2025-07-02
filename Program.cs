using OnlineStoreReviews.Services;
using OnlineStoreReviews.Services.Implementations;

namespace OnlineStoreReviews
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<IProductService, ProductService>();

            var app = builder.Build();

            app.UseStaticFiles();

            app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
