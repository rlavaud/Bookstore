using Localization.Resources.AbpUi;
using TenantExtension.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace TenantExtension
{
    [DependsOn(
        typeof(TenantExtensionApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class TenantExtensionHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(TenantExtensionHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<TenantExtensionResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
