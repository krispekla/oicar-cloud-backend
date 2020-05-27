using Oicar.Api.Utils;
using Oicar.Dal;
using Oicar.Dal.Entities;
using Oicar.Dal.Interfaces;
using Oicar.Service.Interfaces;
using Oicar.Service.Models;
using System;
using System.Linq;

namespace Oicar.Service.Services
{
    public class UserService : IUserService
    {
        private IUnitOfWork _uow;
        private IPasswordHasher _passwordHasher;
        public UserService(OicarContext context)
        {
            _uow = new UnitOfWork(context);
            _passwordHasher = new PasswordHasher();
        }

        public object Register(User user)
        {

            if (string.IsNullOrWhiteSpace(user.FirstName))
                throw new Exception("Ime nije uneseno");
            if (string.IsNullOrWhiteSpace(user.LastName))
                throw new Exception("Prezime nije uneseno");
            if (string.IsNullOrWhiteSpace(user.Email))
                throw new Exception("Email nije unesen");
            if (string.IsNullOrWhiteSpace(user.Password))
                throw new Exception("Lozinka nije unesena");

            user.Password =  _passwordHasher.Hash(user.Password);

            _uow.Users.Add(user);
            _uow.Complete();
            return new { message = "Korisnik uspješno kreiran" };
        }

        public object Login(LoginDTO user)
        {
            User resultUser = _uow.Users.Find(x => x.Email.Equals(user.Email)).FirstOrDefault();

            if (resultUser != null)
            {
               if(!_passwordHasher.Check(resultUser.Password, user.Password))
                    throw new Exception("Kriva lozinka ili korisnicki racun ne postoji");

                return new { message = "korisnik uspjesno prijavljen, tu ce mu proslijediti token itd" };
            }
            else
                throw new Exception("Kriva lozinka ili korisnicki racun ne postoji");
        }
    }
}
