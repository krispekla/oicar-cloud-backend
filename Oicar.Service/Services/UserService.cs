using Oicar.Dal;
using Oicar.Dal.Entities;
using Oicar.Dal.Interfaces;
using Oicar.Service.Interfaces;
using System.Linq;

namespace Oicar.Service.Services
{
    public class UserService : IUserService
    {
        private IUnitOfWork _uow;

        public UserService(OicarContext context)
        {
            _uow = new UnitOfWork(context);
        }

        public void Register(User user)
        {
            user.FirstName = "Kris";
            user.LastName= "Pekla";

            _uow.Users.Add(user);
            _uow.Complete();
        }  
        
        public void Login(User user)
        {
            user.FirstName = "Kris";
            user.LastName= "Pekla";

           User resultUser =  _uow.Users.Find(x => x.FirstName.Equals(user.FirstName)).FirstOrDefault();
        }
    }
}
