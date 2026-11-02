using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mini_StoreOrderSystem.Data.Entities;

namespace Mini_StoreOrderSystem.Data.Configurations
{
    public class ProductsConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(p => p.ProductID);
            builder.Property(p => p.ProductName).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Price).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(p => p.StockQuantity).IsRequired();

            builder.HasData(
            new Product { ProductID = 1, ProductName = "Product A", Price = 19.99m, StockQuantity = 100 },
            new Product { ProductID = 2, ProductName = "Product B", Price = 29.99m, StockQuantity = 50 },
            new Product { ProductID = 3, ProductName = "Product C", Price = 9.99m, StockQuantity = 200 }
            );
        }
    }
}