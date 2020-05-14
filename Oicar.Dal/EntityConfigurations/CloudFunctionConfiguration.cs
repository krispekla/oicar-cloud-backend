using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oicar.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oicar.Dal.EntityConfigurations
{
    public class CloudFunctionConfiguration
    {
        public CloudFunctionConfiguration(EntityTypeBuilder<CloudFunction> entity)
        {
            entity.ToTable("CloudFunction");
        }
    }
}
