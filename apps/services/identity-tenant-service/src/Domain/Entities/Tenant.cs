namespace InfraIQ.IdentityTenantService.Domain.Entities;

public class Tenant
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public TenantType TenantType { get; set; }

    public TenantStatus Status { get; set; }

    public DateTime CreatedAtUtc { get; set; }
}