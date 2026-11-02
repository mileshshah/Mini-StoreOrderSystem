using AutoMapper;
using Mini_StoreOrderSystem.Services.DTO;
using Mini_StoreOrderSystem.Data.Entities;

namespace Mini_StoreOrderSystem.Services.Mappers
{
    public class OrderDtoToOrderProfile
    {
        public static Order MapOrderDtoToOrder(OrderDto orderDto)
        {
            Order order = new()
            {
                OrderID = orderDto.OrderID,
                ProductID = orderDto.ProductID,
                OrderDate = orderDto.OrderDate,
                TotalAmount = orderDto.TotalAmount
            };
            return order;
        }

        public static OrderDto MapOrderToOrderDto(Order order)
        {
            OrderDto orderDto = new()
            {
                OrderID = order.OrderID,
                ProductID = order.ProductID,
                OrderDate = order.OrderDate,
                TotalAmount = order.TotalAmount
            };
            return orderDto;
        }
    }
}