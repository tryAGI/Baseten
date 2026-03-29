namespace Baseten.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static BasetenClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("BASETEN_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("BASETEN_API_KEY environment variable is not found.");

        var client = new BasetenClient(apiKey);
        
        return client;
    }
}
