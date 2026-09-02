
#nullable enable

namespace SmallestAI.Realtime
{
    /// <summary>
    /// One server frame. The populated `data` fields depend on `status`.
    /// </summary>
    public sealed partial class TtsLiveEvent
    {
        /// <summary>
        /// Server-assigned session identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Server-assigned request identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// The caller-supplied `session_id`, echoed back.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_session_id")]
        public string? ExternalSessionId { get; set; }

        /// <summary>
        /// The caller-supplied `request_id`, echoed back.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_request_id")]
        public string? ExternalRequestId { get; set; }

        /// <summary>
        /// Frame kind. `complete` is terminal, except inside a `context_id`<br/>
        /// continuation where it ends one segment and the socket stays open.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SmallestAI.Realtime.JsonConverters.TtsLiveEventStatusJsonConverter))]
        public global::SmallestAI.Realtime.TtsLiveEventStatus? Status { get; set; }

        /// <summary>
        /// Frame payload. `audio` is populated on `chunk` frames; `id`, `word`,<br/>
        /// `start` and `end` on `word_timestamp` frames.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::SmallestAI.Realtime.TtsLiveEventData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsLiveEvent" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// Server-assigned session identifier.
        /// </param>
        /// <param name="requestId">
        /// Server-assigned request identifier.
        /// </param>
        /// <param name="externalSessionId">
        /// The caller-supplied `session_id`, echoed back.
        /// </param>
        /// <param name="externalRequestId">
        /// The caller-supplied `request_id`, echoed back.
        /// </param>
        /// <param name="status">
        /// Frame kind. `complete` is terminal, except inside a `context_id`<br/>
        /// continuation where it ends one segment and the socket stays open.
        /// </param>
        /// <param name="data">
        /// Frame payload. `audio` is populated on `chunk` frames; `id`, `word`,<br/>
        /// `start` and `end` on `word_timestamp` frames.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsLiveEvent(
            string? sessionId,
            string? requestId,
            string? externalSessionId,
            string? externalRequestId,
            global::SmallestAI.Realtime.TtsLiveEventStatus? status,
            global::SmallestAI.Realtime.TtsLiveEventData? data)
        {
            this.SessionId = sessionId;
            this.RequestId = requestId;
            this.ExternalSessionId = externalSessionId;
            this.ExternalRequestId = externalRequestId;
            this.Status = status;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsLiveEvent" /> class.
        /// </summary>
        public TtsLiveEvent()
        {
        }

    }
}