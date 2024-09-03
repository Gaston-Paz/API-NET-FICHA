using Dapper;

namespace BusinessLogic.Interfaces
{
    public interface IBaseLogic<T, T2>
        where T : class
        where T2 : class
    {
        Task<int> AddAsync(DynamicParameters parameters);
        Task<List<T2>> GetAllAsync();
        Task<T2?> GetById(int Id);
        Task<int> DeleteAsync(DynamicParameters parameters);
        Task<int> UpdateAsync(DynamicParameters parameters);

    }
}
