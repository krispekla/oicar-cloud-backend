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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new UserConfiguration(modelBuilder.Entity<User>());
        }
    }
}
