using Jungle_DataAccess.Data;
using Jungle_DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_DataAccess.Repository
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly JungleDbContext _db;

        public UnitOfWork(JungleDbContext db)
        {
            _db = db;

        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
