using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Assignment.DataAccessLayer.Infrastructure.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task<T?> GetEntity(Expression<Func<T,bool>>predicate);
        /*Task<IList<T>> GetAll();
        Task<string> Update(T entity);
        Task<string> Delete(T entity);
        Task<string> DeleteRange(IList<T> entities);
        Task<string> Cretae(T entity);*/
        Task<IList<T>> GetAll();
        Task<string> Cretae(T entity);
        string Update(T entity);
        string Delete(T entity);
        string DeleteRange(IList<T> entities);
    }
}
