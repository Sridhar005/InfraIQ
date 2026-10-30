public class Asset
{
    public Guid Id { get; private set; }

    public Guid TenantId { get; private set; }

    public string AssetCode { get; private set; }

    public string Name { get; private set; }

    public string Description { get; private set; }

    public AssetStatus Status { get; private set; }

    public DateTime CreatedAt { get; private set; }
}