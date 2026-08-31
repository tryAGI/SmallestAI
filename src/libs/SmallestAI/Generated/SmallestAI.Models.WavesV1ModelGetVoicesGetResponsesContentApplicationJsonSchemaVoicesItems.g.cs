
#nullable enable

namespace SmallestAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WavesV1ModelGetVoicesGetResponsesContentApplicationJsonSchemaVoicesItems
    {
        /// <summary>
        /// Unique voice identifier. Pass this value as `voice_id` on `POST /waves/v1/tts` (or the streaming route).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// Human-readable name for the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Metadata describing the voice. Filter client-side to find voices for a target language, accent, or use case. Fields may be empty on some voices.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::SmallestAI.WavesV1ModelGetVoicesGetResponsesContentApplicationJsonSchemaVoicesItemsTags? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WavesV1ModelGetVoicesGetResponsesContentApplicationJsonSchemaVoicesItems" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// Unique voice identifier. Pass this value as `voice_id` on `POST /waves/v1/tts` (or the streaming route).
        /// </param>
        /// <param name="displayName">
        /// Human-readable name for the voice.
        /// </param>
        /// <param name="tags">
        /// Metadata describing the voice. Filter client-side to find voices for a target language, accent, or use case. Fields may be empty on some voices.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WavesV1ModelGetVoicesGetResponsesContentApplicationJsonSchemaVoicesItems(
            string voiceId,
            string displayName,
            global::SmallestAI.WavesV1ModelGetVoicesGetResponsesContentApplicationJsonSchemaVoicesItemsTags? tags)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WavesV1ModelGetVoicesGetResponsesContentApplicationJsonSchemaVoicesItems" /> class.
        /// </summary>
        public WavesV1ModelGetVoicesGetResponsesContentApplicationJsonSchemaVoicesItems()
        {
        }

    }
}