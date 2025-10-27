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
            var clients = _clientService.GetAll();
            return new OkObjectResult(clients);
        }

        [HttpGet("byId")]
        public async Task<IActionResult> GetById(int id)
        {
            var client = _clientService.GetClientById(id);
            return new OkObjectResult(client);
        }

        [HttpGet("byName")]
        public async Task<IActionResult> GetByEmail(string email)
        {
            var client = _clientService.GetClientByEmail(email);
            return new OkObjectResult(client);
        }

        [HttpGet("count")]
        public async Task<IActionResult> CountClient()
        {
            var count = _clientService.GetCount();
            return new OkObjectResult(count);
        }

        [HttpPost()]
        public async Task<IActionResult> CreateClient(Client c)
        {
            _clientService.CreateClient(c);
            return new OkResult();
        }

        [HttpPut()]
        public async Task<IActionResult> UpdateClient(Client c)
        {
            _clientService.UpdateClient(c);
            return new OkResult();
        }

        [HttpDelete()]
        public async Task<IActionResult> DeleteClient(int id)
        {
            if(_clientService.DeleteClient(id))
                return new OkResult();
            else 
                return new NotFoundResult();
        }
    }
}
