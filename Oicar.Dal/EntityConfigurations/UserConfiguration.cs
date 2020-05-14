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
            entity.ToTable("User");
            entity.HasData(new User()
                {
                    Id = 1,
                    FirstName = "Admin",
                    LastName = "Ad",
                    Password = "Admin!123",
                    Email = "admin@test.com",
                },
                new User()
                {
                    Id = 2,
                    FirstName = "Test",
                    LastName = "Testic",
                    Password = "Test!123",
                    Email = "test@test.com",
                }
            );
        }
    }
}
