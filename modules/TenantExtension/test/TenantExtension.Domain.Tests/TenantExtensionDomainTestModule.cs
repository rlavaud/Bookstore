﻿using TenantExtension.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace TenantExtension
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(TenantExtensionEntityFrameworkCoreTestModule)
        )]
    public class TenantExtensionDomainTestModule : AbpModule
    {
        
    }
}
