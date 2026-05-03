#nullable enable

namespace SmallestAI
{
    public partial interface ISubpackageSpeechToTextClient
    {
        /// <summary>
        /// Pulse (Pre-Recorded)<br/>
        /// Convert speech to text using file upload with the Pulse STT POST API<br/>
        /// The STT POST API allows you to convert speech to text using two different input methods:<br/>
        /// 1. **Raw Audio Bytes** (`application/octet-stream`) - Send raw audio data with all parameters as query parameters<br/>
        /// 2. **Audio URL** (`application/json`) - Provide only a URL to an audio file in the JSON body, with all other parameters as query parameters<br/>
        /// Both methods use our Pulse STT model with automatic language detection across 30+ languages.
        /// </summary>
        /// <param name="language">
        /// Default Value: multi-eu
        /// </param>
        /// <param name="webhookUrl"></param>
        /// <param name="webhookExtra"></param>
        /// <param name="wordTimestamps">
        /// Default Value: false
        /// </param>
        /// <param name="diarize">
        /// Default Value: false
        /// </param>
        /// <param name="ageDetection">
        /// Default Value: false
        /// </param>
        /// <param name="genderDetection">
        /// Default Value: false
        /// </param>
        /// <param name="emotionDetection">
        /// Default Value: false
        /// </param>
        /// <param name="format">
        /// Default Value: true
        /// </param>
        /// <param name="punctuate">
        /// Default Value: true
        /// </param>
        /// <param name="capitalize">
        /// Default Value: true
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.SpeechToTextPulseResponse200> PulseAsync(

            byte[] request,
            global::SmallestAI.WavesV1PulseGetTextPostParametersLanguage? language = default,
            string? webhookUrl = default,
            string? webhookExtra = default,
            bool? wordTimestamps = default,
            bool? diarize = default,
            global::SmallestAI.WavesV1PulseGetTextPostParametersAgeDetection? ageDetection = default,
            global::SmallestAI.WavesV1PulseGetTextPostParametersGenderDetection? genderDetection = default,
            global::SmallestAI.WavesV1PulseGetTextPostParametersEmotionDetection? emotionDetection = default,
            global::SmallestAI.WavesV1PulseGetTextPostParametersFormat? format = default,
            global::SmallestAI.WavesV1PulseGetTextPostParametersPunctuate? punctuate = default,
            global::SmallestAI.WavesV1PulseGetTextPostParametersCapitalize? capitalize = default,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}