
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WavesV1LightningLargeAddVoicePostResponsesContentApplicationJsonSchemaData
    {
        /// <summary>
        /// Unique Voice ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// Model used to generate the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Status of the voice creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WavesV1LightningLargeAddVoicePostResponsesContentApplicationJsonSchemaData" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// Unique Voice ID.
        /// </param>
        /// <param name="model">
        /// Model used to generate the voice.
        /// </param>
        /// <param name="status">
        /// Status of the voice creation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WavesV1LightningLargeAddVoicePostResponsesContentApplicationJsonSchemaData(
            string voiceId,
            string model,
            string status)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WavesV1LightningLargeAddVoicePostResponsesContentApplicationJsonSchemaData" /> class.
        /// </summary>
        public WavesV1LightningLargeAddVoicePostResponsesContentApplicationJsonSchemaData()
        {
        }

    }
}