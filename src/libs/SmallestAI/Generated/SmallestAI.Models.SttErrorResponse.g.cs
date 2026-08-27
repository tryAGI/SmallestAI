
#nullable enable

namespace SmallestAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SttErrorResponse
    {
        /// <summary>
        /// Error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// Correlation ID for support / logs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional error details (validation errors).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::System.Collections.Generic.IList<global::SmallestAI.SttErrorResponseDetailsItems>? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SttErrorResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Error message.
        /// </param>
        /// <param name="requestId">
        /// Correlation ID for support / logs
        /// </param>
        /// <param name="details">
        /// Additional error details (validation errors).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SttErrorResponse(
            string error,
            string? requestId,
            global::System.Collections.Generic.IList<global::SmallestAI.SttErrorResponseDetailsItems>? details)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.RequestId = requestId;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SttErrorResponse" /> class.
        /// </summary>
        public SttErrorResponse()
        {
        }

    }
}