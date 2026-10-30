namespace InfraIQ.IdentityTenantService.Domain.Enums;

public enum TenantStatus
{
    PendingInvitation = 1,
    Onboarding = 2,
    PendingApproval = 3,
    Active = 4,
    Suspended = 5,
    Deactivated = 6,
    Rejected = 7,
    Closed = 8
}