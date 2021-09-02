using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace TenantExtension
{
    [DependsOn(
        typeof(TenantExtensionApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class TenantExtensionHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "TenantExtension";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(TenantExtensionApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
