#nullable enable

namespace SmallestAI
{
    public partial interface ISubpackageSpeechToTextClient
    {
        /// <summary>
        /// Pulse (Pre-Recorded)<br/>
        /// Transcribe an audio file to text using the Pulse model. The fastest way to get a transcript when you already have a recording — pass either the raw bytes or a URL.<br/>
        /// ## When to use this<br/>
        /// Use this endpoint when you have a complete audio file (call recording, voicemail, podcast episode) and want the transcript back in one response. For live transcription as audio arrives, use the realtime WebSocket endpoint (`WSS /waves/v1/pulse/get_text`) instead.<br/>
        /// ## Input methods<br/>
        /// Send the audio in one of two ways:<br/>
        /// 1. **Raw bytes** — `Content-Type: application/octet-stream` with the audio in the body. All knobs (`language`, `word_timestamps`, etc.) are query parameters.<br/>
        /// 2. **URL** — `Content-Type: application/json` with `{"url": "..."}` in the body. Useful when the audio already lives in object storage. Same query parameters apply.<br/>
        /// Pulse autodetects the language across 30+ supported locales. Pass `language` explicitly when you already know it — detection is fast but skipping it is faster.<br/>
        /// ## Examples<br/>
        /// **cURL** (raw bytes)<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/pulse/get_text?language=en&amp;word_timestamps=true" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/octet-stream" \<br/>
        ///   --data-binary "@./call.wav"<br/>
        /// ```<br/>
        /// **cURL** (URL)<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/pulse/get_text?language=en" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{"url": "https://your-bucket.s3.amazonaws.com/call.wav"}'<br/>
        /// ```<br/>
        /// **Python** (`pip install smallestai&gt;=4.4.0`)<br/>
        /// ```python<br/>
        /// from smallestai import SmallestAI<br/>
        /// client = SmallestAI(token="YOUR_API_KEY")<br/>
        /// with open("./call.wav", "rb") as f:<br/>
        ///     result = client.waves.transcribe_pulse(<br/>
        ///         request=f.read(),<br/>
        ///         language="en",<br/>
        ///         word_timestamps=True,<br/>
        ///         diarize=True,<br/>
        ///     )<br/>
        /// print(result.status)         # "success"<br/>
        /// print(result.transcription)  # the transcript string<br/>
        /// ```<br/>
        /// **JavaScript / TypeScript** (using `fetch`)<br/>
        /// ```typescript<br/>
        /// import { readFileSync } from "node:fs";<br/>
        /// const audio = readFileSync("./call.wav");<br/>
        /// const params = new URLSearchParams({ language: "en", word_timestamps: "true", diarize: "true" });<br/>
        /// const res = await fetch(`https://api.smallest.ai/waves/v1/pulse/get_text?${params}`, {<br/>
        ///   method: "POST",<br/>
        ///   headers: {<br/>
        ///     Authorization: `Bearer ${process.env.SMALLEST_API_KEY}`,<br/>
        ///     "Content-Type": "application/octet-stream",<br/>
        ///   },<br/>
        ///   body: audio,<br/>
        /// });<br/>
        /// const result = await res.json();<br/>
        /// console.log(result.transcription);<br/>
        /// ```<br/>
        /// ## Common gotchas<br/>
        /// - **Max file size is 25 MB.** Larger files return HTTP `413`. Compress to mono 16 kHz PCM if you're close to the limit; quality is unaffected.<br/>
        /// - **Formatting flags (`format`, `punctuate`, `capitalize`)** are accepted at the wire level and exposed in the Python SDK as of `smallestai&gt;=4.4.0`. Today they currently return the same transcript regardless of value — pass them in your integration so it works as the behavior changes.<br/>
        /// - **Webhook-driven flow**: pass `webhook_url` to receive the transcript asynchronously. The endpoint returns immediately; the transcript hits your webhook when ready. Useful for long files where you don't want to hold an HTTP connection open.<br/>
        /// - **Speaker diarization** (`diarize=true`) adds latency. Skip it if you only need the words.<br/>
        /// - **JavaScript / TypeScript**: the official `smallestai` npm package predates the Pulse model, so call this endpoint with `fetch` or `axios` as shown above.
        /// </summary>
        /// <param name="language">
        /// Default Value: multi-eu
        /// </param>
        /// <param name="encoding"></param>
        /// <param name="webhookUrl"></param>
        /// <param name="webhookExtra"></param>
        /// <param name="wordTimestamps">
        /// Default Value: false
        /// </param>
        /// <param name="diarize">
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
        global::System.Threading.Tasks.Task<global::SmallestAI.SpeechToTextPulseSpeechToTextResponse200> PulseSpeechToTextAsync(

            byte[] request,
            global::SmallestAI.WavesV1PulseGetTextPostParametersLanguage? language = default,
            global::SmallestAI.WavesV1PulseGetTextPostParametersEncoding? encoding = default,
            string? webhookUrl = default,
            string? webhookExtra = default,
            bool? wordTimestamps = default,
            bool? diarize = default,
            global::SmallestAI.WavesV1PulseGetTextPostParametersGenderDetection? genderDetection = default,
            global::SmallestAI.WavesV1PulseGetTextPostParametersEmotionDetection? emotionDetection = default,
            global::SmallestAI.WavesV1PulseGetTextPostParametersFormat? format = default,
            global::SmallestAI.WavesV1PulseGetTextPostParametersPunctuate? punctuate = default,
            global::SmallestAI.WavesV1PulseGetTextPostParametersCapitalize? capitalize = default,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Pulse (Pre-Recorded)<br/>
        /// Transcribe an audio file to text using the Pulse model. The fastest way to get a transcript when you already have a recording — pass either the raw bytes or a URL.<br/>
        /// ## When to use this<br/>
        /// Use this endpoint when you have a complete audio file (call recording, voicemail, podcast episode) and want the transcript back in one response. For live transcription as audio arrives, use the realtime WebSocket endpoint (`WSS /waves/v1/pulse/get_text`) instead.<br/>
        /// ## Input methods<br/>
        /// Send the audio in one of two ways:<br/>
        /// 1. **Raw bytes** — `Content-Type: application/octet-stream` with the audio in the body. All knobs (`language`, `word_timestamps`, etc.) are query parameters.<br/>
        /// 2. **URL** — `Content-Type: application/json` with `{"url": "..."}` in the body. Useful when the audio already lives in object storage. Same query parameters apply.<br/>
        /// Pulse autodetects the language across 30+ supported locales. Pass `language` explicitly when you already know it — detection is fast but skipping it is faster.<br/>
        /// ## Examples<br/>
        /// **cURL** (raw bytes)<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/pulse/get_text?language=en&amp;word_timestamps=true" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/octet-stream" \<br/>
        ///   --data-binary "@./call.wav"<br/>
        /// ```<br/>
        /// **cURL** (URL)<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/pulse/get_text?language=en" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{"url": "https://your-bucket.s3.amazonaws.com/call.wav"}'<br/>
        /// ```<br/>
        /// **Python** (`pip install smallestai&gt;=4.4.0`)<br/>
        /// ```python<br/>
        /// from smallestai import SmallestAI<br/>
        /// client = SmallestAI(token="YOUR_API_KEY")<br/>
        /// with open("./call.wav", "rb") as f:<br/>
        ///     result = client.waves.transcribe_pulse(<br/>
        ///         request=f.read(),<br/>
        ///         language="en",<br/>
        ///         word_timestamps=True,<br/>
        ///         diarize=True,<br/>
        ///     )<br/>
        /// print(result.status)         # "success"<br/>
        /// print(result.transcription)  # the transcript string<br/>
        /// ```<br/>
        /// **JavaScript / TypeScript** (using `fetch`)<br/>
        /// ```typescript<br/>
        /// import { readFileSync } from "node:fs";<br/>
        /// const audio = readFileSync("./call.wav");<br/>
        /// const params = new URLSearchParams({ language: "en", word_timestamps: "true", diarize: "true" });<br/>
        /// const res = await fetch(`https://api.smallest.ai/waves/v1/pulse/get_text?${params}`, {<br/>
        ///   method: "POST",<br/>
        ///   headers: {<br/>
        ///     Authorization: `Bearer ${process.env.SMALLEST_API_KEY}`,<br/>
        ///     "Content-Type": "application/octet-stream",<br/>
        ///   },<br/>
        ///   body: audio,<br/>
        /// });<br/>
        /// const result = await res.json();<br/>
        /// console.log(result.transcription);<br/>
        /// ```<br/>
        /// ## Common gotchas<br/>
        /// - **Max file size is 25 MB.** Larger files return HTTP `413`. Compress to mono 16 kHz PCM if you're close to the limit; quality is unaffected.<br/>
        /// - **Formatting flags (`format`, `punctuate`, `capitalize`)** are accepted at the wire level and exposed in the Python SDK as of `smallestai&gt;=4.4.0`. Today they currently return the same transcript regardless of value — pass them in your integration so it works as the behavior changes.<br/>
        /// - **Webhook-driven flow**: pass `webhook_url` to receive the transcript asynchronously. The endpoint returns immediately; the transcript hits your webhook when ready. Useful for long files where you don't want to hold an HTTP connection open.<br/>
        /// - **Speaker diarization** (`diarize=true`) adds latency. Skip it if you only need the words.<br/>
        /// - **JavaScript / TypeScript**: the official `smallestai` npm package predates the Pulse model, so call this endpoint with `fetch` or `axios` as shown above.
        /// </summary>
        /// <param name="language">
        /// Default Value: multi-eu
        /// </param>
        /// <param name="encoding"></param>
        /// <param name="webhookUrl"></param>
        /// <param name="webhookExtra"></param>
        /// <param name="wordTimestamps">
        /// Default Value: false
        /// </param>
        /// <param name="diarize">
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
        global::System.Threading.Tasks.Task<global::SmallestAI.AutoSDKHttpResponse<global::SmallestAI.SpeechToTextPulseSpeechToTextResponse200>> PulseSpeechToTextAsResponseAsync(

            byte[] request,
            global::SmallestAI.WavesV1PulseGetTextPostParametersLanguage? language = default,
            global::SmallestAI.WavesV1PulseGetTextPostParametersEncoding? encoding = default,
            string? webhookUrl = default,
            string? webhookExtra = default,
            bool? wordTimestamps = default,
            bool? diarize = default,
            global::SmallestAI.WavesV1PulseGetTextPostParametersGenderDetection? genderDetection = default,
            global::SmallestAI.WavesV1PulseGetTextPostParametersEmotionDetection? emotionDetection = default,
            global::SmallestAI.WavesV1PulseGetTextPostParametersFormat? format = default,
            global::SmallestAI.WavesV1PulseGetTextPostParametersPunctuate? punctuate = default,
            global::SmallestAI.WavesV1PulseGetTextPostParametersCapitalize? capitalize = default,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}