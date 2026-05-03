
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVoiceCloneRequestInternalServerError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Present when a known failure mode occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SmallestAI.JsonConverters.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCodeJsonConverter))]
        public global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCode? ErrorCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoiceCloneRequestInternalServerError" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="errorCode">
        /// Present when a known failure mode occurred.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVoiceCloneRequestInternalServerError(
            string? error,
            global::SmallestAI.WavesV1VoiceCloningPostResponsesContentApplicationJsonSchemaErrorCode? errorCode)
        {
            this.Error = error;
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoiceCloneRequestInternalServerError" /> class.
        /// </summary>
        public CreateVoiceCloneRequestInternalServerError()
        {
        }
    }
}