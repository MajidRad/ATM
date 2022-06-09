using ATM.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AtmContext _db;
        public DbSet<T> dbSet;
        public Repository(AtmContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
        }
        public void Add(T entity)
        {
            _db.Add(entity);
        }

        public async Task<T?> GetFirstOrDefault(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;
            query = query
                 .Where(filter);
            return await query.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> GetList()
        {
            var query = dbSet;
            return await query.ToListAsync();
        }

        public void Remove(T entity)
        {
            _db.Remove(entity);
        }

        public void RemoveRange(T entities)
        {
            _db.RemoveRange(entities);
        }


    }
}
