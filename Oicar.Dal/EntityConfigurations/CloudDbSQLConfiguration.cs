using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oicar.Dal.Entities;

namespace Oicar.Dal.EntityConfigurations
{
    public class CloudDbSQLConfiguration
    {
        public CloudDbSQLConfiguration(EntityTypeBuilder<CloudDbSQL> entity)
        {
            entity.ToTable("CloudSQL");
            entity.HasData(
                new CloudDbSQL()
                {
                    Id = 1,
                    CloudProvider = CloudProvider.AWS,
                    Instance = 1,
                    Ram = 1,
                    CpuCores = 1,
                    BaskupSize = 1,
                    AverageDaysPerWeek = 7,
                    AverageHoursPerDay = 24,
                    SQLServerType = SQLServerType.Enterprise2017,
                    Price = 45
                },
            new CloudDbSQL()
            {
                Id = 2,

                CloudProvider = CloudProvider.GCLOUD,
                Instance = 1,
                Ram = 1,
                CpuCores = 1,
                BaskupSize = 1,
                AverageDaysPerWeek = 7,
                AverageHoursPerDay = 24,
                SQLServerType = SQLServerType.Enterprise2017,
                Price = 48
            },
            new CloudDbSQL()
            {
                Id = 3,

                CloudProvider = CloudProvider.AZURE,
                Instance = 1,
                Ram = 1,
                CpuCores = 1,
                BaskupSize = 1,
                AverageDaysPerWeek = 7,
                AverageHoursPerDay = 24,
                SQLServerType = SQLServerType.Enterprise2017,
                Price = 41
            },
                     new CloudDbSQL()
                     {
                         Id = 4,
                         CloudProvider = CloudProvider.AWS,
                         Instance = 1,
                         Ram = 1,
                         CpuCores = 1,
                         BaskupSize = 1,
                         AverageDaysPerWeek = 7,
                         AverageHoursPerDay = 24,
                         SQLServerType = SQLServerType.Express2017,
                         Price = 24
                     },
            new CloudDbSQL()
            {
                Id = 5,
                CloudProvider = CloudProvider.GCLOUD,
                Instance = 1,
                Ram = 1,
                CpuCores = 1,
                BaskupSize = 1,
                AverageDaysPerWeek = 7,
                AverageHoursPerDay = 24,
                SQLServerType = SQLServerType.Express2017,
                Price = 37
            },
            new CloudDbSQL()
            {
                Id = 6,
                CloudProvider = CloudProvider.AZURE,
                Instance = 1,
                Ram = 1,
                CpuCores = 1,
                BaskupSize = 1,
                AverageDaysPerWeek = 7,
                AverageHoursPerDay = 24,
                SQLServerType = SQLServerType.Express2017,
                Price = 36
            },
              new CloudDbSQL()
              {
                  Id = 7,
                  CloudProvider = CloudProvider.AWS,
                  Instance = 1,
                  Ram = 1,
                  CpuCores = 1,
                  BaskupSize = 1,
                  AverageDaysPerWeek = 7,
                  AverageHoursPerDay = 24,
                  SQLServerType = SQLServerType.Standard2017,
                  Price = 27
              },
            new CloudDbSQL()
            {
                Id = 8,
                CloudProvider = CloudProvider.GCLOUD,
                Instance = 1,
                Ram = 1,
                CpuCores = 1,
                BaskupSize = 1,
                AverageDaysPerWeek = 7,
                AverageHoursPerDay = 24,
                SQLServerType = SQLServerType.Standard2017,
                Price = 30
            },
            new CloudDbSQL()
            {
                Id = 9,
                CloudProvider = CloudProvider.AZURE,
                Instance = 1,
                Ram = 1,
                CpuCores = 1,
                BaskupSize = 1,
                AverageDaysPerWeek = 7,
                AverageHoursPerDay = 24,
                SQLServerType = SQLServerType.Standard2017,
                Price = 31
            },
             new CloudDbSQL()
             {
                 Id = 10,
                 CloudProvider = CloudProvider.AWS,
                 Instance = 1,
                 Ram = 1,
                 CpuCores = 1,
                 BaskupSize = 1,
                 AverageDaysPerWeek = 7,
                 AverageHoursPerDay = 24,
                 SQLServerType = SQLServerType.Web2017,
                 Price = 21
             },
            new CloudDbSQL()
            {
                Id = 11,
                CloudProvider = CloudProvider.GCLOUD,
                Instance = 1,
                Ram = 1,
                CpuCores = 1,
                BaskupSize = 1,
                AverageDaysPerWeek = 7,
                AverageHoursPerDay = 24,
                SQLServerType = SQLServerType.Web2017,
                Price = 20
            },
            new CloudDbSQL()
            {
                Id = 12,
                CloudProvider = CloudProvider.AZURE,
                Instance = 1,
                Ram = 1,
                CpuCores = 1,
                BaskupSize = 1,
                AverageDaysPerWeek = 7,
                AverageHoursPerDay = 24,
                SQLServerType = SQLServerType.Web2017,
                Price = 18
            },


                new CloudDbSQL()
                {
                    Id = 13,
                    CloudProvider = CloudProvider.AWS,
                    Instance = 1,
                    Ram = 4,
                    CpuCores = 1,
                    BaskupSize = 1,
                    AverageDaysPerWeek = 7,
                    AverageHoursPerDay = 24,
                    SQLServerType = SQLServerType.Standard2017,
                    Price = 30
                },
            new CloudDbSQL()
            {
                Id = 14,
                CloudProvider = CloudProvider.GCLOUD,
                Instance = 1,
                Ram = 4,
                CpuCores = 1,
                BaskupSize = 1,
                AverageDaysPerWeek = 7,
                AverageHoursPerDay = 24,
                SQLServerType = SQLServerType.Standard2017,
                Price = 27
            },
            new CloudDbSQL()
            {
                Id = 15,
                CloudProvider = CloudProvider.AZURE,
                Instance = 1,
                Ram = 4,
                CpuCores = 1,
                BaskupSize = 1,
                AverageDaysPerWeek = 7,
                AverageHoursPerDay = 24,
                SQLServerType = SQLServerType.Standard2017,
                Price = 28
            },


                new CloudDbSQL()
                {
                    Id = 16,
                    CloudProvider = CloudProvider.AWS,
                    Instance = 1,
                    Ram = 8,
                    CpuCores = 2,
                    BaskupSize = 1,
                    AverageDaysPerWeek = 7,
                    AverageHoursPerDay = 24,
                    SQLServerType = SQLServerType.Standard2017,
                    Price = 38
                },
            new CloudDbSQL()
            {
                Id = 17,
                CloudProvider = CloudProvider.GCLOUD,
                Instance = 1,
                Ram = 8,
                CpuCores = 2,
                BaskupSize = 1,
                AverageDaysPerWeek = 7,
                AverageHoursPerDay = 24,
                SQLServerType = SQLServerType.Standard2017,
                Price = 39
            },
            new CloudDbSQL()
            {
                Id = 18,
                CloudProvider = CloudProvider.AZURE,
                Instance = 1,
                Ram = 8,
                CpuCores = 2,
                BaskupSize = 1,
                AverageDaysPerWeek = 7,
                AverageHoursPerDay = 24,
                SQLServerType = SQLServerType.Standard2017,
                Price = 40
            },

             new CloudDbSQL()
             {
                 Id = 19,
                 CloudProvider = CloudProvider.AWS,
                 Instance = 1,
                 Ram = 16,
                 CpuCores = 4,
                 BaskupSize = 1,
                 AverageDaysPerWeek = 7,
                 AverageHoursPerDay = 24,
                 SQLServerType = SQLServerType.Standard2017,
                 Price = 48
             },
            new CloudDbSQL()
            {
                Id = 20,
                CloudProvider = CloudProvider.GCLOUD,
                Instance = 1,
                Ram = 16,
                CpuCores = 4,
                BaskupSize = 1,
                AverageDaysPerWeek = 7,
                AverageHoursPerDay = 24,
                SQLServerType = SQLServerType.Standard2017,
                Price = 47
            },
            new CloudDbSQL()
            {
                Id = 21,
                CloudProvider = CloudProvider.AZURE,
                Instance = 1,
                Ram = 16,
                CpuCores = 4,
                BaskupSize = 1,
                AverageDaysPerWeek = 7,
                AverageHoursPerDay = 24,
                SQLServerType = SQLServerType.Standard2017,
                Price = 52
            },


               new CloudDbSQL()
               {
                   Id = 22,
                   CloudProvider = CloudProvider.AWS,
                   Instance = 1,
                   Ram = 32,
                   CpuCores = 8,
                   BaskupSize = 64,
                   AverageDaysPerWeek = 7,
                   AverageHoursPerDay = 24,
                   SQLServerType = SQLServerType.Standard2017,
                   Price = 59
               },
            new CloudDbSQL()
            {
                Id = 23,
                CloudProvider = CloudProvider.GCLOUD,
                Instance = 1,
                Ram = 32,
                CpuCores = 8,
                BaskupSize = 64,
                AverageDaysPerWeek = 7,
                AverageHoursPerDay = 24,
                SQLServerType = SQLServerType.Standard2017,
                Price = 56
            },
            new CloudDbSQL()
            {
                Id = 24,
                CloudProvider = CloudProvider.AZURE,
                Instance = 120,
                Ram = 128,
                CpuCores = 8,
                BaskupSize = 1024,
                AverageDaysPerWeek = 7,
                AverageHoursPerDay = 24,
                SQLServerType = SQLServerType.Standard2017,
                Price = 57
            },

              new CloudDbSQL()
              {
                  Id = 25,
                  CloudProvider = CloudProvider.AWS,
                  Instance = 120,
                  Ram = 128,
                  CpuCores = 64,
                  BaskupSize = 1024,
                  AverageDaysPerWeek = 7,
                  AverageHoursPerDay = 24,
                  SQLServerType = SQLServerType.Standard2017,
                  Price = 5900
              },
            new CloudDbSQL()
            {
                Id = 26,
                CloudProvider = CloudProvider.GCLOUD,
                Instance = 120,
                Ram = 128,
                CpuCores = 64,
                BaskupSize = 1024,
                AverageDaysPerWeek = 7,
                AverageHoursPerDay = 24,
                SQLServerType = SQLServerType.Standard2017,
                Price = 5600
            },
            new CloudDbSQL()
            {
                Id = 27,
                CloudProvider = CloudProvider.AZURE,
                Instance = 120,
                Ram = 128,
                CpuCores = 64,
                BaskupSize = 1024,
                AverageDaysPerWeek = 7,
                AverageHoursPerDay = 24,
                SQLServerType = SQLServerType.Standard2017,
                Price = 8400
            }
            );
            entity.Property(x => x.Id)
                .HasIdentityOptions(startValue: 28);
        }
    }
}
