using Oicar.Dal.Entities;

namespace Oicar.Dal.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        User Get(string id);
    }
}
