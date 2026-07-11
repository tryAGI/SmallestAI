
#nullable enable

namespace SmallestAI
{
    public partial class TextToSpeechClient
    {


        private static readonly global::SmallestAI.EndPointSecurityRequirement s_SynthesizeSpeechSseSecurityRequirement0 =
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
        private static readonly global::SmallestAI.EndPointSecurityRequirement[] s_SynthesizeSpeechSseSecurityRequirements =
            new global::SmallestAI.EndPointSecurityRequirement[]
            {                s_SynthesizeSpeechSseSecurityRequirement0,
            };
        partial void PrepareSynthesizeSpeechSseArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::SmallestAI.TtsRequest request);
        partial void PrepareSynthesizeSpeechSseRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::SmallestAI.TtsRequest request);
        partial void ProcessSynthesizeSpeechSseResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

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
        public async global::System.Collections.Generic.IAsyncEnumerable<string> SynthesizeSpeechSseAsync(

            global::SmallestAI.TtsRequest request,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSynthesizeSpeechSseArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::SmallestAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_SynthesizeSpeechSseSecurityRequirements,
                operationName: "SynthesizeSpeechSseAsync");

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
                                path: "/waves/v1/tts/live",
                                baseUri: HttpClient.BaseAddress);
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
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::SmallestAI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareSynthesizeSpeechSseRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
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
                                operationId: "SynthesizeSpeechSse",
                                methodName: "SynthesizeSpeechSseAsync",
                                pathTemplate: "\"/waves/v1/tts/live\"",
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
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
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
                                operationId: "SynthesizeSpeechSse",
                                methodName: "SynthesizeSpeechSseAsync",
                                pathTemplate: "\"/waves/v1/tts/live\"",
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
                                operationId: "SynthesizeSpeechSse",
                                methodName: "SynthesizeSpeechSseAsync",
                                pathTemplate: "\"/waves/v1/tts/live\"",
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
                ProcessSynthesizeSpeechSseResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::SmallestAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::SmallestAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SynthesizeSpeechSse",
                                methodName: "SynthesizeSpeechSseAsync",
                                pathTemplate: "\"/waves/v1/tts/live\"",
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
                                operationId: "SynthesizeSpeechSse",
                                methodName: "SynthesizeSpeechSseAsync",
                                pathTemplate: "\"/waves/v1/tts/live\"",
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

                            try
                            {
                                __response.EnsureSuccessStatusCode();
                            }
                            catch (global::System.Net.Http.HttpRequestException __ex)
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

                            using var __stream = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                __effectiveCancellationToken
                #endif
                            ).ConfigureAwait(false);

                            await foreach (var __sseEvent in global::System.Net.ServerSentEvents.SseParser
                                .Create(__stream).EnumerateAsync(__effectiveCancellationToken))
                            {
                                var __content = __sseEvent.Data;
                                if (__content == "[DONE]")
                                {
                                    yield break;
                                }

                                var __streamedResponse = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(string), JsonSerializerContext) ??
                                                       throw global::SmallestAI.ApiException.Create(
                                                           statusCode: __response.StatusCode,
                                                           message: $"Response deserialization failed for \"{__content}\" ",
                                                           innerException: null,
                                                           responseBody: __content,
                                                           responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                                               __response.Headers,
                                                               h => h.Key,
                                                               h => h.Value));

                                yield return __streamedResponse;
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
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
        /// - Pass the ISO 639-1 code of any other Pro language (e.g. `ta`, `de`, `ja`) with a matching Pro voice — 27 additional languages (9 Indian, 8 Asian &amp; Middle Eastern, 10 European) have dedicated Pro voices.<br/>
        /// - Omit `language` → defaults to `en + hi` (mixed Indian + Western English coverage).
        /// </param>
        /// <param name="numberPronunciationLanguage">
        /// Optional. Sets the language used to read out numeric content —<br/>
        /// numbers, currency amounts, times, and the numeric parts of dates<br/>
        /// and years — independently of the synthesis voice. Ordinary words<br/>
        /// are not translated.<br/>
        /// - If you **omit `language`**, this value also becomes the<br/>
        ///   synthesis language: model selection and voice routing follow it.<br/>
        /// - If you **set `language` explicitly**, `language` always wins for<br/>
        ///   synthesis and `number_pronunciation_language` only changes how<br/>
        ///   numeric content is normalized. It works both ways — read numbers<br/>
        ///   in Hindi under an English voice, or in English under a Hindi<br/>
        ///   voice (tuned for Indian, often mixed-script, use cases).<br/>
        /// - Omit this field to keep the existing behaviour — normalization<br/>
        ///   follows `language`.<br/>
        /// Note: only numeric tokens are re-spoken; the words around them<br/>
        /// stay in the text language. On a cross-language request names may<br/>
        /// also render in the target script (e.g. "Smith" → "स्मिथ"), which<br/>
        /// is generally the desired reading for native-language voices.<br/>
        /// Accepts the same language codes as `language`.
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
        public async global::System.Collections.Generic.IAsyncEnumerable<string> SynthesizeSpeechSseAsync(
            string text = "Hello from Waves TTS.",
            string voiceId = "magnus",
            global::SmallestAI.TtsRequestModel? model = default,
            global::SmallestAI.TtsRequestSampleRate? sampleRate = default,
            double? speed = default,
            global::SmallestAI.TtsRequestLanguage? language = default,
            global::SmallestAI.TtsRequestNumberPronunciationLanguage? numberPronunciationLanguage = default,
            global::SmallestAI.TtsRequestOutputFormat? outputFormat = default,
            global::System.Collections.Generic.IList<string>? pronunciationDicts = default,
            bool? wordTimestamps = default,
            string? sessionId = default,
            string? requestId = default,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::SmallestAI.TtsRequest
            {
                Text = text,
                VoiceId = voiceId,
                Model = model,
                SampleRate = sampleRate,
                Speed = speed,
                Language = language,
                NumberPronunciationLanguage = numberPronunciationLanguage,
                OutputFormat = outputFormat,
                PronunciationDicts = pronunciationDicts,
                WordTimestamps = wordTimestamps,
                SessionId = sessionId,
                RequestId = requestId,
            };

            var __enumerable = SynthesizeSpeechSseAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}