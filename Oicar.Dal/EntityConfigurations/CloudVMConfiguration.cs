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
            entity.HasData(new CloudVM()
            {
                Id = 1,
                InstanceNb = 1,
                OperatingSystem = Entities.OperatingSystem.Linux,
                Core = 4,
                Ram = 16,
                Storage = 256,
                StorageType = StorageType.SSD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.AWS,
                Price = 1500
            },
            new CloudVM()
            {
                Id = 2,
                InstanceNb = 1,
                OperatingSystem = Entities.OperatingSystem.Linux,
                Core = 4,
                Ram = 16,
                Storage = 256,
                StorageType = StorageType.HDD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.AWS,
                Price = 1250
            },
            new CloudVM()
            {
                Id = 3,
                InstanceNb = 1,
                OperatingSystem = Entities.OperatingSystem.Windows,
                Core = 4,
                Ram = 16,
                Storage = 256,
                StorageType = StorageType.SSD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.AWS,
                Price = 1650
            },
            new CloudVM()
            {
                Id = 4,
                InstanceNb = 1,
                OperatingSystem = Entities.OperatingSystem.Windows,
                Core = 4,
                Ram = 16,
                Storage = 256,
                StorageType = StorageType.HDD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.AWS,
                Price = 1400
            },
            new CloudVM()
            {
                Id = 5,
                InstanceNb = 4,
                OperatingSystem = Entities.OperatingSystem.Linux,
                Core = 4,
                Ram = 16,
                Storage = 256,
                StorageType = StorageType.SSD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.AWS,
                Price = 4000
            },
            new CloudVM()
            {
                Id = 6,
                InstanceNb = 4,
                OperatingSystem = Entities.OperatingSystem.Linux,
                Core = 4,
                Ram = 16,
                Storage = 256,
                StorageType = StorageType.HDD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.AWS,
                Price = 3800
            },
            new CloudVM()
            {
                Id = 7,
                InstanceNb = 4,
                OperatingSystem = Entities.OperatingSystem.Windows,
                Core = 4,
                Ram = 16,
                Storage = 256,
                StorageType = StorageType.SSD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.AWS,
                Price = 3600
            },
            new CloudVM()
            {
                Id = 8,
                InstanceNb = 1,
                OperatingSystem = Entities.OperatingSystem.Windows,
                Core = 4,
                Ram = 16,
                Storage = 256,
                StorageType = StorageType.HDD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.AWS,
                Price = 3750
            },
            new CloudVM()
            {
                Id = 9,
                InstanceNb = 1,
                OperatingSystem = Entities.OperatingSystem.Linux,
                Core = 4,
                Ram = 8,
                Storage = 256,
                StorageType = StorageType.SSD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.AWS,
                Price = 850
            },
            new CloudVM()
            {
                Id = 10,
                InstanceNb = 1,
                OperatingSystem = Entities.OperatingSystem.Linux,
                Core = 4,
                Ram = 8,
                Storage = 256,
                StorageType = StorageType.HDD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.AWS,
                Price = 900
            },
            new CloudVM()
            {
                Id = 11,
                InstanceNb = 1,
                OperatingSystem = Entities.OperatingSystem.Windows,
                Core = 4,
                Ram = 8,
                Storage = 256,
                StorageType = StorageType.SSD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.AWS,
                Price = 887
            },
            new CloudVM()
            {
                Id = 12,
                InstanceNb = 1,
                OperatingSystem = Entities.OperatingSystem.Windows,
                Core = 4,
                Ram = 8,
                Storage = 256,
                StorageType = StorageType.HDD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.AWS,
                Price = 800
            },
            new CloudVM()
            {
                Id = 13,
                InstanceNb = 1,
                OperatingSystem = Entities.OperatingSystem.Linux,
                Core = 4,
                Ram = 16,
                Storage = 256,
                StorageType = StorageType.SSD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.AZURE,
                Price = 1509
            },
            new CloudVM()
            {
                Id = 14,
                InstanceNb = 1,
                OperatingSystem = Entities.OperatingSystem.Linux,
                Core = 4,
                Ram = 16,
                Storage = 256,
                StorageType = StorageType.HDD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.AZURE,
                Price = 1350
            },
            new CloudVM()
            {
                Id = 15,
                InstanceNb = 1,
                OperatingSystem = Entities.OperatingSystem.Windows,
                Core = 4,
                Ram = 16,
                Storage = 256,
                StorageType = StorageType.SSD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.AZURE,
                Price = 1652
            },
            new CloudVM()
            {
                Id = 16,
                InstanceNb = 1,
                OperatingSystem = Entities.OperatingSystem.Windows,
                Core = 4,
                Ram = 16,
                Storage = 256,
                StorageType = StorageType.HDD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.AZURE,
                Price = 1389
            },
            new CloudVM()
            {
                Id = 17,
                InstanceNb = 4,
                OperatingSystem = Entities.OperatingSystem.Linux,
                Core = 4,
                Ram = 16,
                Storage = 256,
                StorageType = StorageType.SSD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.AZURE,
                Price = 3800
            },
            new CloudVM()
            {
                Id = 18,
                InstanceNb = 4,
                OperatingSystem = Entities.OperatingSystem.Linux,
                Core = 4,
                Ram = 16,
                Storage = 256,
                StorageType = StorageType.HDD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.AZURE,
                Price = 3901
            },
            new CloudVM()
            {
                Id = 19,
                InstanceNb = 4,
                OperatingSystem = Entities.OperatingSystem.Windows,
                Core = 4,
                Ram = 16,
                Storage = 256,
                StorageType = StorageType.SSD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.AZURE,
                Price = 3609
            },
            new CloudVM()
            {
                Id = 20,
                InstanceNb = 1,
                OperatingSystem = Entities.OperatingSystem.Windows,
                Core = 4,
                Ram = 16,
                Storage = 256,
                StorageType = StorageType.HDD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.AZURE,
                Price = 3759
            },
            new CloudVM()
            {
                Id = 21,
                InstanceNb = 1,
                OperatingSystem = Entities.OperatingSystem.Linux,
                Core = 4,
                Ram = 8,
                Storage = 256,
                StorageType = StorageType.SSD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.AZURE,
                Price = 950
            },
            new CloudVM()
            {
                Id = 22,
                InstanceNb = 1,
                OperatingSystem = Entities.OperatingSystem.Linux,
                Core = 4,
                Ram = 8,
                Storage = 256,
                StorageType = StorageType.HDD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.AZURE,
                Price = 909
            },
            new CloudVM()
            {
                Id = 23,
                InstanceNb = 1,
                OperatingSystem = Entities.OperatingSystem.Windows,
                Core = 4,
                Ram = 8,
                Storage = 256,
                StorageType = StorageType.SSD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.AZURE,
                Price = 869
            },
            new CloudVM()
            {
                Id = 24,
                InstanceNb = 1,
                OperatingSystem = Entities.OperatingSystem.Windows,
                Core = 4,
                Ram = 8,
                Storage = 256,
                StorageType = StorageType.HDD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.AZURE,
                Price = 809
            },
            new CloudVM()
            {
                Id = 25,
                InstanceNb = 1,
                OperatingSystem = Entities.OperatingSystem.Linux,
                Core = 4,
                Ram = 16,
                Storage = 256,
                StorageType = StorageType.SSD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.GCLOUD,
                Price = 1499
            },
            new CloudVM()
            {
                Id = 26,
                InstanceNb = 1,
                OperatingSystem = Entities.OperatingSystem.Linux,
                Core = 4,
                Ram = 16,
                Storage = 256,
                StorageType = StorageType.HDD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.GCLOUD,
                Price = 1359
            },
            new CloudVM()
            {
                Id = 27,
                InstanceNb = 1,
                OperatingSystem = Entities.OperatingSystem.Windows,
                Core = 4,
                Ram = 16,
                Storage = 256,
                StorageType = StorageType.SSD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.GCLOUD,
                Price = 1656
            },
            new CloudVM()
            {
                Id = 28,
                InstanceNb = 1,
                OperatingSystem = Entities.OperatingSystem.Windows,
                Core = 4,
                Ram = 16,
                Storage = 256,
                StorageType = StorageType.HDD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.GCLOUD,
                Price = 1379
            },
            new CloudVM()
            {
                Id = 29,
                InstanceNb = 4,
                OperatingSystem = Entities.OperatingSystem.Linux,
                Core = 4,
                Ram = 16,
                Storage = 256,
                StorageType = StorageType.SSD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.GCLOUD,
                Price = 3790
            },
            new CloudVM()
            {
                Id = 30,
                InstanceNb = 4,
                OperatingSystem = Entities.OperatingSystem.Linux,
                Core = 4,
                Ram = 16,
                Storage = 256,
                StorageType = StorageType.HDD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.GCLOUD,
                Price = 3911
            },
            new CloudVM()
            {
                Id = 31,
                InstanceNb = 4,
                OperatingSystem = Entities.OperatingSystem.Windows,
                Core = 4,
                Ram = 16,
                Storage = 256,
                StorageType = StorageType.SSD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.GCLOUD,
                Price = 3619
            },
            new CloudVM()
            {
                Id = 32,
                InstanceNb = 1,
                OperatingSystem = Entities.OperatingSystem.Windows,
                Core = 4,
                Ram = 16,
                Storage = 256,
                StorageType = StorageType.HDD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.GCLOUD,
                Price = 3659
            },
            new CloudVM()
            {
                Id = 33,
                InstanceNb = 1,
                OperatingSystem = Entities.OperatingSystem.Linux,
                Core = 4,
                Ram = 8,
                Storage = 256,
                StorageType = StorageType.SSD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.GCLOUD,
                Price = 944
            },
            new CloudVM()
            {
                Id = 34,
                InstanceNb = 1,
                OperatingSystem = Entities.OperatingSystem.Linux,
                Core = 4,
                Ram = 8,
                Storage = 256,
                StorageType = StorageType.HDD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.GCLOUD,
                Price = 911
            },
            new CloudVM()
            {
                Id = 35,
                InstanceNb = 1,
                OperatingSystem = Entities.OperatingSystem.Windows,
                Core = 4,
                Ram = 8,
                Storage = 256,
                StorageType = StorageType.SSD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.GCLOUD,
                Price = 919
            },
            new CloudVM()
            {
                Id = 36,
                InstanceNb = 1,
                OperatingSystem = Entities.OperatingSystem.Windows,
                Core = 4,
                Ram = 8,
                Storage = 256,
                StorageType = StorageType.HDD,
                AverageHoursPerDay = 16,
                AverageDaysPerWeek = 6,
                CloudProvider = CloudProvider.GCLOUD,
                Price = 821
            }
            );
        }
    }
}
