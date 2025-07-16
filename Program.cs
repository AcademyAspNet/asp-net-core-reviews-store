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
            builder.Services.AddSession();

            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddSingleton<ICartService, CartService>();

            var app = builder.Build();

            app.UseStaticFiles();
            app.UseSession();

            app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
