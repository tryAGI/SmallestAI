
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        public string? Accent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SmallestAI.JsonConverters.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsStatusJsonConverter))]
        public global::SmallestAI.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloningType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SmallestAI.JsonConverters.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsCloningTypeJsonConverter))]
        public global::SmallestAI.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsCloningType? CloningType { get; set; }

        /// <summary>
        /// Models this clone is compatible with. `lightning-v3.1`<br/>
        /// is the current default. Older entries may list<br/>
        /// `lightning-large`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelIds")]
        public global::System.Collections.Generic.IList<string>? ModelIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItems" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="voiceId"></param>
        /// <param name="displayName"></param>
        /// <param name="description"></param>
        /// <param name="accent"></param>
        /// <param name="tags"></param>
        /// <param name="language"></param>
        /// <param name="status"></param>
        /// <param name="cloningType"></param>
        /// <param name="modelIds">
        /// Models this clone is compatible with. `lightning-v3.1`<br/>
        /// is the current default. Older entries may list<br/>
        /// `lightning-large`.
        /// </param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItems(
            string? id,
            string? voiceId,
            string? displayName,
            string? description,
            string? accent,
            global::System.Collections.Generic.IList<string>? tags,
            string? language,
            global::SmallestAI.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsStatus? status,
            global::SmallestAI.WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItemsCloningType? cloningType,
            global::System.Collections.Generic.IList<string>? modelIds,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.VoiceId = voiceId;
            this.DisplayName = displayName;
            this.Description = description;
            this.Accent = accent;
            this.Tags = tags;
            this.Language = language;
            this.Status = status;
            this.CloningType = cloningType;
            this.ModelIds = modelIds;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItems" /> class.
        /// </summary>
        public WavesV1VoiceCloningGetResponsesContentApplicationJsonSchemaDataItems()
        {
        }

    }
}