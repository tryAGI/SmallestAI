
#nullable enable

namespace SmallestAI
{
    public partial class SubpackageSpeechToTextClient
    {


        private static readonly global::SmallestAI.EndPointSecurityRequirement s_PulseSpeechToTextSecurityRequirement0 =
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
        private static readonly global::SmallestAI.EndPointSecurityRequirement[] s_PulseSpeechToTextSecurityRequirements =
            new global::SmallestAI.EndPointSecurityRequirement[]
            {                s_PulseSpeechToTextSecurityRequirement0,
            };
        partial void PreparePulseSpeechToTextArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::SmallestAI.WavesV1PulseGetTextPostParametersLanguage? language,
            ref global::SmallestAI.WavesV1PulseGetTextPostParametersEncoding? encoding,
            ref string? webhookUrl,
            ref string? webhookExtra,
            ref bool? wordTimestamps,
            ref bool? diarize,
            ref global::SmallestAI.WavesV1PulseGetTextPostParametersGenderDetection? genderDetection,
            ref global::SmallestAI.WavesV1PulseGetTextPostParametersEmotionDetection? emotionDetection,
            ref global::SmallestAI.WavesV1PulseGetTextPostParametersFormat? format,
            ref global::SmallestAI.WavesV1PulseGetTextPostParametersPunctuate? punctuate,
            ref global::SmallestAI.WavesV1PulseGetTextPostParametersCapitalize? capitalize,
            byte[] request);
        partial void PreparePulseSpeechToTextRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::SmallestAI.WavesV1PulseGetTextPostParametersLanguage? language,
            global::SmallestAI.WavesV1PulseGetTextPostParametersEncoding? encoding,
            string? webhookUrl,
            string? webhookExtra,
            bool? wordTimestamps,
            bool? diarize,
            global::SmallestAI.WavesV1PulseGetTextPostParametersGenderDetection? genderDetection,
            global::SmallestAI.WavesV1PulseGetTextPostParametersEmotionDetection? emotionDetection,
            global::SmallestAI.WavesV1PulseGetTextPostParametersFormat? format,
            global::SmallestAI.WavesV1PulseGetTextPostParametersPunctuate? punctuate,
            global::SmallestAI.WavesV1PulseGetTextPostParametersCapitalize? capitalize,
            byte[] request);
        partial void ProcessPulseSpeechToTextResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPulseSpeechToTextResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::SmallestAI.SpeechToTextPulseSpeechToTextResponse200> PulseSpeechToTextAsync(

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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await PulseSpeechToTextAsResponseAsync(

                request: request,
                language: language,
                encoding: encoding,
                webhookUrl: webhookUrl,
                webhookExtra: webhookExtra,
                wordTimestamps: wordTimestamps,
                diarize: diarize,
                genderDetection: genderDetection,
                emotionDetection: emotionDetection,
                format: format,
                punctuate: punctuate,
                capitalize: capitalize,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
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
        public async global::System.Threading.Tasks.Task<global::SmallestAI.AutoSDKHttpResponse<global::SmallestAI.SpeechToTextPulseSpeechToTextResponse200>> PulseSpeechToTextAsResponseAsync(

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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePulseSpeechToTextArguments(
                httpClient: HttpClient,
                language: ref language,
                encoding: ref encoding,
                webhookUrl: ref webhookUrl,
                webhookExtra: ref webhookExtra,
                wordTimestamps: ref wordTimestamps,
                diarize: ref diarize,
                genderDetection: ref genderDetection,
                emotionDetection: ref emotionDetection,
                format: ref format,
                punctuate: ref punctuate,
                capitalize: ref capitalize,
                request: request);


            var __authorizations = global::SmallestAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_PulseSpeechToTextSecurityRequirements,
                operationName: "PulseSpeechToTextAsync");

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
                                path: "/waves/v1/pulse/get_text",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("language", language?.ToValueString())
                                .AddOptionalParameter("encoding", encoding?.ToValueString())
                                .AddOptionalParameter("webhook_url", webhookUrl)
                                .AddOptionalParameter("webhook_extra", webhookExtra)
                                .AddOptionalParameter("word_timestamps", wordTimestamps?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("diarize", diarize?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("gender_detection", genderDetection?.ToValueString())
                                .AddOptionalParameter("emotion_detection", emotionDetection?.ToValueString())
                                .AddOptionalParameter("format", format?.ToValueString())
                                .AddOptionalParameter("punctuate", punctuate?.ToValueString())
                                .AddOptionalParameter("capitalize", capitalize?.ToValueString())
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
                PreparePulseSpeechToTextRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    language: language,
                    encoding: encoding,
                    webhookUrl: webhookUrl,
                    webhookExtra: webhookExtra,
                    wordTimestamps: wordTimestamps,
                    diarize: diarize,
                    genderDetection: genderDetection,
                    emotionDetection: emotionDetection,
                    format: format,
                    punctuate: punctuate,
                    capitalize: capitalize,
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
                                operationId: "PulseSpeechToText",
                                methodName: "PulseSpeechToTextAsync",
                                pathTemplate: "\"/waves/v1/pulse/get_text\"",
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
                                operationId: "PulseSpeechToText",
                                methodName: "PulseSpeechToTextAsync",
                                pathTemplate: "\"/waves/v1/pulse/get_text\"",
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
                                operationId: "PulseSpeechToText",
                                methodName: "PulseSpeechToTextAsync",
                                pathTemplate: "\"/waves/v1/pulse/get_text\"",
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
                ProcessPulseSpeechToTextResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::SmallestAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::SmallestAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PulseSpeechToText",
                                methodName: "PulseSpeechToTextAsync",
                                pathTemplate: "\"/waves/v1/pulse/get_text\"",
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
                                operationId: "PulseSpeechToText",
                                methodName: "PulseSpeechToTextAsync",
                                pathTemplate: "\"/waves/v1/pulse/get_text\"",
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
                            // Bad request - Invalid parameters or file format
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

                                throw new global::SmallestAI.ApiException<global::SmallestAI.ErrorResponse>(
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_400,
                                    ResponseObject = __value_400,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // Unauthorized - Invalid or missing authentication
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

                                throw new global::SmallestAI.ApiException<global::SmallestAI.ErrorResponse>(
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_401,
                                    ResponseObject = __value_401,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // Payload too large - File size exceeds limit
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

                                throw new global::SmallestAI.ApiException<global::SmallestAI.ErrorResponse>(
                                    message: __content_413 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_413,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_413,
                                    ResponseObject = __value_413,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // Too many requests - Rate limit exceeded
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

                                throw new global::SmallestAI.ApiException<global::SmallestAI.ErrorResponse>(
                                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_429,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_429,
                                    ResponseObject = __value_429,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // Internal server error
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                global::SmallestAI.ErrorResponse? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::SmallestAI.ErrorResponse.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = global::SmallestAI.ErrorResponse.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }

                                throw new global::SmallestAI.ApiException<global::SmallestAI.ErrorResponse>(
                                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_500,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_500,
                                    ResponseObject = __value_500,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
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
                                ProcessPulseSpeechToTextResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::SmallestAI.SpeechToTextPulseSpeechToTextResponse200.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::SmallestAI.AutoSDKHttpResponse<global::SmallestAI.SpeechToTextPulseSpeechToTextResponse200>(
                                        statusCode: __response.StatusCode,
                                        headers: global::SmallestAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::SmallestAI.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
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

                                    var __value = await global::SmallestAI.SpeechToTextPulseSpeechToTextResponse200.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::SmallestAI.AutoSDKHttpResponse<global::SmallestAI.SpeechToTextPulseSpeechToTextResponse200>(
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

                                    throw new global::SmallestAI.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
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