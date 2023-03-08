using System.Linq.Expressions;

namespace Newlife.Web.Core.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T: class
    {
        Task<T> GetByIdAsync(int id);

        Task<List<T>> GetAllAsync();

        Task<T> FindAsync(Expression<Func<T, bool>> match,string[] includes = null);
        Task<List<T>> FindAllAsync(Expression<Func<T, bool>> match,string[] includes = null);


        Task<T> AddAsync(T entity);

        T Update(T entity);
         T ToggleStatus(int id);
        void Delete(T entity);
      
        Task<int> CountAsync();
        Task<int> CountAsync(Expression<Func<T, bool>> criteria);

    }
}
