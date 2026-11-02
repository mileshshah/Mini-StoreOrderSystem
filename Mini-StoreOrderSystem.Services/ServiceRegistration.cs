using Microsoft.Extensions.DependencyInjection;
using Mini_StoreOrderSystem.Services.Implementation;
using Mini_StoreOrderSystem.Services.Interfaces;
using Mini_StoreOrderSystem.Services.Mappers;
using Mini_StoreOrderSystem.Repository.Interfaces;
using Mini_StoreOrderSystem.Repository.Implementation;
using Mini_StoreOrderSystem.Data.DatabaseContext;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Mini_StoreOrderSystem.Services
{
    public static class ServiceRegistration
    {
        public static void AddServicesAndRepos(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ProductDbContext>(options =>
    options.UseSqlite(configuration.GetConnectionString("ProductConnection")));
            services.AddDbContext<OrderDbContext>(options =>
    options.UseSqlite(configuration.GetConnectionString("OrderConnection")));
            services.AddAutoMapper(cfg => 
                cfg.AddMaps(typeof(ProductDtoToProductProfile).Assembly));
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
        }
    }
}