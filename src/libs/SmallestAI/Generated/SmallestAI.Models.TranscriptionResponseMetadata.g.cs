
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptionResponseMetadata
    {
        /// <summary>
        /// Audio duration in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Pulse Pro only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing_time_ms")]
        public double? ProcessingTimeMs { get; set; }

        /// <summary>
        /// Real-time factor for this request (Pulse Pro only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rtfx")]
        public double? Rtfx { get; set; }

        /// <summary>
        /// Number of internal chunks the audio was split into (Pulse Pro only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_chunks")]
        public double? NumChunks { get; set; }

        /// <summary>
        /// Pulse responses include this when sent via URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Bytes received (Pulse responses).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileSize")]
        public double? FileSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionResponseMetadata" /> class.
        /// </summary>
        /// <param name="duration">
        /// Audio duration in seconds.
        /// </param>
        /// <param name="processingTimeMs">
        /// Pulse Pro only.
        /// </param>
        /// <param name="rtfx">
        /// Real-time factor for this request (Pulse Pro only).
        /// </param>
        /// <param name="numChunks">
        /// Number of internal chunks the audio was split into (Pulse Pro only).
        /// </param>
        /// <param name="filename">
        /// Pulse responses include this when sent via URL.
        /// </param>
        /// <param name="fileSize">
        /// Bytes received (Pulse responses).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptionResponseMetadata(
            double? duration,
            double? processingTimeMs,
            double? rtfx,
            double? numChunks,
            string? filename,
            double? fileSize)
        {
            this.Duration = duration;
            this.ProcessingTimeMs = processingTimeMs;
            this.Rtfx = rtfx;
            this.NumChunks = numChunks;
            this.Filename = filename;
            this.FileSize = fileSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionResponseMetadata" /> class.
        /// </summary>
        public TranscriptionResponseMetadata()
        {
        }

    }
}