using Oicar.Dal.Interfaces;
using Oicar.Dal.Repositories;
using System;

namespace Oicar.Dal
{
    public class UnitOfWork : IUnitOfWork
    {
        public IUserRepository Users { get; private set; }

        public IUserCloudRepository UserCloud { get; private set; }

        public ICloudDbSQLRepository CloudDbSQL { get; private set; }

        public ICloudFunctionRepository CloudFunction { get; private set; }

        public ICloudStorageRepository CloudStorage { get; private set; }

        public ICloudVMRepository CloudVM { get; private set; }
        public INewsRepository News { get; private set; }


        private readonly OicarContext _context;
        public UnitOfWork(OicarContext context)
        {
            _context = context;
            Users = new UserRepository(_context);
            CloudDbSQL = new CloudDbSQLRepository(_context);
            CloudFunction = new CloudFunctionRepository(_context);
            CloudStorage = new CloudStorageRepository(_context);
            CloudVM = new CloudVMRepository(_context);
            UserCloud = new UserCloudRepository(_context);
            News = new NewsRepository(_context);
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
