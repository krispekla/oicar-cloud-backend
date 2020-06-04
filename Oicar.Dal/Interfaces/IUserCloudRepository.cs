using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Oicar.Dal.Entities;

namespace Oicar.Dal.Interfaces
{
    public interface IUserCloudRepository : IRepository<UserCloud>
    {
        IEnumerable<UserCloud> GetAllById(int userId);
        IEnumerable<CloudDbSQL> GetAllUserCloudDbSQL();
        IEnumerable<CloudFunction> GetAllUserCloudFunctions();
        IEnumerable<CloudStorage> GetAllUserCloudStorage();
        IEnumerable<CloudVM> GetAllUserCloudVM();
    }
}
