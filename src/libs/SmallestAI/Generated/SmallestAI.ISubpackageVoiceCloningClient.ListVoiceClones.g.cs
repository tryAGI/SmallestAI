#nullable enable

namespace SmallestAI
{
    public partial interface ISubpackageVoiceCloningClient
    {
        /// <summary>
        /// List Voice Clones<br/>
        /// Retrieve all voice clones in your organization.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.VoiceCloningListVoiceClonesResponse200> ListVoiceClonesAsync(
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}