#nullable enable

namespace SmallestAI
{
    public partial interface ISubpackageVoiceCloningClient
    {
        /// <summary>
        /// Get your cloned Voices (Deprecated)<br/>
        /// **Deprecated** — use `GET /waves/v1/voice-cloning` instead. The new<br/>
        /// list endpoint returns the same data plus a `modelIds` array per<br/>
        /// clone. Kept live for backward compatibility.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.VoiceCloningGetClonedVoicesResponse200> GetClonedVoicesAsync(
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get your cloned Voices (Deprecated)<br/>
        /// **Deprecated** — use `GET /waves/v1/voice-cloning` instead. The new<br/>
        /// list endpoint returns the same data plus a `modelIds` array per<br/>
        /// clone. Kept live for backward compatibility.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.AutoSDKHttpResponse<global::SmallestAI.VoiceCloningGetClonedVoicesResponse200>> GetClonedVoicesAsResponseAsync(
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}