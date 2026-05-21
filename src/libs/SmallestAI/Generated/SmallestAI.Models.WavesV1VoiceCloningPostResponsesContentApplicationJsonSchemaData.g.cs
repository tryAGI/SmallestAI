
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaData
    {
        /// <summary>
        /// Unique voice ID. Pass this as `voice_id` in TTS requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Internal model document for the cloned voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SmallestAI.JsonConverters.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataStatusJsonConverter))]
        public global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioFileNames")]
        public global::System.Collections.Generic.IList<string>? AudioFileNames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizationId")]
        public string? OrganizationId { get; set; }

        /// <summary>
        /// Pre-generated sample audio clips in the cloned voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("samples")]
        public global::System.Collections.Generic.IList<global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataSamplesItems>? Samples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaData" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// Unique voice ID. Pass this as `voice_id` in TTS requests.
        /// </param>
        /// <param name="displayName"></param>
        /// <param name="model">
        /// Internal model document for the cloned voice.
        /// </param>
        /// <param name="status"></param>
        /// <param name="language"></param>
        /// <param name="audioFileNames"></param>
        /// <param name="createdAt"></param>
        /// <param name="organizationId"></param>
        /// <param name="samples">
        /// Pre-generated sample audio clips in the cloned voice.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaData(
            string? voiceId,
            string? displayName,
            string? model,
            global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataStatus? status,
            string? language,
            global::System.Collections.Generic.IList<string>? audioFileNames,
            global::System.DateTime? createdAt,
            string? organizationId,
            global::System.Collections.Generic.IList<global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaDataSamplesItems>? samples)
        {
            this.VoiceId = voiceId;
            this.DisplayName = displayName;
            this.Model = model;
            this.Status = status;
            this.Language = language;
            this.AudioFileNames = audioFileNames;
            this.CreatedAt = createdAt;
            this.OrganizationId = organizationId;
            this.Samples = samples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaData" /> class.
        /// </summary>
        public WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaData()
        {
        }

    }
}