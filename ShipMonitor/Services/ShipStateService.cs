namespace ShipMonitor.Services;

public class ShipStateService : BackgroundService
{
    readonly IServiceScopeFactory _scopeFactory;

    public ShipStateService(
        IServiceScopeFactory scopeFactory)
    {
        _scopeFactory = scopeFactory
            ?? throw new ArgumentNullException(nameof(scopeFactory));
    }

    protected override async Task ExecuteAsync(CancellationToken cancellationToken)
    {
        while (!cancellationToken.IsCancellationRequested)
        {
            using var scope = _scopeFactory.CreateScope();

            //var logger = scope.ServiceProvider.GetRequiredService<ILogger<ThumbnailGenerationService>>();

            //logger.LogInformation($"{nameof(ThumbnailGenerationService)} started.");

            //var assetBusiness = scope.ServiceProvider.GetRequiredService<IAssetBusiness>();

            //await assetBusiness.GenerateThumbnailsAsync(cancellationToken);

            //logger.LogInformation($"{nameof(ThumbnailGenerationService)} ended.");

            //await Task.Delay(60 * 1000, cancellationToken);
        }
    }
}
