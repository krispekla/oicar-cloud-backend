using Oicar.Api.Utils;
using Oicar.Dal;
using Oicar.Dal.Entities;
using Oicar.Dal.Interfaces;
using Oicar.Service.Interfaces;
using Oicar.Service.Models;
using System;
using System.Linq;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Oicar.Api.Helpers;
using Microsoft.Extensions.Options;

namespace Oicar.Service.Services
{
    public class UserService : IUserService
    {
        private IUnitOfWork _uow;
        private IPasswordHasher _passwordHasher;
        private readonly AppSettings _appSettings;

        public UserService(OicarContext context, IOptions<AppSettings> appSettings)
        {
            _uow = new UnitOfWork(context);
            _passwordHasher = new PasswordHasher();
            _appSettings = appSettings.Value;
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

            user.Password = _passwordHasher.Hash(user.Password);

            _uow.Users.Add(user);
            _uow.Complete();
            return new { message = "Korisnik uspješno kreiran" };
        }

        public LoginDTO Login(LoginDTO user)
        {
            User resultUser = _uow.Users.Find(x => x.Email.Equals(user.Email)).FirstOrDefault();

            if (resultUser != null)
            {
                if (!_passwordHasher.Check(resultUser.Password, user.Password))
                    throw new Exception("Kriva lozinka ili korisnicki racun ne postoji");


                // authentication successful so generate jwt token
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                    new Claim(ClaimTypes.Name, resultUser.Id.ToString())
                    }),
                    Expires = DateTime.UtcNow.AddDays(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                user.Token = tokenHandler.WriteToken(token);
                user.Id = resultUser.Id;
                return user;
            }
            else
                throw new Exception("Kriva lozinka ili korisnicki racun ne postoji");

        }
    }
}
