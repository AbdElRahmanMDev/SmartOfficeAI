using Microsoft.EntityFrameworkCore;
using SmartOfficeAI.Entities;
using System.Linq.Expressions;

namespace SmartOfficeAI.Persistance.Data
{
    public class Repository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> dbSet;


        public Repository(ApplicationDbContext context)
        {
            _context = context;
            dbSet = _context.Set<T>();
        }


        public async Task<T?> GetByIdAsync(Guid id)
        {
            return await dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public async Task AddAsync(T entity)
        {
            await dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
        public IQueryable<T> Query()
        {
            return dbSet.AsQueryable();
        }

        public IQueryable<T> Get()
        {
            return dbSet.Where(entity => !entity.IsDeleted);
        }
        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return Get().Where(predicate);
        }

        public bool Any(Expression<Func<T, bool>> predicate)
        {
            return Get().Any(predicate);
        }


    }
}
