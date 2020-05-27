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
            entity.HasData(new CloudFunction()
            {
                Id = 1,
                ExecutinPerRequestInMiliseconds = 10000,
                MemorySizeInMB = 1,
                ExecutionsPerMonth = 10000,
                CloudProvider = CloudProvider.AWS,
                Price = 10
            },
            new CloudFunction()
            {
                Id = 2,
                ExecutinPerRequestInMiliseconds = 10000,
                MemorySizeInMB = 1,
                ExecutionsPerMonth = 10000,
                CloudProvider = CloudProvider.AZURE,
                Price = 12
            },
            new CloudFunction()
            {
                Id = 3,
                ExecutinPerRequestInMiliseconds = 10000,
                MemorySizeInMB = 1,
                ExecutionsPerMonth = 100000,
                CloudProvider = CloudProvider.GCLOUD,
                Price = 9
            },
            new CloudFunction()
            {
                Id = 4,
                ExecutinPerRequestInMiliseconds = 50000,
                MemorySizeInMB = 10,
                ExecutionsPerMonth = 50000,
                CloudProvider = CloudProvider.AWS,
                Price = 18
            },
            new CloudFunction()
            {
                Id = 5,
                ExecutinPerRequestInMiliseconds = 50000,
                MemorySizeInMB = 10,
                ExecutionsPerMonth = 50000,
                CloudProvider = CloudProvider.AZURE,
                Price = 20
            },
            new CloudFunction()
            {
                Id = 6,
                ExecutinPerRequestInMiliseconds = 50000,
                MemorySizeInMB = 10,
                ExecutionsPerMonth = 50000,
                CloudProvider = CloudProvider.GCLOUD,
                Price = 22
            },
            new CloudFunction()
            {
                Id = 7,
                ExecutinPerRequestInMiliseconds = 20000,
                MemorySizeInMB = 100,
                ExecutionsPerMonth = 1000000,
                CloudProvider = CloudProvider.AWS,
                Price = 44
            },
            new CloudFunction()
            {
                Id = 8,
                ExecutinPerRequestInMiliseconds = 20000,
                MemorySizeInMB = 100,
                ExecutionsPerMonth = 1000000,
                CloudProvider = CloudProvider.AZURE,
                Price = 41
            },
            new CloudFunction()
            {
                Id = 9,
                ExecutinPerRequestInMiliseconds = 20000,
                MemorySizeInMB = 100,
                ExecutionsPerMonth = 1000000,
                CloudProvider = CloudProvider.GCLOUD,
                Price = 39
            },
              new CloudFunction()
              {
                  Id = 10,
                  ExecutinPerRequestInMiliseconds = 20000,
                  MemorySizeInMB = 1000,
                  ExecutionsPerMonth = 1000000,
                  CloudProvider = CloudProvider.AWS,
                  Price = 44
              },
            new CloudFunction()
            {
                Id = 11,
                ExecutinPerRequestInMiliseconds = 20000,
                MemorySizeInMB = 1000,
                ExecutionsPerMonth = 1000000,
                CloudProvider = CloudProvider.AZURE,
                Price = 41
            },
            new CloudFunction()
            {
                Id = 12,
                ExecutinPerRequestInMiliseconds = 20000,
                MemorySizeInMB = 1000,
                ExecutionsPerMonth = 1000000,
                CloudProvider = CloudProvider.GCLOUD,
                Price = 39
            }
            );
                
        }
    }
}
