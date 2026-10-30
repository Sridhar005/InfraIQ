public class AssetRepository : IAssetRepository
{
    private readonly AssetDbContext _db;

    public AssetRepository(
        AssetDbContext db)
    {
        _db = db;
    }

    public async Task<Asset?> GetAsync(
        Guid tenantId,
        Guid assetId)
    {
        return await _db.Assets
            .Where(x =>
                x.TenantId == tenantId &&
                x.Id == assetId)
            .FirstOrDefaultAsync();
    }
}