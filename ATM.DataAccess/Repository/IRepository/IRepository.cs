using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DataAccess.Repository.IRepository
{
    public interface IRepository<T>where T:class
    {
       Task<T?> GetFirstOrDefault(Expression<Func<T, bool>> filter);
       Task<IEnumerable<T>> GetList();

        void Add(T entity);
        void Remove(T entity);

        void RemoveRange(T entities);
    }
}
