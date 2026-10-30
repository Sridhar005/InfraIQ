public class AuthenticationVerification
{
    public Guid Id { get; set; }

    public string Email { get; set; } = null!;

    public string OtpHash { get; set; } = null!;

    public DateTime ExpiresAtUtc { get; set; }

    public bool IsVerified { get; set; }
}