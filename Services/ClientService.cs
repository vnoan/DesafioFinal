using DesafioFinal.Models;
using DesafioFinal.Repositories;

namespace DesafioFinal.Services
{
    public class ClientService
    {
        private readonly ClientRepository _clientRepository;

        public ClientService(ClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public Client GetClientById(int id)
        {
            return _clientRepository.GetById(id);
        }
        public Client GetClientByEmail(string email)
        {
            return _clientRepository.GetByEmail(email);
        }

        public List<Client> GetAll()
        {
            return _clientRepository.GetAll();
        }

        public int GetCount()
        {
            return _clientRepository.CountAsync();
        }

        public bool CreateClient(Client c)
        {
            throw new NotImplementedException();
        }

        public bool UpdateClient(Client c)
        {
            throw new NotImplementedException();
        }

        public bool DeleteClient(int id)
        {
            throw new NotImplementedException();
        }
    }
}
