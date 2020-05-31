using Oicar.Dal.Entities;
using Oicar.Service.Models;

namespace Oicar.Service.Interfaces
{
    public interface IUserService
    {
        LoginDTO Login(LoginDTO user);
        object Register(User user);
    }
}
