#nullable enable

namespace SmallestAI
{
    public partial interface IPronunciationDictionariesClient
    {
        /// <summary>
        /// Update<br/>
        /// Update an existing pronunciation dictionary for the authenticated user
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.UpdatePronunciationDictResponse> UpdatePronunciationDictAsync(

            global::SmallestAI.UpdatePronunciationDictRequest request,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update<br/>
        /// Update an existing pronunciation dictionary for the authenticated user
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.AutoSDKHttpResponse<global::SmallestAI.UpdatePronunciationDictResponse>> UpdatePronunciationDictAsResponseAsync(

            global::SmallestAI.UpdatePronunciationDictRequest request,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update<br/>
        /// Update an existing pronunciation dictionary for the authenticated user
        /// </summary>
        /// <param name="id">
        /// ID of the pronunciation dictionary to update
        /// </param>
        /// <param name="items">
        /// Updated list of word-pronunciation pairs
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.UpdatePronunciationDictResponse> UpdatePronunciationDictAsync(
            string id,
            global::System.Collections.Generic.IList<global::SmallestAI.PronunciationItem> items,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}