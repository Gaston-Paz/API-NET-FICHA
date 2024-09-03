using AutoMapper;
using BusinessLogic.Interfaces;
using Dapper;
using DataAccess.Interfaces;

namespace BusinessLogic.Logics
{
    public class BaseLogic<T, T2> : IBaseLogic<T, T2>
        where T : class
        where T2 : class
    {
        private readonly IBaseRepository<T> _baseRepository;
        private readonly IMapper _mapper;
        public BaseLogic(IBaseRepository<T> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public async Task<int> AddAsync(DynamicParameters parameters)
        {
            return await _baseRepository.AddAsync(parameters);
        }

        public async Task<int> DeleteAsync(DynamicParameters parameters)
        {
            return await _baseRepository.DeleteAsync(parameters);
        }

        public async Task<List<T2>> GetAllAsync()
        {
            IEnumerable<T> response = await _baseRepository.GetAllAsync();
            List<T> responseList = response.ToList();
            return _mapper.Map<List<T2>>(responseList);
        }

        public async Task<T2?> GetById(int Id)
        {
            T? response = await _baseRepository.GetById(Id);
            return _mapper.Map<T2>(response);
        }

        public async Task<int> UpdateAsync(DynamicParameters parameters)
        {
            return await _baseRepository.UpdateAsync(parameters);
        }
    }
}
