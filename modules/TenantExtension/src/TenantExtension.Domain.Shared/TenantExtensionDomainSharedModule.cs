using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using TenantExtension.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace TenantExtension
{
    [DependsOn(
        typeof(AbpValidationModule)
    )]
    public class TenantExtensionDomainSharedModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            
            TenantExtensionModuleExtensionConfigurator.Configure();
        }
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<TenantExtensionDomainSharedModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<TenantExtensionResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/TenantExtension");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("TenantExtension", typeof(TenantExtensionResource));
            });
        }
    }
}
