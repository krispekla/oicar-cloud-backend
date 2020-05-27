using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oicar.Dal.Entities;

namespace Oicar.Dal.EntityConfigurations
{
    public class UserCloudConfiguration
    {
        public UserCloudConfiguration(EntityTypeBuilder<UserCloud> entity)
        {
            entity.Property(x => x.IsActive).HasDefaultValue(1);
        }
    }
}
