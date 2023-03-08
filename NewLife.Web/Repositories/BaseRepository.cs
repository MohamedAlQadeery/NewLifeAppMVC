using Microsoft.EntityFrameworkCore;
using Newlife.Web.Core.Interfaces.Repositories;
using NewLife.Web.Core.Models;
using NewLife.Web.Data;
using System.Linq.Expressions;

namespace Newlife.Web.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

       

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T> FindAsync(Expression<Func<T, bool>> match, string[] includes = null)
        {
            IQueryable<T> query = _context.Set<T>();
            if(includes != null)
            {
                foreach (var include in includes)
                {
                   query =  query.Include(include);
                }
            }
            
            return await query.SingleOrDefaultAsync(match);
        }

        public async Task<List<T>> FindAllAsync(Expression<Func<T, bool>> match, string[] includes = null)
        {
            IQueryable<T> query = _context.Set<T>();
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }

            return await query.Where(match).ToListAsync();

        }

        public async Task<T> AddAsync(T entity)
        {
           await _context.Set<T>().AddAsync(entity);
            return entity;
        }


        public T Update(T entity)
        {
            _context.Update(entity);
            return entity;
        }

        public  void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        
        
        public async Task<int> CountAsync()
        {
            return await _context.Set<T>().CountAsync();
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> criteria)
        {
            return await _context.Set<T>().CountAsync(criteria);
        }

        public T ToggleStatus(int id)
        {
            var entity = _context.Set<T>().Find(id);
            var model = entity as BaseModel;
            model.IsActive = !model.IsActive;
            _context.Set<T>().Update(entity);
            
            return entity;
        }
    }
}
