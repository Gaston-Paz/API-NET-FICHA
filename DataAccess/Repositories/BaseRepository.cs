using Dapper;
using DataAccess.Interfaces;
using System.Data;
using System.Transactions;

namespace DataAccess.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private DapperDataContext _dapperDataContext;
        public IDbTransaction Transaction { get; internal set; }

        public BaseRepository(DapperDataContext dapperDataContext, string tableName)
        {
            _dapperDataContext = dapperDataContext;
            _tableName = tableName;
        }

        private readonly string _tableName;
        protected string InsertCommand { get { return string.Format("sp{0}_Insert", _tableName); } }
        protected string UpdateCommand { get { return string.Format("sp{0}_Update", _tableName); } }
        protected string DeleteCommand { get { return string.Format("sp{0}_Delete", _tableName); } }
        protected string GetAllCommand { get { return string.Format("sp{0}_GetAll", _tableName); } }
        protected string GetByIdCommand { get { return string.Format("sp{0}_GetById", _tableName); } }

        protected string GetCommandName(string action)
        {
            return string.Format("sp{0}_{1}", _tableName, action);
        }

        protected IDbConnection GetDbConnection()
        {
            var connection = _dapperDataContext.Connection;
            if (connection != null)
            {
                return connection;
            }

            // Manejar el caso cuando la conexión es nula
            throw new Exception("La conexión a la base de datos es nula.");
        }

        public async Task<int> AddAsync(DynamicParameters parameters)
        {
            return await GetDbConnection().ExecuteAsync(InsertCommand, parameters, transaction: Transaction, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await GetDbConnection().QueryAsync<T>(GetAllCommand, commandType: CommandType.StoredProcedure);
        }

        public async Task<T?> GetById(int Id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", Id);
            var response = await GetDbConnection().QueryAsync<T>(GetAllCommand, parameters, commandType: CommandType.StoredProcedure);
            return response.FirstOrDefault();
        }

        public async Task<int> DeleteAsync(DynamicParameters parameters)
        {
            return await GetDbConnection().ExecuteAsync(DeleteCommand, parameters, transaction: Transaction, commandType: CommandType.StoredProcedure);
        }

        public async Task<int> UpdateAsync(DynamicParameters parameters)
        {
            return await GetDbConnection().ExecuteAsync(UpdateCommand, parameters, transaction: Transaction, commandType: CommandType.StoredProcedure);
        }

        public DapperDataContext Context
        {
            get { return _dapperDataContext; }
            internal set { _dapperDataContext = value; }
        }

    }
}
