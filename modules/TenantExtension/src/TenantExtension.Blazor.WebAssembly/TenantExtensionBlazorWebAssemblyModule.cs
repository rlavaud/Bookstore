using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace TenantExtension.Blazor.WebAssembly
{
    [DependsOn(
        typeof(TenantExtensionBlazorModule),
        typeof(TenantExtensionHttpApiClientModule),
        typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
        )]
    public class TenantExtensionBlazorWebAssemblyModule : AbpModule
    {
        
    }
}