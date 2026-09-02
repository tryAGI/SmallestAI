
#nullable enable

namespace SmallestAI.Realtime
{
    /// <summary>
    /// Pulse realtime speech-to-text. Audio is uploaded as raw binary frames<br/>
    /// (~4096-byte PCM chunks); transcription results arrive as JSON frames.<br/>
    /// Only `model=pulse` is served here. Pulse Pro has no streaming worker and<br/>
    /// returns `400` before the WebSocket upgrade completes.<br/>
    /// Speaker labels require `diarize=true`, and per-word speakers additionally<br/>
    /// require `word_timestamps=true`. Only frames with `is_final: true` carry<br/>
    /// the `words` array — never render speaker attribution from interim frames.<br/>
    /// Speaker ids are zero-indexed and stable within a session only.
    /// </summary>
    public sealed partial class SmallestAISttLiveRealtimeClient : global::System.IDisposable, global::System.IAsyncDisposable
    {
        /// <summary>
        /// Default WebSocket base URL.
        /// </summary>
        public const string DefaultBaseUrl = "wss://api.smallest.ai/waves/v1/stt/live";

        private global::System.Net.WebSockets.ClientWebSocket _clientWebSocket;
        private global::System.Uri? _lastConnectUri;
        private global::System.Collections.Generic.Dictionary<string, string>? _lastAdditionalHeaders;
        private global::System.Collections.Generic.List<string>? _lastAdditionalSubProtocols;
        private global::System.TimeSpan? _lastKeepAliveInterval;
        private global::System.TimeSpan? _lastConnectTimeout;


        /// <summary>
        /// Current WebSocket connection status.
        /// </summary>
        public enum AutoSDKWebSocketConnectionStatus
        {
            /// <summary>
            /// The client is not connected.
            /// </summary>
            Disconnected,

            /// <summary>
            /// The client is connecting.
            /// </summary>
            Connecting,

            /// <summary>
            /// The client is connected.
            /// </summary>
            Connected,

            /// <summary>
            /// The client observed a normal close.
            /// </summary>
            Closed,

            /// <summary>
            /// The client observed a connection error.
            /// </summary>
            Faulted,
        }

        /// <summary>
        /// Configures automatic reconnect attempts after receive-loop WebSocket failures.
        /// </summary>
        public sealed class AutoSDKWebSocketReconnectOptions
        {
            /// <summary>
            /// Enables reconnect attempts from the receive loop.
            /// </summary>
            public bool Enabled { get; set; }

            /// <summary>
            /// Maximum reconnect attempts per observed receive failure.
            /// </summary>
            public int MaxAttempts { get; set; } = 3;

            /// <summary>
            /// Delay before the first reconnect attempt.
            /// </summary>
            public global::System.TimeSpan InitialDelay { get; set; } = global::System.TimeSpan.FromSeconds(1);

            /// <summary>
            /// Maximum delay between reconnect attempts.
            /// </summary>
            public global::System.TimeSpan MaxDelay { get; set; } = global::System.TimeSpan.FromSeconds(30);

            /// <summary>
            /// Multiplier applied to the delay after each failed reconnect attempt.
            /// </summary>
            public double BackoffMultiplier { get; set; } = 2D;
        }

        /// <summary>
        /// Event data for closed WebSocket connections.
        /// </summary>
        public sealed class AutoSDKWebSocketClosedEventArgs : global::System.EventArgs
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="AutoSDKWebSocketClosedEventArgs"/> class.
            /// </summary>
            public AutoSDKWebSocketClosedEventArgs(
                global::System.Net.WebSockets.WebSocketCloseStatus? closeStatus,
                string? closeStatusDescription)
            {
                CloseStatus = closeStatus;
                CloseStatusDescription = closeStatusDescription;
            }

            /// <summary>
            /// Gets the WebSocket close status.
            /// </summary>
            public global::System.Net.WebSockets.WebSocketCloseStatus? CloseStatus { get; }

            /// <summary>
            /// Gets the WebSocket close status description.
            /// </summary>
            public string? CloseStatusDescription { get; }
        }

        /// <summary>
        /// Event data for WebSocket exceptions.
        /// </summary>
        public sealed class AutoSDKWebSocketExceptionEventArgs : global::System.EventArgs
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="AutoSDKWebSocketExceptionEventArgs"/> class.
            /// </summary>
            public AutoSDKWebSocketExceptionEventArgs(
                global::System.Exception exception)
            {
                Exception = exception ?? throw new global::System.ArgumentNullException(nameof(exception));
            }

            /// <summary>
            /// Gets the observed exception.
            /// </summary>
            public global::System.Exception Exception { get; }
        }

        /// <summary>
        /// Event data for WebSocket reconnect attempts.
        /// </summary>
        public sealed class AutoSDKWebSocketReconnectEventArgs : global::System.EventArgs
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="AutoSDKWebSocketReconnectEventArgs"/> class.
            /// </summary>
            public AutoSDKWebSocketReconnectEventArgs(
                int attempt,
                global::System.TimeSpan delay,
                global::System.Exception exception)
            {
                Attempt = attempt;
                Delay = delay;
                Exception = exception ?? throw new global::System.ArgumentNullException(nameof(exception));
            }

            /// <summary>
            /// Gets the reconnect attempt number.
            /// </summary>
            public int Attempt { get; }

            /// <summary>
            /// Gets the delay before the reconnect attempt.
            /// </summary>
            public global::System.TimeSpan Delay { get; }

            /// <summary>
            /// Gets the exception that triggered reconnect.
            /// </summary>
            public global::System.Exception Exception { get; }
        }

        /// <summary>
        /// Event data for deserialized WebSocket messages.
        /// </summary>
        public sealed class AutoSDKWebSocketMessageEventArgs<TMessage> : global::System.EventArgs
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="AutoSDKWebSocketMessageEventArgs{TMessage}"/> class.
            /// </summary>
            public AutoSDKWebSocketMessageEventArgs(
                TMessage message,
                string rawText,
                global::System.Text.Json.JsonElement? json)
            {
                Message = message;
                RawText = rawText ?? string.Empty;
                Json = json;
            }

            /// <summary>
            /// Gets the deserialized message.
            /// </summary>
            public TMessage Message { get; }

            /// <summary>
            /// Gets the raw text received from the WebSocket.
            /// </summary>
            public string RawText { get; }

            /// <summary>
            /// Gets the parsed JSON payload when available.
            /// </summary>
            public global::System.Text.Json.JsonElement? Json { get; }
        }

        /// <summary>
        /// Event data for messages that could not be deserialized into a known receive type.
        /// </summary>
        public sealed class AutoSDKWebSocketUnknownMessageEventArgs : global::System.EventArgs
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="AutoSDKWebSocketUnknownMessageEventArgs"/> class.
            /// </summary>
            public AutoSDKWebSocketUnknownMessageEventArgs(
                string rawText,
                global::System.Text.Json.JsonElement? json)
            {
                RawText = rawText ?? string.Empty;
                Json = json;
            }

            /// <summary>
            /// Gets the raw text received from the WebSocket.
            /// </summary>
            public string RawText { get; }

            /// <summary>
            /// Gets the parsed JSON payload when available.
            /// </summary>
            public global::System.Text.Json.JsonElement? Json { get; }
        }

        /// <summary>
        /// Gets the current WebSocket connection status.
        /// </summary>
        public AutoSDKWebSocketConnectionStatus Status { get; private set; } = AutoSDKWebSocketConnectionStatus.Disconnected;

        /// <summary>
        /// Gets reconnect options used by the receive loop.
        /// </summary>
        public AutoSDKWebSocketReconnectOptions ReconnectOptions { get; } = new AutoSDKWebSocketReconnectOptions();

        /// <summary>
        /// Raised after the WebSocket connection is opened.
        /// </summary>
        public event global::System.EventHandler? Connected;

        /// <summary>
        /// Raised after the WebSocket connection is closed.
        /// </summary>
        public event global::System.EventHandler<AutoSDKWebSocketClosedEventArgs>? Closed;

        /// <summary>
        /// Raised after a WebSocket connection exception is observed.
        /// </summary>
        public event global::System.EventHandler<AutoSDKWebSocketExceptionEventArgs>? ExceptionOccurred;

        /// <summary>
        /// Raised before a reconnect attempt starts.
        /// </summary>
        public event global::System.EventHandler<AutoSDKWebSocketReconnectEventArgs>? Reconnecting;

        /// <summary>
        /// Raised when an inbound text message cannot be deserialized into a known receive event.
        /// </summary>
        public event global::System.EventHandler<AutoSDKWebSocketUnknownMessageEventArgs>? UnknownMessage;

        /// <summary>
        /// Raised after a text message is deserialized into the receive event type.
        /// </summary>
        public event global::System.EventHandler<AutoSDKWebSocketMessageEventArgs<global::SmallestAI.Realtime.SttTranscriptionEvent>>? MessageReceived;
        /// <summary>
        /// Raised after a SttTranscription message is deserialized.
        /// </summary>
        public event global::System.EventHandler<AutoSDKWebSocketMessageEventArgs<global::SmallestAI.Realtime.SttTranscriptionEvent>>? SttTranscriptionReceived;

        /// <summary>
        ///
        /// </summary>

        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::SmallestAI.Realtime.RealtimeSourceGenerationContext.Default;

        /// <summary>
        /// Gets a value indicating whether the WebSocket connection is open.
        /// </summary>
        public bool IsConnected => _clientWebSocket.State == global::System.Net.WebSockets.WebSocketState.Open;

        /// <summary>
        /// Creates a new instance of the SmallestAISttLiveRealtimeClient.
        /// If no clientWebSocket is provided, a new one will be created.
        /// </summary>
        /// <param name="clientWebSocket">The ClientWebSocket instance. If not provided, a new one will be created.</param>
        public SmallestAISttLiveRealtimeClient(
            global::System.Net.WebSockets.ClientWebSocket? clientWebSocket = null)
        {
            _clientWebSocket = clientWebSocket ?? new global::System.Net.WebSockets.ClientWebSocket();

            Initialized(_clientWebSocket);
        }


        private string? _storedAuthorizationHeaderName;
        private string? _storedAuthorizationHeaderScheme;
        private string? _storedAuthorizationApiKey;

        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingBearer(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            _storedAuthorizationApiKey = apiKey;
            _storedAuthorizationHeaderName = "Authorization";
            _storedAuthorizationHeaderScheme = "bearer";
        }

        /// <summary>
        /// Creates a new instance with bearer token authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="clientWebSocket"></param>
        public SmallestAISttLiveRealtimeClient(
            string apiKey,
            global::System.Net.WebSockets.ClientWebSocket? clientWebSocket = null) : this(clientWebSocket)
        {
            Authorizing(_clientWebSocket, ref apiKey);

            AuthorizeUsingBearer(apiKey);

            Authorized(_clientWebSocket);
        }





        private void ApplyStoredAuthorization(
            bool useSubprotocolAuth)
        {

            if (_storedAuthorizationApiKey is not null &&
                _storedAuthorizationHeaderName is not null)
            {
                var __authorizationValue = _storedAuthorizationHeaderScheme is not null
                    ? $"{_storedAuthorizationHeaderScheme} {_storedAuthorizationApiKey}"
                    : _storedAuthorizationApiKey;
                _clientWebSocket.Options.SetRequestHeader(_storedAuthorizationHeaderName, __authorizationValue);
            }
        }
        private void RememberConnectionOptions(
            global::System.Uri uri,
            global::System.Collections.Generic.IDictionary<string, string>? additionalHeaders,
            global::System.Collections.Generic.IEnumerable<string>? additionalSubProtocols,
            global::System.TimeSpan? keepAliveInterval,
            global::System.TimeSpan? connectTimeout)
        {
            _lastConnectUri = uri;
            _lastAdditionalHeaders = additionalHeaders is null
                ? null
                : new global::System.Collections.Generic.Dictionary<string, string>(
                    additionalHeaders,
                    global::System.StringComparer.OrdinalIgnoreCase);
            _lastAdditionalSubProtocols = additionalSubProtocols is null
                ? null
                : new global::System.Collections.Generic.List<string>(additionalSubProtocols);
            _lastKeepAliveInterval = keepAliveInterval;
            _lastConnectTimeout = connectTimeout;
        }

        private void ResetClientWebSocket()
        {
            _clientWebSocket.Dispose();
            _clientWebSocket = new global::System.Net.WebSockets.ClientWebSocket();
            Initialized(_clientWebSocket);
        }

        private void RaiseClosed(
            global::System.Net.WebSockets.WebSocketCloseStatus? closeStatus,
            string? closeStatusDescription)
        {
            Status = AutoSDKWebSocketConnectionStatus.Closed;
            Closed?.Invoke(
                this,
                new AutoSDKWebSocketClosedEventArgs(closeStatus, closeStatusDescription));
        }

        private void RaiseException(
            global::System.Exception exception)
        {
            Status = AutoSDKWebSocketConnectionStatus.Faulted;
            ExceptionOccurred?.Invoke(
                this,
                new AutoSDKWebSocketExceptionEventArgs(exception));
        }

        private global::System.TimeSpan GetReconnectDelay(
            int attempt)
        {
            var delay = ReconnectOptions.InitialDelay;
            if (delay < global::System.TimeSpan.Zero)
            {
                delay = global::System.TimeSpan.Zero;
            }

            var multiplier = ReconnectOptions.BackoffMultiplier;
            if (multiplier < 1D)
            {
                multiplier = 1D;
            }

            for (var index = 1; index < attempt; index++)
            {
                var nextMilliseconds = delay.TotalMilliseconds * multiplier;
                if (nextMilliseconds >= ReconnectOptions.MaxDelay.TotalMilliseconds)
                {
                    delay = ReconnectOptions.MaxDelay;
                    break;
                }

                delay = global::System.TimeSpan.FromMilliseconds(nextMilliseconds);
            }

            if (ReconnectOptions.MaxDelay >= global::System.TimeSpan.Zero &&
                delay > ReconnectOptions.MaxDelay)
            {
                delay = ReconnectOptions.MaxDelay;
            }

            return delay;
        }

        private async global::System.Threading.Tasks.Task<bool> TryReconnectAsync(
            global::System.Exception exception,
            global::System.Threading.CancellationToken cancellationToken)
        {
            if (!ReconnectOptions.Enabled ||
                _lastConnectUri is null ||
                cancellationToken.IsCancellationRequested)
            {
                return false;
            }

            var maxAttempts = ReconnectOptions.MaxAttempts < 1 ? 1 : ReconnectOptions.MaxAttempts;
            var lastException = exception;
            for (var attempt = 1; attempt <= maxAttempts; attempt++)
            {
                var delay = GetReconnectDelay(attempt);
                Reconnecting?.Invoke(
                    this,
                    new AutoSDKWebSocketReconnectEventArgs(attempt, delay, lastException));

                if (delay > global::System.TimeSpan.Zero)
                {
                    await global::System.Threading.Tasks.Task.Delay(delay, cancellationToken).ConfigureAwait(false);
                }

                try
                {
                    ResetClientWebSocket();
                    await ConnectAsync(
                        uri: _lastConnectUri,
                        additionalHeaders: _lastAdditionalHeaders,
                        additionalSubProtocols: _lastAdditionalSubProtocols,
                        keepAliveInterval: _lastKeepAliveInterval,
                        connectTimeout: _lastConnectTimeout,
                        cancellationToken: cancellationToken).ConfigureAwait(false);
                    return true;
                }
                catch (global::System.Exception reconnectException) when (
                    reconnectException is global::System.Net.WebSockets.WebSocketException ||
                    reconnectException is global::System.Net.Http.HttpRequestException ||
                    reconnectException is global::System.OperationCanceledException)
                {
                    lastException = reconnectException;
                    RaiseException(reconnectException);
                    if (cancellationToken.IsCancellationRequested)
                    {
                        return false;
                    }
                }
            }

            return false;
        }

        private void ApplyConnectionOptions(
            global::System.Collections.Generic.IDictionary<string, string>? additionalHeaders,
            global::System.Collections.Generic.IEnumerable<string>? additionalSubProtocols,
            global::System.TimeSpan? keepAliveInterval)
        {
            if (keepAliveInterval is not null)
            {
                _clientWebSocket.Options.KeepAliveInterval = keepAliveInterval.Value;
            }

            ApplyStoredAuthorization(false);

            if (additionalHeaders is not null)
            {
                foreach (var header in additionalHeaders)
                {
                    _clientWebSocket.Options.SetRequestHeader(header.Key, header.Value);
                }
            }

            if (additionalSubProtocols is not null)
            {
                foreach (var subProtocol in additionalSubProtocols)
                {
                    _clientWebSocket.Options.AddSubProtocol(subProtocol);
                }
            }
        }

        private async global::System.Threading.Tasks.Task ConnectAsyncCore(
            global::System.Uri uri,
            global::System.TimeSpan? connectTimeout,
            global::System.Threading.CancellationToken cancellationToken)
        {
            global::System.Threading.CancellationTokenSource? __timeoutCancellationTokenSource = null;
            var __effectiveCancellationToken = cancellationToken;

            if (connectTimeout is not null)
            {
                __timeoutCancellationTokenSource = global::System.Threading.CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
                __timeoutCancellationTokenSource.CancelAfter(connectTimeout.Value);
                __effectiveCancellationToken = __timeoutCancellationTokenSource.Token;
            }

            try
            {
                Status = AutoSDKWebSocketConnectionStatus.Connecting;
                await _clientWebSocket.ConnectAsync(uri, __effectiveCancellationToken).ConfigureAwait(false);
                Status = AutoSDKWebSocketConnectionStatus.Connected;
                Connected?.Invoke(this, global::System.EventArgs.Empty);
            }
            catch (global::System.Exception exception) when (
                exception is global::System.Net.WebSockets.WebSocketException ||
                exception is global::System.Net.Http.HttpRequestException ||
                exception is global::System.OperationCanceledException)
            {
                RaiseException(exception);
                throw;
            }
            finally
            {
                __timeoutCancellationTokenSource?.Dispose();
            }
        }

        private const string DefaultBaseUrlTemplate = "wss://api.smallest.ai/waves/v1/stt/live";


        /// <inheritdoc cref="global::System.Net.WebSockets.ClientWebSocket.ConnectAsync(global::System.Uri, global::System.Threading.CancellationToken)"/>
        public async global::System.Threading.Tasks.Task ConnectAsync(
            global::System.Uri? uri = null,
            global::System.Collections.Generic.IDictionary<string, string>? additionalHeaders = null,
            global::System.Collections.Generic.IEnumerable<string>? additionalSubProtocols = null,
            global::System.TimeSpan? keepAliveInterval = null,
            global::System.TimeSpan? connectTimeout = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            global::System.Uri __uri;
            if (uri is not null)
            {
                __uri = uri;
            }
            else
            {
                var __pathBuilder = new global::SmallestAI.Realtime.PathBuilder(
                    path: DefaultBaseUrl);

                __uri = new global::System.Uri(__pathBuilder.ToString());
            }

            RememberConnectionOptions(__uri, additionalHeaders, additionalSubProtocols, keepAliveInterval, connectTimeout);
            ApplyConnectionOptions(additionalHeaders, additionalSubProtocols, keepAliveInterval);
            await ConnectAsyncCore(__uri, connectTimeout, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Connects to the WebSocket server with typed connection parameters.
        /// </summary>
        /// <param name="model">Transcription model. Only `pulse` is served on this channel — Pulse Pro has no streaming worker and returns `400` before the upgrade completes.</param>
        /// <param name="capitalize">Apply capitalization.</param>
        /// <param name="diarize">Emit speaker labels. Pair with `word_timestamps` for per-word attribution.</param>
        /// <param name="emotionDetection">Emit emotion scores alongside transcripts.</param>
        /// <param name="encoding">Encoding of the binary audio frames.</param>
        /// <param name="endpointing">Finalize promptly on trailing silence.</param>
        /// <param name="eouTimeoutMs">End-of-utterance timeout, in milliseconds.</param>
        /// <param name="finalizeOnWords">Whether `max_words` forces finalization.</param>
        /// <param name="format">Apply punctuation and capitalization formatting to transcripts.</param>
        /// <param name="fullTranscript">Include the cumulative session transcript on final frames.</param>
        /// <param name="genderDetection">Emit a speaker gender label alongside transcripts.</param>
        /// <param name="itnNormalize">Inverse text normalization, for example "twenty five" to "25".</param>
        /// <param name="keywords">Comma-separated `KEYWORD:INTENSIFIER` pairs boosting domain-specific terms, for example `NVIDIA:2,Kubernetes:1`. Omit the parameter entirely when empty — an empty value registers a single empty keyword.</param>
        /// <param name="language">Language code (for example `en`, `hi`, `de`, `es`, `ru`, `fr`, `ta`, `te`) or a regional aggregator (`multi-eu`, `multi-asian`, `multi-indic`). Left open rather than enumerated because the streaming worker accepts codes the pre-recorded endpoint does not.</param>
        /// <param name="maxWords">Force finalization after this many words.</param>
        /// <param name="numerals">Convert spoken numerals to digits.</param>
        /// <param name="punctuate">Insert punctuation.</param>
        /// <param name="redactPci">Redact payment card information from transcripts.</param>
        /// <param name="redactPii">Redact personally identifiable information from transcripts.</param>
        /// <param name="sampleRate">Sample rate of the binary audio frames, in Hz.</param>
        /// <param name="sentenceTimestamps">Emit sentence-level `utterances` on final frames.</param>
        /// <param name="wordTimestamps">Emit per-word timings on final frames. Required for per-word speaker labels.</param>
        /// <param name="uri">Optional WebSocket endpoint override.</param>
        /// <param name="additionalHeaders">Additional headers applied before connecting.</param>
        /// <param name="additionalSubProtocols">Additional WebSocket subprotocols applied before connecting.</param>
        /// <param name="keepAliveInterval">Optional keep-alive interval.</param>
        /// <param name="connectTimeout">Optional connect timeout.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task ConnectAsync(
            global::SmallestAI.Realtime.SttLiveModel model,
            global::SmallestAI.Realtime.SttLiveCapitalize? capitalize = default,
            global::SmallestAI.Realtime.SttLiveDiarize? diarize = default,
            global::SmallestAI.Realtime.SttLiveEmotionDetection? emotionDetection = default,
            global::SmallestAI.Realtime.SttLiveEncoding? encoding = default,
            global::SmallestAI.Realtime.SttLiveEndpointing? endpointing = default,
            int? eouTimeoutMs = default,
            global::SmallestAI.Realtime.SttLiveFinalizeOnWords? finalizeOnWords = default,
            global::SmallestAI.Realtime.SttLiveFormat? format = default,
            global::SmallestAI.Realtime.SttLiveFullTranscript? fullTranscript = default,
            global::SmallestAI.Realtime.SttLiveGenderDetection? genderDetection = default,
            global::SmallestAI.Realtime.SttLiveItnNormalize? itnNormalize = default,
            string? keywords = default,
            string? language = default,
            int? maxWords = default,
            global::SmallestAI.Realtime.SttLiveNumerals? numerals = default,
            global::SmallestAI.Realtime.SttLivePunctuate? punctuate = default,
            global::SmallestAI.Realtime.SttLiveRedactPci? redactPci = default,
            global::SmallestAI.Realtime.SttLiveRedactPii? redactPii = default,
            int? sampleRate = default,
            global::SmallestAI.Realtime.SttLiveSentenceTimestamps? sentenceTimestamps = default,
            global::SmallestAI.Realtime.SttLiveWordTimestamps? wordTimestamps = default,
            global::System.Uri? uri = null,
            global::System.Collections.Generic.IDictionary<string, string>? additionalHeaders = null,
            global::System.Collections.Generic.IEnumerable<string>? additionalSubProtocols = null,
            global::System.TimeSpan? keepAliveInterval = null,
            global::System.TimeSpan? connectTimeout = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            global::System.Uri __uri;
            if (uri is not null)
            {
                __uri = uri;
            }
            else
            {
                var __baseUrl = DefaultBaseUrlTemplate;
                var __pathBuilder = new global::SmallestAI.Realtime.PathBuilder(
                    path: __baseUrl);
                __pathBuilder
                .AddRequiredParameter("model", model.ToValueString())
                .AddOptionalParameter("capitalize", capitalize?.ToValueString())
                .AddOptionalParameter("diarize", diarize?.ToValueString())
                .AddOptionalParameter("emotion_detection", emotionDetection?.ToValueString())
                .AddOptionalParameter("encoding", encoding?.ToValueString())
                .AddOptionalParameter("endpointing", endpointing?.ToValueString())
                .AddOptionalParameter("eou_timeout_ms", eouTimeoutMs?.ToString())
                .AddOptionalParameter("finalize_on_words", finalizeOnWords?.ToValueString())
                .AddOptionalParameter("format", format?.ToValueString())
                .AddOptionalParameter("full_transcript", fullTranscript?.ToValueString())
                .AddOptionalParameter("gender_detection", genderDetection?.ToValueString())
                .AddOptionalParameter("itn_normalize", itnNormalize?.ToValueString())
                .AddOptionalParameter("keywords", keywords)
                .AddOptionalParameter("language", language)
                .AddOptionalParameter("max_words", maxWords?.ToString())
                .AddOptionalParameter("numerals", numerals?.ToValueString())
                .AddOptionalParameter("punctuate", punctuate?.ToValueString())
                .AddOptionalParameter("redact_pci", redactPci?.ToValueString())
                .AddOptionalParameter("redact_pii", redactPii?.ToValueString())
                .AddOptionalParameter("sample_rate", sampleRate?.ToString())
                .AddOptionalParameter("sentence_timestamps", sentenceTimestamps?.ToValueString())
                .AddOptionalParameter("word_timestamps", wordTimestamps?.ToValueString())
                ;

                __uri = new global::System.Uri(__pathBuilder.ToString());
            }

            RememberConnectionOptions(__uri, additionalHeaders, additionalSubProtocols, keepAliveInterval, connectTimeout);
            ApplyConnectionOptions(additionalHeaders, additionalSubProtocols, keepAliveInterval);
            await ConnectAsyncCore(__uri, connectTimeout, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Sends a raw text message over the WebSocket connection.
        /// </summary>
        public async global::System.Threading.Tasks.Task SendAsync(
            string text,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            if (!IsConnected)
            {
                await ConnectAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
            }

            await _clientWebSocket.SendAsync(
                buffer: new global::System.ArraySegment<byte>(global::System.Text.Encoding.UTF8.GetBytes(text)),
                messageType: global::System.Net.WebSockets.WebSocketMessageType.Text,
                endOfMessage: true,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Sends raw bytes over the WebSocket connection.
        /// </summary>
        public async global::System.Threading.Tasks.Task SendAsync(
            global::System.ArraySegment<byte> bytes,
            global::System.Net.WebSockets.WebSocketMessageType messageType,
            bool endOfMessage,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            if (!IsConnected)
            {
                await ConnectAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
            }

            await _clientWebSocket.SendAsync(
                bytes,
                messageType,
                endOfMessage,
                cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _clientWebSocket.Dispose();
        }

        /// <inheritdoc/>
        public async global::System.Threading.Tasks.ValueTask DisposeAsync()
        {
            if (IsConnected)
            {
                try
                {
                    await _clientWebSocket.CloseAsync(
                        closeStatus: global::System.Net.WebSockets.WebSocketCloseStatus.NormalClosure,
                        statusDescription: "Closing",
                        cancellationToken: default).ConfigureAwait(false);
                }
                catch (global::System.Net.WebSockets.WebSocketException)
                {
                    // Ignore errors during dispose
                }
            }
            _clientWebSocket.Dispose();
        }

        partial void Initialized(
            global::System.Net.WebSockets.ClientWebSocket client);
        partial void Authorizing(
            global::System.Net.WebSockets.ClientWebSocket client,
            ref string apiKey);
        partial void Authorized(
            global::System.Net.WebSockets.ClientWebSocket client);
        partial void PrepareArguments(
            global::System.Net.WebSockets.ClientWebSocket client);
        partial void PrepareRequest(
            global::System.Net.WebSockets.ClientWebSocket client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.WebSockets.ClientWebSocket client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.WebSockets.ClientWebSocket client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
        partial void OnReceiveException(
            global::System.Exception exception,
            ref bool rethrow);
    }
}