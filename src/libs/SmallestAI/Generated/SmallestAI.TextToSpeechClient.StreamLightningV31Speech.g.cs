
#nullable enable

namespace SmallestAI
{
    public partial class TextToSpeechClient
    {


        private static readonly global::SmallestAI.EndPointSecurityRequirement s_StreamLightningV31SpeechSecurityRequirement0 =
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
        private static readonly global::SmallestAI.EndPointSecurityRequirement[] s_StreamLightningV31SpeechSecurityRequirements =
            new global::SmallestAI.EndPointSecurityRequirement[]
            {                s_StreamLightningV31SpeechSecurityRequirement0,
            };
        partial void PrepareStreamLightningV31SpeechArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::SmallestAI.LightningV31Request request);
        partial void PrepareStreamLightningV31SpeechRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::SmallestAI.LightningV31Request request);
        partial void ProcessStreamLightningV31SpeechResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessStreamLightningV31SpeechResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Lightning v3.1 SSE (endpoint will be deprecated)<br/>
        /// &lt;Warning&gt;**Endpoint scheduled for retirement.** This URL will stop accepting requests **60 days from the Lightning v3.1 Pro launch (2026-05-15)** — i.e. on **2026-07-14**. The Lightning v3.1 model itself is current and stays. Migrate to [`POST /waves/v1/tts/live`](/waves/api-reference/api-reference/text-to-speech/synthesize-speech-sse) and select Lightning v3.1 via the `model` body field (default).&lt;/Warning&gt;<br/>
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
        /// client = SmallestAI(api_key="YOUR_API_KEY")<br/>
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
        public async global::System.Threading.Tasks.Task<string> StreamLightningV31SpeechAsync(

            global::SmallestAI.LightningV31Request request,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await StreamLightningV31SpeechAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Lightning v3.1 SSE (endpoint will be deprecated)<br/>
        /// &lt;Warning&gt;**Endpoint scheduled for retirement.** This URL will stop accepting requests **60 days from the Lightning v3.1 Pro launch (2026-05-15)** — i.e. on **2026-07-14**. The Lightning v3.1 model itself is current and stays. Migrate to [`POST /waves/v1/tts/live`](/waves/api-reference/api-reference/text-to-speech/synthesize-speech-sse) and select Lightning v3.1 via the `model` body field (default).&lt;/Warning&gt;<br/>
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
        /// client = SmallestAI(api_key="YOUR_API_KEY")<br/>
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
        public async global::System.Threading.Tasks.Task<global::SmallestAI.AutoSDKHttpResponse<string>> StreamLightningV31SpeechAsResponseAsync(

            global::SmallestAI.LightningV31Request request,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareStreamLightningV31SpeechArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::SmallestAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_StreamLightningV31SpeechSecurityRequirements,
                operationName: "StreamLightningV31SpeechAsync");

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
                                path: "/waves/v1/lightning-v3.1/stream",
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
                PrepareStreamLightningV31SpeechRequest(
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
                                operationId: "StreamLightningV31Speech",
                                methodName: "StreamLightningV31SpeechAsync",
                                pathTemplate: "\"/waves/v1/lightning-v3.1/stream\"",
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
                                operationId: "StreamLightningV31Speech",
                                methodName: "StreamLightningV31SpeechAsync",
                                pathTemplate: "\"/waves/v1/lightning-v3.1/stream\"",
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
                                operationId: "StreamLightningV31Speech",
                                methodName: "StreamLightningV31SpeechAsync",
                                pathTemplate: "\"/waves/v1/lightning-v3.1/stream\"",
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
                ProcessStreamLightningV31SpeechResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::SmallestAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::SmallestAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "StreamLightningV31Speech",
                                methodName: "StreamLightningV31SpeechAsync",
                                pathTemplate: "\"/waves/v1/lightning-v3.1/stream\"",
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
                                operationId: "StreamLightningV31Speech",
                                methodName: "StreamLightningV31SpeechAsync",
                                pathTemplate: "\"/waves/v1/lightning-v3.1/stream\"",
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
                                global::SmallestAI.StreamLightningV31SpeechRequestBadRequestError? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::SmallestAI.StreamLightningV31SpeechRequestBadRequestError.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::SmallestAI.StreamLightningV31SpeechRequestBadRequestError.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::SmallestAI.ApiException<global::SmallestAI.StreamLightningV31SpeechRequestBadRequestError>.Create(
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
                                global::SmallestAI.StreamLightningV31SpeechRequestUnauthorizedError? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::SmallestAI.StreamLightningV31SpeechRequestUnauthorizedError.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::SmallestAI.StreamLightningV31SpeechRequestUnauthorizedError.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::SmallestAI.ApiException<global::SmallestAI.StreamLightningV31SpeechRequestUnauthorizedError>.Create(
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
                                global::SmallestAI.StreamLightningV31SpeechRequestInternalServerError? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::SmallestAI.StreamLightningV31SpeechRequestInternalServerError.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = global::SmallestAI.StreamLightningV31SpeechRequestInternalServerError.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }


                                throw global::SmallestAI.ApiException<global::SmallestAI.StreamLightningV31SpeechRequestInternalServerError>.Create(
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
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessStreamLightningV31SpeechResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return new global::SmallestAI.AutoSDKHttpResponse<string>(
                                        statusCode: __response.StatusCode,
                                        headers: global::SmallestAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __content);
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
                                    var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return new global::SmallestAI.AutoSDKHttpResponse<string>(
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
        /// Lightning v3.1 SSE (endpoint will be deprecated)<br/>
        /// &lt;Warning&gt;**Endpoint scheduled for retirement.** This URL will stop accepting requests **60 days from the Lightning v3.1 Pro launch (2026-05-15)** — i.e. on **2026-07-14**. The Lightning v3.1 model itself is current and stays. Migrate to [`POST /waves/v1/tts/live`](/waves/api-reference/api-reference/text-to-speech/synthesize-speech-sse) and select Lightning v3.1 via the `model` body field (default).&lt;/Warning&gt;<br/>
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
        /// client = SmallestAI(api_key="YOUR_API_KEY")<br/>
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
        public async global::System.Threading.Tasks.Task<string> StreamLightningV31SpeechAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::SmallestAI.LightningV31Request
            {
                Text = text,
                VoiceId = voiceId,
                Model = model,
                SampleRate = sampleRate,
                Speed = speed,
                Language = language,
                OutputFormat = outputFormat,
                PronunciationDicts = pronunciationDicts,
                SessionId = sessionId,
                RequestId = requestId,
            };

            return await StreamLightningV31SpeechAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}