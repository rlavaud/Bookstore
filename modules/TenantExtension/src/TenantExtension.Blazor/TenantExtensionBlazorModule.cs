using Microsoft.Extensions.DependencyInjection;
using TenantExtension.Blazor.Menus;
using Volo.Abp.AspNetCore.Components.Web.Theming;
using Volo.Abp.AspNetCore.Components.Web.Theming.Routing;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;

namespace TenantExtension.Blazor
{
    [DependsOn(
        typeof(TenantExtensionApplicationContractsModule),
        typeof(AbpAspNetCoreComponentsWebThemingModule),
        typeof(AbpAutoMapperModule)
        )]
    public class TenantExtensionBlazorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<TenantExtensionBlazorModule>();

            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<TenantExtensionBlazorAutoMapperProfile>(validate: true);
            });

            Configure<AbpNavigationOptions>(options =>
            {
                options.MenuContributors.Add(new TenantExtensionMenuContributor());
            });

            Configure<AbpRouterOptions>(options =>
            {
                options.AdditionalAssemblies.Add(typeof(TenantExtensionBlazorModule).Assembly);
            });
        }
    }
}