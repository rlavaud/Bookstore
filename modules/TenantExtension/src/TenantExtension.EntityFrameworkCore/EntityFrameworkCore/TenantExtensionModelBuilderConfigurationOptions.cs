using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace TenantExtension.EntityFrameworkCore
{
    public class TenantExtensionModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public TenantExtensionModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}