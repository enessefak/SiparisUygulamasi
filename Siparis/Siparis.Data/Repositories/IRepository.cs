using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Siparis.Data.Repositories
{
    /// <summary>
    /// Model katmanımızda bulunan her T tipi için aşağıda tanımladığımız fonksiyonları gerçekleştirebilecek generic bir repository tanımlıyoruz.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetAll(Expression<System.Func<T, bool>> predicate); 
        Task<T> GetById(int id);
        Task<T> GetExpression(Expression<System.Func<T, bool>> predicate);
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task Delete(int id);
    }
}
