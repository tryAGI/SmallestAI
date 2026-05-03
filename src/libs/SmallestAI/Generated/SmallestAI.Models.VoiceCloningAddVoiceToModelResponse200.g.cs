
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceCloningAddVoiceToModelResponse200
    {
        /// <summary>
        /// Message if the voice clone was created successfully.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::SmallestAI.WavesV1LightningLargeAddVoicePostResponsesContentApplicationJsonSchemaData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceCloningAddVoiceToModelResponse200" /> class.
        /// </summary>
        /// <param name="message">
        /// Message if the voice clone was created successfully.
        /// </param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceCloningAddVoiceToModelResponse200(
            string? message,
            global::SmallestAI.WavesV1LightningLargeAddVoicePostResponsesContentApplicationJsonSchemaData? data)
        {
            this.Message = message;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceCloningAddVoiceToModelResponse200" /> class.
        /// </summary>
        public VoiceCloningAddVoiceToModelResponse200()
        {
        }
    }
}