#nullable enable

namespace SmallestAI
{
    public partial interface ISubpackagePronunciationDictionariesClient
    {
        /// <summary>
        /// Delete<br/>
        /// Delete an existing pronunciation dictionary for the authenticated user
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.DeletePronunciationDictResponse> DeletePronunciationDictAsync(

            global::SmallestAI.DeletePronunciationDictRequest request,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete<br/>
        /// Delete an existing pronunciation dictionary for the authenticated user
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.AutoSDKHttpResponse<global::SmallestAI.DeletePronunciationDictResponse>> DeletePronunciationDictAsResponseAsync(

            global::SmallestAI.DeletePronunciationDictRequest request,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete<br/>
        /// Delete an existing pronunciation dictionary for the authenticated user
        /// </summary>
        /// <param name="id">
        /// ID of the pronunciation dictionary to delete
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.DeletePronunciationDictResponse> DeletePronunciationDictAsync(
            string id,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}