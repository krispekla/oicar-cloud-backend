using Oicar.Dal.Interfaces;
using Oicar.Dal.Repositories;
using System;

namespace Oicar.Dal
{
    public class UnitOfWork : IUnitOfWork
    {
        public IUserRepository Users { get; private set; }

        private readonly OicarContext _context;
        public UnitOfWork(OicarContext context)
        {
            _context = context;
            Users = new UserRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
