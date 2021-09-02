using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace TenantExtension.EntityFrameworkCore
{
    [ConnectionStringName(TenantExtensionDbProperties.ConnectionStringName)]
    public class TenantExtensionDbContext : AbpDbContext<TenantExtensionDbContext>, ITenantExtensionDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public TenantExtensionDbContext(DbContextOptions<TenantExtensionDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureTenantExtension();
        }
    }
}