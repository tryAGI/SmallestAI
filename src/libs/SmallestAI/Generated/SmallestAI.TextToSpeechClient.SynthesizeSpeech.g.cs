
#nullable enable

namespace SmallestAI
{
    public partial class TextToSpeechClient
    {


        private static readonly global::SmallestAI.EndPointSecurityRequirement s_SynthesizeSpeechSecurityRequirement0 =
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
        private static readonly global::SmallestAI.EndPointSecurityRequirement[] s_SynthesizeSpeechSecurityRequirements =
            new global::SmallestAI.EndPointSecurityRequirement[]
            {                s_SynthesizeSpeechSecurityRequirement0,
            };
        partial void PrepareSynthesizeSpeechArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::SmallestAI.WavesV1TtsPostParametersAccept accept,
            global::SmallestAI.TtsRequest request);
        partial void PrepareSynthesizeSpeechRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::SmallestAI.WavesV1TtsPostParametersAccept accept,
            global::SmallestAI.TtsRequest request);
        partial void ProcessSynthesizeSpeechResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSynthesizeSpeechResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref byte[] content);

        /// <summary>
        /// Synthesize speech<br/>
        /// Synthesize speech from text in a single request. Pass `text` + `voice_id`, get back binary audio.<br/>
        /// Pick the model with the `model` body parameter: default `lightning_v3.1`, or `lightning_v3.1_pro` for the Pro pool. Other request parameters are identical across models.<br/>
        /// **Language behaviour on `lightning_v3.1_pro`:** pass `language: en` for UK + American accented English, pass `language: hi` for Indian accented English + Hindi (code-switching), or omit `language` to default to `en + hi` (mixed Indian + Western English coverage). On `lightning_v3.1` the full 12-language catalog applies (see voice catalog).<br/>
        /// ## When to use this<br/>
        /// - **Use this** for short utterances you can render before playback (notifications, prompts, batch jobs, audio file generation).<br/>
        /// - **Use `/waves/v1/tts/live`** when you want playback to start before the full audio is ready (long passages, latency-sensitive apps).<br/>
        /// - **Use `/waves/v1/tts/live`** (WebSocket) when text arrives incrementally (LLM token streams, live captioning).<br/>
        /// ## Key features<br/>
        /// - 44 kHz natural, expressive synthesis<br/>
        /// - Model selectable per request via `model` body parameter<br/>
        /// - Cloned voice IDs (`voice_*`) work on `lightning_v3.1` — same param as catalog voices<br/>
        /// - 12 documented languages on `lightning_v3.1`. On `lightning_v3.1_pro`: `language: en` → UK + American accented English; `language: hi` → Indian accented English + Hindi; omit `language` → defaults to `en + hi`.<br/>
        /// - Output formats: `pcm`, `mp3`, `wav`, `ulaw`, `alaw`<br/>
        /// - Sample rates: 8 kHz – 44.1 kHz<br/>
        /// - Speed: 0.5× – 2×<br/>
        /// - Per-call pronunciation dictionaries via `pronunciation_dicts`<br/>
        /// ## Examples<br/>
        /// **cURL — Lightning v3.1 (default)**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/tts" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Hello from Waves TTS.",<br/>
        ///     "voice_id": "magnus",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// **cURL — Lightning v3.1 Pro (omit `language` → defaults to `en + hi`)**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/tts" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Hello from the Lightning v3.1 Pro pool.",<br/>
        ///     "voice_id": "meher",<br/>
        ///     "model": "lightning_v3.1_pro",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// **cURL — Lightning v3.1 Pro with explicit `language: en` (UK + American accented English)**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/tts" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Good morning, this is a Pro voice speaking.",<br/>
        ///     "voice_id": "meher",<br/>
        ///     "model": "lightning_v3.1_pro",<br/>
        ///     "language": "en",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// **cURL — Lightning v3.1 Pro with explicit `language: hi` (Indian accented English + Hindi)**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/tts" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Namaste, this is an Indian-accented Pro voice.",<br/>
        ///     "voice_id": "meher",<br/>
        ///     "model": "lightning_v3.1_pro",<br/>
        ///     "language": "hi",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// ## Common gotchas<br/>
        /// - **Set `Accept: audio/wav`.** Omitting it can return an empty or unplayable response.<br/>
        /// - **Pair voice IDs with the right model.** Voice catalogs differ between `lightning_v3.1` and `lightning_v3.1_pro`. The API does not reject mismatched pairings, but using a Pro-only `voice_id` with `model=lightning_v3.1` (or omitting `model`) can return wrong or hallucinated audio. Pair Pro voices with `model=lightning_v3.1_pro`; standard catalog voices with `model=lightning_v3.1` (the default).<br/>
        /// - **Cloned voices** (`voice_*` from `add_voice`) work with `lightning_v3.1` only; voice cloning is not available on `lightning_v3.1_pro`.<br/>
        /// - **44.1 kHz output** is supported but most playback environments are happy with 24 kHz — drop the sample rate if bandwidth matters.
        /// </summary>
        /// <param name="accept">
        /// Default Value: audio/wav
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<byte[]> SynthesizeSpeechAsync(

            global::SmallestAI.TtsRequest request,
            global::SmallestAI.WavesV1TtsPostParametersAccept accept = global::SmallestAI.WavesV1TtsPostParametersAccept.AudioWav,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await SynthesizeSpeechAsResponseAsync(

                request: request,
                accept: accept,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Synthesize speech<br/>
        /// Synthesize speech from text in a single request. Pass `text` + `voice_id`, get back binary audio.<br/>
        /// Pick the model with the `model` body parameter: default `lightning_v3.1`, or `lightning_v3.1_pro` for the Pro pool. Other request parameters are identical across models.<br/>
        /// **Language behaviour on `lightning_v3.1_pro`:** pass `language: en` for UK + American accented English, pass `language: hi` for Indian accented English + Hindi (code-switching), or omit `language` to default to `en + hi` (mixed Indian + Western English coverage). On `lightning_v3.1` the full 12-language catalog applies (see voice catalog).<br/>
        /// ## When to use this<br/>
        /// - **Use this** for short utterances you can render before playback (notifications, prompts, batch jobs, audio file generation).<br/>
        /// - **Use `/waves/v1/tts/live`** when you want playback to start before the full audio is ready (long passages, latency-sensitive apps).<br/>
        /// - **Use `/waves/v1/tts/live`** (WebSocket) when text arrives incrementally (LLM token streams, live captioning).<br/>
        /// ## Key features<br/>
        /// - 44 kHz natural, expressive synthesis<br/>
        /// - Model selectable per request via `model` body parameter<br/>
        /// - Cloned voice IDs (`voice_*`) work on `lightning_v3.1` — same param as catalog voices<br/>
        /// - 12 documented languages on `lightning_v3.1`. On `lightning_v3.1_pro`: `language: en` → UK + American accented English; `language: hi` → Indian accented English + Hindi; omit `language` → defaults to `en + hi`.<br/>
        /// - Output formats: `pcm`, `mp3`, `wav`, `ulaw`, `alaw`<br/>
        /// - Sample rates: 8 kHz – 44.1 kHz<br/>
        /// - Speed: 0.5× – 2×<br/>
        /// - Per-call pronunciation dictionaries via `pronunciation_dicts`<br/>
        /// ## Examples<br/>
        /// **cURL — Lightning v3.1 (default)**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/tts" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Hello from Waves TTS.",<br/>
        ///     "voice_id": "magnus",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// **cURL — Lightning v3.1 Pro (omit `language` → defaults to `en + hi`)**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/tts" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Hello from the Lightning v3.1 Pro pool.",<br/>
        ///     "voice_id": "meher",<br/>
        ///     "model": "lightning_v3.1_pro",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// **cURL — Lightning v3.1 Pro with explicit `language: en` (UK + American accented English)**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/tts" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Good morning, this is a Pro voice speaking.",<br/>
        ///     "voice_id": "meher",<br/>
        ///     "model": "lightning_v3.1_pro",<br/>
        ///     "language": "en",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// **cURL — Lightning v3.1 Pro with explicit `language: hi` (Indian accented English + Hindi)**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/tts" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Namaste, this is an Indian-accented Pro voice.",<br/>
        ///     "voice_id": "meher",<br/>
        ///     "model": "lightning_v3.1_pro",<br/>
        ///     "language": "hi",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// ## Common gotchas<br/>
        /// - **Set `Accept: audio/wav`.** Omitting it can return an empty or unplayable response.<br/>
        /// - **Pair voice IDs with the right model.** Voice catalogs differ between `lightning_v3.1` and `lightning_v3.1_pro`. The API does not reject mismatched pairings, but using a Pro-only `voice_id` with `model=lightning_v3.1` (or omitting `model`) can return wrong or hallucinated audio. Pair Pro voices with `model=lightning_v3.1_pro`; standard catalog voices with `model=lightning_v3.1` (the default).<br/>
        /// - **Cloned voices** (`voice_*` from `add_voice`) work with `lightning_v3.1` only; voice cloning is not available on `lightning_v3.1_pro`.<br/>
        /// - **44.1 kHz output** is supported but most playback environments are happy with 24 kHz — drop the sample rate if bandwidth matters.
        /// </summary>
        /// <param name="accept">
        /// Default Value: audio/wav
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.IO.Stream> SynthesizeSpeechAsStreamAsync(

            global::SmallestAI.TtsRequest request,
            global::SmallestAI.WavesV1TtsPostParametersAccept accept = global::SmallestAI.WavesV1TtsPostParametersAccept.AudioWav,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSynthesizeSpeechArguments(
                httpClient: HttpClient,
                accept: ref accept,
                request: request);


            var __authorizations = global::SmallestAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_SynthesizeSpeechSecurityRequirements,
                operationName: "SynthesizeSpeechAsync");

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
                                path: "/waves/v1/tts",
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

                __httpRequest.Headers.TryAddWithoutValidation("Accept", accept.ToValueString());

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
                PrepareSynthesizeSpeechRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    accept: accept!,
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
                                operationId: "SynthesizeSpeech",
                                methodName: "SynthesizeSpeechAsync",
                                pathTemplate: "\"/waves/v1/tts\"",
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
                                operationId: "SynthesizeSpeech",
                                methodName: "SynthesizeSpeechAsync",
                                pathTemplate: "\"/waves/v1/tts\"",
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
                                operationId: "SynthesizeSpeech",
                                methodName: "SynthesizeSpeechAsync",
                                pathTemplate: "\"/waves/v1/tts\"",
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

                try
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessSynthesizeSpeechResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::SmallestAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::SmallestAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SynthesizeSpeech",
                                methodName: "SynthesizeSpeechAsync",
                                pathTemplate: "\"/waves/v1/tts\"",
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
                                operationId: "SynthesizeSpeech",
                                methodName: "SynthesizeSpeechAsync",
                                pathTemplate: "\"/waves/v1/tts\"",
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
                            // Bad request.
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::SmallestAI.TtsError? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::SmallestAI.TtsError.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::SmallestAI.TtsError.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::SmallestAI.ApiException<global::SmallestAI.TtsError>.Create(
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
                            // Unauthorized.
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::SmallestAI.TtsError? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::SmallestAI.TtsError.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::SmallestAI.TtsError.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::SmallestAI.ApiException<global::SmallestAI.TtsError>.Create(
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
                            // Server error occurred.
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                global::SmallestAI.TtsError? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::SmallestAI.TtsError.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = global::SmallestAI.TtsError.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }


                                throw global::SmallestAI.ApiException<global::SmallestAI.TtsError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_500,
                                    responseBody: __content_500,
                                    responseObject: __value_500,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            try
                            {
                                __response.EnsureSuccessStatusCode();

                                var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                return new global::SmallestAI.ResponseStream(__response, __content);
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
                catch
                {
                    __response.Dispose();
                    throw;
                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Synthesize speech<br/>
        /// Synthesize speech from text in a single request. Pass `text` + `voice_id`, get back binary audio.<br/>
        /// Pick the model with the `model` body parameter: default `lightning_v3.1`, or `lightning_v3.1_pro` for the Pro pool. Other request parameters are identical across models.<br/>
        /// **Language behaviour on `lightning_v3.1_pro`:** pass `language: en` for UK + American accented English, pass `language: hi` for Indian accented English + Hindi (code-switching), or omit `language` to default to `en + hi` (mixed Indian + Western English coverage). On `lightning_v3.1` the full 12-language catalog applies (see voice catalog).<br/>
        /// ## When to use this<br/>
        /// - **Use this** for short utterances you can render before playback (notifications, prompts, batch jobs, audio file generation).<br/>
        /// - **Use `/waves/v1/tts/live`** when you want playback to start before the full audio is ready (long passages, latency-sensitive apps).<br/>
        /// - **Use `/waves/v1/tts/live`** (WebSocket) when text arrives incrementally (LLM token streams, live captioning).<br/>
        /// ## Key features<br/>
        /// - 44 kHz natural, expressive synthesis<br/>
        /// - Model selectable per request via `model` body parameter<br/>
        /// - Cloned voice IDs (`voice_*`) work on `lightning_v3.1` — same param as catalog voices<br/>
        /// - 12 documented languages on `lightning_v3.1`. On `lightning_v3.1_pro`: `language: en` → UK + American accented English; `language: hi` → Indian accented English + Hindi; omit `language` → defaults to `en + hi`.<br/>
        /// - Output formats: `pcm`, `mp3`, `wav`, `ulaw`, `alaw`<br/>
        /// - Sample rates: 8 kHz – 44.1 kHz<br/>
        /// - Speed: 0.5× – 2×<br/>
        /// - Per-call pronunciation dictionaries via `pronunciation_dicts`<br/>
        /// ## Examples<br/>
        /// **cURL — Lightning v3.1 (default)**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/tts" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Hello from Waves TTS.",<br/>
        ///     "voice_id": "magnus",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// **cURL — Lightning v3.1 Pro (omit `language` → defaults to `en + hi`)**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/tts" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Hello from the Lightning v3.1 Pro pool.",<br/>
        ///     "voice_id": "meher",<br/>
        ///     "model": "lightning_v3.1_pro",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// **cURL — Lightning v3.1 Pro with explicit `language: en` (UK + American accented English)**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/tts" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Good morning, this is a Pro voice speaking.",<br/>
        ///     "voice_id": "meher",<br/>
        ///     "model": "lightning_v3.1_pro",<br/>
        ///     "language": "en",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// **cURL — Lightning v3.1 Pro with explicit `language: hi` (Indian accented English + Hindi)**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/tts" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Namaste, this is an Indian-accented Pro voice.",<br/>
        ///     "voice_id": "meher",<br/>
        ///     "model": "lightning_v3.1_pro",<br/>
        ///     "language": "hi",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// ## Common gotchas<br/>
        /// - **Set `Accept: audio/wav`.** Omitting it can return an empty or unplayable response.<br/>
        /// - **Pair voice IDs with the right model.** Voice catalogs differ between `lightning_v3.1` and `lightning_v3.1_pro`. The API does not reject mismatched pairings, but using a Pro-only `voice_id` with `model=lightning_v3.1` (or omitting `model`) can return wrong or hallucinated audio. Pair Pro voices with `model=lightning_v3.1_pro`; standard catalog voices with `model=lightning_v3.1` (the default).<br/>
        /// - **Cloned voices** (`voice_*` from `add_voice`) work with `lightning_v3.1` only; voice cloning is not available on `lightning_v3.1_pro`.<br/>
        /// - **44.1 kHz output** is supported but most playback environments are happy with 24 kHz — drop the sample rate if bandwidth matters.
        /// </summary>
        /// <param name="accept">
        /// Default Value: audio/wav
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::SmallestAI.AutoSDKHttpResponse<byte[]>> SynthesizeSpeechAsResponseAsync(

            global::SmallestAI.TtsRequest request,
            global::SmallestAI.WavesV1TtsPostParametersAccept accept = global::SmallestAI.WavesV1TtsPostParametersAccept.AudioWav,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSynthesizeSpeechArguments(
                httpClient: HttpClient,
                accept: ref accept,
                request: request);


            var __authorizations = global::SmallestAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_SynthesizeSpeechSecurityRequirements,
                operationName: "SynthesizeSpeechAsync");

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
                                path: "/waves/v1/tts",
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

                __httpRequest.Headers.TryAddWithoutValidation("Accept", accept.ToValueString());

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
                PrepareSynthesizeSpeechRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    accept: accept!,
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
                                operationId: "SynthesizeSpeech",
                                methodName: "SynthesizeSpeechAsync",
                                pathTemplate: "\"/waves/v1/tts\"",
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
                                operationId: "SynthesizeSpeech",
                                methodName: "SynthesizeSpeechAsync",
                                pathTemplate: "\"/waves/v1/tts\"",
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
                                operationId: "SynthesizeSpeech",
                                methodName: "SynthesizeSpeechAsync",
                                pathTemplate: "\"/waves/v1/tts\"",
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
                ProcessSynthesizeSpeechResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::SmallestAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::SmallestAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SynthesizeSpeech",
                                methodName: "SynthesizeSpeechAsync",
                                pathTemplate: "\"/waves/v1/tts\"",
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
                                operationId: "SynthesizeSpeech",
                                methodName: "SynthesizeSpeechAsync",
                                pathTemplate: "\"/waves/v1/tts\"",
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
                            // Bad request.
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::SmallestAI.TtsError? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::SmallestAI.TtsError.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::SmallestAI.TtsError.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::SmallestAI.ApiException<global::SmallestAI.TtsError>.Create(
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
                            // Unauthorized.
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::SmallestAI.TtsError? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::SmallestAI.TtsError.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::SmallestAI.TtsError.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::SmallestAI.ApiException<global::SmallestAI.TtsError>.Create(
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
                            // Server error occurred.
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                global::SmallestAI.TtsError? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::SmallestAI.TtsError.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = global::SmallestAI.TtsError.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }


                                throw global::SmallestAI.ApiException<global::SmallestAI.TtsError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_500,
                                    responseBody: __content_500,
                                    responseObject: __value_500,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsByteArrayAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessSynthesizeSpeechResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return new global::SmallestAI.AutoSDKHttpResponse<byte[]>(
                                        statusCode: __response.StatusCode,
                                        headers: global::SmallestAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __content);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::SmallestAI.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: null,
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
                                    var __content = await __response.Content.ReadAsByteArrayAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return new global::SmallestAI.AutoSDKHttpResponse<byte[]>(
                                        statusCode: __response.StatusCode,
                                        headers: global::SmallestAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __content);
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
        /// <summary>
        /// Synthesize speech<br/>
        /// Synthesize speech from text in a single request. Pass `text` + `voice_id`, get back binary audio.<br/>
        /// Pick the model with the `model` body parameter: default `lightning_v3.1`, or `lightning_v3.1_pro` for the Pro pool. Other request parameters are identical across models.<br/>
        /// **Language behaviour on `lightning_v3.1_pro`:** pass `language: en` for UK + American accented English, pass `language: hi` for Indian accented English + Hindi (code-switching), or omit `language` to default to `en + hi` (mixed Indian + Western English coverage). On `lightning_v3.1` the full 12-language catalog applies (see voice catalog).<br/>
        /// ## When to use this<br/>
        /// - **Use this** for short utterances you can render before playback (notifications, prompts, batch jobs, audio file generation).<br/>
        /// - **Use `/waves/v1/tts/live`** when you want playback to start before the full audio is ready (long passages, latency-sensitive apps).<br/>
        /// - **Use `/waves/v1/tts/live`** (WebSocket) when text arrives incrementally (LLM token streams, live captioning).<br/>
        /// ## Key features<br/>
        /// - 44 kHz natural, expressive synthesis<br/>
        /// - Model selectable per request via `model` body parameter<br/>
        /// - Cloned voice IDs (`voice_*`) work on `lightning_v3.1` — same param as catalog voices<br/>
        /// - 12 documented languages on `lightning_v3.1`. On `lightning_v3.1_pro`: `language: en` → UK + American accented English; `language: hi` → Indian accented English + Hindi; omit `language` → defaults to `en + hi`.<br/>
        /// - Output formats: `pcm`, `mp3`, `wav`, `ulaw`, `alaw`<br/>
        /// - Sample rates: 8 kHz – 44.1 kHz<br/>
        /// - Speed: 0.5× – 2×<br/>
        /// - Per-call pronunciation dictionaries via `pronunciation_dicts`<br/>
        /// ## Examples<br/>
        /// **cURL — Lightning v3.1 (default)**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/tts" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Hello from Waves TTS.",<br/>
        ///     "voice_id": "magnus",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// **cURL — Lightning v3.1 Pro (omit `language` → defaults to `en + hi`)**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/tts" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Hello from the Lightning v3.1 Pro pool.",<br/>
        ///     "voice_id": "meher",<br/>
        ///     "model": "lightning_v3.1_pro",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// **cURL — Lightning v3.1 Pro with explicit `language: en` (UK + American accented English)**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/tts" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Good morning, this is a Pro voice speaking.",<br/>
        ///     "voice_id": "meher",<br/>
        ///     "model": "lightning_v3.1_pro",<br/>
        ///     "language": "en",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// **cURL — Lightning v3.1 Pro with explicit `language: hi` (Indian accented English + Hindi)**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/tts" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -H "Accept: audio/wav" \<br/>
        ///   -d '{<br/>
        ///     "text": "Namaste, this is an Indian-accented Pro voice.",<br/>
        ///     "voice_id": "meher",<br/>
        ///     "model": "lightning_v3.1_pro",<br/>
        ///     "language": "hi",<br/>
        ///     "sample_rate": 24000,<br/>
        ///     "output_format": "wav"<br/>
        ///   }' --output speech.wav<br/>
        /// ```<br/>
        /// ## Common gotchas<br/>
        /// - **Set `Accept: audio/wav`.** Omitting it can return an empty or unplayable response.<br/>
        /// - **Pair voice IDs with the right model.** Voice catalogs differ between `lightning_v3.1` and `lightning_v3.1_pro`. The API does not reject mismatched pairings, but using a Pro-only `voice_id` with `model=lightning_v3.1` (or omitting `model`) can return wrong or hallucinated audio. Pair Pro voices with `model=lightning_v3.1_pro`; standard catalog voices with `model=lightning_v3.1` (the default).<br/>
        /// - **Cloned voices** (`voice_*` from `add_voice`) work with `lightning_v3.1` only; voice cloning is not available on `lightning_v3.1_pro`.<br/>
        /// - **44.1 kHz output** is supported but most playback environments are happy with 24 kHz — drop the sample rate if bandwidth matters.
        /// </summary>
        /// <param name="accept">
        /// Default Value: audio/wav
        /// </param>
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
        public async global::System.Threading.Tasks.Task<byte[]> SynthesizeSpeechAsync(
            global::SmallestAI.WavesV1TtsPostParametersAccept accept = global::SmallestAI.WavesV1TtsPostParametersAccept.AudioWav,
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::SmallestAI.TtsRequest
            {
                Text = text,
                VoiceId = voiceId,
                Model = model,
                SampleRate = sampleRate,
                Speed = speed,
                Language = language,
                OutputFormat = outputFormat,
                PronunciationDicts = pronunciationDicts,
                WordTimestamps = wordTimestamps,
                SessionId = sessionId,
                RequestId = requestId,
            };

            return await SynthesizeSpeechAsync(
                accept: accept,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}