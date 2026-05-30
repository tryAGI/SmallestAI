
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// Returned by Pulse Pro when `webhook_url` is set. The transcription arrives on the webhook when ready.
    /// </summary>
    public sealed partial class AsyncAccepted
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncAccepted" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="requestId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncAccepted(
            string status,
            string requestId)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncAccepted" /> class.
        /// </summary>
        public AsyncAccepted()
        {
        }

    }
}