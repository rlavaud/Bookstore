using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace TenantExtension.EntityFrameworkCore
{
    [DependsOn(
        typeof(TenantExtensionDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class TenantExtensionEntityFrameworkCoreModule : AbpModule
    {

        //added to call the extension mapping
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            TenantExtensionEfCoreEntityExtensionMappings.Configure();
        }
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<TenantExtensionDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
            });
        }
    }
}