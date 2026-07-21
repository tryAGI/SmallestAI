
#nullable enable

namespace SmallestAI
{
    public partial class LlmClient
    {


        private static readonly global::SmallestAI.EndPointSecurityRequirement s_ElectronChatCompletionsSecurityRequirement0 =
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
        private static readonly global::SmallestAI.EndPointSecurityRequirement[] s_ElectronChatCompletionsSecurityRequirements =
            new global::SmallestAI.EndPointSecurityRequirement[]
            {                s_ElectronChatCompletionsSecurityRequirement0,
            };
        partial void PrepareElectronChatCompletionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::SmallestAI.ChatCompletionRequest request);
        partial void PrepareElectronChatCompletionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::SmallestAI.ChatCompletionRequest request);
        partial void ProcessElectronChatCompletionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessElectronChatCompletionsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Chat Completions (Electron)<br/>
        /// Generate a chat completion with Electron. OpenAI-compatible<br/>
        /// request/response shape — point any OpenAI SDK at<br/>
        /// `https://api.smallest.ai/waves/v1` and it just works.<br/>
        /// Set `stream: true` to receive tokens via Server-Sent Events. With<br/>
        /// `stream_options: { include_usage: true }`, the final SSE chunk<br/>
        /// carries the `usage` block so token accounting is exact even on<br/>
        /// client disconnects.<br/>
        /// Tool calling follows OpenAI's `tools` array convention. When you<br/>
        /// provide a voice-agent-style system prompt, Electron emits a short<br/>
        /// filler phrase in the assistant message `content` field alongside<br/>
        /// `tool_calls` — see the [Tool Calling guide](/models/documentation/llm-electron/tool-function-calling)<br/>
        /// for the voice-agent pattern.<br/>
        /// ## Examples<br/>
        /// **cURL**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/chat/completions" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///     "model": "electron",<br/>
        ///     "messages": [<br/>
        ///       {"role": "user", "content": "Write one sentence about why the sky is blue."}<br/>
        ///     ]<br/>
        ///   }'<br/>
        /// ```<br/>
        /// **Python** (`pip install openai`)<br/>
        /// ```python<br/>
        /// import os<br/>
        /// from openai import OpenAI<br/>
        /// client = OpenAI(<br/>
        ///     base_url="https://api.smallest.ai/waves/v1",<br/>
        ///     api_key=os.environ["SMALLEST_API_KEY"],<br/>
        /// )<br/>
        /// response = client.chat.completions.create(<br/>
        ///     model="electron",<br/>
        ///     messages=[<br/>
        ///         {"role": "user", "content": "Write one sentence about why the sky is blue."}<br/>
        ///     ],<br/>
        /// )<br/>
        /// print(response.choices[0].message.content)<br/>
        /// ```<br/>
        /// **JavaScript / TypeScript** (`npm install openai`)<br/>
        /// ```typescript<br/>
        /// import OpenAI from "openai";<br/>
        /// const client = new OpenAI({<br/>
        ///   baseURL: "https://api.smallest.ai/waves/v1",<br/>
        ///   apiKey: process.env.SMALLEST_API_KEY,<br/>
        /// });<br/>
        /// const response = await client.chat.completions.create({<br/>
        ///   model: "electron",<br/>
        ///   messages: [<br/>
        ///     { role: "user", content: "Write one sentence about why the sky is blue." },<br/>
        ///   ],<br/>
        /// });<br/>
        /// console.log(response.choices[0].message.content);<br/>
        /// ```<br/>
        /// **Streaming with usage** (Python)<br/>
        /// ```python<br/>
        /// stream = client.chat.completions.create(<br/>
        ///     model="electron",<br/>
        ///     messages=[{"role": "user", "content": "Tell me a one-sentence fun fact."}],<br/>
        ///     stream=True,<br/>
        ///     stream_options={"include_usage": True},<br/>
        /// )<br/>
        /// for chunk in stream:<br/>
        ///     if chunk.choices and chunk.choices[0].delta.content:<br/>
        ///         print(chunk.choices[0].delta.content, end="", flush=True)<br/>
        ///     if chunk.usage:<br/>
        ///         print(f"\n\nTokens: {chunk.usage.total_tokens}")<br/>
        /// ```<br/>
        /// ## Common gotchas<br/>
        /// - **Base URL is `/waves/v1`**, not `/v1`. The OpenAI SDK appends `/chat/completions` for you.<br/>
        /// - **`stream_options.include_usage: true`** is required for exact token accounting on streaming calls — the final SSE chunk carries the `usage` block.<br/>
        /// - **`n &gt; 1` and `prompt_logprobs` are rejected.** Use multiple requests if you need parallel completions.<br/>
        /// - **Auth header is `Authorization: Bearer $SMALLEST_API_KEY`** — get the key from the [Smallest AI Console](https://app.smallest.ai/dashboard/api-keys).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::SmallestAI.ChatCompletion> ElectronChatCompletionsAsync(

            global::SmallestAI.ChatCompletionRequest request,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ElectronChatCompletionsAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Chat Completions (Electron)<br/>
        /// Generate a chat completion with Electron. OpenAI-compatible<br/>
        /// request/response shape — point any OpenAI SDK at<br/>
        /// `https://api.smallest.ai/waves/v1` and it just works.<br/>
        /// Set `stream: true` to receive tokens via Server-Sent Events. With<br/>
        /// `stream_options: { include_usage: true }`, the final SSE chunk<br/>
        /// carries the `usage` block so token accounting is exact even on<br/>
        /// client disconnects.<br/>
        /// Tool calling follows OpenAI's `tools` array convention. When you<br/>
        /// provide a voice-agent-style system prompt, Electron emits a short<br/>
        /// filler phrase in the assistant message `content` field alongside<br/>
        /// `tool_calls` — see the [Tool Calling guide](/models/documentation/llm-electron/tool-function-calling)<br/>
        /// for the voice-agent pattern.<br/>
        /// ## Examples<br/>
        /// **cURL**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/chat/completions" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///     "model": "electron",<br/>
        ///     "messages": [<br/>
        ///       {"role": "user", "content": "Write one sentence about why the sky is blue."}<br/>
        ///     ]<br/>
        ///   }'<br/>
        /// ```<br/>
        /// **Python** (`pip install openai`)<br/>
        /// ```python<br/>
        /// import os<br/>
        /// from openai import OpenAI<br/>
        /// client = OpenAI(<br/>
        ///     base_url="https://api.smallest.ai/waves/v1",<br/>
        ///     api_key=os.environ["SMALLEST_API_KEY"],<br/>
        /// )<br/>
        /// response = client.chat.completions.create(<br/>
        ///     model="electron",<br/>
        ///     messages=[<br/>
        ///         {"role": "user", "content": "Write one sentence about why the sky is blue."}<br/>
        ///     ],<br/>
        /// )<br/>
        /// print(response.choices[0].message.content)<br/>
        /// ```<br/>
        /// **JavaScript / TypeScript** (`npm install openai`)<br/>
        /// ```typescript<br/>
        /// import OpenAI from "openai";<br/>
        /// const client = new OpenAI({<br/>
        ///   baseURL: "https://api.smallest.ai/waves/v1",<br/>
        ///   apiKey: process.env.SMALLEST_API_KEY,<br/>
        /// });<br/>
        /// const response = await client.chat.completions.create({<br/>
        ///   model: "electron",<br/>
        ///   messages: [<br/>
        ///     { role: "user", content: "Write one sentence about why the sky is blue." },<br/>
        ///   ],<br/>
        /// });<br/>
        /// console.log(response.choices[0].message.content);<br/>
        /// ```<br/>
        /// **Streaming with usage** (Python)<br/>
        /// ```python<br/>
        /// stream = client.chat.completions.create(<br/>
        ///     model="electron",<br/>
        ///     messages=[{"role": "user", "content": "Tell me a one-sentence fun fact."}],<br/>
        ///     stream=True,<br/>
        ///     stream_options={"include_usage": True},<br/>
        /// )<br/>
        /// for chunk in stream:<br/>
        ///     if chunk.choices and chunk.choices[0].delta.content:<br/>
        ///         print(chunk.choices[0].delta.content, end="", flush=True)<br/>
        ///     if chunk.usage:<br/>
        ///         print(f"\n\nTokens: {chunk.usage.total_tokens}")<br/>
        /// ```<br/>
        /// ## Common gotchas<br/>
        /// - **Base URL is `/waves/v1`**, not `/v1`. The OpenAI SDK appends `/chat/completions` for you.<br/>
        /// - **`stream_options.include_usage: true`** is required for exact token accounting on streaming calls — the final SSE chunk carries the `usage` block.<br/>
        /// - **`n &gt; 1` and `prompt_logprobs` are rejected.** Use multiple requests if you need parallel completions.<br/>
        /// - **Auth header is `Authorization: Bearer $SMALLEST_API_KEY`** — get the key from the [Smallest AI Console](https://app.smallest.ai/dashboard/api-keys).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::SmallestAI.AutoSDKHttpResponse<global::SmallestAI.ChatCompletion>> ElectronChatCompletionsAsResponseAsync(

            global::SmallestAI.ChatCompletionRequest request,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareElectronChatCompletionsArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::SmallestAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ElectronChatCompletionsSecurityRequirements,
                operationName: "ElectronChatCompletionsAsync");

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
                supportsRetry: false);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::SmallestAI.PathBuilder(
                                path: "/waves/v1/chat/completions",
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
                PrepareElectronChatCompletionsRequest(
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
                                operationId: "ElectronChatCompletions",
                                methodName: "ElectronChatCompletionsAsync",
                                pathTemplate: "\"/waves/v1/chat/completions\"",
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
                                operationId: "ElectronChatCompletions",
                                methodName: "ElectronChatCompletionsAsync",
                                pathTemplate: "\"/waves/v1/chat/completions\"",
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
                                operationId: "ElectronChatCompletions",
                                methodName: "ElectronChatCompletionsAsync",
                                pathTemplate: "\"/waves/v1/chat/completions\"",
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
                ProcessElectronChatCompletionsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::SmallestAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::SmallestAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ElectronChatCompletions",
                                methodName: "ElectronChatCompletionsAsync",
                                pathTemplate: "\"/waves/v1/chat/completions\"",
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
                                operationId: "ElectronChatCompletions",
                                methodName: "ElectronChatCompletionsAsync",
                                pathTemplate: "\"/waves/v1/chat/completions\"",
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
                            // Bad request — schema validation, unsupported parameter (`n > 1`, `prompt_logprobs`), context length exceeded, or invalid field value forwarded by the model. 
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::SmallestAI.Error? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::SmallestAI.Error.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::SmallestAI.Error.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::SmallestAI.ApiException<global::SmallestAI.Error>.Create(
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
                            // Missing or invalid API key.
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::SmallestAI.Error? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::SmallestAI.Error.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::SmallestAI.Error.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::SmallestAI.ApiException<global::SmallestAI.Error>.Create(
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
                            // API key valid but no access to Electron on this plan.
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                global::SmallestAI.Error? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::SmallestAI.Error.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = global::SmallestAI.Error.FromJson(__content_403, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }


                                throw global::SmallestAI.ApiException<global::SmallestAI.Error>.Create(
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
                            // Rate limit (RPM) or concurrency cap hit. See [Concurrency and Limits](/models/api-reference/concurrency-and-limits). 
                            if ((int)__response.StatusCode == 429)
                            {
                                string? __content_429 = null;
                                global::System.Exception? __exception_429 = null;
                                global::SmallestAI.Error? __value_429 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_429 = global::SmallestAI.Error.FromJson(__content_429, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_429 = global::SmallestAI.Error.FromJson(__content_429, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }


                                throw global::SmallestAI.ApiException<global::SmallestAI.Error>.Create(
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
                            // Upstream model unavailable. Retry with backoff.
                            if ((int)__response.StatusCode == 502)
                            {
                                string? __content_502 = null;
                                global::System.Exception? __exception_502 = null;
                                global::SmallestAI.Error? __value_502 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_502 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_502 = global::SmallestAI.Error.FromJson(__content_502, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_502 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_502 = global::SmallestAI.Error.FromJson(__content_502, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_502 = __ex;
                                }


                                throw global::SmallestAI.ApiException<global::SmallestAI.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_502 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_502,
                                    responseBody: __content_502,
                                    responseObject: __value_502,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Endpoint temporarily disabled, or upstream model overloaded.
                            if ((int)__response.StatusCode == 503)
                            {
                                string? __content_503 = null;
                                global::System.Exception? __exception_503 = null;
                                global::SmallestAI.Error? __value_503 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_503 = global::SmallestAI.Error.FromJson(__content_503, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_503 = global::SmallestAI.Error.FromJson(__content_503, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_503 = __ex;
                                }


                                throw global::SmallestAI.ApiException<global::SmallestAI.Error>.Create(
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
                                ProcessElectronChatCompletionsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::SmallestAI.ChatCompletion.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::SmallestAI.AutoSDKHttpResponse<global::SmallestAI.ChatCompletion>(
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

                                    var __value = await global::SmallestAI.ChatCompletion.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::SmallestAI.AutoSDKHttpResponse<global::SmallestAI.ChatCompletion>(
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
        /// <summary>
        /// Chat Completions (Electron)<br/>
        /// Generate a chat completion with Electron. OpenAI-compatible<br/>
        /// request/response shape — point any OpenAI SDK at<br/>
        /// `https://api.smallest.ai/waves/v1` and it just works.<br/>
        /// Set `stream: true` to receive tokens via Server-Sent Events. With<br/>
        /// `stream_options: { include_usage: true }`, the final SSE chunk<br/>
        /// carries the `usage` block so token accounting is exact even on<br/>
        /// client disconnects.<br/>
        /// Tool calling follows OpenAI's `tools` array convention. When you<br/>
        /// provide a voice-agent-style system prompt, Electron emits a short<br/>
        /// filler phrase in the assistant message `content` field alongside<br/>
        /// `tool_calls` — see the [Tool Calling guide](/models/documentation/llm-electron/tool-function-calling)<br/>
        /// for the voice-agent pattern.<br/>
        /// ## Examples<br/>
        /// **cURL**<br/>
        /// ```bash<br/>
        /// curl -X POST "https://api.smallest.ai/waves/v1/chat/completions" \<br/>
        ///   -H "Authorization: Bearer $SMALLEST_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///     "model": "electron",<br/>
        ///     "messages": [<br/>
        ///       {"role": "user", "content": "Write one sentence about why the sky is blue."}<br/>
        ///     ]<br/>
        ///   }'<br/>
        /// ```<br/>
        /// **Python** (`pip install openai`)<br/>
        /// ```python<br/>
        /// import os<br/>
        /// from openai import OpenAI<br/>
        /// client = OpenAI(<br/>
        ///     base_url="https://api.smallest.ai/waves/v1",<br/>
        ///     api_key=os.environ["SMALLEST_API_KEY"],<br/>
        /// )<br/>
        /// response = client.chat.completions.create(<br/>
        ///     model="electron",<br/>
        ///     messages=[<br/>
        ///         {"role": "user", "content": "Write one sentence about why the sky is blue."}<br/>
        ///     ],<br/>
        /// )<br/>
        /// print(response.choices[0].message.content)<br/>
        /// ```<br/>
        /// **JavaScript / TypeScript** (`npm install openai`)<br/>
        /// ```typescript<br/>
        /// import OpenAI from "openai";<br/>
        /// const client = new OpenAI({<br/>
        ///   baseURL: "https://api.smallest.ai/waves/v1",<br/>
        ///   apiKey: process.env.SMALLEST_API_KEY,<br/>
        /// });<br/>
        /// const response = await client.chat.completions.create({<br/>
        ///   model: "electron",<br/>
        ///   messages: [<br/>
        ///     { role: "user", content: "Write one sentence about why the sky is blue." },<br/>
        ///   ],<br/>
        /// });<br/>
        /// console.log(response.choices[0].message.content);<br/>
        /// ```<br/>
        /// **Streaming with usage** (Python)<br/>
        /// ```python<br/>
        /// stream = client.chat.completions.create(<br/>
        ///     model="electron",<br/>
        ///     messages=[{"role": "user", "content": "Tell me a one-sentence fun fact."}],<br/>
        ///     stream=True,<br/>
        ///     stream_options={"include_usage": True},<br/>
        /// )<br/>
        /// for chunk in stream:<br/>
        ///     if chunk.choices and chunk.choices[0].delta.content:<br/>
        ///         print(chunk.choices[0].delta.content, end="", flush=True)<br/>
        ///     if chunk.usage:<br/>
        ///         print(f"\n\nTokens: {chunk.usage.total_tokens}")<br/>
        /// ```<br/>
        /// ## Common gotchas<br/>
        /// - **Base URL is `/waves/v1`**, not `/v1`. The OpenAI SDK appends `/chat/completions` for you.<br/>
        /// - **`stream_options.include_usage: true`** is required for exact token accounting on streaming calls — the final SSE chunk carries the `usage` block.<br/>
        /// - **`n &gt; 1` and `prompt_logprobs` are rejected.** Use multiple requests if you need parallel completions.<br/>
        /// - **Auth header is `Authorization: Bearer $SMALLEST_API_KEY`** — get the key from the [Smallest AI Console](https://app.smallest.ai/dashboard/api-keys).
        /// </summary>
        /// <param name="model">
        /// Model ID. Currently only `"electron"`.
        /// </param>
        /// <param name="messages">
        /// Chat history. Standard OpenAI message array.
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="maxTokens">
        /// Maximum output tokens. Combined input + output context ceiling<br/>
        /// is 32,768.
        /// </param>
        /// <param name="stream">
        /// When true, response is `text/event-stream`. See the<br/>
        /// [Streaming guide](/models/documentation/llm-electron/streaming).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="streamOptions"></param>
        /// <param name="tools">
        /// Tool / function calling definitions. Standard OpenAI shape.<br/>
        /// See [Tool Calling](/models/documentation/llm-electron/tool-function-calling).
        /// </param>
        /// <param name="toolChoice"></param>
        /// <param name="responseFormat">
        /// Output shape. `{type: "text"}` (default) or `{type: "json_object"}`.
        /// </param>
        /// <param name="stop"></param>
        /// <param name="seed">
        /// Best-effort determinism.
        /// </param>
        /// <param name="logitBias"></param>
        /// <param name="logprobs">
        /// Default Value: false
        /// </param>
        /// <param name="topLogprobs"></param>
        /// <param name="presencePenalty">
        /// Default Value: 0
        /// </param>
        /// <param name="frequencyPenalty">
        /// Default Value: 0
        /// </param>
        /// <param name="user">
        /// Opaque end-user identifier. Not interpreted by Electron.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::SmallestAI.ChatCompletion> ElectronChatCompletionsAsync(
            string model,
            global::System.Collections.Generic.IList<global::SmallestAI.ElectronMessage> messages,
            double? temperature = default,
            double? topP = default,
            int? maxTokens = default,
            bool? stream = default,
            global::SmallestAI.ChatCompletionRequestStreamOptions? streamOptions = default,
            global::System.Collections.Generic.IList<global::SmallestAI.Tool>? tools = default,
            global::SmallestAI.ChatCompletionRequestToolChoice? toolChoice = default,
            global::SmallestAI.ChatCompletionRequestResponseFormat? responseFormat = default,
            global::SmallestAI.ChatCompletionRequestStop? stop = default,
            int? seed = default,
            global::System.Collections.Generic.Dictionary<string, double>? logitBias = default,
            bool? logprobs = default,
            int? topLogprobs = default,
            double? presencePenalty = default,
            double? frequencyPenalty = default,
            string? user = default,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::SmallestAI.ChatCompletionRequest
            {
                Model = model,
                Messages = messages,
                Temperature = temperature,
                TopP = topP,
                MaxTokens = maxTokens,
                Stream = stream,
                StreamOptions = streamOptions,
                Tools = tools,
                ToolChoice = toolChoice,
                ResponseFormat = responseFormat,
                Stop = stop,
                Seed = seed,
                LogitBias = logitBias,
                Logprobs = logprobs,
                TopLogprobs = topLogprobs,
                PresencePenalty = presencePenalty,
                FrequencyPenalty = frequencyPenalty,
                User = user,
            };

            return await ElectronChatCompletionsAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}