
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
        /// Per-word timestamps. **Empty unless the request sets `word_timestamps=true`.** Each entry carries `word`, `start`, `end`, and `confidence` (0.0–1.0). Pulse responses with `diarize=true` also include `speaker` and `speaker_confidence`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::SmallestAI.Word>? Words { get; set; }

        /// <summary>
        /// Sentence-level segments. Returned by `?model=pulse` only; Pulse Pro responses omit this field entirely. **Empty on Pulse unless the request sets `word_timestamps=true`** (the same flag turns on both `words[]` and `utterances[]`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utterances")]
        public global::System.Collections.Generic.IList<global::SmallestAI.Utterance>? Utterances { get; set; }

        /// <summary>
        /// Language of the transcription. Present on Pulse Pro responses; Pulse responses omit this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Response metadata. Pulse responses carry `duration` and `fileSize`. Pulse Pro responses carry `duration`, `processing_time_ms`, `rtfx`, and `num_chunks`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::SmallestAI.TranscriptionResponseMetadata? Metadata { get; set; }

        /// <summary>
        /// Server-assigned request identifier. Present on Pulse Pro responses; Pulse responses omit this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Bytes received. Pulse Pro only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalBytes")]
        public double? TotalBytes { get; set; }

        /// <summary>
        /// Detected speaker gender label. Present when `gender_detection=true` was set on the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        public string? Gender { get; set; }

        /// <summary>
        /// Detected emotion labels mapped to confidence scores. Present when `emotion_detection=true` was set on the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotions")]
        public global::System.Collections.Generic.Dictionary<string, double>? Emotions { get; set; }

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
        /// <param name="words">
        /// Per-word timestamps. **Empty unless the request sets `word_timestamps=true`.** Each entry carries `word`, `start`, `end`, and `confidence` (0.0–1.0). Pulse responses with `diarize=true` also include `speaker` and `speaker_confidence`.
        /// </param>
        /// <param name="utterances">
        /// Sentence-level segments. Returned by `?model=pulse` only; Pulse Pro responses omit this field entirely. **Empty on Pulse unless the request sets `word_timestamps=true`** (the same flag turns on both `words[]` and `utterances[]`).
        /// </param>
        /// <param name="language">
        /// Language of the transcription. Present on Pulse Pro responses; Pulse responses omit this field.
        /// </param>
        /// <param name="metadata">
        /// Response metadata. Pulse responses carry `duration` and `fileSize`. Pulse Pro responses carry `duration`, `processing_time_ms`, `rtfx`, and `num_chunks`.
        /// </param>
        /// <param name="requestId">
        /// Server-assigned request identifier. Present on Pulse Pro responses; Pulse responses omit this field.
        /// </param>
        /// <param name="totalBytes">
        /// Bytes received. Pulse Pro only.
        /// </param>
        /// <param name="gender">
        /// Detected speaker gender label. Present when `gender_detection=true` was set on the request.
        /// </param>
        /// <param name="emotions">
        /// Detected emotion labels mapped to confidence scores. Present when `emotion_detection=true` was set on the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptionResponse(
            string status,
            string transcription,
            global::System.Collections.Generic.IList<global::SmallestAI.Word>? words,
            global::System.Collections.Generic.IList<global::SmallestAI.Utterance>? utterances,
            string? language,
            global::SmallestAI.TranscriptionResponseMetadata? metadata,
            string? requestId,
            double? totalBytes,
            string? gender,
            global::System.Collections.Generic.Dictionary<string, double>? emotions)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Transcription = transcription ?? throw new global::System.ArgumentNullException(nameof(transcription));
            this.Words = words;
            this.Utterances = utterances;
            this.Language = language;
            this.Metadata = metadata;
            this.RequestId = requestId;
            this.TotalBytes = totalBytes;
            this.Gender = gender;
            this.Emotions = emotions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionResponse" /> class.
        /// </summary>
        public TranscriptionResponse()
        {
        }

    }
}