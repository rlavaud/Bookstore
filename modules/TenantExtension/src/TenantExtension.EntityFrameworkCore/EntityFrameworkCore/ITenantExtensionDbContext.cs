using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace TenantExtension.EntityFrameworkCore
{
    [ConnectionStringName(TenantExtensionDbProperties.ConnectionStringName)]
    public interface ITenantExtensionDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}