#nullable enable

namespace SmallestAI
{
    public partial interface ISubpackageTextToSpeechClient
    {
        /// <summary>
        /// Stream speech (SSE)<br/>
        /// Synthesize speech and stream the audio back over Server-Sent Events. Same body as `/waves/v1/tts` — the only difference is the response is a stream of base64-encoded PCM chunks instead of one binary blob.<br/>
        /// Pick the model with the `model` body parameter, same as the sync route.<br/>
        /// &lt;Note&gt;<br/>
        ///   **The same URL serves the WebSocket endpoint.** `wss://api.smallest.ai/waves/v1/tts/live` accepts a WebSocket upgrade for streaming-text scenarios (LLM token streams, live captioning). The HTTP `POST` documented on this page returns SSE; use `wss://` to use the WebSocket protocol instead. See the [WebSocket reference](/waves/api-reference/api-reference/text-to-speech/tts).<br/>
        /// &lt;/Note&gt;<br/>
        /// ## When to use this<br/>
        /// - **Use this** when you want playback to start before synthesis is complete — long passages, latency-sensitive UI, live narration.<br/>
        /// - **Use sync `/waves/v1/tts`** when total latency doesn't matter and you'd rather get one buffer.<br/>
        /// - **Use `/waves/v1/tts/live`** (WebSocket) when the *text* arrives incrementally (LLM token stream). SSE assumes you have the full text up front.<br/>
        /// ## How it works<br/>
        /// 1. POST your text + voice settings — same payload as `/waves/v1/tts`, plus optional `model`.<br/>
        /// 2. The response is `Content-Type: text/event-stream`. Each chunk frame is `event: audio\n` followed by `data: {"audio": "&lt;base64-pcm&gt;"}\n\n`.<br/>
        /// 3. Decode each chunk's `audio` field with base64 and feed the PCM bytes to your audio pipeline (browser `MediaSource`, ffmpeg pipe, raw PCM player, etc.).<br/>
        /// 4. A final `data: {"done": true}\n\n` frame marks end of stream.<br/>
        /// ## Examples<br/>
        /// **cURL**<br/>
        /// ```bash<br/>
        /// curl -N -X POST "https://api.smallest.ai/waves/v1/tts/live" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///     "text": "Streaming this paragraph chunk by chunk so playback can start sooner.",<br/>
        ///     "voice_id": "magnus",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "pcm"<br/>
        ///   }'<br/>
        /// ```<br/>
        /// ## Common gotchas<br/>
        /// - **Use a streaming-friendly client.** `curl -N`, Python `iter_lines`, or a `fetch` `ReadableStream` reader. Buffering clients will hide the latency win.<br/>
        /// - **Audio is base64 inside the event payload**, not the raw event bytes. Decode the `data.audio` field per event.<br/>
        /// - **`output_format=pcm`** gives the lowest overhead for streaming playback. `wav`/`mp3` work but add per-chunk framing bytes.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<string> SynthesizeSpeechSseAsync(

            global::SmallestAI.TtsRequest request,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream speech (SSE)<br/>
        /// Synthesize speech and stream the audio back over Server-Sent Events. Same body as `/waves/v1/tts` — the only difference is the response is a stream of base64-encoded PCM chunks instead of one binary blob.<br/>
        /// Pick the model with the `model` body parameter, same as the sync route.<br/>
        /// &lt;Note&gt;<br/>
        ///   **The same URL serves the WebSocket endpoint.** `wss://api.smallest.ai/waves/v1/tts/live` accepts a WebSocket upgrade for streaming-text scenarios (LLM token streams, live captioning). The HTTP `POST` documented on this page returns SSE; use `wss://` to use the WebSocket protocol instead. See the [WebSocket reference](/waves/api-reference/api-reference/text-to-speech/tts).<br/>
        /// &lt;/Note&gt;<br/>
        /// ## When to use this<br/>
        /// - **Use this** when you want playback to start before synthesis is complete — long passages, latency-sensitive UI, live narration.<br/>
        /// - **Use sync `/waves/v1/tts`** when total latency doesn't matter and you'd rather get one buffer.<br/>
        /// - **Use `/waves/v1/tts/live`** (WebSocket) when the *text* arrives incrementally (LLM token stream). SSE assumes you have the full text up front.<br/>
        /// ## How it works<br/>
        /// 1. POST your text + voice settings — same payload as `/waves/v1/tts`, plus optional `model`.<br/>
        /// 2. The response is `Content-Type: text/event-stream`. Each chunk frame is `event: audio\n` followed by `data: {"audio": "&lt;base64-pcm&gt;"}\n\n`.<br/>
        /// 3. Decode each chunk's `audio` field with base64 and feed the PCM bytes to your audio pipeline (browser `MediaSource`, ffmpeg pipe, raw PCM player, etc.).<br/>
        /// 4. A final `data: {"done": true}\n\n` frame marks end of stream.<br/>
        /// ## Examples<br/>
        /// **cURL**<br/>
        /// ```bash<br/>
        /// curl -N -X POST "https://api.smallest.ai/waves/v1/tts/live" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///     "text": "Streaming this paragraph chunk by chunk so playback can start sooner.",<br/>
        ///     "voice_id": "magnus",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "pcm"<br/>
        ///   }'<br/>
        /// ```<br/>
        /// ## Common gotchas<br/>
        /// - **Use a streaming-friendly client.** `curl -N`, Python `iter_lines`, or a `fetch` `ReadableStream` reader. Buffering clients will hide the latency win.<br/>
        /// - **Audio is base64 inside the event payload**, not the raw event bytes. Decode the `data.audio` field per event.<br/>
        /// - **`output_format=pcm`** gives the lowest overhead for streaming playback. `wav`/`mp3` work but add per-chunk framing bytes.
        /// </summary>
        /// <param name="text">
        /// The text to convert to speech.<br/>
        /// Default Value: Hello from Waves TTS.
        /// </param>
        /// <param name="voiceId">
        /// The voice identifier to use for speech generation. See the model card for available voices per model.<br/>
        /// Default Value: magnus
        /// </param>
        /// <param name="model">
        /// TTS model to route the request to. Controls which model pool serves<br/>
        /// this synthesis.<br/>
        /// - `lightning_v3.1` (default) — standard Lightning v3.1.<br/>
        /// - `lightning_v3.1_pro` — Lightning v3.1 Pro pool. Improved audio<br/>
        ///   quality and naturalness, with a curated voice catalog. See the<br/>
        ///   [Lightning v3.1 Pro model card](/waves/model-cards/text-to-speech/lightning-v-3-1-pro)<br/>
        ///   for supported voice IDs.<br/>
        /// Same concurrency and latency profile across both. Other request<br/>
        /// parameters behave identically.<br/>
        /// Default Value: lightning_v3.1
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
        /// Each voice has its own `tags.language` set in the voice catalog —<br/>
        /// query `GET /waves/v1/lightning-v3.1/get_voices`. Pass a language<br/>
        /// the voice was trained on; passing other codes is accepted by the<br/>
        /// API but produces English-pronounced output.<br/>
        /// **On `lightning_v3.1`**, the full 12-language catalog applies.<br/>
        /// **On `lightning_v3.1_pro`**:<br/>
        /// - Pass `en` → UK + American accented English.<br/>
        /// - Pass `hi` → Indian accented English + Hindi (code-switching).<br/>
        /// - Omit `language` → defaults to `en + hi` (mixed Indian + Western English coverage).
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
        /// The IDs of the pronunciation dictionaries to use for speech generation. Available on both `lightning_v3.1` and `lightning_v3.1_pro`.
        /// </param>
        /// <param name="wordTimestamps">
        /// **WebSocket-only feature.** Accepted on this endpoint but ignored — no per-word timing information is returned in the sync HTTP or SSE response shape. To receive `status: "word_timestamp"` frames with per-word `{ id, word, start, end }` data, use the WebSocket endpoint `wss://api.smallest.ai/waves/v1/tts/live`. See [Word-level timestamps](/waves/documentation/text-to-speech-lightning/word-timestamps).<br/>
        /// Default Value: false
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
        global::System.Collections.Generic.IAsyncEnumerable<string> SynthesizeSpeechSseAsync(
            string text = "Hello from Waves TTS.",
            string voiceId = "magnus",
            global::SmallestAI.TtsRequestModel? model = default,
            global::SmallestAI.TtsRequestSampleRate? sampleRate = default,
            double? speed = default,
            global::SmallestAI.TtsRequestLanguage? language = default,
            global::SmallestAI.TtsRequestOutputFormat? outputFormat = default,
            global::System.Collections.Generic.IList<string>? pronunciationDicts = default,
            bool? wordTimestamps = default,
            string? sessionId = default,
            string? requestId = default,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}