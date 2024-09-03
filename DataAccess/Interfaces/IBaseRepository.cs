
using Dapper;

namespace DataAccess.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<int> AddAsync(DynamicParameters parameters);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetById(int Id);
        Task<int> DeleteAsync(DynamicParameters parameters);
        Task<int> UpdateAsync(DynamicParameters parameters);
    }
}
