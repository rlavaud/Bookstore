using TenantExtension.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TenantExtension.Permissions
{
    public class TenantExtensionPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(TenantExtensionPermissions.GroupName, L("Permission:TenantExtension"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<TenantExtensionResource>(name);
        }
    }
}