
#nullable enable

namespace SmallestAI.Realtime
{
    /// <summary>
    /// One synthesis request.
    /// </summary>
    public sealed partial class TtsSynthesizeRequest
    {
        /// <summary>
        /// Voice to synthesize with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// Text to synthesize.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Lightning model id, for example `lightning_v3.1` or `lightning_v3.1_pro`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Language code, or `auto` to detect.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Language used when pronouncing numbers, or `auto`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number_pronunciation_language")]
        public string? NumberPronunciationLanguage { get; set; }

        /// <summary>
        /// Groups fragments of one utterance so prosody carries across<br/>
        /// segments. Mutually exclusive with the legacy `flush` flag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_id")]
        public string? ContextId { get; set; }

        /// <summary>
        /// Buffer this fragment and wait; with `context_id`, hold until a sentence boundary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("continue")]
        public bool? Continue { get; set; }

        /// <summary>
        /// End the context and flush any buffered text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_close")]
        public bool? ContextClose { get; set; }

        /// <summary>
        /// Legacy buffer flush. Incompatible with `context_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flush")]
        public bool? Flush { get; set; }

        /// <summary>
        /// Maximum time to hold buffered text before flushing, in milliseconds.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_buffer_flush_ms")]
        public int? MaxBufferFlushMs { get; set; }

        /// <summary>
        /// Maximum buffering delay, in milliseconds.<br/>
        /// Default Value: 3000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_buffer_delay_ms")]
        public int? MaxBufferDelayMs { get; set; }

        /// <summary>
        /// Delay before emitting `complete` once the buffer drains, in milliseconds.<br/>
        /// Default Value: 4000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("complete_backoff_ms")]
        public double? CompleteBackoffMs { get; set; }

        /// <summary>
        /// Sample rate of the synthesized audio, in Hz.<br/>
        /// Default Value: 44100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// Playback speed multiplier.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Read mathematical notation aloud.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("math_notation")]
        public bool? MathNotation { get; set; }

        /// <summary>
        /// Emit `word_timestamp` frames. English and Hindi voices only.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_timestamps")]
        public bool? WordTimestamps { get; set; }

        /// <summary>
        /// Caller-supplied session identifier, echoed back as `external_session_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Caller-supplied request identifier, echoed back as `external_request_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsSynthesizeRequest" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// Voice to synthesize with.
        /// </param>
        /// <param name="text">
        /// Text to synthesize.
        /// </param>
        /// <param name="model">
        /// Lightning model id, for example `lightning_v3.1` or `lightning_v3.1_pro`.
        /// </param>
        /// <param name="language">
        /// Language code, or `auto` to detect.
        /// </param>
        /// <param name="numberPronunciationLanguage">
        /// Language used when pronouncing numbers, or `auto`.
        /// </param>
        /// <param name="contextId">
        /// Groups fragments of one utterance so prosody carries across<br/>
        /// segments. Mutually exclusive with the legacy `flush` flag.
        /// </param>
        /// <param name="continue">
        /// Buffer this fragment and wait; with `context_id`, hold until a sentence boundary.
        /// </param>
        /// <param name="contextClose">
        /// End the context and flush any buffered text.
        /// </param>
        /// <param name="flush">
        /// Legacy buffer flush. Incompatible with `context_id`.
        /// </param>
        /// <param name="maxBufferFlushMs">
        /// Maximum time to hold buffered text before flushing, in milliseconds.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="maxBufferDelayMs">
        /// Maximum buffering delay, in milliseconds.<br/>
        /// Default Value: 3000
        /// </param>
        /// <param name="completeBackoffMs">
        /// Delay before emitting `complete` once the buffer drains, in milliseconds.<br/>
        /// Default Value: 4000
        /// </param>
        /// <param name="sampleRate">
        /// Sample rate of the synthesized audio, in Hz.<br/>
        /// Default Value: 44100
        /// </param>
        /// <param name="speed">
        /// Playback speed multiplier.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="mathNotation">
        /// Read mathematical notation aloud.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="wordTimestamps">
        /// Emit `word_timestamp` frames. English and Hindi voices only.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sessionId">
        /// Caller-supplied session identifier, echoed back as `external_session_id`.
        /// </param>
        /// <param name="requestId">
        /// Caller-supplied request identifier, echoed back as `external_request_id`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsSynthesizeRequest(
            string voiceId,
            string text,
            string? model,
            string? language,
            string? numberPronunciationLanguage,
            string? contextId,
            bool? @continue,
            bool? contextClose,
            bool? flush,
            int? maxBufferFlushMs,
            int? maxBufferDelayMs,
            double? completeBackoffMs,
            int? sampleRate,
            double? speed,
            bool? mathNotation,
            bool? wordTimestamps,
            string? sessionId,
            string? requestId)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Model = model;
            this.Language = language;
            this.NumberPronunciationLanguage = numberPronunciationLanguage;
            this.ContextId = contextId;
            this.Continue = @continue;
            this.ContextClose = contextClose;
            this.Flush = flush;
            this.MaxBufferFlushMs = maxBufferFlushMs;
            this.MaxBufferDelayMs = maxBufferDelayMs;
            this.CompleteBackoffMs = completeBackoffMs;
            this.SampleRate = sampleRate;
            this.Speed = speed;
            this.MathNotation = mathNotation;
            this.WordTimestamps = wordTimestamps;
            this.SessionId = sessionId;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsSynthesizeRequest" /> class.
        /// </summary>
        public TtsSynthesizeRequest()
        {
        }

    }
}