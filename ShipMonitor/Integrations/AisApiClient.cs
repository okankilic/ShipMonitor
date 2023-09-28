namespace ShipMonitor.Integrations;

public class AisApiClient : IAisApiClient
{
    readonly IHttpClientFactory _httpClientFactory;

    public AisApiClient(
        IHttpClientFactory httpClientFactory)
    {

        _httpClientFactory = httpClientFactory
            ?? throw new ArgumentNullException(nameof(httpClientFactory));
    }
}
