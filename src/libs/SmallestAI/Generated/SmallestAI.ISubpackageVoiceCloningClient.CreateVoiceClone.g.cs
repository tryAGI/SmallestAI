#nullable enable

namespace SmallestAI
{
    public partial interface ISubpackageVoiceCloningClient
    {
        /// <summary>
        /// Create a Voice Clone<br/>
        /// Create an instant voice clone in a single call. Defaults to `lightning-v3.1`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.VoiceCloningCreateVoiceCloneResponse200> CreateVoiceCloneAsync(

            global::SmallestAI.CreateVoiceCloneRequest request,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Voice Clone<br/>
        /// Create an instant voice clone in a single call. Defaults to `lightning-v3.1`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.AutoSDKHttpResponse<global::SmallestAI.VoiceCloningCreateVoiceCloneResponse200>> CreateVoiceCloneAsResponseAsync(

            global::SmallestAI.CreateVoiceCloneRequest request,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Voice Clone<br/>
        /// Create an instant voice clone in a single call. Defaults to `lightning-v3.1`.
        /// </summary>
        /// <param name="displayName">
        /// Human-readable name for the voice clone.
        /// </param>
        /// <param name="file">
        /// Audio file to clone from. Supported MIME types:<br/>
        /// `audio/mpeg`, `audio/mpeg-3`, `audio/wav`, `audio/wave`,<br/>
        /// `audio/webm`, `video/webm`, `audio/mp4`, `video/mp4`.<br/>
        /// Maximum size: 5 MB.
        /// </param>
        /// <param name="filename">
        /// Audio file to clone from. Supported MIME types:<br/>
        /// `audio/mpeg`, `audio/mpeg-3`, `audio/wav`, `audio/wave`,<br/>
        /// `audio/webm`, `video/webm`, `audio/mp4`, `video/mp4`.<br/>
        /// Maximum size: 5 MB.
        /// </param>
        /// <param name="description">
        /// Optional longer description for the voice clone.
        /// </param>
        /// <param name="accent">
        /// Optional accent tag (e.g. "general", "indian").
        /// </param>
        /// <param name="tags">
        /// Optional comma-separated list of tags. Server splits on<br/>
        /// commas and trims whitespace (`"en, tone-test"` → `["en", "tone-test"]`).
        /// </param>
        /// <param name="language">
        /// Primary language the clone will be used for. Optional, but<br/>
        /// **strongly recommended** — set it to the language of your<br/>
        /// reference audio. The TTS request's `language` should also<br/>
        /// match this code; setting it now avoids silent language<br/>
        /// mismatches at inference time.<br/>
        /// Must be one of the languages supported by `lightning-v3.1`<br/>
        /// (e.g. `en`, `hi`, `multi`). The server validates and rejects<br/>
        /// unsupported codes with a 400.
        /// </param>
        /// <param name="model">
        /// Voice cloning model. Defaults to `lightning-v3.1`.<br/>
        /// `lightning-v2` is accepted by the schema for historical<br/>
        /// reasons but is deprecated — the server returns 400 with<br/>
        /// `"Voice cloning for lightning-v2 is deprecated. Please use lightning-v3.1"`.<br/>
        /// Default Value: lightning-v3.1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.VoiceCloningCreateVoiceCloneResponse200> CreateVoiceCloneAsync(
            string displayName,
            byte[] file,
            string filename,
            string? description = default,
            string? accent = default,
            string? tags = default,
            string? language = default,
            global::SmallestAI.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModel? model = default,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a Voice Clone<br/>
        /// Create an instant voice clone in a single call. Defaults to `lightning-v3.1`.
        /// </summary>
        /// <param name="displayName">
        /// Human-readable name for the voice clone.
        /// </param>
        /// <param name="file">
        /// Audio file to clone from. Supported MIME types:<br/>
        /// `audio/mpeg`, `audio/mpeg-3`, `audio/wav`, `audio/wave`,<br/>
        /// `audio/webm`, `video/webm`, `audio/mp4`, `video/mp4`.<br/>
        /// Maximum size: 5 MB.
        /// </param>
        /// <param name="filename">
        /// Audio file to clone from. Supported MIME types:<br/>
        /// `audio/mpeg`, `audio/mpeg-3`, `audio/wav`, `audio/wave`,<br/>
        /// `audio/webm`, `video/webm`, `audio/mp4`, `video/mp4`.<br/>
        /// Maximum size: 5 MB.
        /// </param>
        /// <param name="description">
        /// Optional longer description for the voice clone.
        /// </param>
        /// <param name="accent">
        /// Optional accent tag (e.g. "general", "indian").
        /// </param>
        /// <param name="tags">
        /// Optional comma-separated list of tags. Server splits on<br/>
        /// commas and trims whitespace (`"en, tone-test"` → `["en", "tone-test"]`).
        /// </param>
        /// <param name="language">
        /// Primary language the clone will be used for. Optional, but<br/>
        /// **strongly recommended** — set it to the language of your<br/>
        /// reference audio. The TTS request's `language` should also<br/>
        /// match this code; setting it now avoids silent language<br/>
        /// mismatches at inference time.<br/>
        /// Must be one of the languages supported by `lightning-v3.1`<br/>
        /// (e.g. `en`, `hi`, `multi`). The server validates and rejects<br/>
        /// unsupported codes with a 400.
        /// </param>
        /// <param name="model">
        /// Voice cloning model. Defaults to `lightning-v3.1`.<br/>
        /// `lightning-v2` is accepted by the schema for historical<br/>
        /// reasons but is deprecated — the server returns 400 with<br/>
        /// `"Voice cloning for lightning-v2 is deprecated. Please use lightning-v3.1"`.<br/>
        /// Default Value: lightning-v3.1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.VoiceCloningCreateVoiceCloneResponse200> CreateVoiceCloneAsync(
            string displayName,
            global::System.IO.Stream file,
            string filename,
            string? description = default,
            string? accent = default,
            string? tags = default,
            string? language = default,
            global::SmallestAI.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModel? model = default,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Voice Clone<br/>
        /// Create an instant voice clone in a single call. Defaults to `lightning-v3.1`.
        /// </summary>
        /// <param name="displayName">
        /// Human-readable name for the voice clone.
        /// </param>
        /// <param name="file">
        /// Audio file to clone from. Supported MIME types:<br/>
        /// `audio/mpeg`, `audio/mpeg-3`, `audio/wav`, `audio/wave`,<br/>
        /// `audio/webm`, `video/webm`, `audio/mp4`, `video/mp4`.<br/>
        /// Maximum size: 5 MB.
        /// </param>
        /// <param name="filename">
        /// Audio file to clone from. Supported MIME types:<br/>
        /// `audio/mpeg`, `audio/mpeg-3`, `audio/wav`, `audio/wave`,<br/>
        /// `audio/webm`, `video/webm`, `audio/mp4`, `video/mp4`.<br/>
        /// Maximum size: 5 MB.
        /// </param>
        /// <param name="description">
        /// Optional longer description for the voice clone.
        /// </param>
        /// <param name="accent">
        /// Optional accent tag (e.g. "general", "indian").
        /// </param>
        /// <param name="tags">
        /// Optional comma-separated list of tags. Server splits on<br/>
        /// commas and trims whitespace (`"en, tone-test"` → `["en", "tone-test"]`).
        /// </param>
        /// <param name="language">
        /// Primary language the clone will be used for. Optional, but<br/>
        /// **strongly recommended** — set it to the language of your<br/>
        /// reference audio. The TTS request's `language` should also<br/>
        /// match this code; setting it now avoids silent language<br/>
        /// mismatches at inference time.<br/>
        /// Must be one of the languages supported by `lightning-v3.1`<br/>
        /// (e.g. `en`, `hi`, `multi`). The server validates and rejects<br/>
        /// unsupported codes with a 400.
        /// </param>
        /// <param name="model">
        /// Voice cloning model. Defaults to `lightning-v3.1`.<br/>
        /// `lightning-v2` is accepted by the schema for historical<br/>
        /// reasons but is deprecated — the server returns 400 with<br/>
        /// `"Voice cloning for lightning-v2 is deprecated. Please use lightning-v3.1"`.<br/>
        /// Default Value: lightning-v3.1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.AutoSDKHttpResponse<global::SmallestAI.VoiceCloningCreateVoiceCloneResponse200>> CreateVoiceCloneAsResponseAsync(
            string displayName,
            global::System.IO.Stream file,
            string filename,
            string? description = default,
            string? accent = default,
            string? tags = default,
            string? language = default,
            global::SmallestAI.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModel? model = default,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}