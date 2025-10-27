using DesafioFinal.Models;
using DesafioFinal.Repositories;

namespace DesafioFinal.Services
{
    // Classe de exemplo para compreensão dos papéis dos serviços
    public class ClientService
    {
        private readonly ClientRepository _clientRepository;

        public ClientService(ClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<Client> GetClientByIdAsync(int id)
        {
            return await _clientRepository.GetById(id);
        }
        public async Task<Client> GetClientByEmailAsync(string email)
        {
            return await _clientRepository.GetByEmail(email);
        }

        public async Task<List<Client>> GetAllAsync()
        {
            return await _clientRepository.GetAll();
        }

        public async Task<int> GetCountAsync()
        {
            return await _clientRepository.CountAsync();
        }

        public async Task<bool> CreateClient(Client c)
        {
            var checkClient = await _clientRepository.GetByEmail(c.Email);

            if (checkClient != null)
                return false;

            await _clientRepository.CreateClient(c);
            return true;
        }

        public async Task<bool> UpdateClient(Client c)
        {
            var linesChanged = await _clientRepository.UpdateClient(c);
            if(linesChanged > 0)
                return true;
            return false;
        }

        public async Task<bool> DeleteClientAsync(int id)
        {
            var linesChanged = await _clientRepository.DeleteClient(id);
            if (linesChanged > 0)
                return true;
            return false;
        }
    }
}
