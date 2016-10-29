using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity.Infrastructure;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Siparis.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;
        private Repository(DbContext dbContext)
        {
            if (dbContext == null)
                throw new ArgumentNullException("DBContext null olamaz.");

            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }
        private static Repository<T> _instance;
        public static Repository<T> GetInstance(DbContext dbContext)
        {

            if (_instance == null)
            {
                _instance = new Repository<T>(dbContext);
            }

            return _instance;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<T> GetExpression(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).SingleOrDefaultAsync();
        }

        public async Task Add(T entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Added;
            _dbSet.Add(entity);
        }

        public async Task Update(T entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public async Task Delete(T entity)
        {
            DbEntityEntry dbEntityEntry = _dbContext.Entry(entity);

            if (dbEntityEntry.State != EntityState.Deleted)
            {
                dbEntityEntry.State = EntityState.Deleted;
            }
            else
            {
                _dbSet.Attach(entity);
                _dbSet.Remove(entity);
            }
        }

        public async Task Delete(int id)
        {
            T entity = await GetById(id);
            await Delete(entity);
        }

    }
}
