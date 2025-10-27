using DesafioFinal.Models;
using DesafioFinal.Services;
using Microsoft.AspNetCore.Mvc;

namespace DesafioFinal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly ClientService _clientService;

        public ClientController(ClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var clients = await _clientService.GetAllAsync();
            return new OkObjectResult(clients);
        }

        [HttpGet("byId")]
        public async Task<IActionResult> GetById(int id)
        {
            var client = await _clientService.GetClientByIdAsync(id);
            return new OkObjectResult(client);
        }

        [HttpGet("byName")]
        public async Task<IActionResult> GetByEmail(string email)
        {
            var client = await _clientService.GetClientByEmailAsync(email);
            return new OkObjectResult(client);
        }

        [HttpGet("count")]
        public async Task<IActionResult> CountClient()
        {
            var count = await _clientService.GetCountAsync();
            return new OkObjectResult(count);
        }

        [HttpPost()]
        public async Task<IActionResult> CreateClient(Client c)
        {
            await _clientService.CreateClient(c);
            return new OkResult();
        }

        [HttpPut()]
        public async Task<IActionResult> UpdateClient(Client c)
        {
            await _clientService.UpdateClient(c);
            return new OkResult();
        }

        [HttpDelete()]
        public async Task<IActionResult> DeleteClient(int id)
        {
            if(await _clientService.DeleteClientAsync(id))
                return new OkResult();
            else 
                return new NotFoundResult();
        }
    }
}
