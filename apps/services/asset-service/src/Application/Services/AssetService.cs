public class AssetService : IAssetService
{
    private readonly IAssetRepository _repository;

    public AssetService(
        IAssetRepository repository)
    {
        _repository = repository;
    }

    public async Task<Guid> CreateAssetAsync(
        CreateAssetCommand command)
    {
        var asset = Asset.Create(
            command.TenantId,
            command.AssetCode,
            command.Name);

        await _repository.AddAsync(asset);

        return asset.Id;
    }
}