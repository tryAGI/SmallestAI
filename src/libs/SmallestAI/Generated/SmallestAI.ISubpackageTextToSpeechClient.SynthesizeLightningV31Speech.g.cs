#nullable enable

namespace SmallestAI
{
    public partial interface ISubpackageTextToSpeechClient
    {
        /// <summary>
        /// Lightning v3.1<br/>
        /// Get speech for given text using the Lightning v3.1 model<br/>
        /// ## Overview<br/>
        /// Lightning v3.1 is a 44 kHz text-to-speech model that delivers natural, expressive, and realistic speech synthesis.<br/>
        /// ## Key Features<br/>
        /// * **Voice Cloning Support**: Compatible with cloned voices<br/>
        /// * **Ultra-Low Latency**: Optimized for real-time applications<br/>
        /// * **Multi-Language**: Supports English (en) and Hindi (hi)<br/>
        /// * **Multiple Output Formats**: PCM, MP3, WAV, ulaw, and alaw<br/>
        /// * **Flexible Sample Rates**: 8000 Hz to 44100 Hz<br/>
        /// * **Speed Control**: Adjustable from 0.5x to 2x speed
        /// </summary>
        /// <param name="accept">
        /// Default Value: audio/wav
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> SynthesizeLightningV31SpeechAsync(

            global::SmallestAI.LightningV31Request request,
            global::SmallestAI.WavesV1LightningV31GetSpeechPostParametersAccept accept = global::SmallestAI.WavesV1LightningV31GetSpeechPostParametersAccept.AudioWav,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Lightning v3.1<br/>
        /// Get speech for given text using the Lightning v3.1 model<br/>
        /// ## Overview<br/>
        /// Lightning v3.1 is a 44 kHz text-to-speech model that delivers natural, expressive, and realistic speech synthesis.<br/>
        /// ## Key Features<br/>
        /// * **Voice Cloning Support**: Compatible with cloned voices<br/>
        /// * **Ultra-Low Latency**: Optimized for real-time applications<br/>
        /// * **Multi-Language**: Supports English (en) and Hindi (hi)<br/>
        /// * **Multiple Output Formats**: PCM, MP3, WAV, ulaw, and alaw<br/>
        /// * **Flexible Sample Rates**: 8000 Hz to 44100 Hz<br/>
        /// * **Speed Control**: Adjustable from 0.5x to 2x speed
        /// </summary>
        /// <param name="accept">
        /// Default Value: audio/wav
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> SynthesizeLightningV31SpeechAsStreamAsync(

            global::SmallestAI.LightningV31Request request,
            global::SmallestAI.WavesV1LightningV31GetSpeechPostParametersAccept accept = global::SmallestAI.WavesV1LightningV31GetSpeechPostParametersAccept.AudioWav,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Lightning v3.1<br/>
        /// Get speech for given text using the Lightning v3.1 model<br/>
        /// ## Overview<br/>
        /// Lightning v3.1 is a 44 kHz text-to-speech model that delivers natural, expressive, and realistic speech synthesis.<br/>
        /// ## Key Features<br/>
        /// * **Voice Cloning Support**: Compatible with cloned voices<br/>
        /// * **Ultra-Low Latency**: Optimized for real-time applications<br/>
        /// * **Multi-Language**: Supports English (en) and Hindi (hi)<br/>
        /// * **Multiple Output Formats**: PCM, MP3, WAV, ulaw, and alaw<br/>
        /// * **Flexible Sample Rates**: 8000 Hz to 44100 Hz<br/>
        /// * **Speed Control**: Adjustable from 0.5x to 2x speed
        /// </summary>
        /// <param name="accept">
        /// Default Value: audio/wav
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.AutoSDKHttpResponse<byte[]>> SynthesizeLightningV31SpeechAsResponseAsync(

            global::SmallestAI.LightningV31Request request,
            global::SmallestAI.WavesV1LightningV31GetSpeechPostParametersAccept accept = global::SmallestAI.WavesV1LightningV31GetSpeechPostParametersAccept.AudioWav,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Lightning v3.1<br/>
        /// Get speech for given text using the Lightning v3.1 model<br/>
        /// ## Overview<br/>
        /// Lightning v3.1 is a 44 kHz text-to-speech model that delivers natural, expressive, and realistic speech synthesis.<br/>
        /// ## Key Features<br/>
        /// * **Voice Cloning Support**: Compatible with cloned voices<br/>
        /// * **Ultra-Low Latency**: Optimized for real-time applications<br/>
        /// * **Multi-Language**: Supports English (en) and Hindi (hi)<br/>
        /// * **Multiple Output Formats**: PCM, MP3, WAV, ulaw, and alaw<br/>
        /// * **Flexible Sample Rates**: 8000 Hz to 44100 Hz<br/>
        /// * **Speed Control**: Adjustable from 0.5x to 2x speed
        /// </summary>
        /// <param name="accept">
        /// Default Value: audio/wav
        /// </param>
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
        global::System.Threading.Tasks.Task<byte[]> SynthesizeLightningV31SpeechAsync(
            global::SmallestAI.WavesV1LightningV31GetSpeechPostParametersAccept accept = global::SmallestAI.WavesV1LightningV31GetSpeechPostParametersAccept.AudioWav,
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