using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace TenantExtension
{
    [DependsOn(
        typeof(TenantExtensionDomainModule),
        typeof(TenantExtensionApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class TenantExtensionApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<TenantExtensionApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<TenantExtensionApplicationModule>(validate: true);
            });
        }
    }
}
