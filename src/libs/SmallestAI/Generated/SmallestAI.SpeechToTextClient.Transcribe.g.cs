
#nullable enable

namespace SmallestAI
{
    public partial class SpeechToTextClient
    {


        private static readonly global::SmallestAI.EndPointSecurityRequirement s_TranscribeSecurityRequirement0 =
            new global::SmallestAI.EndPointSecurityRequirement
            {
                Authorizations = new global::SmallestAI.EndPointAuthorizationRequirement[]
                {                    new global::SmallestAI.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::SmallestAI.EndPointSecurityRequirement[] s_TranscribeSecurityRequirements =
            new global::SmallestAI.EndPointSecurityRequirement[]
            {                s_TranscribeSecurityRequirement0,
            };
        partial void PrepareTranscribeArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::SmallestAI.WavesV1SttPostParametersModel model,
            ref global::SmallestAI.WavesV1SttPostParametersLanguage language,
            ref bool? wordTimestamps,
            ref bool? diarize,
            ref string? webhookUrl,
            ref global::SmallestAI.WavesV1SttPostParametersWebhookMethod? webhookMethod,
            ref string? webhookExtra,
            ref global::SmallestAI.WavesV1SttPostParametersRedactPii? redactPii,
            ref global::SmallestAI.WavesV1SttPostParametersRedactPci? redactPci,
            ref global::SmallestAI.WavesV1SttPostParametersEmotionDetection? emotionDetection,
            ref global::SmallestAI.WavesV1SttPostParametersGenderDetection? genderDetection,
            byte[] request);
        partial void PrepareTranscribeRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::SmallestAI.WavesV1SttPostParametersModel model,
            global::SmallestAI.WavesV1SttPostParametersLanguage language,
            bool? wordTimestamps,
            bool? diarize,
            string? webhookUrl,
            global::SmallestAI.WavesV1SttPostParametersWebhookMethod? webhookMethod,
            string? webhookExtra,
            global::SmallestAI.WavesV1SttPostParametersRedactPii? redactPii,
            global::SmallestAI.WavesV1SttPostParametersRedactPci? redactPci,
            global::SmallestAI.WavesV1SttPostParametersEmotionDetection? emotionDetection,
            global::SmallestAI.WavesV1SttPostParametersGenderDetection? genderDetection,
            byte[] request);
        partial void ProcessTranscribeResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTranscribeResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Transcribe (Pre-recorded)<br/>
        /// Transcribe an audio file. The model is chosen via `?model=`:<br/>
        /// - `?model=pulse-pro`: English-only, leaderboard-ranked accuracy. Raw bytes only; pass `webhook_url` to receive transcription asynchronously on long files.<br/>
        /// - `?model=pulse`: multilingual transcription (17 streaming + 26 pre-recorded languages), supports both raw bytes and audio-by-URL.<br/>
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
        public async global::System.Threading.Tasks.Task<global::SmallestAI.SpeechToTextTranscribeResponse200> TranscribeAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await TranscribeAsResponseAsync(
                model: model,
                language: language,

                request: request,
                wordTimestamps: wordTimestamps,
                diarize: diarize,
                webhookUrl: webhookUrl,
                webhookMethod: webhookMethod,
                webhookExtra: webhookExtra,
                redactPii: redactPii,
                redactPci: redactPci,
                emotionDetection: emotionDetection,
                genderDetection: genderDetection,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Transcribe (Pre-recorded)<br/>
        /// Transcribe an audio file. The model is chosen via `?model=`:<br/>
        /// - `?model=pulse-pro`: English-only, leaderboard-ranked accuracy. Raw bytes only; pass `webhook_url` to receive transcription asynchronously on long files.<br/>
        /// - `?model=pulse`: multilingual transcription (17 streaming + 26 pre-recorded languages), supports both raw bytes and audio-by-URL.<br/>
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
        public async global::System.Threading.Tasks.Task<global::SmallestAI.AutoSDKHttpResponse<global::SmallestAI.SpeechToTextTranscribeResponse200>> TranscribeAsResponseAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareTranscribeArguments(
                httpClient: HttpClient,
                model: ref model,
                language: ref language,
                wordTimestamps: ref wordTimestamps,
                diarize: ref diarize,
                webhookUrl: ref webhookUrl,
                webhookMethod: ref webhookMethod,
                webhookExtra: ref webhookExtra,
                redactPii: ref redactPii,
                redactPci: ref redactPci,
                emotionDetection: ref emotionDetection,
                genderDetection: ref genderDetection,
                request: request);


            var __authorizations = global::SmallestAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_TranscribeSecurityRequirements,
                operationName: "TranscribeAsync");

            using var __timeoutCancellationTokenSource = global::SmallestAI.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::SmallestAI.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::SmallestAI.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::SmallestAI.PathBuilder(
                                path: "/waves/v1/stt/",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddRequiredParameter("model", model.ToValueString())
                                .AddRequiredParameter("language", language.ToValueString())
                                .AddOptionalParameter("word_timestamps", wordTimestamps?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("diarize", diarize?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("webhook_url", webhookUrl)
                                .AddOptionalParameter("webhook_method", webhookMethod?.ToValueString())
                                .AddOptionalParameter("webhook_extra", webhookExtra)
                                .AddOptionalParameter("redact_pii", redactPii?.ToValueString())
                                .AddOptionalParameter("redact_pci", redactPci?.ToValueString())
                                .AddOptionalParameter("emotion_detection", emotionDetection?.ToValueString())
                                .AddOptionalParameter("gender_detection", genderDetection?.ToValueString())
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::SmallestAI.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }

                            var __httpRequestContent = new global::System.Net.Http.ByteArrayContent(request);
                            __httpRequestContent.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
                            __httpRequest.Content = __httpRequestContent;
                global::SmallestAI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareTranscribeRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    model: model!,
                    language: language!,
                    wordTimestamps: wordTimestamps,
                    diarize: diarize,
                    webhookUrl: webhookUrl,
                    webhookMethod: webhookMethod,
                    webhookExtra: webhookExtra,
                    redactPii: redactPii,
                    redactPci: redactPci,
                    emotionDetection: emotionDetection,
                    genderDetection: genderDetection,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::SmallestAI.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::SmallestAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Transcribe",
                                methodName: "TranscribeAsync",
                                pathTemplate: "\"/waves/v1/stt/\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::SmallestAI.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::SmallestAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::SmallestAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Transcribe",
                                methodName: "TranscribeAsync",
                                pathTemplate: "\"/waves/v1/stt/\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::SmallestAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::SmallestAI.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::SmallestAI.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::SmallestAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::SmallestAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Transcribe",
                                methodName: "TranscribeAsync",
                                pathTemplate: "\"/waves/v1/stt/\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::SmallestAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessTranscribeResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::SmallestAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::SmallestAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Transcribe",
                                methodName: "TranscribeAsync",
                                pathTemplate: "\"/waves/v1/stt/\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::SmallestAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::SmallestAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Transcribe",
                                methodName: "TranscribeAsync",
                                pathTemplate: "\"/waves/v1/stt/\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Missing or invalid `model` query parameter, invalid params, or unsupported feature combination (e.g. `?model=pulse-pro` on the WS endpoint, audio-by-URL with `?model=pulse-pro`).
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::SmallestAI.ErrorResponse? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::SmallestAI.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::SmallestAI.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::SmallestAI.ApiException<global::SmallestAI.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseObject: __value_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // API key missing or invalid.
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::SmallestAI.ErrorResponse? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::SmallestAI.ErrorResponse.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::SmallestAI.ErrorResponse.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::SmallestAI.ApiException<global::SmallestAI.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    responseBody: __content_401,
                                    responseObject: __value_401,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Plan does not include access to the requested model.
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                global::SmallestAI.ErrorResponse? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::SmallestAI.ErrorResponse.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = global::SmallestAI.ErrorResponse.FromJson(__content_403, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }


                                throw global::SmallestAI.ApiException<global::SmallestAI.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    responseBody: __content_403,
                                    responseObject: __value_403,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Payload exceeds 250 MB.
                            if ((int)__response.StatusCode == 413)
                            {
                                string? __content_413 = null;
                                global::System.Exception? __exception_413 = null;
                                global::SmallestAI.ErrorResponse? __value_413 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_413 = global::SmallestAI.ErrorResponse.FromJson(__content_413, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_413 = global::SmallestAI.ErrorResponse.FromJson(__content_413, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_413 = __ex;
                                }


                                throw global::SmallestAI.ApiException<global::SmallestAI.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_413 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_413,
                                    responseBody: __content_413,
                                    responseObject: __value_413,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // RPM cap exceeded (Standard plan default 25/min per model).
                            if ((int)__response.StatusCode == 429)
                            {
                                string? __content_429 = null;
                                global::System.Exception? __exception_429 = null;
                                global::SmallestAI.ErrorResponse? __value_429 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_429 = global::SmallestAI.ErrorResponse.FromJson(__content_429, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_429 = global::SmallestAI.ErrorResponse.FromJson(__content_429, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }


                                throw global::SmallestAI.ApiException<global::SmallestAI.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_429,
                                    responseBody: __content_429,
                                    responseObject: __value_429,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Worker temporarily unavailable.
                            if ((int)__response.StatusCode == 503)
                            {
                                string? __content_503 = null;
                                global::System.Exception? __exception_503 = null;
                                global::SmallestAI.ErrorResponse? __value_503 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_503 = global::SmallestAI.ErrorResponse.FromJson(__content_503, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_503 = global::SmallestAI.ErrorResponse.FromJson(__content_503, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_503 = __ex;
                                }


                                throw global::SmallestAI.ApiException<global::SmallestAI.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_503 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_503,
                                    responseBody: __content_503,
                                    responseObject: __value_503,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessTranscribeResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::SmallestAI.SpeechToTextTranscribeResponse200.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::SmallestAI.AutoSDKHttpResponse<global::SmallestAI.SpeechToTextTranscribeResponse200>(
                                        statusCode: __response.StatusCode,
                                        headers: global::SmallestAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::SmallestAI.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::SmallestAI.SpeechToTextTranscribeResponse200.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::SmallestAI.AutoSDKHttpResponse<global::SmallestAI.SpeechToTextTranscribeResponse200>(
                                        statusCode: __response.StatusCode,
                                        headers: global::SmallestAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::SmallestAI.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}