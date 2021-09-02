using Volo.Abp.Modularity;

namespace TenantExtension
{
    [DependsOn(
        typeof(TenantExtensionApplicationModule),
        typeof(TenantExtensionDomainTestModule)
        )]
    public class TenantExtensionApplicationTestModule : AbpModule
    {

    }
}
