using Volo.Abp.Reflection;

namespace TenantExtension.Permissions
{
    public class TenantExtensionPermissions
    {
        public const string GroupName = "TenantExtension";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(TenantExtensionPermissions));
        }
    }
}