using Microsoft.AspNetCore.Mvc;

namespace Mini_StoreOrderSystem.Controllers;

[ApiController]
[Route("[controller]")]
public class OrdersController : ControllerBase
{

    [HttpGet("GetOrders")]
    public IEnumerable<Order> Get()
    {
        return new List<Order>
        {
            new Order { OrderID = 1, ProductID = 1, OrderDate = DateTime.Parse("2024-01-15"), TotalAmount = 19.99m },
            new Order { OrderID = 2, ProductID = 2, OrderDate = DateTime.Parse("2024-01-16"), TotalAmount = 29.99m },
            new Order { OrderID = 3, ProductID = 3, OrderDate = DateTime.Parse("2024-01-17"), TotalAmount = 9.99m }
        };
    }

    [HttpGet("GetOrder/{id}")]
    public ActionResult<Order> Get(int id)
    {
        var order = new List<Order>
        {
            new Order { OrderID = 1, ProductID = 1, OrderDate = DateTime.Parse("2024-01-15"), TotalAmount = 19.99m },
            new Order { OrderID = 2, ProductID = 2, OrderDate = DateTime.Parse("2024-01-16"), TotalAmount = 29.99m },
            new Order { OrderID = 3, ProductID = 3, OrderDate = DateTime.Parse("2024-01-17"), TotalAmount = 9.99m }
        }.FirstOrDefault(o => o.OrderID == id);

        if (order == null)
        {
            return NotFound();
        }

        return order;
    }
}

