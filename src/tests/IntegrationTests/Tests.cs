namespace SmallestAI.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static SmallestAIClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("SMALLESTAI_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : Environment.GetEnvironmentVariable("SMALLEST_API_KEY") is { Length: > 0 } smallestKeyValue
                ? smallestKeyValue
                : throw new AssertInconclusiveException("SMALLESTAI_API_KEY or SMALLEST_API_KEY environment variable is not found.");

        var client = new SmallestAIClient(apiKey);
        
        return client;
    }
}
