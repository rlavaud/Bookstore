namespace TenantExtension
{
    public static class TenantExtensionDbProperties
    {
        public static string DbTablePrefix { get; set; } = "TenantExtension";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "TenantExtension";
    }
}
