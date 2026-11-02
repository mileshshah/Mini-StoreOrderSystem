using Microsoft.AspNetCore.Mvc;
using Mini_StoreOrderSystem.Services.Interfaces;
using Mini_StoreOrderSystem.Services.DTO;

namespace Mini_StoreOrderSystem.Controllers;

[ApiController]
[Route("[controller]")]
public class OrdersController(IOrderService orderService) : ControllerBase
{
    private readonly IOrderService _orderService = orderService;

    [HttpGet("GetOrders")]
    public async Task<IEnumerable<OrderDto>> Get()
    {
        return await _orderService.GetAllOrdersAsync();
    }
    

    [HttpGet("GetOrder/{id}")]
    public async Task<ActionResult<OrderDto>> Get(int id)
    {
        var order = await _orderService.GetOrderByIdAsync(id);

        if (order == null)
        {
            return NotFound();
        }

        return order;
    }
}

