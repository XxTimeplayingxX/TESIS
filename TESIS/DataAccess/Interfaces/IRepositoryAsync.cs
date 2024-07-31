using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DB.DataAccess.Interfaces
{
    public interface IRepositoryAsync<T> : IDisposable where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetByID(int id);
        Task<T> Insert(T entity);
        Task<T> Delete(int id);
        Task Update(T student);
        Task<T> Find(Expression<Func<T, bool>> expr);
    }
}
