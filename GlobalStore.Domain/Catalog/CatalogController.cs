using Microsoft.AspNetCore.Mvc;
using GlobalStore.Domain.Catalog;

namespace GlobalStore.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
    
    [HttpGet]
    public IActionResult GetItems()
    {
        var items = new List<Item>()
        {
            new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m),
            new Item("Shorts", "Ohio State shorts.", "Nike", 49.99m)
        };
        return Ok(items);
    }
    }
}