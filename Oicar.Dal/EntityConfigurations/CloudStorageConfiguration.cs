using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oicar.Dal.Entities;

namespace Oicar.Dal.EntityConfigurations
{
    public class CloudStorageConfiguration
    {
        public CloudStorageConfiguration(EntityTypeBuilder<CloudStorage> entity)
        {
            entity.ToTable("CloudStorage");
            entity.HasData(
                new CloudStorage()
                {
                    Id = 1,
                    TotalAmount = 512,
                    ReadOperationsPerMonth = 1000000,
                    WriteOperationsPerMonth = 1000000,
                    CloudProvider = CloudProvider.AWS,
                    Price = 100

                },
                new CloudStorage()
                {
                    Id = 2,
                    TotalAmount = 16,
                    ReadOperationsPerMonth = 1000000,
                    WriteOperationsPerMonth = 1000000,
                    CloudProvider = CloudProvider.GCLOUD,
                    Price = 54
                },
                new CloudStorage()
                {
                    Id = 3,
                    TotalAmount = 32,
                    ReadOperationsPerMonth = 1000000,
                    WriteOperationsPerMonth = 1000000,
                    CloudProvider = CloudProvider.AZURE,
                    Price = 60
                },
                new CloudStorage()
                {
                    Id = 4,
                    TotalAmount = 64,
                    ReadOperationsPerMonth = 500000,
                    WriteOperationsPerMonth = 500000,
                    CloudProvider = CloudProvider.AWS,
                    Price = 68
                },
                new CloudStorage()
                {
                    Id = 5,
                    TotalAmount = 128,
                    ReadOperationsPerMonth = 500000,
                    WriteOperationsPerMonth = 500000,
                    CloudProvider = CloudProvider.GCLOUD,
                    Price = 88
                },
                new CloudStorage()
                {
                    Id = 6,
                    TotalAmount = 254,
                    ReadOperationsPerMonth = 500000,
                    WriteOperationsPerMonth = 500000,
                    CloudProvider = CloudProvider.AZURE,
                    Price = 98
                },
                new CloudStorage()
                {
                    Id = 7,
                    TotalAmount = 512,
                    ReadOperationsPerMonth = 2000000,
                    WriteOperationsPerMonth = 2000000,
                    CloudProvider = CloudProvider.AWS,
                    Price = 112
                },
                new CloudStorage()
                {
                    Id = 8,
                    TotalAmount = 1024,
                    ReadOperationsPerMonth = 2000000,
                    WriteOperationsPerMonth = 2000000,
                    CloudProvider = CloudProvider.GCLOUD,
                    Price = 122
                },
                new CloudStorage()
                {
                    Id = 9,
                    TotalAmount = 1024,
                    ReadOperationsPerMonth = 2000000,
                    WriteOperationsPerMonth = 2000000,
                    CloudProvider = CloudProvider.AZURE,
                    Price = 135
                },
                new CloudStorage()
                {
                    Id = 10,
                    TotalAmount = 1024,
                    ReadOperationsPerMonth = 2000000,
                    WriteOperationsPerMonth = 2000000,
                    CloudProvider = CloudProvider.AWS,
                    Price = 156
                },
                new CloudStorage()
                {
                    Id = 11,
                    TotalAmount = 1024,
                    ReadOperationsPerMonth = 250000,
                    WriteOperationsPerMonth = 250000,
                    CloudProvider = CloudProvider.GCLOUD,
                    Price = 159
                },
                new CloudStorage()
                {
                    Id = 12,
                    TotalAmount = 254,
                    ReadOperationsPerMonth = 250000,
                    WriteOperationsPerMonth = 250000,
                    CloudProvider = CloudProvider.AZURE,
                    Price = 76
                },
                new CloudStorage()
                {
                    Id = 13,
                    TotalAmount = 254,
                    ReadOperationsPerMonth = 250000,
                    WriteOperationsPerMonth = 250000,
                    CloudProvider = CloudProvider.AWS,
                    Price = 73
                },
                new CloudStorage()
                {
                    Id = 14,
                    TotalAmount = 254,
                    ReadOperationsPerMonth = 250000,
                    WriteOperationsPerMonth = 250000,
                    CloudProvider = CloudProvider.GCLOUD,
                    Price = 79
                },
                new CloudStorage()
                {
                    Id = 15,
                    TotalAmount = 254,
                    ReadOperationsPerMonth = 4000000,
                    WriteOperationsPerMonth = 4000000,
                    CloudProvider = CloudProvider.AZURE,
                    Price = 86
                },
                new CloudStorage()
                {
                    Id = 16,
                    TotalAmount = 512,
                    ReadOperationsPerMonth = 4000000,
                    WriteOperationsPerMonth = 4000000,
                    CloudProvider = CloudProvider.AWS,
                    Price = 99
                },
                new CloudStorage()
                {
                    Id = 17,
                    TotalAmount = 512,
                    ReadOperationsPerMonth = 4000000,
                    WriteOperationsPerMonth = 4000000,
                    CloudProvider = CloudProvider.GCLOUD,
                    Price = 113
                },
                new CloudStorage()
                {
                    Id = 18,
                    TotalAmount = 2028,
                    ReadOperationsPerMonth = 4000000,
                    WriteOperationsPerMonth = 4000000,
                    CloudProvider = CloudProvider.AZURE,
                    Price = 183
                },
                new CloudStorage()
                {
                    Id = 19,
                    TotalAmount = 2028,
                    ReadOperationsPerMonth = 4000000,
                    WriteOperationsPerMonth = 4000000,
                    CloudProvider = CloudProvider.AWS,
                    Price = 180
                },
                new CloudStorage()
                {
                    Id = 20,
                    TotalAmount = 2028,
                    ReadOperationsPerMonth = 10000,
                    WriteOperationsPerMonth = 10000,
                    CloudProvider = CloudProvider.GCLOUD,
                    Price = 167
                },
                new CloudStorage()
                {
                    Id = 21,
                    TotalAmount = 2028,
                    ReadOperationsPerMonth = 10000,
                    WriteOperationsPerMonth = 10000,
                    CloudProvider = CloudProvider.AZURE,
                    Price = 169
                },
                new CloudStorage()
                {
                    Id = 22,
                    TotalAmount = 2028,
                    ReadOperationsPerMonth = 10000,
                    WriteOperationsPerMonth = 10000,
                    CloudProvider = CloudProvider.AWS,
                    Price = 160
                },
                new CloudStorage()
                {
                    Id = 23,
                    TotalAmount = 2028,
                    ReadOperationsPerMonth = 10000,
                    WriteOperationsPerMonth = 10000,
                    CloudProvider = CloudProvider.GCLOUD,
                    Price = 183
                },
                new CloudStorage()
                {
                    Id = 24,
                    TotalAmount = 128,
                    ReadOperationsPerMonth = 50000,
                    WriteOperationsPerMonth = 50000,
                    CloudProvider = CloudProvider.AZURE,
                    Price = 68
                },
                new CloudStorage()
                {
                    Id = 25,
                    TotalAmount = 128,
                    ReadOperationsPerMonth = 50000,
                    WriteOperationsPerMonth = 50000,
                    CloudProvider = CloudProvider.AWS,
                    Price = 78
                },
                new CloudStorage()
                {
                    Id = 26,
                    TotalAmount = 128,
                    ReadOperationsPerMonth = 50000,
                    WriteOperationsPerMonth = 50000,
                    CloudProvider = CloudProvider.GCLOUD,
                    Price = 65
                },
                new CloudStorage()
                {
                    Id = 27,
                    TotalAmount = 128,
                    ReadOperationsPerMonth = 500000,
                    WriteOperationsPerMonth = 500000,
                    CloudProvider = CloudProvider.AZURE,
                    Price = 78
                },
                new CloudStorage()
                {
                    Id = 28,
                    TotalAmount = 90000,
                    ReadOperationsPerMonth = 800000,
                    WriteOperationsPerMonth = 800000,
                    CloudProvider = CloudProvider.AWS,
                    Price = 660
                },
                new CloudStorage()
                {
                    Id = 29,
                    TotalAmount = 90000,
                    ReadOperationsPerMonth = 800000,
                    WriteOperationsPerMonth = 800000,
                    CloudProvider = CloudProvider.GCLOUD,
                    Price = 460
                },
                new CloudStorage()
                {
                    Id = 30,
                    TotalAmount = 90000,
                    ReadOperationsPerMonth = 800000,
                    WriteOperationsPerMonth = 800000,
                    CloudProvider = CloudProvider.AZURE,
                    Price = 550
                }

            );
            entity.Property(x => x.Id)
                .HasIdentityOptions(startValue: 31);
        }
    }
}
