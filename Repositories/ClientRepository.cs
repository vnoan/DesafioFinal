using Dapper;
using DesafioFinal.Models;
using DesafioFinal.Repositories.Scripts;
using System.Data;

namespace DesafioFinal.Repositories
{
    // Classe de exemplo para compreensão dos papéis dos Repositories
    public class ClientRepository : BaseRepository<Client>
    {
        public ClientRepository(IDbConnection connection) : base(connection)
        {
            
        }

        internal async Task<int> CountAsync()
        {
            return await base.Count("Client");
        }

        internal async Task<Client> GetById(int id)
        {
            return await base.GetById("Client", id);
        }

        internal async Task<List<Client>> GetAll()
        {
            return (await base.GetAll("Client")).ToList();
        }

        internal async Task<int> DeleteClient(int id)
        {
            return await base.Delete("Client", id);
        }

        internal async Task<Client> GetByEmail(string email)
        {
            return await _connection.QueryFirstOrDefaultAsync<Client>(SQLScripts.GetClientByEmail, new {Email = email});
        }

        internal async Task<int> CreateClient(Client client)
        {
            return await _connection.ExecuteAsync(SQLScripts.InsertClient, 
                new 
                { 
                    Id = client.Id,
                    Email = client.Email,
                    Name = client.Name,
                    Phone = client.Phone,
                    Address = client.Address,
                    City = client.City
                });
        }

        internal async Task<int> UpdateClient(Client client)
        {
            return await _connection.ExecuteAsync(SQLScripts.UpdateClient,
                new
                {
                    Id = client.Id,
                    Name = client.Name,
                    Phone = client.Phone,
                    Address = client.Address,
                    City = client.City
                });
        }
    }
}
