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
        }
    }
}
