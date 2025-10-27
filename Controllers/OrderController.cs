using DesafioFinal.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesafioFinal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        public OrderController()
        {
                
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            return new OkObjectResult(new Order());
        }

        [HttpGet("byId")]
        public async Task<IActionResult> GetById(int id)
        {
            return new OkObjectResult(new Order());
        }

        [HttpGet("count")]
        public async Task<IActionResult> CountOrder()
        {
            return new OkObjectResult(new Order());
        }

        [HttpPost()]
        public async Task<IActionResult> CreateOrder(Order c)
        {
            return new OkResult();
        }

        [HttpPut("addProduct")]
        public async Task<IActionResult> AddProduct(int orderId, int productId)
        {
            return new OkResult();
        }

        [HttpPut("RemoveProduct")]
        public async Task<IActionResult> RemoveProduct(int orderId, int productId)
        {
            return new OkResult();
        }

        [HttpDelete()]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            return new OkResult();
        }
    }
}
