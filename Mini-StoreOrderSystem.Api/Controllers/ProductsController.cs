using Microsoft.AspNetCore.Mvc;
using Mini_StoreOrderSystem.Services.Interfaces;
using Mini_StoreOrderSystem.Services.DTO;

namespace Mini_StoreOrderSystem.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController(IProductService productService) : ControllerBase
{
    private readonly IProductService _productService = productService;

    [HttpGet("GetProducts")]
    public async Task<IEnumerable<ProductDto>> Get()
    {
        return await _productService.GetAllProductsAsync();
    }

    [HttpGet("GetProduct/{id}")]
    public async Task<ActionResult<ProductDto>> Get(int id)
    {
        var product = await _productService.GetProductByIdAsync(id);

        if (product == null)
        {
            return NotFound();
        }

        return product;
    }
}
