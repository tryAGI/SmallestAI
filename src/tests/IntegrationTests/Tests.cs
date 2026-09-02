namespace SmallestAI.IntegrationTests;

[TestClass]
public partial class Tests
{
    /// <summary>
    /// Injected by MSTest; used for per-test cancellation.
    /// </summary>
    public TestContext TestContext { get; set; } = null!;

    private static string GetApiKey() =>
        Environment.GetEnvironmentVariable("SMALLESTAI_API_KEY") is { Length: > 0 } apiKeyValue
            ? apiKeyValue
            : Environment.GetEnvironmentVariable("SMALLEST_API_KEY") is { Length: > 0 } smallestKeyValue
            ? smallestKeyValue
            : throw new AssertInconclusiveException("SMALLESTAI_API_KEY or SMALLEST_API_KEY environment variable is not found.");

    private static SmallestAIClient GetAuthenticatedClient()
    {
        var client = new SmallestAIClient(GetApiKey());

        return client;
    }
}
