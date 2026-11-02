using Mini_StoreOrderSystem.Services.Interfaces;
using Mini_StoreOrderSystem.Repository.Interfaces;
using Mini_StoreOrderSystem.Services.DTO;
using Mini_StoreOrderSystem.Data.Entities;
using AutoMapper;
using Mini_StoreOrderSystem.Services.Mappers;

namespace Mini_StoreOrderSystem.Services.Implementation
{
    public class OrderService(IOrderRepository orderRepository) : IOrderService
    {

        private readonly IOrderRepository _orderRepository = orderRepository;

        public async Task AddOrderAsync(OrderDto orderDto)
        {
            var order = OrderDtoToOrderProfile.MapOrderDtoToOrder(orderDto);
            await _orderRepository.AddOrderAsync(order);
        }

        public async Task DeleteOrderAsync(int orderId)
        {
            await orderRepository.DeleteOrderAsync(orderId);
        }

        public async Task<IEnumerable<OrderDto>> GetAllOrdersAsync()
        {
            return await _orderRepository.GetAllOrdersAsync()
                .ContinueWith(task => task.Result.Select(order => OrderDtoToOrderProfile.MapOrderToOrderDto(order)));
        }

        public async Task<OrderDto?> GetOrderByIdAsync(int orderId)
        {
            var order = await _orderRepository.GetOrderByIdAsync(orderId);
            return order != null ? OrderDtoToOrderProfile.MapOrderToOrderDto(order) : null;
        }

        public async Task UpdateOrderAsync(OrderDto orderDto)
        {
            var order = OrderDtoToOrderProfile.MapOrderDtoToOrder(orderDto);
            await _orderRepository.UpdateOrderAsync(order);
        }
    }
}