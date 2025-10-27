using Dapper;
using DesafioFinal.Models;
using DesafioFinal.Repositories.Scripts;
using System.Data;

namespace DesafioFinal.Repositories
{
    public class OrderRepository : BaseRepository<Order>
    {
        public OrderRepository(IDbConnection connection) : base(connection)
        {

        }

        internal async Task<int> CountAsync()
        {
            return await base.Count("Order");
        }

        internal async Task<Order> GetById(int id)
        {
            return await base.GetById("Order", id);
        }

        internal async Task<List<Order>> GetAll()
        {
            return (await base.GetAll("Order")).ToList();
        }
    }
}
