using System.Data;

namespace DataAccess.Interfaces
{
    public interface IDapperDataContext
    {
        IDbConnection Connection { get; }
    }
}
