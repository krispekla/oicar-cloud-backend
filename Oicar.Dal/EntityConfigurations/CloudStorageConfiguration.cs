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
        }
    }
}
