#nullable enable

namespace SmallestAI
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Create access token<br/>
        /// Mint a short-lived access token from your API key. Call this from your server,<br/>
        /// then hand the returned `access_token` to a browser or mobile client. The client<br/>
        /// sends it as `Authorization: Bearer &lt;access_token&gt;` on TTS and STT requests. On<br/>
        /// WebSocket connections it can also go in the `api_key` query parameter. HTTP<br/>
        /// requests must use the header.<br/>
        /// A token works any number of times until it expires. It is accepted only on<br/>
        /// TTS, STT and speech-to-speech inference routes: `POST /waves/v1/stt/`, `WSS /waves/v1/stt/live`,<br/>
        /// `POST /waves/v1/tts`, `POST /waves/v1/tts/live`, `WSS /waves/v1/tts/live`, the<br/>
        /// dedicated Lightning v3.1 routes (`POST /waves/v1/lightning-v3.1/get_speech`,<br/>
        /// `POST /waves/v1/lightning-v3.1/stream`, `WSS /waves/v1/lightning-v3.1/get_speech/stream`),<br/>
        /// `WSS /waves/v1/s2s`, and the voice-listing routes. Every other<br/>
        /// route, including this one and `POST /waves/v1/pulse/get_text`, returns `403`<br/>
        /// to a token.<br/>
        /// Requests made with a token are billed to the API key that minted it. Deleting<br/>
        /// that key invalidates its tokens. A token is valid only in the region that<br/>
        /// minted it. If your server and your users can be in different regions, mint and<br/>
        /// call through the same region-pinned hostname (for example `api.us.smallest.ai`).<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/auth/token" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{"ttl_seconds": 300}'<br/>
        /// ```<br/>
        /// See the [Authentication guide](/models/api-reference/token-based-authentication)<br/>
        /// for the end-to-end server and client flow.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.AccessTokenResponse> CreateAccessTokenAsync(

            global::SmallestAI.CreateAccessTokenRequest request,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create access token<br/>
        /// Mint a short-lived access token from your API key. Call this from your server,<br/>
        /// then hand the returned `access_token` to a browser or mobile client. The client<br/>
        /// sends it as `Authorization: Bearer &lt;access_token&gt;` on TTS and STT requests. On<br/>
        /// WebSocket connections it can also go in the `api_key` query parameter. HTTP<br/>
        /// requests must use the header.<br/>
        /// A token works any number of times until it expires. It is accepted only on<br/>
        /// TTS, STT and speech-to-speech inference routes: `POST /waves/v1/stt/`, `WSS /waves/v1/stt/live`,<br/>
        /// `POST /waves/v1/tts`, `POST /waves/v1/tts/live`, `WSS /waves/v1/tts/live`, the<br/>
        /// dedicated Lightning v3.1 routes (`POST /waves/v1/lightning-v3.1/get_speech`,<br/>
        /// `POST /waves/v1/lightning-v3.1/stream`, `WSS /waves/v1/lightning-v3.1/get_speech/stream`),<br/>
        /// `WSS /waves/v1/s2s`, and the voice-listing routes. Every other<br/>
        /// route, including this one and `POST /waves/v1/pulse/get_text`, returns `403`<br/>
        /// to a token.<br/>
        /// Requests made with a token are billed to the API key that minted it. Deleting<br/>
        /// that key invalidates its tokens. A token is valid only in the region that<br/>
        /// minted it. If your server and your users can be in different regions, mint and<br/>
        /// call through the same region-pinned hostname (for example `api.us.smallest.ai`).<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/auth/token" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{"ttl_seconds": 300}'<br/>
        /// ```<br/>
        /// See the [Authentication guide](/models/api-reference/token-based-authentication)<br/>
        /// for the end-to-end server and client flow.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.AutoSDKHttpResponse<global::SmallestAI.AccessTokenResponse>> CreateAccessTokenAsResponseAsync(

            global::SmallestAI.CreateAccessTokenRequest request,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create access token<br/>
        /// Mint a short-lived access token from your API key. Call this from your server,<br/>
        /// then hand the returned `access_token` to a browser or mobile client. The client<br/>
        /// sends it as `Authorization: Bearer &lt;access_token&gt;` on TTS and STT requests. On<br/>
        /// WebSocket connections it can also go in the `api_key` query parameter. HTTP<br/>
        /// requests must use the header.<br/>
        /// A token works any number of times until it expires. It is accepted only on<br/>
        /// TTS, STT and speech-to-speech inference routes: `POST /waves/v1/stt/`, `WSS /waves/v1/stt/live`,<br/>
        /// `POST /waves/v1/tts`, `POST /waves/v1/tts/live`, `WSS /waves/v1/tts/live`, the<br/>
        /// dedicated Lightning v3.1 routes (`POST /waves/v1/lightning-v3.1/get_speech`,<br/>
        /// `POST /waves/v1/lightning-v3.1/stream`, `WSS /waves/v1/lightning-v3.1/get_speech/stream`),<br/>
        /// `WSS /waves/v1/s2s`, and the voice-listing routes. Every other<br/>
        /// route, including this one and `POST /waves/v1/pulse/get_text`, returns `403`<br/>
        /// to a token.<br/>
        /// Requests made with a token are billed to the API key that minted it. Deleting<br/>
        /// that key invalidates its tokens. A token is valid only in the region that<br/>
        /// minted it. If your server and your users can be in different regions, mint and<br/>
        /// call through the same region-pinned hostname (for example `api.us.smallest.ai`).<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/auth/token" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{"ttl_seconds": 300}'<br/>
        /// ```<br/>
        /// See the [Authentication guide](/models/api-reference/token-based-authentication)<br/>
        /// for the end-to-end server and client flow.
        /// </summary>
        /// <param name="ttlSeconds">
        /// How long the token stays valid, in seconds. Between 30 and 900. Defaults to 300 when omitted.<br/>
        /// Default Value: 300
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.AccessTokenResponse> CreateAccessTokenAsync(
            int? ttlSeconds = default,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}