
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVoiceCloneRequestBadRequestError
    {
        /// <summary>
        /// Error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoiceCloneRequestBadRequestError" /> class.
        /// </summary>
        /// <param name="error">
        /// Error message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVoiceCloneRequestBadRequestError(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoiceCloneRequestBadRequestError" /> class.
        /// </summary>
        public CreateVoiceCloneRequestBadRequestError()
        {
        }

    }
}