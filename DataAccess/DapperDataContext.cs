using DataAccess.Interfaces;
using MySqlConnector;
using System.Data;

namespace DataAccess
{
    public class DapperDataContext: IDapperDataContext
    {
        private readonly string? _connectionString;
        private IDbConnection? _connection;
        private IDbTransaction? _transaction;
        public DapperDataContext()
        {
            _connectionString = System.Environment.GetEnvironmentVariable("MySqlConnectionString");
        }


        public IDbConnection? Connection
        {
            get
            {
                if (_connection is null || _connection.State != ConnectionState.Open)
                    _connection = new MySqlConnection(_connectionString);
                return _connection;
            }
        }
        public IDbTransaction? Transaction
        {
            get
            {
                return _transaction;
            }

            set
            {
                _transaction = value;
            }
        }
    }
}

