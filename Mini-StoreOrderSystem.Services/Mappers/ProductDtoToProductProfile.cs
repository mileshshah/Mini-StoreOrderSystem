
using Mini_StoreOrderSystem.Services.DTO;
using Mini_StoreOrderSystem.Data.Entities;

namespace Mini_StoreOrderSystem.Services.Mappers
{
    public class ProductDtoToProductProfile
    {
        public static Product MapProductDtoToProduct(ProductDto productDto)
        {
            Product product = new()
            {
                ProductID = productDto.ProductID,
                ProductName = productDto.ProductName,
                StockQuantity = productDto.StockQuantity,
                Price = productDto.Price
            };
            return product;
        }

        public static ProductDto MapProductToProductDto(Product product)
        {
            ProductDto productDto = new()
            {
                ProductID = product.ProductID,
                ProductName = product.ProductName,
                StockQuantity = product.StockQuantity,
                Price = product.Price
            };
            return productDto;
        }
    }
}