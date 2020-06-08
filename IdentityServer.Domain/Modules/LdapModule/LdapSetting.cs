namespace IdentityServer.Domain.Modules.LdapModule
{
    public class LdapSetting
    {
        public string Host { get; set; } = null!;
        public int Port { get; set; }
        public string Base { get; set; } = null!;
        public string Domain { get; set; } = null!;
    }
}
