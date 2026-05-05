#nullable enable

namespace SmallestAI
{
    public partial interface ISubpackageTextToSpeechClient
    {
        /// <summary>
        /// Lightning v2 SSE<br/>
        /// The Lightning v2 SSE API provides real-time text-to-speech streaming capabilities with high-quality voice synthesis. This API uses Server-Sent Events (SSE) to deliver audio chunks as they're generated, enabling low-latency audio playback without waiting for the entire audio file to process.<br/>
        /// For an end-to-end example of how to use the Lightning v2 SSE API, check out [Text to Speech (SSE) Example](https://github.com/smallest-inc/waves-examples/blob/main/lightning_v2/http_streaming/http_streaming_api.py)<br/>
        /// ## When to Use<br/>
        /// - **Interactive Applications**: Perfect for chatbots, virtual assistants, and other applications requiring immediate voice responses<br/>
        /// - **Long-Form Content**: Efficiently stream audio for articles, stories, or other long-form content without buffering delays<br/>
        /// - **Voice User Interfaces**: Create natural-sounding voice interfaces with minimal perceived latency<br/>
        /// - **Accessibility Solutions**: Provide real-time audio versions of written content for users with visual impairments<br/>
        /// ## How It Works<br/>
        /// 1. **Make a POST Request**: Send your text and voice settings to the API endpoint<br/>
        /// 2. **Receive Audio Chunks**: The API processes your text and streams audio back as base64-encoded chunks with 1024 byte size<br/>
        /// 3. **Process the Stream**: Handle the SSE events to decode and play audio chunks sequentially<br/>
        /// 4. **End of Stream**: The API sends a completion event when all audio has been delivered
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StreamLightningv2SpeechAsync(

            global::SmallestAI.Lightningv2Request request,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Lightning v2 SSE<br/>
        /// The Lightning v2 SSE API provides real-time text-to-speech streaming capabilities with high-quality voice synthesis. This API uses Server-Sent Events (SSE) to deliver audio chunks as they're generated, enabling low-latency audio playback without waiting for the entire audio file to process.<br/>
        /// For an end-to-end example of how to use the Lightning v2 SSE API, check out [Text to Speech (SSE) Example](https://github.com/smallest-inc/waves-examples/blob/main/lightning_v2/http_streaming/http_streaming_api.py)<br/>
        /// ## When to Use<br/>
        /// - **Interactive Applications**: Perfect for chatbots, virtual assistants, and other applications requiring immediate voice responses<br/>
        /// - **Long-Form Content**: Efficiently stream audio for articles, stories, or other long-form content without buffering delays<br/>
        /// - **Voice User Interfaces**: Create natural-sounding voice interfaces with minimal perceived latency<br/>
        /// - **Accessibility Solutions**: Provide real-time audio versions of written content for users with visual impairments<br/>
        /// ## How It Works<br/>
        /// 1. **Make a POST Request**: Send your text and voice settings to the API endpoint<br/>
        /// 2. **Receive Audio Chunks**: The API processes your text and streams audio back as base64-encoded chunks with 1024 byte size<br/>
        /// 3. **Process the Stream**: Handle the SSE events to decode and play audio chunks sequentially<br/>
        /// 4. **End of Stream**: The API sends a completion event when all audio has been delivered
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.AutoSDKHttpResponse<string>> StreamLightningv2SpeechAsResponseAsync(

            global::SmallestAI.Lightningv2Request request,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Lightning v2 SSE<br/>
        /// The Lightning v2 SSE API provides real-time text-to-speech streaming capabilities with high-quality voice synthesis. This API uses Server-Sent Events (SSE) to deliver audio chunks as they're generated, enabling low-latency audio playback without waiting for the entire audio file to process.<br/>
        /// For an end-to-end example of how to use the Lightning v2 SSE API, check out [Text to Speech (SSE) Example](https://github.com/smallest-inc/waves-examples/blob/main/lightning_v2/http_streaming/http_streaming_api.py)<br/>
        /// ## When to Use<br/>
        /// - **Interactive Applications**: Perfect for chatbots, virtual assistants, and other applications requiring immediate voice responses<br/>
        /// - **Long-Form Content**: Efficiently stream audio for articles, stories, or other long-form content without buffering delays<br/>
        /// - **Voice User Interfaces**: Create natural-sounding voice interfaces with minimal perceived latency<br/>
        /// - **Accessibility Solutions**: Provide real-time audio versions of written content for users with visual impairments<br/>
        /// ## How It Works<br/>
        /// 1. **Make a POST Request**: Send your text and voice settings to the API endpoint<br/>
        /// 2. **Receive Audio Chunks**: The API processes your text and streams audio back as base64-encoded chunks with 1024 byte size<br/>
        /// 3. **Process the Stream**: Handle the SSE events to decode and play audio chunks sequentially<br/>
        /// 4. **End of Stream**: The API sends a completion event when all audio has been delivered
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
        global::System.Threading.Tasks.Task<string> StreamLightningv2SpeechAsync(
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