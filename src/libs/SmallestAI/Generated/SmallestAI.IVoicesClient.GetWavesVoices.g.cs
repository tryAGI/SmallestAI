#nullable enable

namespace SmallestAI
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Get voices for a pool<br/>
        /// Return the voice catalog for the chosen Lightning v3.1 pool. Two pools:<br/>
        /// - `lightning-v3.1` — the Standard catalog. Supports voice cloning; 20 language codes.<br/>
        /// - `lightning-v3.1-pro` — the Pro catalog. Curated set across American, British, and Indian accents plus 29 additional languages. Same latency and concurrency as Standard, on dedicated inference.<br/>
        /// The endpoint is pool-scoped: `/waves/v1/lightning-v3.1/get_voices` returns Standard voices only; `/waves/v1/lightning-v3.1-pro/get_voices` returns Pro voices only. Call one or both depending on which pool you plan to use.<br/>
        /// Each voice carries tags (`language`, `accent`, `gender`, `age`, `emotions`, `usecases`). Filter client-side to find the voices that match a target language, accent, or use case. Pass the returned `voiceId` as `voice_id` on the unified [`POST /waves/v1/tts`](/models/api-reference/text-to-speech/synthesize-speech) route, together with `"model": "lightning_v3.1"` (Standard) or `"model": "lightning_v3.1_pro"` (Pro).<br/>
        /// For the canonical per-language voice list (with previews and recommended pairings), see the [Lightning v3.1](/models/model-cards/text-to-speech/lightning-v-3-1) and [Lightning v3.1 Pro](/models/model-cards/text-to-speech/lightning-v-3-1-pro) model cards.
        /// </summary>
        /// <param name="model">
        /// Default Value: lightning-v3.1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.VoicesGetWavesVoicesResponse200> GetWavesVoicesAsync(
            global::SmallestAI.WavesV1ModelGetVoicesGetParametersModel model = global::SmallestAI.WavesV1ModelGetVoicesGetParametersModel.LightningV31,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get voices for a pool<br/>
        /// Return the voice catalog for the chosen Lightning v3.1 pool. Two pools:<br/>
        /// - `lightning-v3.1` — the Standard catalog. Supports voice cloning; 20 language codes.<br/>
        /// - `lightning-v3.1-pro` — the Pro catalog. Curated set across American, British, and Indian accents plus 29 additional languages. Same latency and concurrency as Standard, on dedicated inference.<br/>
        /// The endpoint is pool-scoped: `/waves/v1/lightning-v3.1/get_voices` returns Standard voices only; `/waves/v1/lightning-v3.1-pro/get_voices` returns Pro voices only. Call one or both depending on which pool you plan to use.<br/>
        /// Each voice carries tags (`language`, `accent`, `gender`, `age`, `emotions`, `usecases`). Filter client-side to find the voices that match a target language, accent, or use case. Pass the returned `voiceId` as `voice_id` on the unified [`POST /waves/v1/tts`](/models/api-reference/text-to-speech/synthesize-speech) route, together with `"model": "lightning_v3.1"` (Standard) or `"model": "lightning_v3.1_pro"` (Pro).<br/>
        /// For the canonical per-language voice list (with previews and recommended pairings), see the [Lightning v3.1](/models/model-cards/text-to-speech/lightning-v-3-1) and [Lightning v3.1 Pro](/models/model-cards/text-to-speech/lightning-v-3-1-pro) model cards.
        /// </summary>
        /// <param name="model">
        /// Default Value: lightning-v3.1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.AutoSDKHttpResponse<global::SmallestAI.VoicesGetWavesVoicesResponse200>> GetWavesVoicesAsResponseAsync(
            global::SmallestAI.WavesV1ModelGetVoicesGetParametersModel model = global::SmallestAI.WavesV1ModelGetVoicesGetParametersModel.LightningV31,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}