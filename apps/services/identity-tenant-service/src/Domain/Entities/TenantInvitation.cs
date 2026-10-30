public class TenantInvitation
{
    public Guid Id { get; set; }

    public Guid TenantId { get; set; }

    public string Email { get; set; } = null!;

    public DateTime ExpiresAtUtc { get; set; }

    public bool IsAccepted { get; set; }
}