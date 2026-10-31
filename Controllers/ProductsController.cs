using Microsoft.AspNetCore.Mvc;

namespace Mini_StoreOrderSystem.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{

    [HttpGet("GetProducts")]
    public IEnumerable<Product> Get()
    {
        return new List<Product>
        {
            new Product { ProductID = 1, ProductName = "Product A", Price = 10.99m, StockQuantity = 100 },
            new Product { ProductID = 2, ProductName = "Product B", Price = 15.49m, StockQuantity = 50 },
            new Product { ProductID = 3, ProductName = "Product C", Price = 7.99m, StockQuantity = 200 }
        };
    }

    [HttpGet("GetProduct/{id}")]
    public ActionResult<Product> Get(int id)
    {
        var product = new List<Product>
        {
            new Product { ProductID = 1, ProductName = "Product A", Price = 10.99m, StockQuantity = 100 },
            new Product { ProductID = 2, ProductName = "Product B", Price = 15.49m, StockQuantity = 50 },
            new Product { ProductID = 3, ProductName = "Product C", Price = 7.99m, StockQuantity = 200 }
        }.FirstOrDefault(p => p.ProductID == id);

        if (product == null)
        {
            return NotFound();
        }

        return product;
    }
}
