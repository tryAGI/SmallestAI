#nullable enable

namespace SmallestAI
{
    public partial interface ISubpackageSpeechToTextClient
    {
        /// <summary>
        /// Transcribe (Pre-recorded)<br/>
        /// Transcribe an audio file. The model is chosen via `?model=`:<br/>
        /// - `?model=pulse-pro`: English-only, leaderboard-ranked accuracy. Raw bytes only; pass `webhook_url` to receive transcription asynchronously on long files.<br/>
        /// - `?model=pulse`: multilingual transcription (38 languages), supports both raw bytes and audio-by-URL.<br/>
        /// ## When to use this<br/>
        /// Use this endpoint when you have a complete audio file (call recording, voicemail, podcast episode) and want the transcript back in one response. For live transcription as audio arrives, use the realtime WebSocket endpoint (`WS /waves/v1/stt/live`) instead.<br/>
        /// Pulse Pro has no streaming worker today; calls to `WS /waves/v1/stt/live?model=pulse-pro` return `400` before the WebSocket upgrades.<br/>
        /// ## Input methods<br/>
        /// - **Raw bytes**: `Content-Type: application/octet-stream` with the audio in the body. All knobs are query parameters.<br/>
        /// - **URL (`?model=pulse` only)**: `Content-Type: application/json` with `{"url": "..."}` in the body.<br/>
        /// ## Examples<br/>
        /// **cURL**: Pulse Pro, sync<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/stt/?model=pulse-pro&amp;language=en&amp;word_timestamps=true" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/octet-stream" \<br/>
        ///   --data-binary "@./call.wav"<br/>
        /// ```<br/>
        /// **cURL**: Pulse Pro, async via webhook<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/stt/?model=pulse-pro&amp;language=en&amp;webhook_url=https://your.app/cb" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/octet-stream" \<br/>
        ///   --data-binary "@./call.wav"<br/>
        /// ```<br/>
        /// Returns `200 { "status": "processing", "request_id": "..." }` immediately. The webhook receives the full transcription when ready.<br/>
        /// **cURL**: Pulse, audio-by-URL<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/stt/?model=pulse&amp;language=en" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{"url": "https://your-bucket.s3.amazonaws.com/call.wav"}'<br/>
        /// ```<br/>
        /// **Python**<br/>
        /// ```python<br/>
        /// import requests<br/>
        /// with open("./call.wav", "rb") as f:<br/>
        ///     audio = f.read()<br/>
        /// r = requests.post(<br/>
        ///     "https://api.smallest.ai/waves/v1/stt/",<br/>
        ///     params={"model": "pulse-pro", "language": "en", "word_timestamps": "true"},<br/>
        ///     headers={"Authorization": f"Bearer {API_KEY}", "Content-Type": "application/octet-stream"},<br/>
        ///     data=audio,<br/>
        /// )<br/>
        /// r.raise_for_status()<br/>
        /// print(r.json()["transcription"])<br/>
        /// ```<br/>
        /// **JavaScript / TypeScript**<br/>
        /// ```typescript<br/>
        /// import { readFileSync } from "node:fs";<br/>
        /// const audio = readFileSync("./call.wav");<br/>
        /// const params = new URLSearchParams({ model: "pulse-pro", language: "en", word_timestamps: "true" });<br/>
        /// const res = await fetch(`https://api.smallest.ai/waves/v1/stt/?${params}`, {<br/>
        ///   method: "POST",<br/>
        ///   headers: { Authorization: `Bearer ${process.env.SMALLEST_API_KEY}`, "Content-Type": "application/octet-stream" },<br/>
        ///   body: audio,<br/>
        /// });<br/>
        /// console.log((await res.json()).transcription);<br/>
        /// ```<br/>
        /// ## Common gotchas<br/>
        /// - **`model` is required.** Missing or invalid values return `400` with an enum-validation error.<br/>
        /// - **Pulse Pro is English only.** Pass `language=en`. Other language codes are accepted at the wire level but produce unpredictable output.<br/>
        /// - **Pulse Pro does not support audio-by-URL.** Send raw bytes or use `?model=pulse` for the URL flow.<br/>
        /// - **Async (webhook) mode is Pulse Pro only.** Pulse runs sync only on this endpoint.<br/>
        /// - **Max payload 250 MB.** Larger requests return `413`. Compress to mono 16 kHz PCM if you are close to the limit; quality is unaffected.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="language"></param>
        /// <param name="wordTimestamps">
        /// Default Value: false
        /// </param>
        /// <param name="diarize">
        /// Default Value: false
        /// </param>
        /// <param name="webhookUrl"></param>
        /// <param name="webhookMethod">
        /// Default Value: POST
        /// </param>
        /// <param name="webhookExtra"></param>
        /// <param name="redactPii">
        /// Default Value: false
        /// </param>
        /// <param name="redactPci">
        /// Default Value: false
        /// </param>
        /// <param name="emotionDetection">
        /// Default Value: false
        /// </param>
        /// <param name="genderDetection">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.SpeechToTextTranscribeResponse200> TranscribeAsync(
            global::SmallestAI.WavesV1SttPostParametersModel model,
            global::SmallestAI.WavesV1SttPostParametersLanguage language,

            byte[] request,
            bool? wordTimestamps = default,
            bool? diarize = default,
            string? webhookUrl = default,
            global::SmallestAI.WavesV1SttPostParametersWebhookMethod? webhookMethod = default,
            string? webhookExtra = default,
            global::SmallestAI.WavesV1SttPostParametersRedactPii? redactPii = default,
            global::SmallestAI.WavesV1SttPostParametersRedactPci? redactPci = default,
            global::SmallestAI.WavesV1SttPostParametersEmotionDetection? emotionDetection = default,
            global::SmallestAI.WavesV1SttPostParametersGenderDetection? genderDetection = default,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transcribe (Pre-recorded)<br/>
        /// Transcribe an audio file. The model is chosen via `?model=`:<br/>
        /// - `?model=pulse-pro`: English-only, leaderboard-ranked accuracy. Raw bytes only; pass `webhook_url` to receive transcription asynchronously on long files.<br/>
        /// - `?model=pulse`: multilingual transcription (38 languages), supports both raw bytes and audio-by-URL.<br/>
        /// ## When to use this<br/>
        /// Use this endpoint when you have a complete audio file (call recording, voicemail, podcast episode) and want the transcript back in one response. For live transcription as audio arrives, use the realtime WebSocket endpoint (`WS /waves/v1/stt/live`) instead.<br/>
        /// Pulse Pro has no streaming worker today; calls to `WS /waves/v1/stt/live?model=pulse-pro` return `400` before the WebSocket upgrades.<br/>
        /// ## Input methods<br/>
        /// - **Raw bytes**: `Content-Type: application/octet-stream` with the audio in the body. All knobs are query parameters.<br/>
        /// - **URL (`?model=pulse` only)**: `Content-Type: application/json` with `{"url": "..."}` in the body.<br/>
        /// ## Examples<br/>
        /// **cURL**: Pulse Pro, sync<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/stt/?model=pulse-pro&amp;language=en&amp;word_timestamps=true" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/octet-stream" \<br/>
        ///   --data-binary "@./call.wav"<br/>
        /// ```<br/>
        /// **cURL**: Pulse Pro, async via webhook<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/stt/?model=pulse-pro&amp;language=en&amp;webhook_url=https://your.app/cb" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/octet-stream" \<br/>
        ///   --data-binary "@./call.wav"<br/>
        /// ```<br/>
        /// Returns `200 { "status": "processing", "request_id": "..." }` immediately. The webhook receives the full transcription when ready.<br/>
        /// **cURL**: Pulse, audio-by-URL<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/stt/?model=pulse&amp;language=en" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{"url": "https://your-bucket.s3.amazonaws.com/call.wav"}'<br/>
        /// ```<br/>
        /// **Python**<br/>
        /// ```python<br/>
        /// import requests<br/>
        /// with open("./call.wav", "rb") as f:<br/>
        ///     audio = f.read()<br/>
        /// r = requests.post(<br/>
        ///     "https://api.smallest.ai/waves/v1/stt/",<br/>
        ///     params={"model": "pulse-pro", "language": "en", "word_timestamps": "true"},<br/>
        ///     headers={"Authorization": f"Bearer {API_KEY}", "Content-Type": "application/octet-stream"},<br/>
        ///     data=audio,<br/>
        /// )<br/>
        /// r.raise_for_status()<br/>
        /// print(r.json()["transcription"])<br/>
        /// ```<br/>
        /// **JavaScript / TypeScript**<br/>
        /// ```typescript<br/>
        /// import { readFileSync } from "node:fs";<br/>
        /// const audio = readFileSync("./call.wav");<br/>
        /// const params = new URLSearchParams({ model: "pulse-pro", language: "en", word_timestamps: "true" });<br/>
        /// const res = await fetch(`https://api.smallest.ai/waves/v1/stt/?${params}`, {<br/>
        ///   method: "POST",<br/>
        ///   headers: { Authorization: `Bearer ${process.env.SMALLEST_API_KEY}`, "Content-Type": "application/octet-stream" },<br/>
        ///   body: audio,<br/>
        /// });<br/>
        /// console.log((await res.json()).transcription);<br/>
        /// ```<br/>
        /// ## Common gotchas<br/>
        /// - **`model` is required.** Missing or invalid values return `400` with an enum-validation error.<br/>
        /// - **Pulse Pro is English only.** Pass `language=en`. Other language codes are accepted at the wire level but produce unpredictable output.<br/>
        /// - **Pulse Pro does not support audio-by-URL.** Send raw bytes or use `?model=pulse` for the URL flow.<br/>
        /// - **Async (webhook) mode is Pulse Pro only.** Pulse runs sync only on this endpoint.<br/>
        /// - **Max payload 250 MB.** Larger requests return `413`. Compress to mono 16 kHz PCM if you are close to the limit; quality is unaffected.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="language"></param>
        /// <param name="wordTimestamps">
        /// Default Value: false
        /// </param>
        /// <param name="diarize">
        /// Default Value: false
        /// </param>
        /// <param name="webhookUrl"></param>
        /// <param name="webhookMethod">
        /// Default Value: POST
        /// </param>
        /// <param name="webhookExtra"></param>
        /// <param name="redactPii">
        /// Default Value: false
        /// </param>
        /// <param name="redactPci">
        /// Default Value: false
        /// </param>
        /// <param name="emotionDetection">
        /// Default Value: false
        /// </param>
        /// <param name="genderDetection">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SmallestAI.AutoSDKHttpResponse<global::SmallestAI.SpeechToTextTranscribeResponse200>> TranscribeAsResponseAsync(
            global::SmallestAI.WavesV1SttPostParametersModel model,
            global::SmallestAI.WavesV1SttPostParametersLanguage language,

            byte[] request,
            bool? wordTimestamps = default,
            bool? diarize = default,
            string? webhookUrl = default,
            global::SmallestAI.WavesV1SttPostParametersWebhookMethod? webhookMethod = default,
            string? webhookExtra = default,
            global::SmallestAI.WavesV1SttPostParametersRedactPii? redactPii = default,
            global::SmallestAI.WavesV1SttPostParametersRedactPci? redactPci = default,
            global::SmallestAI.WavesV1SttPostParametersEmotionDetection? emotionDetection = default,
            global::SmallestAI.WavesV1SttPostParametersGenderDetection? genderDetection = default,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}