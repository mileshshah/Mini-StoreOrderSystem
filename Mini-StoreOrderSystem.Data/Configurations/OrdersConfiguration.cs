using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mini_StoreOrderSystem.Data.Entities;

namespace Mini_StoreOrderSystem.Data.Configurations
{
    public class OrdersConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(o => o.OrderID);
            builder.Property(o => o.ProductID).IsRequired();
            builder.Property(o => o.OrderDate).IsRequired();
            builder.HasData(
            new Order 
            { 
                OrderID = 1, 
                ProductID = 1, 
                OrderDate = new DateTime(2024, 1, 15), 
                TotalAmount = 19.99m 
            },
            new Order 
            { 
                OrderID = 2, 
                ProductID = 2, 
                OrderDate = new DateTime(2024, 1, 16), 
                TotalAmount = 29.99m 
            },
            new Order 
            { 
                OrderID = 3, 
                ProductID = 3, 
                OrderDate = new DateTime(2024, 1, 17), 
                TotalAmount = 9.99m 
            }
        );
        }
    }
}