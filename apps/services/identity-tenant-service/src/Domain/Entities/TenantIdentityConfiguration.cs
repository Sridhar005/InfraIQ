public class TenantIdentityConfiguration
{
    public Guid Id { get; set; }

    public Guid TenantId { get; set; }

    public string EntraTenantId { get; set; } = null!;

    public string ClientId { get; set; } = null!;

    public string Issuer { get; set; } = null!;
}