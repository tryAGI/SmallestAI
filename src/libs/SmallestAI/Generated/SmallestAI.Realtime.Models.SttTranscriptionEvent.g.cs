
#nullable enable

namespace SmallestAI.Realtime
{
    /// <summary>
    /// A transcription frame. Interim frames carry only `transcript`; the<br/>
    /// `words` and `utterances` arrays are populated on `is_final` frames.
    /// </summary>
    public sealed partial class SttTranscriptionEvent
    {
        /// <summary>
        /// Identifier of this WebSocket session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Recognized text for this frame.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// Cumulative session transcript, when `full_transcript=true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_transcript")]
        public string? FullTranscript { get; set; }

        /// <summary>
        /// Whether this frame finalizes the current utterance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_final")]
        public bool? IsFinal { get; set; }

        /// <summary>
        /// Whether this is the terminal frame of the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_last")]
        public bool? IsLast { get; set; }

        /// <summary>
        /// Detected or configured language code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Detected language codes when multiple were recognized.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<string>? Languages { get; set; }

        /// <summary>
        /// Per-word timings and speaker labels. Present on final frames only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::SmallestAI.Realtime.SttWord>? Words { get; set; }

        /// <summary>
        /// Sentence-level segments with speaker labels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utterances")]
        public global::System.Collections.Generic.IList<global::SmallestAI.Realtime.SttUtterance>? Utterances { get; set; }

        /// <summary>
        /// Entity categories removed by PII or PCI redaction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redacted_entities")]
        public global::System.Collections.Generic.IList<string>? RedactedEntities { get; set; }

        /// <summary>
        /// Frame type identifier, when the server sends one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Human-readable server message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Error text, when the server reports a failure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SttTranscriptionEvent" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// Identifier of this WebSocket session.
        /// </param>
        /// <param name="transcript">
        /// Recognized text for this frame.
        /// </param>
        /// <param name="fullTranscript">
        /// Cumulative session transcript, when `full_transcript=true`.
        /// </param>
        /// <param name="isFinal">
        /// Whether this frame finalizes the current utterance.
        /// </param>
        /// <param name="isLast">
        /// Whether this is the terminal frame of the session.
        /// </param>
        /// <param name="language">
        /// Detected or configured language code.
        /// </param>
        /// <param name="languages">
        /// Detected language codes when multiple were recognized.
        /// </param>
        /// <param name="words">
        /// Per-word timings and speaker labels. Present on final frames only.
        /// </param>
        /// <param name="utterances">
        /// Sentence-level segments with speaker labels.
        /// </param>
        /// <param name="redactedEntities">
        /// Entity categories removed by PII or PCI redaction.
        /// </param>
        /// <param name="type">
        /// Frame type identifier, when the server sends one.
        /// </param>
        /// <param name="message">
        /// Human-readable server message.
        /// </param>
        /// <param name="error">
        /// Error text, when the server reports a failure.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SttTranscriptionEvent(
            string? sessionId,
            string? transcript,
            string? fullTranscript,
            bool? isFinal,
            bool? isLast,
            string? language,
            global::System.Collections.Generic.IList<string>? languages,
            global::System.Collections.Generic.IList<global::SmallestAI.Realtime.SttWord>? words,
            global::System.Collections.Generic.IList<global::SmallestAI.Realtime.SttUtterance>? utterances,
            global::System.Collections.Generic.IList<string>? redactedEntities,
            string? type,
            string? message,
            string? error)
        {
            this.SessionId = sessionId;
            this.Transcript = transcript;
            this.FullTranscript = fullTranscript;
            this.IsFinal = isFinal;
            this.IsLast = isLast;
            this.Language = language;
            this.Languages = languages;
            this.Words = words;
            this.Utterances = utterances;
            this.RedactedEntities = redactedEntities;
            this.Type = type;
            this.Message = message;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SttTranscriptionEvent" /> class.
        /// </summary>
        public SttTranscriptionEvent()
        {
        }

    }
}