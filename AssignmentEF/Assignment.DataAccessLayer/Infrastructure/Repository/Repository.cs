using Assignment.DataAccessLayer.Data;
using Assignment.DataAccessLayer.Infrastructure.IRepository;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Assignment.DataAccessLayer.Infrastructure.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private ErpContext _context { get; }
        private DbSet<T> _dbSet;
        public Repository(ErpContext context) 
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public async Task<string> Cretae(T entity)
        {
            try
            {
                await _dbSet.AddAsync(entity);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
            return "Succesfully";
        }

        public string Delete(T entity)
        {
            try
            {
                _dbSet.Remove(entity);
            }
            catch (Exception ex) 
            { 
                return ex.Message;
            }
            return "Successfully";
        }

        public string DeleteRange(IList<T> entities)
        {
            try 
            {
                _dbSet.RemoveRange(entities);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "Sucessfully";
        }

        public async Task<IList<T>> GetAll()
        {
            return  await _dbSet.ToListAsync();

            /*IList<T> data;
            try
            {
                data = _dbSet.ToList();
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            return data;*/
        }

        public string Update(T entity)
        {
            try
            {
                _dbSet.Update(entity);
            }
            catch(Exception ex)
            {
                return ex.Message;
            }

            return "Sucessfully";
        }

        public async Task<T?> GetEntity(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).FirstOrDefaultAsync();
        }
    }
}