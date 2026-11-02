using Mini_StoreOrderSystem.Services.Interfaces;
using Mini_StoreOrderSystem.Repository.Interfaces;
using Mini_StoreOrderSystem.Services.DTO;
using Mini_StoreOrderSystem.Services.Mappers;

namespace Mini_StoreOrderSystem.Services.Implementation
{
    public class ProductService(IProductRepository productRepository) : IProductService
    {

        private readonly IProductRepository _productRepository = productRepository;

        public async Task AddProductAsync(ProductDto product)
        {
            var productEntity = ProductDtoToProductProfile.MapProductDtoToProduct(product);
            await _productRepository.AddProductAsync(productEntity);
        }

        public async Task<ProductDto?> GetProductByIdAsync(int productId)
        {
            var product = await _productRepository.GetProductByIdAsync(productId);
            return product != null ? ProductDtoToProductProfile.MapProductToProductDto(product) : null;
        }
        

        public async Task UpdateProductAsync(ProductDto product)
        {
            var productEntity = ProductDtoToProductProfile.MapProductDtoToProduct(product);
            await _productRepository.UpdateProductAsync(productEntity);
        }
        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllProductsAsync()
                .ContinueWith(task => task.Result.Select(product => ProductDtoToProductProfile.MapProductToProductDto(product)));
        }

        public async Task DeleteProductAsync(int productId)
        {
            await _productRepository.DeleteProductAsync(productId);
        }
    }
}