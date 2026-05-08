#nullable enable

namespace SmallestAI
{
    public partial interface ISubpackageTextToSpeechClient
    {
        /// <summary>
        /// Lightning v3.1 SSE<br/>
        /// Stream speech for given text using the Lightning v3.1 SSE API<br/>
        /// ## Overview<br/>
        /// The Lightning v3.1 SSE API provides real-time text-to-speech streaming capabilities with natural, expressive voice synthesis. This API uses Server-Sent Events (SSE) to deliver audio chunks as they're generated, enabling low-latency audio playback without waiting for the entire audio file to process.<br/>
        /// Lightning v3.1 is a 44 kHz model that produces natural, expressive, and realistic speech, with support for voice cloning.<br/>
        /// ## When to Use<br/>
        /// * **Interactive Applications**: Perfect for chatbots, virtual assistants, and other applications requiring immediate voice responses<br/>
        /// * **Long-Form Content**: Efficiently stream audio for articles, stories, or other long-form content without buffering delays<br/>
        /// * **Voice User Interfaces**: Create natural-sounding voice interfaces with minimal perceived latency<br/>
        /// * **Accessibility Solutions**: Provide real-time audio versions of written content for users with visual impairments<br/>
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
        global::System.Threading.Tasks.Task<string> StreamLightningV31SpeechAsync(

            global::SmallestAI.LightningV31Request request,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Lightning v3.1 SSE<br/>
        /// Stream speech for given text using the Lightning v3.1 SSE API<br/>
        /// ## Overview<br/>
        /// The Lightning v3.1 SSE API provides real-time text-to-speech streaming capabilities with natural, expressive voice synthesis. This API uses Server-Sent Events (SSE) to deliver audio chunks as they're generated, enabling low-latency audio playback without waiting for the entire audio file to process.<br/>
        /// Lightning v3.1 is a 44 kHz model that produces natural, expressive, and realistic speech, with support for voice cloning.<br/>
        /// ## When to Use<br/>
        /// * **Interactive Applications**: Perfect for chatbots, virtual assistants, and other applications requiring immediate voice responses<br/>
        /// * **Long-Form Content**: Efficiently stream audio for articles, stories, or other long-form content without buffering delays<br/>
        /// * **Voice User Interfaces**: Create natural-sounding voice interfaces with minimal perceived latency<br/>
        /// * **Accessibility Solutions**: Provide real-time audio versions of written content for users with visual impairments<br/>
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
        global::System.Threading.Tasks.Task<global::SmallestAI.AutoSDKHttpResponse<string>> StreamLightningV31SpeechAsResponseAsync(

            global::SmallestAI.LightningV31Request request,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Lightning v3.1 SSE<br/>
        /// Stream speech for given text using the Lightning v3.1 SSE API<br/>
        /// ## Overview<br/>
        /// The Lightning v3.1 SSE API provides real-time text-to-speech streaming capabilities with natural, expressive voice synthesis. This API uses Server-Sent Events (SSE) to deliver audio chunks as they're generated, enabling low-latency audio playback without waiting for the entire audio file to process.<br/>
        /// Lightning v3.1 is a 44 kHz model that produces natural, expressive, and realistic speech, with support for voice cloning.<br/>
        /// ## When to Use<br/>
        /// * **Interactive Applications**: Perfect for chatbots, virtual assistants, and other applications requiring immediate voice responses<br/>
        /// * **Long-Form Content**: Efficiently stream audio for articles, stories, or other long-form content without buffering delays<br/>
        /// * **Voice User Interfaces**: Create natural-sounding voice interfaces with minimal perceived latency<br/>
        /// * **Accessibility Solutions**: Provide real-time audio versions of written content for users with visual impairments<br/>
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
        /// Default Value: daniel
        /// </param>
        /// <param name="sampleRate">
        /// The sample rate for the generated audio.<br/>
        /// Default Value: 44100
        /// </param>
        /// <param name="speed">
        /// The speed of the generated speech.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="language">
        /// Language code for synthesis. Influences pronunciation, number/date<br/>
        /// normalization, and phoneme selection.<br/>
        /// - **Indian:** `en`, `hi`, `mr` (Marathi), `kn` (Kannada), `ta` (Tamil),<br/>
        ///   `bn` (Bengali), `gu` (Gujarati), `te` (Telugu), `ml` (Malayalam),<br/>
        ///   `pa` (Punjabi), `or` (Odia)<br/>
        /// - **European:** `de`, `fr`, `es`, `it`, `pl`, `nl`, `ru`, `sv` (Swedish),<br/>
        ///   `pt` (Portuguese)<br/>
        /// - **MENA:** `ar` (Arabic), `he` (Hebrew)<br/>
        /// - `auto` — auto-detect from input text (recommended for code-switching)<br/>
        /// Default Value: en
        /// </param>
        /// <param name="outputFormat">
        /// Format of the returned audio. `pcm` is the lowest-latency option<br/>
        /// but requires a decoder to play; `mp3` and `wav` are directly<br/>
        /// playable in browsers and most media players. The server default<br/>
        /// is `pcm` when the field is omitted — the API playground uses<br/>
        /// `mp3` so the generated audio is directly playable.<br/>
        /// Default Value: pcm
        /// </param>
        /// <param name="pronunciationDicts">
        /// The IDs of the pronunciation dictionaries to use for speech generation.
        /// </param>
        /// <param name="sessionId">
        /// Optional client-provided session identifier for correlation. Only alphanumeric characters, hyphens, underscores, and dots are allowed. Max 128 characters. Echoed back in response headers as `X-External-Session-Id`.
        /// </param>
        /// <param name="requestId">
        /// Optional client-provided request identifier for correlation. Only alphanumeric characters, hyphens, underscores, and dots are allowed. Max 128 characters. Echoed back in response headers as `X-External-Request-Id`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StreamLightningV31SpeechAsync(
            string text = "Hey i am your a text to speech model",
            string voiceId = "daniel",
            global::SmallestAI.LightningV31RequestSampleRate? sampleRate = default,
            double? speed = default,
            global::SmallestAI.LightningV31RequestLanguage? language = default,
            global::SmallestAI.LightningV31RequestOutputFormat? outputFormat = default,
            global::System.Collections.Generic.IList<string>? pronunciationDicts = default,
            string? sessionId = default,
            string? requestId = default,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}