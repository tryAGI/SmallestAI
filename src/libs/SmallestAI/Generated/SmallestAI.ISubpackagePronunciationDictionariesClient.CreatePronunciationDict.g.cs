#nullable enable

namespace SmallestAI
{
    public partial interface ISubpackagePronunciationDictionariesClient
    {
        /// <summary>
        /// Create<br/>
        /// Create a new pronunciation dictionary for the authenticated user
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.PronunciationDict> CreatePronunciationDictAsync(

            global::SmallestAI.CreatePronunciationDictRequest request,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create<br/>
        /// Create a new pronunciation dictionary for the authenticated user
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.AutoSDKHttpResponse<global::SmallestAI.PronunciationDict>> CreatePronunciationDictAsResponseAsync(

            global::SmallestAI.CreatePronunciationDictRequest request,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create<br/>
        /// Create a new pronunciation dictionary for the authenticated user
        /// </summary>
        /// <param name="items">
        /// List of word-pronunciation pairs to create
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.PronunciationDict> CreatePronunciationDictAsync(
            global::System.Collections.Generic.IList<global::SmallestAI.PronunciationItem> items,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}