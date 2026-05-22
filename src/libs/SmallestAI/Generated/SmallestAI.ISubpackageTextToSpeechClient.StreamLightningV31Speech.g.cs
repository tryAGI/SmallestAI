#nullable enable

namespace SmallestAI
{
    public partial interface ISubpackageTextToSpeechClient
    {
        /// <summary>
        /// Lightning v3.1 SSE (endpoint will be deprecated)<br/>
        /// &lt;Warning&gt;**Endpoint scheduled for retirement.** This URL will stop accepting requests **60 days from the Lightning v3.1 Pro launch (2026-05-15)** — i.e. on **2026-07-14**. The Lightning v3.1 model itself is current and stays. Migrate to [`POST /waves/v1/tts/live`](/waves/api-reference/api-reference/text-to-speech/stream-speech-sse) and select Lightning v3.1 via the `model` body field (default).&lt;/Warning&gt;<br/>
        /// Synthesize speech and stream the audio back over Server-Sent Events. The body and parameters are identical to the sync `/get_speech` endpoint — the difference is the response is a stream of base64-encoded PCM chunks instead of one binary blob.<br/>
        /// ## When to use this<br/>
        /// - **Use this** when you want playback to start before synthesis is complete — long passages, latency-sensitive UI, live narration.<br/>
        /// - **Use sync `/get_speech`** when total latency doesn't matter and you'd rather get one buffer.<br/>
        /// - **Use the WebSocket endpoint** when the *text* arrives incrementally (LLM token stream). SSE assumes you have the full text up front.<br/>
        /// ## How it works<br/>
        /// 1. POST your text + voice settings — same payload as `/get_speech`.<br/>
        /// 2. The response is `Content-Type: text/event-stream`. Each chunk frame is `event: audio\n` followed by `data: {"audio": "&lt;base64-pcm&gt;"}\n\n`.<br/>
        /// 3. Decode each chunk's `audio` field with base64 and feed the PCM bytes to your audio pipeline (browser `MediaSource`, ffmpeg pipe, raw PCM player, etc.).<br/>
        /// 4. A final `data: {"done": true}\n\n` frame marks end of stream.<br/>
        /// ## Examples<br/>
        /// **cURL**<br/>
        /// ```bash<br/>
        /// curl -N -X POST "https://api.smallest.ai/waves/v1/lightning-v3.1/stream" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///     "text": "Streaming this paragraph chunk by chunk so playback can start sooner.",<br/>
        ///     "voice_id": "magnus",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "pcm"<br/>
        ///   }'<br/>
        /// ```<br/>
        /// **Python** (`pip install smallestai&gt;=4.4.0`)<br/>
        /// ```python<br/>
        /// import base64<br/>
        /// from smallestai import SmallestAI<br/>
        /// client = SmallestAI(token="YOUR_API_KEY")<br/>
        /// with open("stream.pcm", "wb") as f:<br/>
        ///     for chunk in client.waves.synthesize_sse_lightning_v3_1(<br/>
        ///         text="Streaming this paragraph chunk by chunk so playback can start sooner.",<br/>
        ///         voice_id="magnus",<br/>
        ///         sample_rate=24000,<br/>
        ///         output_format="pcm",<br/>
        ///     ):<br/>
        ///         # Each chunk is `{"audio": "&lt;base64-encoded PCM&gt;"}`.<br/>
        ///         # Decode and pipe to your audio pipeline.<br/>
        ///         if chunk.get("audio"):<br/>
        ///             f.write(base64.b64decode(chunk["audio"]))<br/>
        /// ```<br/>
        /// **JavaScript / TypeScript** (using `fetch` + a reader)<br/>
        /// ```typescript<br/>
        /// const res = await fetch("https://api.smallest.ai/waves/v1/lightning-v3.1/stream", {<br/>
        ///   method: "POST",<br/>
        ///   headers: {<br/>
        ///     Authorization: `Bearer ${process.env.SMALLEST_API_KEY}`,<br/>
        ///     "Content-Type": "application/json",<br/>
        ///   },<br/>
        ///   body: JSON.stringify({<br/>
        ///     text: "Streaming this paragraph chunk by chunk so playback can start sooner.",<br/>
        ///     voice_id: "magnus",<br/>
        ///     sample_rate: 24000,<br/>
        ///     output_format: "pcm",<br/>
        ///   }),<br/>
        /// });<br/>
        /// const reader = res.body!.getReader();<br/>
        /// const decoder = new TextDecoder();<br/>
        /// let buf = "";<br/>
        /// let finished = false;<br/>
        /// while (!finished) {<br/>
        ///   const { value, done } = await reader.read();<br/>
        ///   if (done) break;<br/>
        ///   buf += decoder.decode(value);<br/>
        ///   const events = buf.split("\n\n");<br/>
        ///   buf = events.pop() ?? "";<br/>
        ///   for (const ev of events) {<br/>
        ///     // SSE frames are "event: audio\ndata: {json}" or just "data: {json}".<br/>
        ///     // We only care about the data line — pull it out and parse.<br/>
        ///     const dataLine = ev.split("\n").find((l) =&gt; l.startsWith("data:"));<br/>
        ///     if (!dataLine) continue;<br/>
        ///     const payload = JSON.parse(dataLine.slice(5).trim());<br/>
        ///     if (payload.done) { finished = true; break; }<br/>
        ///     if (payload.audio) {<br/>
        ///       const pcm = Buffer.from(payload.audio, "base64");<br/>
        ///       // … hand pcm to your audio pipeline<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// ## Common gotchas<br/>
        /// - **Use a streaming-friendly client.** `curl -N`, Python `iter_lines`, or a `fetch` `ReadableStream` reader. Buffering clients will hide the latency win.<br/>
        /// - **Audio is base64 inside the event payload**, not the raw event bytes. Decode the `data.audio` field per event.<br/>
        /// - **`output_format=pcm`** gives the lowest overhead for streaming playback. `wav`/`mp3` work but add per-chunk framing bytes.<br/>
        /// - **First-chunk latency** depends on model warm-up + network distance. Use `output_format=pcm` and a streaming-friendly client to minimize what you can control.<br/>
        /// - **JavaScript / TypeScript**: the official `smallestai` npm package predates Lightning v3.1, so call this endpoint with `fetch` as shown above.
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
        /// Lightning v3.1 SSE (endpoint will be deprecated)<br/>
        /// &lt;Warning&gt;**Endpoint scheduled for retirement.** This URL will stop accepting requests **60 days from the Lightning v3.1 Pro launch (2026-05-15)** — i.e. on **2026-07-14**. The Lightning v3.1 model itself is current and stays. Migrate to [`POST /waves/v1/tts/live`](/waves/api-reference/api-reference/text-to-speech/stream-speech-sse) and select Lightning v3.1 via the `model` body field (default).&lt;/Warning&gt;<br/>
        /// Synthesize speech and stream the audio back over Server-Sent Events. The body and parameters are identical to the sync `/get_speech` endpoint — the difference is the response is a stream of base64-encoded PCM chunks instead of one binary blob.<br/>
        /// ## When to use this<br/>
        /// - **Use this** when you want playback to start before synthesis is complete — long passages, latency-sensitive UI, live narration.<br/>
        /// - **Use sync `/get_speech`** when total latency doesn't matter and you'd rather get one buffer.<br/>
        /// - **Use the WebSocket endpoint** when the *text* arrives incrementally (LLM token stream). SSE assumes you have the full text up front.<br/>
        /// ## How it works<br/>
        /// 1. POST your text + voice settings — same payload as `/get_speech`.<br/>
        /// 2. The response is `Content-Type: text/event-stream`. Each chunk frame is `event: audio\n` followed by `data: {"audio": "&lt;base64-pcm&gt;"}\n\n`.<br/>
        /// 3. Decode each chunk's `audio` field with base64 and feed the PCM bytes to your audio pipeline (browser `MediaSource`, ffmpeg pipe, raw PCM player, etc.).<br/>
        /// 4. A final `data: {"done": true}\n\n` frame marks end of stream.<br/>
        /// ## Examples<br/>
        /// **cURL**<br/>
        /// ```bash<br/>
        /// curl -N -X POST "https://api.smallest.ai/waves/v1/lightning-v3.1/stream" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///     "text": "Streaming this paragraph chunk by chunk so playback can start sooner.",<br/>
        ///     "voice_id": "magnus",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "pcm"<br/>
        ///   }'<br/>
        /// ```<br/>
        /// **Python** (`pip install smallestai&gt;=4.4.0`)<br/>
        /// ```python<br/>
        /// import base64<br/>
        /// from smallestai import SmallestAI<br/>
        /// client = SmallestAI(token="YOUR_API_KEY")<br/>
        /// with open("stream.pcm", "wb") as f:<br/>
        ///     for chunk in client.waves.synthesize_sse_lightning_v3_1(<br/>
        ///         text="Streaming this paragraph chunk by chunk so playback can start sooner.",<br/>
        ///         voice_id="magnus",<br/>
        ///         sample_rate=24000,<br/>
        ///         output_format="pcm",<br/>
        ///     ):<br/>
        ///         # Each chunk is `{"audio": "&lt;base64-encoded PCM&gt;"}`.<br/>
        ///         # Decode and pipe to your audio pipeline.<br/>
        ///         if chunk.get("audio"):<br/>
        ///             f.write(base64.b64decode(chunk["audio"]))<br/>
        /// ```<br/>
        /// **JavaScript / TypeScript** (using `fetch` + a reader)<br/>
        /// ```typescript<br/>
        /// const res = await fetch("https://api.smallest.ai/waves/v1/lightning-v3.1/stream", {<br/>
        ///   method: "POST",<br/>
        ///   headers: {<br/>
        ///     Authorization: `Bearer ${process.env.SMALLEST_API_KEY}`,<br/>
        ///     "Content-Type": "application/json",<br/>
        ///   },<br/>
        ///   body: JSON.stringify({<br/>
        ///     text: "Streaming this paragraph chunk by chunk so playback can start sooner.",<br/>
        ///     voice_id: "magnus",<br/>
        ///     sample_rate: 24000,<br/>
        ///     output_format: "pcm",<br/>
        ///   }),<br/>
        /// });<br/>
        /// const reader = res.body!.getReader();<br/>
        /// const decoder = new TextDecoder();<br/>
        /// let buf = "";<br/>
        /// let finished = false;<br/>
        /// while (!finished) {<br/>
        ///   const { value, done } = await reader.read();<br/>
        ///   if (done) break;<br/>
        ///   buf += decoder.decode(value);<br/>
        ///   const events = buf.split("\n\n");<br/>
        ///   buf = events.pop() ?? "";<br/>
        ///   for (const ev of events) {<br/>
        ///     // SSE frames are "event: audio\ndata: {json}" or just "data: {json}".<br/>
        ///     // We only care about the data line — pull it out and parse.<br/>
        ///     const dataLine = ev.split("\n").find((l) =&gt; l.startsWith("data:"));<br/>
        ///     if (!dataLine) continue;<br/>
        ///     const payload = JSON.parse(dataLine.slice(5).trim());<br/>
        ///     if (payload.done) { finished = true; break; }<br/>
        ///     if (payload.audio) {<br/>
        ///       const pcm = Buffer.from(payload.audio, "base64");<br/>
        ///       // … hand pcm to your audio pipeline<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// ## Common gotchas<br/>
        /// - **Use a streaming-friendly client.** `curl -N`, Python `iter_lines`, or a `fetch` `ReadableStream` reader. Buffering clients will hide the latency win.<br/>
        /// - **Audio is base64 inside the event payload**, not the raw event bytes. Decode the `data.audio` field per event.<br/>
        /// - **`output_format=pcm`** gives the lowest overhead for streaming playback. `wav`/`mp3` work but add per-chunk framing bytes.<br/>
        /// - **First-chunk latency** depends on model warm-up + network distance. Use `output_format=pcm` and a streaming-friendly client to minimize what you can control.<br/>
        /// - **JavaScript / TypeScript**: the official `smallestai` npm package predates Lightning v3.1, so call this endpoint with `fetch` as shown above.
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
        /// Lightning v3.1 SSE (endpoint will be deprecated)<br/>
        /// &lt;Warning&gt;**Endpoint scheduled for retirement.** This URL will stop accepting requests **60 days from the Lightning v3.1 Pro launch (2026-05-15)** — i.e. on **2026-07-14**. The Lightning v3.1 model itself is current and stays. Migrate to [`POST /waves/v1/tts/live`](/waves/api-reference/api-reference/text-to-speech/stream-speech-sse) and select Lightning v3.1 via the `model` body field (default).&lt;/Warning&gt;<br/>
        /// Synthesize speech and stream the audio back over Server-Sent Events. The body and parameters are identical to the sync `/get_speech` endpoint — the difference is the response is a stream of base64-encoded PCM chunks instead of one binary blob.<br/>
        /// ## When to use this<br/>
        /// - **Use this** when you want playback to start before synthesis is complete — long passages, latency-sensitive UI, live narration.<br/>
        /// - **Use sync `/get_speech`** when total latency doesn't matter and you'd rather get one buffer.<br/>
        /// - **Use the WebSocket endpoint** when the *text* arrives incrementally (LLM token stream). SSE assumes you have the full text up front.<br/>
        /// ## How it works<br/>
        /// 1. POST your text + voice settings — same payload as `/get_speech`.<br/>
        /// 2. The response is `Content-Type: text/event-stream`. Each chunk frame is `event: audio\n` followed by `data: {"audio": "&lt;base64-pcm&gt;"}\n\n`.<br/>
        /// 3. Decode each chunk's `audio` field with base64 and feed the PCM bytes to your audio pipeline (browser `MediaSource`, ffmpeg pipe, raw PCM player, etc.).<br/>
        /// 4. A final `data: {"done": true}\n\n` frame marks end of stream.<br/>
        /// ## Examples<br/>
        /// **cURL**<br/>
        /// ```bash<br/>
        /// curl -N -X POST "https://api.smallest.ai/waves/v1/lightning-v3.1/stream" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///     "text": "Streaming this paragraph chunk by chunk so playback can start sooner.",<br/>
        ///     "voice_id": "magnus",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "pcm"<br/>
        ///   }'<br/>
        /// ```<br/>
        /// **Python** (`pip install smallestai&gt;=4.4.0`)<br/>
        /// ```python<br/>
        /// import base64<br/>
        /// from smallestai import SmallestAI<br/>
        /// client = SmallestAI(token="YOUR_API_KEY")<br/>
        /// with open("stream.pcm", "wb") as f:<br/>
        ///     for chunk in client.waves.synthesize_sse_lightning_v3_1(<br/>
        ///         text="Streaming this paragraph chunk by chunk so playback can start sooner.",<br/>
        ///         voice_id="magnus",<br/>
        ///         sample_rate=24000,<br/>
        ///         output_format="pcm",<br/>
        ///     ):<br/>
        ///         # Each chunk is `{"audio": "&lt;base64-encoded PCM&gt;"}`.<br/>
        ///         # Decode and pipe to your audio pipeline.<br/>
        ///         if chunk.get("audio"):<br/>
        ///             f.write(base64.b64decode(chunk["audio"]))<br/>
        /// ```<br/>
        /// **JavaScript / TypeScript** (using `fetch` + a reader)<br/>
        /// ```typescript<br/>
        /// const res = await fetch("https://api.smallest.ai/waves/v1/lightning-v3.1/stream", {<br/>
        ///   method: "POST",<br/>
        ///   headers: {<br/>
        ///     Authorization: `Bearer ${process.env.SMALLEST_API_KEY}`,<br/>
        ///     "Content-Type": "application/json",<br/>
        ///   },<br/>
        ///   body: JSON.stringify({<br/>
        ///     text: "Streaming this paragraph chunk by chunk so playback can start sooner.",<br/>
        ///     voice_id: "magnus",<br/>
        ///     sample_rate: 24000,<br/>
        ///     output_format: "pcm",<br/>
        ///   }),<br/>
        /// });<br/>
        /// const reader = res.body!.getReader();<br/>
        /// const decoder = new TextDecoder();<br/>
        /// let buf = "";<br/>
        /// let finished = false;<br/>
        /// while (!finished) {<br/>
        ///   const { value, done } = await reader.read();<br/>
        ///   if (done) break;<br/>
        ///   buf += decoder.decode(value);<br/>
        ///   const events = buf.split("\n\n");<br/>
        ///   buf = events.pop() ?? "";<br/>
        ///   for (const ev of events) {<br/>
        ///     // SSE frames are "event: audio\ndata: {json}" or just "data: {json}".<br/>
        ///     // We only care about the data line — pull it out and parse.<br/>
        ///     const dataLine = ev.split("\n").find((l) =&gt; l.startsWith("data:"));<br/>
        ///     if (!dataLine) continue;<br/>
        ///     const payload = JSON.parse(dataLine.slice(5).trim());<br/>
        ///     if (payload.done) { finished = true; break; }<br/>
        ///     if (payload.audio) {<br/>
        ///       const pcm = Buffer.from(payload.audio, "base64");<br/>
        ///       // … hand pcm to your audio pipeline<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// ## Common gotchas<br/>
        /// - **Use a streaming-friendly client.** `curl -N`, Python `iter_lines`, or a `fetch` `ReadableStream` reader. Buffering clients will hide the latency win.<br/>
        /// - **Audio is base64 inside the event payload**, not the raw event bytes. Decode the `data.audio` field per event.<br/>
        /// - **`output_format=pcm`** gives the lowest overhead for streaming playback. `wav`/`mp3` work but add per-chunk framing bytes.<br/>
        /// - **First-chunk latency** depends on model warm-up + network distance. Use `output_format=pcm` and a streaming-friendly client to minimize what you can control.<br/>
        /// - **JavaScript / TypeScript**: the official `smallestai` npm package predates Lightning v3.1, so call this endpoint with `fetch` as shown above.
        /// </summary>
        /// <param name="text">
        /// The text to convert to speech.<br/>
        /// Default Value: Hey i am your a text to speech model
        /// </param>
        /// <param name="voiceId">
        /// The voice identifier to use for speech generation.<br/>
        /// Default Value: daniel
        /// </param>
        /// <param name="model">
        /// TTS model to route the request to.<br/>
        /// - `lightning_v3.1` (default) — standard Lightning v3.1 pool.<br/>
        /// - `lightning_v3.1_pro` — Lightning v3.1 Pro pool with a curated<br/>
        ///   voice catalog. See the<br/>
        ///   [Pro model card](/waves/model-cards/text-to-speech/lightning-v-3-1-pro).<br/>
        /// New integrations should use the unified<br/>
        /// `/waves/v1/tts` route instead of this endpoint, but the `model`<br/>
        /// field is supported here for backwards-compatible Pro opt-in.<br/>
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
        /// - **Indian:** `en`, `hi`, `mr` (Marathi), `kn` (Kannada), `ta` (Tamil),<br/>
        ///   `bn` (Bengali), `gu` (Gujarati), `te` (Telugu), `ml` (Malayalam),<br/>
        ///   `pa` (Punjabi), `or` (Odia)<br/>
        /// - **European:** `es` (Spanish)<br/>
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
            global::SmallestAI.LightningV31RequestModel? model = default,
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