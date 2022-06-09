using ATM.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AtmContext _db;

        public UnitOfWork(AtmContext db)
        {
            _db = db;
        }
        public void SaveChangesAsync()
        {
            _db.SaveChangesAsync();
        }
    }
}
