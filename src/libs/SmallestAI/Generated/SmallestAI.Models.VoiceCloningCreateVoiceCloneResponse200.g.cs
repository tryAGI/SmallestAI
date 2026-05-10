
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceCloningCreateVoiceCloneResponse200
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceCloningCreateVoiceCloneResponse200" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceCloningCreateVoiceCloneResponse200(
            string? message,
            global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaData? data)
        {
            this.Message = message;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceCloningCreateVoiceCloneResponse200" /> class.
        /// </summary>
        public VoiceCloningCreateVoiceCloneResponse200()
        {
        }

    }
}