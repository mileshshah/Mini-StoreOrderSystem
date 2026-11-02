using Mini_StoreOrderSystem.Repository.Interfaces;
using Mini_StoreOrderSystem.Data.DatabaseContext;
using Mini_StoreOrderSystem.Data.Entities;

namespace Mini_StoreOrderSystem.Repository.Implementation
{
    public class ProductRepository(ProductDbContext context) : IProductRepository
    {
        private readonly ProductDbContext _context = context;

        public async Task AddProductAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _context.Products.AsAsyncEnumerable().ToListAsync();
        }

        public async Task<Product?> GetProductByIdAsync(int productId)
        {
            return await _context.Products.FindAsync(productId) ?? null;
        }

        public async Task UpdateProductAsync(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}