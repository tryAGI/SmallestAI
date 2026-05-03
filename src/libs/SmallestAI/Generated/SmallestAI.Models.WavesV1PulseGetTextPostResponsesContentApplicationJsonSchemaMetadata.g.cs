
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Metadata about the transcription
    /// </summary>
    public sealed partial class WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaMetadata
    {
        /// <summary>
        /// Name of the audio file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Duration of the audio file in minutes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Size of the audio file in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileSize")]
        public double? FileSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaMetadata" /> class.
        /// </summary>
        /// <param name="filename">
        /// Name of the audio file
        /// </param>
        /// <param name="duration">
        /// Duration of the audio file in minutes
        /// </param>
        /// <param name="fileSize">
        /// Size of the audio file in bytes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaMetadata(
            string? filename,
            double? duration,
            double? fileSize)
        {
            this.Filename = filename;
            this.Duration = duration;
            this.FileSize = fileSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaMetadata" /> class.
        /// </summary>
        public WavesV1PulseGetTextPostResponsesContentApplicationJsonSchemaMetadata()
        {
        }
    }
}