using Oicar.Dal.Entities;

namespace Oicar.Service.Interfaces
{
    public interface IUserService
    {
        void Login(User user);
        void Register(User user);
    }
}
