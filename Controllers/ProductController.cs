using DesafioFinal.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesafioFinal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        public ProductController()
        {
                
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            return new OkObjectResult(new Product());
        }

        [HttpGet("byId")]
        public async Task<IActionResult> GetById(int id)
        {
            return new OkObjectResult(new Product { Name = "teste2" });
        }

        [HttpGet("byName")]
        public async Task<IActionResult> GetByName(string name)
        {
            return new OkObjectResult(new Product { Name = "teste1"});
        }

        [HttpGet("count")]
        public async Task<IActionResult> CountProduct()
        {
            return new OkObjectResult(new Product());
        }

        [HttpPost()]
        public async Task<IActionResult> CreateProduct(Product c)
        {
            return new OkResult();
        }

        [HttpPut()]
        public async Task<IActionResult> UpdateProduct(Product c)
        {
            return new OkResult();
        }

        [HttpDelete()]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            return new OkResult();
        }
    }
}
