public class CreateTenantCommand
{
    public string Name { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public TenantType TenantType { get; set; }
}