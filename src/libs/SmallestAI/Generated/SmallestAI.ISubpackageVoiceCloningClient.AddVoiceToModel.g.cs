#nullable enable

namespace SmallestAI
{
    public partial interface ISubpackageVoiceCloningClient
    {
        /// <summary>
        /// Add your Voice (Deprecated)<br/>
        /// **Deprecated** — use `POST /waves/v1/voice-cloning` instead. The new<br/>
        /// endpoint defaults to `lightning-v3.1`, supports optional metadata,<br/>
        /// and returns pre-generated sample clips. This endpoint only clones<br/>
        /// onto `lightning-large` and the resulting voices do not work on<br/>
        /// `lightning-v3.1` (returns an empty WAV). Kept live for backward<br/>
        /// compatibility; new integrations should migrate.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.VoiceCloningAddVoiceToModelResponse200> AddVoiceToModelAsync(

            global::SmallestAI.AddVoiceToModelRequest request,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add your Voice (Deprecated)<br/>
        /// **Deprecated** — use `POST /waves/v1/voice-cloning` instead. The new<br/>
        /// endpoint defaults to `lightning-v3.1`, supports optional metadata,<br/>
        /// and returns pre-generated sample clips. This endpoint only clones<br/>
        /// onto `lightning-large` and the resulting voices do not work on<br/>
        /// `lightning-v3.1` (returns an empty WAV). Kept live for backward<br/>
        /// compatibility; new integrations should migrate.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.AutoSDKHttpResponse<global::SmallestAI.VoiceCloningAddVoiceToModelResponse200>> AddVoiceToModelAsResponseAsync(

            global::SmallestAI.AddVoiceToModelRequest request,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add your Voice (Deprecated)<br/>
        /// **Deprecated** — use `POST /waves/v1/voice-cloning` instead. The new<br/>
        /// endpoint defaults to `lightning-v3.1`, supports optional metadata,<br/>
        /// and returns pre-generated sample clips. This endpoint only clones<br/>
        /// onto `lightning-large` and the resulting voices do not work on<br/>
        /// `lightning-v3.1` (returns an empty WAV). Kept live for backward<br/>
        /// compatibility; new integrations should migrate.
        /// </summary>
        /// <param name="displayName">
        /// Display name for the voice clone.
        /// </param>
        /// <param name="file">
        /// Audio file to create voice clone from.
        /// </param>
        /// <param name="filename">
        /// Audio file to create voice clone from.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.VoiceCloningAddVoiceToModelResponse200> AddVoiceToModelAsync(
            string displayName,
            byte[] file,
            string filename,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add your Voice (Deprecated)<br/>
        /// **Deprecated** — use `POST /waves/v1/voice-cloning` instead. The new<br/>
        /// endpoint defaults to `lightning-v3.1`, supports optional metadata,<br/>
        /// and returns pre-generated sample clips. This endpoint only clones<br/>
        /// onto `lightning-large` and the resulting voices do not work on<br/>
        /// `lightning-v3.1` (returns an empty WAV). Kept live for backward<br/>
        /// compatibility; new integrations should migrate.
        /// </summary>
        /// <param name="displayName">
        /// Display name for the voice clone.
        /// </param>
        /// <param name="file">
        /// Audio file to create voice clone from.
        /// </param>
        /// <param name="filename">
        /// Audio file to create voice clone from.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.VoiceCloningAddVoiceToModelResponse200> AddVoiceToModelAsync(
            string displayName,
            global::System.IO.Stream file,
            string filename,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add your Voice (Deprecated)<br/>
        /// **Deprecated** — use `POST /waves/v1/voice-cloning` instead. The new<br/>
        /// endpoint defaults to `lightning-v3.1`, supports optional metadata,<br/>
        /// and returns pre-generated sample clips. This endpoint only clones<br/>
        /// onto `lightning-large` and the resulting voices do not work on<br/>
        /// `lightning-v3.1` (returns an empty WAV). Kept live for backward<br/>
        /// compatibility; new integrations should migrate.
        /// </summary>
        /// <param name="displayName">
        /// Display name for the voice clone.
        /// </param>
        /// <param name="file">
        /// Audio file to create voice clone from.
        /// </param>
        /// <param name="filename">
        /// Audio file to create voice clone from.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.AutoSDKHttpResponse<global::SmallestAI.VoiceCloningAddVoiceToModelResponse200>> AddVoiceToModelAsResponseAsync(
            string displayName,
            global::System.IO.Stream file,
            string filename,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}