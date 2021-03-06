﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oicar.Dal.Entities;
using Oicar.Service.Interfaces;
using Oicar.Service.Models;

namespace Oicar.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("register")]
        public ActionResult Register([FromBody] User user)
        {
            return Ok(_userService.Register(user));
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("login")]
        public ActionResult<LoginDTO> Login([FromBody] LoginDTO user)
        {
            return Ok(_userService.Login(user));
        }
    }

}