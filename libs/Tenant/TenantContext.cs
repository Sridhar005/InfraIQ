public sealed class TenantContext
{
    public Guid TenantId { get; set; }

    public Guid UserId { get; set; }

    public string[] Permissions { get; set; }
        = Array.Empty<string>();
}