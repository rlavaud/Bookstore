using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace TenantExtension
{
    [DependsOn(
        typeof(TenantExtensionHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class TenantExtensionConsoleApiClientModule : AbpModule
    {
        
    }
}
