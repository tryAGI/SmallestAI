
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamLightningv2SpeechRequestUnauthorizedError
    {
        /// <summary>
        /// Error type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamLightningv2SpeechRequestUnauthorizedError" /> class.
        /// </summary>
        /// <param name="error">
        /// Error type.
        /// </param>
        /// <param name="message">
        /// Error message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StreamLightningv2SpeechRequestUnauthorizedError(
            string? error,
            string? message)
        {
            this.Error = error;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamLightningv2SpeechRequestUnauthorizedError" /> class.
        /// </summary>
        public StreamLightningv2SpeechRequestUnauthorizedError()
        {
        }
    }
}