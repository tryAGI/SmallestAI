#nullable enable

namespace SmallestAI
{
    public partial interface ISubpackageTextToSpeechClient
    {
        /// <summary>
        /// Lightning v2<br/>
        /// Get speech for given text using the Waves API
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> SynthesizeLightningv2SpeechAsync(

            global::SmallestAI.Lightningv2Request request,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Lightning v2<br/>
        /// Get speech for given text using the Waves API
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> SynthesizeLightningv2SpeechAsStreamAsync(

            global::SmallestAI.Lightningv2Request request,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Lightning v2<br/>
        /// Get speech for given text using the Waves API
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.AutoSDKHttpResponse<byte[]>> SynthesizeLightningv2SpeechAsResponseAsync(

            global::SmallestAI.Lightningv2Request request,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Lightning v2<br/>
        /// Get speech for given text using the Waves API
        /// </summary>
        /// <param name="text">
        /// The text to convert to speech.<br/>
        /// Default Value: Hey i am your a text to speech model
        /// </param>
        /// <param name="voiceId">
        /// The voice identifier to use for speech generation.<br/>
        /// Default Value: malcom
        /// </param>
        /// <param name="sampleRate">
        /// The sample rate for the generated audio.<br/>
        /// Default Value: 24000
        /// </param>
        /// <param name="speed">
        /// The speed of the generated speech.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="consistency">
        /// This parameter controls word repetition and skipping. Decrease it to prevent skipped words, and increase it to prevent repetition.<br/>
        /// Default Value: 0.5F
        /// </param>
        /// <param name="similarity">
        /// This parameter controls the similarity between the generated speech and the reference audio. Increase it to make the speech more similar to the reference audio.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="enhancement">
        /// Enhances speech quality at the cost of increased latency.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="language">
        /// Determines how numbers are spelled out. If set to 'en', numbers will be read as individual digits in English. If set to 'hi', numbers will be read as individual digits in Hindi.<br/>
        /// Default Value: en
        /// </param>
        /// <param name="outputFormat">
        /// The format of the output audio.<br/>
        /// Default Value: pcm
        /// </param>
        /// <param name="pronunciationDicts">
        /// The IDs of the pronunciation dictionaries to use for speech generation.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> SynthesizeLightningv2SpeechAsync(
            string text = "Hey i am your a text to speech model",
            string voiceId = "malcom",
            int? sampleRate = default,
            double? speed = default,
            double? consistency = default,
            double? similarity = default,
            double? enhancement = default,
            global::SmallestAI.Lightningv2RequestLanguage? language = default,
            global::SmallestAI.Lightningv2RequestOutputFormat? outputFormat = default,
            global::System.Collections.Generic.IList<string>? pronunciationDicts = default,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}