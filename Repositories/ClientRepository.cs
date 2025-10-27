using Dapper;
using DesafioFinal.Models;
using DesafioFinal.Repositories.Scripts;

namespace DesafioFinal.Repositories
{
    public class ClientRepository : BaseRepository<Client>
    {
        internal async Task<int> CountAsync()
        {
            return await base.Count("Client");
        }

        internal async Task<List<Client>> GetAll()
        {
            return (await base.GetAll("Client")).ToList();
        }

        internal async Task<Client> GetByEmail(string email)
        {
            return await _connection.QueryFirstAsync<int>(SQLScripts.GetClientByEmail, new {Email = email});
        }
    }
}
