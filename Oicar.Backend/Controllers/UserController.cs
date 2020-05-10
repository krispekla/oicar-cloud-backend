using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oicar.Dal.Entities;
using Oicar.Service.Interfaces;

namespace Oicar.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        //Samo za brzo testiranje da je sve povezano
        [HttpGet]
        [Route("register")]
        public ActionResult Register()

        {
            User user = new User();
            _userService.Register(user);
            return Ok();
        }

        [HttpPost]
        [Route("login")]
        public ActionResult Login()
        {
            //User user = new User();
            //_userService.Login(user);
            Console.WriteLine("prosao");
            User user = new User();
            user.FirstName = "Kris";
            user.Email= "test@";
            return Ok(user);
        }
    }

}