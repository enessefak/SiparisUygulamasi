using System;
using Siparis.Data.Repositories;
using Siparis.Data.Model;
using System.Data.Entity;
using Siparis.Data.Context;

namespace Siparis.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SiparisContext _dbContext;

        public UnitOfWork(SiparisContext dbContext)
        {
            Database.SetInitializer<SiparisContext>(null);

            if (dbContext == null)
                throw new ArgumentNullException("dbContext null Olamaz.");

            _dbContext = dbContext;

            //_dbContext.Configuration.LazyLoadingEnabled = false;
            //_dbContext.Configuration.ValidateOnSaveEnabled = false;
            //_dbContext.Configuration.ProxyCreationEnabled = false;
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }

            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public Repository<T> GetRepository<T>() where T : class
        {
            return Repository<T>.GetInstance(_dbContext);
        }

        public async System.Threading.Tasks.Task<int> SaveChanges()
        {
            try
            {
                return await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var m = ex.Message;
                throw;
            }
        }
    }
}
