#nullable enable

namespace SmallestAI
{
    public partial interface ISubpackageVoicesClient
    {
        /// <summary>
        /// Get Voices<br/>
        /// Get voices supported for a given model using the new Waves API.
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
    }
}