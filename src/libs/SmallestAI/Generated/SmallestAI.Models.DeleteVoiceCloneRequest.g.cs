
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteVoiceCloneRequest
    {
        /// <summary>
        /// The unique identifier of the voice clone to delete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteVoiceCloneRequest" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// The unique identifier of the voice clone to delete.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteVoiceCloneRequest(
            string voiceId)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteVoiceCloneRequest" /> class.
        /// </summary>
        public DeleteVoiceCloneRequest()
        {
        }
    }
}