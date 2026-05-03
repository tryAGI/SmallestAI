#nullable enable

namespace SmallestAI
{
    public partial interface ISubpackagePronunciationDictionariesClient
    {
        /// <summary>
        /// List<br/>
        /// Retrieve all pronunciation dictionaries for the authenticated user
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::SmallestAI.PronunciationDict>> GetPronunciationDictsAsync(
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}