using Mini_StoreOrderSystem.Repository.Interfaces;
using Mini_StoreOrderSystem.Data.DatabaseContext;
using Mini_StoreOrderSystem.Data.Entities;

namespace Mini_StoreOrderSystem.Repository.Implementation
{
    public class OrderRepository(OrderDbContext context) : IOrderRepository
    {
        private readonly OrderDbContext _context = context;

        public async Task AddOrderAsync(Order order)
        {
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteOrderAsync(int orderId)
        {
            var order = await _context.Orders.FindAsync(orderId);
            if (order != null)
            {
                _context.Orders.Remove(order);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Order>> GetAllOrdersAsync()
        {
            return await _context.Orders.AsAsyncEnumerable().ToListAsync();
        }

        public async Task<Order?> GetOrderByIdAsync(int orderId)
        {
            return await _context.Orders.FindAsync(orderId) ?? null;
        }

        public async Task UpdateOrderAsync(Order order)
        {
            _context.Orders.Update(order);
            await _context.SaveChangesAsync();
        }
    }
}