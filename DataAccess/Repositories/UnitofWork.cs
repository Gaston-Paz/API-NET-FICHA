using DataAccess.Interfaces;
using System.Data;

namespace DataAccess.Repositories
{
    public class UnitofWork : IUnitofWork, IDisposable
    {
        private readonly DapperDataContext _dapperDataContextEco;

        private bool _disposed = false;

        public UnitofWork()
        {
            _dapperDataContextEco = new DapperDataContext();
        }

        private void OpenConnectionIfNeeded(DapperDataContext context)
        {
            if (context.Connection?.State != ConnectionState.Open)
            {
                context.Connection?.Open();
            }
        }

        private void StartTransactionIfNeeded(DapperDataContext context)
        {
            if (context.Transaction == null)
            {
                context.Transaction = context.Connection?.BeginTransaction();
            }
        }

        public void Commit()
        {
            CommitTransaction(_dapperDataContextEco);
        }

        private void CommitTransaction(DapperDataContext context)
        {
            if (context.Transaction != null)
            {
                context.Transaction.Commit();
                context.Transaction.Dispose();
                context.Transaction = null;
            }
        }

        public void Rollback()
        {
            RollbackTransaction(_dapperDataContextEco);
        }

        private void RollbackTransaction(DapperDataContext context)
        {
            if (context.Transaction != null)
            {
                context.Transaction.Rollback();
                context.Transaction.Dispose();
                context.Transaction = null;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Dispose managed resources
                    Commit();
                    _dapperDataContextEco.Connection?.Dispose();
                }

                _disposed = true;
            }
        }

        public void BeginTransaction()
        {
            OpenConnectionIfNeeded(_dapperDataContextEco);

            StartTransactionIfNeeded(_dapperDataContextEco);
        }


    }
}
