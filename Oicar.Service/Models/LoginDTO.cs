﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Oicar.Service.Models
{
    public class LoginDTO
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
