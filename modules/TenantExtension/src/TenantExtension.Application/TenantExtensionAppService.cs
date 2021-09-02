using TenantExtension.Localization;
using Volo.Abp.Application.Services;

namespace TenantExtension
{
    public abstract class TenantExtensionAppService : ApplicationService
    {
        protected TenantExtensionAppService()
        {
            LocalizationResource = typeof(TenantExtensionResource);
            ObjectMapperContext = typeof(TenantExtensionApplicationModule);
        }
    }
}
