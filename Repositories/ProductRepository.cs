using DesafioFinal.Models;
using System.Data;

namespace DesafioFinal.Repositories
{
    public class ProductRepository : BaseRepository<Product>
    {
        public ProductRepository(IDbConnection connection) : base(connection)
        {

        }

        internal async Task<int> CountAsync()
        {
            return await base.Count("Product");
        }

        internal async Task<Product> GetById(int id)
        {
            return await base.GetById("Product", id);
        }

        internal async Task<List<Product>> GetAll()
        {
            return (await base.GetAll("Product")).ToList();
        }
    }
}
