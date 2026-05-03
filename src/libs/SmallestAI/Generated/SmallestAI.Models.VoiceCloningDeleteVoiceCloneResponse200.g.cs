
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceCloningDeleteVoiceCloneResponse200
    {
        /// <summary>
        /// Status if the voice clone was deleted successfully.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// Voice ID of the deleted voice clone.
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
        /// Initializes a new instance of the <see cref="VoiceCloningDeleteVoiceCloneResponse200" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID of the deleted voice clone.
        /// </param>
        /// <param name="success">
        /// Status if the voice clone was deleted successfully.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceCloningDeleteVoiceCloneResponse200(
            string voiceId,
            bool? success)
        {
            this.Success = success;
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceCloningDeleteVoiceCloneResponse200" /> class.
        /// </summary>
        public VoiceCloningDeleteVoiceCloneResponse200()
        {
        }
    }
}