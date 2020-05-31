using Microsoft.EntityFrameworkCore;
using Oicar.Dal.Entities;
using Oicar.Dal.EntityConfigurations;

namespace Oicar.Dal
{
    public class OicarContext : DbContext
    {
        //Uncomment on run
        //public OicarContext(DbContextOptions<OicarContext> options) : base(options)
        //{
        //}

        //Comment on run
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("server=localhost;database=postgres;User ID=postgres;password=postgres;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserCloud> UserClouds { get; set; }
        public DbSet<CloudStorage> CloudStorages { get; set; }
        public DbSet<CloudVM> CloudVMs { get; set; }
        public DbSet<CloudFunction> CloudFunctions { get; set; }
        public DbSet<CloudDbSQL> CloudDbSQLs { get; set; }
        public DbSet<NewsPost> NewsPosts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new UserConfiguration(modelBuilder.Entity<User>());
            new CloudStorageConfiguration(modelBuilder.Entity<CloudStorage>());
            new CloudVMConfiguration(modelBuilder.Entity<CloudVM>());
            new CloudFunctionConfiguration(modelBuilder.Entity<CloudFunction>());
            new CloudDbSQLConfiguration(modelBuilder.Entity<CloudDbSQL>());
            new UserCloudConfiguration(modelBuilder.Entity<UserCloud>());
            new NewsPostConfiguration(modelBuilder.Entity<NewsPost>());
        }
    }
}
