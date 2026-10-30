public interface IAssetRepository
{
    Task<Asset?> GetAsync(
        Guid tenantId,
        Guid assetId);

    Task AddAsync(
        Asset asset);

    Task UpdateAsync(
        Asset asset);

    Task DeleteAsync(
        Guid tenantId,
        Guid assetId);
}