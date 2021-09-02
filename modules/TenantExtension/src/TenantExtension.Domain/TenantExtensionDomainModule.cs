using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace TenantExtension
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(TenantExtensionDomainSharedModule)
    )]
    public class TenantExtensionDomainModule : AbpModule
    {

    }
}
