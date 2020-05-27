using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oicar.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oicar.Dal.EntityConfigurations
{
    public class UserConfiguration
    {
        public UserConfiguration(EntityTypeBuilder<User> entity)
        {
            //Password is "admin"
            entity.ToTable("User");
            entity.HasData(new User()
                {
                    Id = 1,
                    FirstName = "Admin",
                    LastName = "Ad",
                    Password = "10000.7mSNp+Oapzv2iVbiybMmSA==.TjfFGVah1ko7+nrYvgKIBwpJGGgVzRz2BcG24jUBMiE=",
                    Email = "admin@test.com",
                },
                new User()
                {
                    Id = 2,
                    FirstName = "Test",
                    LastName = "Testic",
                    Password = "10000.7mSNp+Oapzv2iVbiybMmSA==.TjfFGVah1ko7+nrYvgKIBwpJGGgVzRz2BcG24jUBMiE=",
                    Email = "test@test.com",
                }
            );
        }
    }
}
