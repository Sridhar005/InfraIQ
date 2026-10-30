public class TenantService : ITenantService
{
    private readonly ITenantRepository _repository;

    public TenantService(
        ITenantRepository repository)
    {
        _repository = repository;
    }

    public async Task<Guid> CreateTenantAsync(
        CreateTenantCommand request)
    {
        var tenant = new Tenant
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            DisplayName = request.DisplayName,
            TenantType = request.TenantType,
            Status = TenantStatus.PendingInvitation,
            CreatedAtUtc = DateTime.UtcNow
        };

        await _repository.AddAsync(tenant);

        return tenant.Id;
    }
}