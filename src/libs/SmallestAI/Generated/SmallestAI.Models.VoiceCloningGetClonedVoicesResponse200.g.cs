
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceCloningGetClonedVoicesResponse200
    {
        /// <summary>
        /// List of available voices.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voices")]
        public global::System.Collections.Generic.IList<global::SmallestAI.WavesV1LightningLargeGetClonedVoicesGetResponsesContentApplicationJsonSchemaVoicesItems>? Voices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceCloningGetClonedVoicesResponse200" /> class.
        /// </summary>
        /// <param name="voices">
        /// List of available voices.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceCloningGetClonedVoicesResponse200(
            global::System.Collections.Generic.IList<global::SmallestAI.WavesV1LightningLargeGetClonedVoicesGetResponsesContentApplicationJsonSchemaVoicesItems>? voices)
        {
            this.Voices = voices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceCloningGetClonedVoicesResponse200" /> class.
        /// </summary>
        public VoiceCloningGetClonedVoicesResponse200()
        {
        }
    }
}