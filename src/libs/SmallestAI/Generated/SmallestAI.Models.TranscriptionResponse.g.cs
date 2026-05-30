
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Transcription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<object>? Words { get; set; }

        /// <summary>
        /// Sentence-level segments with optional speaker labels. Returned by `?model=pulse` only; Pulse Pro responses omit this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utterances")]
        public global::System.Collections.Generic.IList<object>? Utterances { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Reference to TranscriptionResponseMetadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionResponse" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="transcription"></param>
        /// <param name="words"></param>
        /// <param name="utterances">
        /// Sentence-level segments with optional speaker labels. Returned by `?model=pulse` only; Pulse Pro responses omit this field.
        /// </param>
        /// <param name="language"></param>
        /// <param name="metadata">
        /// Reference to TranscriptionResponseMetadata
        /// </param>
        /// <param name="requestId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptionResponse(
            string status,
            string transcription,
            global::System.Collections.Generic.IList<object>? words,
            global::System.Collections.Generic.IList<object>? utterances,
            string? language,
            object? metadata,
            string? requestId)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Transcription = transcription ?? throw new global::System.ArgumentNullException(nameof(transcription));
            this.Words = words;
            this.Utterances = utterances;
            this.Language = language;
            this.Metadata = metadata;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionResponse" /> class.
        /// </summary>
        public TranscriptionResponse()
        {
        }

    }
}