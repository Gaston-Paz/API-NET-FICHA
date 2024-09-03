
namespace DataAccess.Interfaces
{
    internal interface IUnitofWork : IDisposable
    {
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
