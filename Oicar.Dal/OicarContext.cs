using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Oicar.Dal.Entities;
using Oicar.Dal.EntityConfigurations;
using System;

namespace Oicar.Dal
{
    public class OicarContext : DbContext
    {
        public OicarContext(DbContextOptions<OicarContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<CloudStorage> CloudStorages { get; set; }
        public DbSet<CloudVM> CloudVMs { get; set; }
        public DbSet<CloudFunction> CloudFunctions { get; set; }
        public DbSet<CloudDbSQL> CloudDbSQLs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new UserConfiguration(modelBuilder.Entity<User>());
            new CloudStorageConfiguration(modelBuilder.Entity<CloudStorage>());
            new CloudVMConfiguration(modelBuilder.Entity<CloudVM>());
            new CloudFunctionConfiguration(modelBuilder.Entity<CloudFunction>());
            new CloudDbSQLConfiguration(modelBuilder.Entity<CloudDbSQL>());
        }
    }
}
