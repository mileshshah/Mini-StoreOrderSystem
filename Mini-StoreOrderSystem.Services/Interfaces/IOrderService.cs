using Mini_StoreOrderSystem.Services.DTO;

namespace Mini_StoreOrderSystem.Services.Interfaces
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderDto>> GetAllOrdersAsync();
        Task<OrderDto?> GetOrderByIdAsync(int orderId);
        Task AddOrderAsync(OrderDto order);
        Task UpdateOrderAsync(OrderDto order);
        Task DeleteOrderAsync(int orderId);
    }
}