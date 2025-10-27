using Dapper;
using DesafioFinal.Models;
using DesafioFinal.Repositories.Scripts;
using System.Data;

namespace DesafioFinal.Repositories
{
    public abstract class BaseRepository<T> where T : BaseModel
    {
        protected readonly IDbConnection _connection;

        protected BaseRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public virtual async Task<IEnumerable<T>> GetAll(string table)
        {
            return await _connection.QueryAsync<T>(SQLScripts.GetAllGeneric.Replace("{Table}", table));
        }

        public virtual async Task<T> GetById(string table, int id)
        {
            return await _connection.QuerySingleOrDefaultAsync<T>(SQLScripts.GetGeneric.Replace("{Table}", table), new { Id = id });
        }

        public virtual async Task<int> Count(string table)
        {
            return await _connection.QueryFirstAsync<int>(SQLScripts.CountGeneric.Replace("{Table}", table));
        }

        public virtual async Task<int> Delete(string table, int id)
        {
            return await _connection.ExecuteAsync(SQLScripts.DeleteGeneric.Replace("{Table}", table), new { Id = id});
        }
    }
}
