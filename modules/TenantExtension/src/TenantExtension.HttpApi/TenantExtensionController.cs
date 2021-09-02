using TenantExtension.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TenantExtension
{
    public abstract class TenantExtensionController : AbpController
    {
        protected TenantExtensionController()
        {
            LocalizationResource = typeof(TenantExtensionResource);
        }
    }
}
