using Siparis.Data.Repositories;
using System;

namespace Siparis.Data.UnitOfWork
{
    public interface IUnitOfWork: IDisposable
    {
        Repository<T> GetRepository<T>() where T : class;
        System.Threading.Tasks.Task<int> SaveChanges();
    }
}
