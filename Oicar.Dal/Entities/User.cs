﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Oicar.Dal.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
