
#nullable enable

namespace SmallestAI
{
    public partial class SubpackageVoiceCloningClient
    {


        private static readonly global::SmallestAI.EndPointSecurityRequirement s_CreateVoiceCloneSecurityRequirement0 =
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
        private static readonly global::SmallestAI.EndPointSecurityRequirement[] s_CreateVoiceCloneSecurityRequirements =
            new global::SmallestAI.EndPointSecurityRequirement[]
            {                s_CreateVoiceCloneSecurityRequirement0,
            };
        partial void PrepareCreateVoiceCloneArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::SmallestAI.CreateVoiceCloneRequest request);
        partial void PrepareCreateVoiceCloneRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::SmallestAI.CreateVoiceCloneRequest request);
        partial void ProcessCreateVoiceCloneResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateVoiceCloneResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a Voice Clone<br/>
        /// Create an instant voice clone in a single call. Defaults to `lightning-v3.1`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SmallestAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::SmallestAI.VoiceCloningCreateVoiceCloneResponse200> CreateVoiceCloneAsync(

            global::SmallestAI.CreateVoiceCloneRequest request,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateVoiceCloneArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::SmallestAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateVoiceCloneSecurityRequirements,
                operationName: "CreateVoiceCloneAsync");

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
                                path: "/waves/v1/voice-cloning",
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
                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
                            __httpRequestContent.Add(
                                content: new global::System.Net.Http.StringContent(request.DisplayName ?? string.Empty),
                                name: "\"displayName\"");
                            var __contentFile = new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>());
                            __contentFile.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                request.Filename is null
                                    ? "application/octet-stream"
                                    : (global::System.IO.Path.GetExtension(request.Filename) ?? string.Empty).ToLowerInvariant() switch
                                    {
                                        ".aac" => "audio/aac",
                                        ".flac" => "audio/flac",
                                        ".gif" => "image/gif",
                                        ".jpeg" => "image/jpeg",
                                        ".jpg" => "image/jpeg",
                                        ".json" => "application/json",
                                        ".m4a" => "audio/mp4",
                                        ".mp3" => "audio/mpeg",
                                        ".mp4" => "video/mp4",
                                        ".mpeg" => "audio/mpeg",
                                        ".mpga" => "audio/mpeg",
                                        ".oga" => "audio/ogg",
                                        ".ogg" => "audio/ogg",
                                        ".opus" => "audio/ogg",
                                        ".pdf" => "application/pdf",
                                        ".png" => "image/png",
                                        ".txt" => "text/plain",
                                        ".wav" => "audio/wav",
                                        ".weba" => "audio/webm",
                                        ".webm" => "video/webm",
                                        ".webp" => "image/webp",
                                        _ => "application/octet-stream",
                                    });
                            __httpRequestContent.Add(
                                content: __contentFile,
                                name: "\"file\"",
                                fileName: request.Filename != null ? $"\"{request.Filename}\"" : string.Empty);
                            if (__contentFile.Headers.ContentDisposition != null)
                            {
                                __contentFile.Headers.ContentDisposition.FileNameStar = null;
                            }
                            if (request.Description != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Description ?? string.Empty),
                                    name: "\"description\"");
                            } 
                            if (request.Accent != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Accent ?? string.Empty),
                                    name: "\"accent\"");
                            } 
                            if (request.Tags != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Tags ?? string.Empty),
                                    name: "\"tags\"");
                            } 
                            if (request.Language != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Language ?? string.Empty),
                                    name: "\"language\"");
                            } 
                            if (request.Model != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.Model).HasValue ? (request.Model).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"model\"");
                            }
                            __httpRequest.Content = __httpRequestContent;
                global::SmallestAI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateVoiceCloneRequest(
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
                                operationId: "CreateVoiceClone",
                                methodName: "CreateVoiceCloneAsync",
                                pathTemplate: "\"/waves/v1/voice-cloning\"",
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
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::SmallestAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::SmallestAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateVoiceClone",
                                methodName: "CreateVoiceCloneAsync",
                                pathTemplate: "\"/waves/v1/voice-cloning\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::SmallestAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::SmallestAI.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::SmallestAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::SmallestAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateVoiceClone",
                                methodName: "CreateVoiceCloneAsync",
                                pathTemplate: "\"/waves/v1/voice-cloning\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::SmallestAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
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
                ProcessCreateVoiceCloneResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::SmallestAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::SmallestAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateVoiceClone",
                                methodName: "CreateVoiceCloneAsync",
                                pathTemplate: "\"/waves/v1/voice-cloning\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::SmallestAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::SmallestAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateVoiceClone",
                                methodName: "CreateVoiceCloneAsync",
                                pathTemplate: "\"/waves/v1/voice-cloning\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Validation error. Common causes: no file provided, invalid MIME type, file too large, clone limit exceeded, invalid language, or `model=lightning-v2` (deprecated). 
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::SmallestAI.CreateVoiceCloneRequestBadRequestError? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::SmallestAI.CreateVoiceCloneRequestBadRequestError.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::SmallestAI.CreateVoiceCloneRequestBadRequestError.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }

                                throw new global::SmallestAI.ApiException<global::SmallestAI.CreateVoiceCloneRequestBadRequestError>(
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
                            // Unauthorized — missing or invalid API key.
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::SmallestAI.CreateVoiceCloneRequestUnauthorizedError? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::SmallestAI.CreateVoiceCloneRequestUnauthorizedError.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::SmallestAI.CreateVoiceCloneRequestUnauthorizedError.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }

                                throw new global::SmallestAI.ApiException<global::SmallestAI.CreateVoiceCloneRequestUnauthorizedError>(
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
                            // Server error. The `error_code` field may be populated for known failure modes.
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                global::SmallestAI.CreateVoiceCloneRequestInternalServerError? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::SmallestAI.CreateVoiceCloneRequestInternalServerError.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = global::SmallestAI.CreateVoiceCloneRequestInternalServerError.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }

                                throw new global::SmallestAI.ApiException<global::SmallestAI.CreateVoiceCloneRequestInternalServerError>(
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
                                ProcessCreateVoiceCloneResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::SmallestAI.VoiceCloningCreateVoiceCloneResponse200.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
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

                                    return
                                        await global::SmallestAI.VoiceCloningCreateVoiceCloneResponse200.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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
        /// <summary>
        /// Create a Voice Clone<br/>
        /// Create an instant voice clone in a single call. Defaults to `lightning-v3.1`.
        /// </summary>
        /// <param name="displayName">
        /// Human-readable name for the voice clone.
        /// </param>
        /// <param name="file">
        /// Audio file to clone from. Supported MIME types:<br/>
        /// `audio/mpeg`, `audio/mpeg-3`, `audio/wav`, `audio/wave`,<br/>
        /// `audio/webm`, `video/webm`, `audio/mp4`, `video/mp4`.<br/>
        /// Maximum size: 5 MB.
        /// </param>
        /// <param name="filename">
        /// Audio file to clone from. Supported MIME types:<br/>
        /// `audio/mpeg`, `audio/mpeg-3`, `audio/wav`, `audio/wave`,<br/>
        /// `audio/webm`, `video/webm`, `audio/mp4`, `video/mp4`.<br/>
        /// Maximum size: 5 MB.
        /// </param>
        /// <param name="description">
        /// Optional longer description for the voice clone.
        /// </param>
        /// <param name="accent">
        /// Optional accent tag (e.g. "general", "indian").
        /// </param>
        /// <param name="tags">
        /// Optional comma-separated list of tags. Server splits on<br/>
        /// commas and trims whitespace (`"en, tone-test"` → `["en", "tone-test"]`).
        /// </param>
        /// <param name="language">
        /// Primary language the clone will be used for. Optional, but<br/>
        /// **strongly recommended** — set it to the language of your<br/>
        /// reference audio. When a TTS request later uses<br/>
        /// `language: "auto"`, the server falls back to this value, so<br/>
        /// setting it now avoids silent language mismatches at inference<br/>
        /// time.<br/>
        /// Must be one of the languages supported by `lightning-v3.1`<br/>
        /// (e.g. `en`, `hi`, `multi`). The server validates and rejects<br/>
        /// unsupported codes with a 400.
        /// </param>
        /// <param name="model">
        /// Voice cloning model. Defaults to `lightning-v3.1`.<br/>
        /// `lightning-v2` is accepted by the schema for historical<br/>
        /// reasons but is deprecated — the server returns 400 with<br/>
        /// `"Voice cloning for lightning-v2 is deprecated. Please use lightning-v3.1"`.<br/>
        /// Default Value: lightning-v3.1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::SmallestAI.VoiceCloningCreateVoiceCloneResponse200> CreateVoiceCloneAsync(
            string displayName,
            byte[] file,
            string filename,
            string? description = default,
            string? accent = default,
            string? tags = default,
            string? language = default,
            global::SmallestAI.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModel? model = default,
            global::SmallestAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::SmallestAI.CreateVoiceCloneRequest
            {
                DisplayName = displayName,
                File = file,
                Filename = filename,
                Description = description,
                Accent = accent,
                Tags = tags,
                Language = language,
                Model = model,
            };

            return await CreateVoiceCloneAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}