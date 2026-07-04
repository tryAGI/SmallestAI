#nullable enable

namespace SmallestAI
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Get Voices<br/>
        /// List voices available for Lightning v3.1. The response is the union of the standard and Pro voice catalogs — the API does not return a per-voice "is Pro" flag, so consult the [Lightning v3.1 Pro](/waves/model-cards/text-to-speech/lightning-v-3-1-pro) and [Lightning v3.1](/waves/model-cards/text-to-speech/lightning-v-3-1) model cards for the canonical per-pool voice lists. Use the `voice_id` from this response together with `"model": "lightning_v3.1"` (default) or `"model": "lightning_v3.1_pro"` on the unified `/waves/v1/tts` route to pick the pool.
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
        /// Get Voices<br/>
        /// List voices available for Lightning v3.1. The response is the union of the standard and Pro voice catalogs — the API does not return a per-voice "is Pro" flag, so consult the [Lightning v3.1 Pro](/waves/model-cards/text-to-speech/lightning-v-3-1-pro) and [Lightning v3.1](/waves/model-cards/text-to-speech/lightning-v-3-1) model cards for the canonical per-pool voice lists. Use the `voice_id` from this response together with `"model": "lightning_v3.1"` (default) or `"model": "lightning_v3.1_pro"` on the unified `/waves/v1/tts` route to pick the pool.
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