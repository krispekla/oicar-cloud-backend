using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oicar.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oicar.Dal.EntityConfigurations
{
   public class CloudVMConfiguration
    {
        public CloudVMConfiguration(EntityTypeBuilder<CloudVM> entity)
        {
            entity.ToTable("CloudVM");
        }
    }
}
