#nullable enable

namespace SmallestAI
{
    public partial interface ISubpackageVoiceCloningClient
    {
        /// <summary>
        /// Delete a Voice Clone (Deprecated)<br/>
        /// Delete a voice clone by `voiceId`. Despite the `/lightning-large/`<br/>
        /// path, this endpoint deletes any voice clone on the organization,<br/>
        /// including clones created via `POST /waves/v1/voice-cloning`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.VoiceCloningDeleteVoiceCloneResponse200> DeleteVoiceCloneAsync(

            global::SmallestAI.DeleteVoiceCloneRequest request,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a Voice Clone (Deprecated)<br/>
        /// Delete a voice clone by `voiceId`. Despite the `/lightning-large/`<br/>
        /// path, this endpoint deletes any voice clone on the organization,<br/>
        /// including clones created via `POST /waves/v1/voice-cloning`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.AutoSDKHttpResponse<global::SmallestAI.VoiceCloningDeleteVoiceCloneResponse200>> DeleteVoiceCloneAsResponseAsync(

            global::SmallestAI.DeleteVoiceCloneRequest request,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a Voice Clone (Deprecated)<br/>
        /// Delete a voice clone by `voiceId`. Despite the `/lightning-large/`<br/>
        /// path, this endpoint deletes any voice clone on the organization,<br/>
        /// including clones created via `POST /waves/v1/voice-cloning`.
        /// </summary>
        /// <param name="voiceId">
        /// The unique identifier of the voice clone to delete.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.VoiceCloningDeleteVoiceCloneResponse200> DeleteVoiceCloneAsync(
            string voiceId,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}