using System;

namespace Oicar.Dal.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        ICloudDbSQLRepository CloudDbSQL { get; }
        ICloudFunctionRepository CloudFunction { get; }
        ICloudStorageRepository CloudStorage { get; }
        ICloudVMRepository CloudVM { get; }
        int Complete();
    }
}
